namespace SchoolSystem.WebApi.Tests.RepositoriesTests
{
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Transactions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem.Data;
    using SchoolSystem.Models;
    using SchoolSystem.Repositories;

    [TestClass]
    public class StudentsDbRepositoryTests
    {
        private readonly SchoolSystemDbContext dbContext;
        private readonly IRepository repository;
        private static TransactionScope transaction;

        public StudentsDbRepositoryTests()
        {
            this.dbContext = new SchoolSystemDbContext();
            this.repository = new StudentsDbRepository(this.dbContext);
        }

        [TestInitialize]
        public void InitializeTransaction()
        {
            transaction = new TransactionScope(TransactionScopeOption.Required, 
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted });
        }

        [TestCleanup]
        public void DisposeTransaction()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void All_WhenDbContainsThreeStudents_ShuldReturnThreeStudents()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();

            // Act
            var students = this.repository.All<Student>();

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(this.dbContext.Students.Count(), students.Count());
            Assert.IsTrue(students.Any(s => s.FirstName == "Gosho"));
            Assert.IsTrue(students.Any(s => s.FirstName == "Pesho"));
            Assert.IsTrue(students.Any(s => s.FirstName == "Ivan"));
        }

        [TestMethod]
        public void All_WhenDbStudentsTableIsEmpty_ShuldReturnEmptyCollection()
        {
            // Arrange

            // Act
            var students = this.repository.All<Student>();

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(0, students.Count());
        }

        [TestMethod]
        public void Get_WhenExistStudentByGivenExpressions_ShouldReturnSingleStudent()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.SaveChanges();

            // Act
            var firstStudentByLastName = this.repository.Get<Student>(s => s.LastName == "Petkov");
            var firstStudentByFirstNameAndAge = this.repository.Get<Student>(s => s.FirstName == "Gosho" && s.Age == 14);

            // Assert
            Assert.IsNotNull(firstStudentByLastName);
            Assert.IsNotNull(firstStudentByFirstNameAndAge);
            Assert.IsTrue(firstStudentByLastName.LastName == "Petkov");
            Assert.IsTrue(firstStudentByFirstNameAndAge.FirstName == "Gosho");
            Assert.IsTrue(firstStudentByFirstNameAndAge.Age == 14);
        }

        [TestMethod]
        public void Get_WhenNotExistStudentByGivenExpressions_ShouldReturnNull()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Georgiev", Age = 14, Grade = 8 });
            this.dbContext.SaveChanges();

            // Act
            var firstStudentByLastName = this.repository.Get<Student>(s => s.LastName == "Petkov");
            var firstStudentByFirstNameAndAge = this.repository.Get<Student>(s => s.FirstName == "Gosho" && s.Age == 14);

            // Assert
            Assert.IsNull(firstStudentByLastName);
            Assert.IsNull(firstStudentByFirstNameAndAge);
        }

        [TestMethod]
        public void Find_WhenExistStudentByGivenExpressions_ShouldReturnSingleStudent()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.SaveChanges();

            // Act
            var firstStudentByLastName = this.repository.Find<Student>(s => s.LastName == "Petkov");
            var firstStudentByFirstNameAndAge = this.repository.Get<Student>(s => s.FirstName == "Gosho" && s.Age == 14);

            // Assert
            Assert.IsNotNull(firstStudentByLastName);
            Assert.IsNotNull(firstStudentByFirstNameAndAge);
            Assert.IsTrue(firstStudentByLastName.LastName == "Petkov");
            Assert.IsTrue(firstStudentByFirstNameAndAge.FirstName == "Gosho");
            Assert.IsTrue(firstStudentByFirstNameAndAge.Age == 14);
        }

        [TestMethod]
        public void Find_WhenNotExistStudentByGivenExpressions_ShouldReturnNull()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Georgiev", Age = 14, Grade = 8 });
            this.dbContext.SaveChanges();

            // Act
            var firstStudentByLastName = this.repository.Find<Student>(s => s.LastName == "Ivanov");
            var firstStudentByFirstNameAndAge = this.repository.Get<Student>(s => s.FirstName == "Gosho" && s.Age == 14);

            // Assert
            Assert.IsNull(firstStudentByLastName);
            Assert.IsNull(firstStudentByFirstNameAndAge);
        }

        [TestMethod]
        public void Filter_WhenDbContainsThreeStudents_OnlyTwoAreValidByGivenExpression_ShouldReturnTwoStudents()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();

            // Act
            var students = this.repository.Filter<Student>(s => s.Grade >= 8);

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(2, students.Count());
            Assert.AreEqual(2, students.Select(s => s.Age >= 8).Count());
            Assert.IsTrue(students.Any(s => s.FirstName == "Gosho"));
            Assert.IsTrue(students.Any(s => s.FirstName == "Pesho"));
            Assert.IsFalse(students.Any(s => s.FirstName == "Ivan"));
        }

        [TestMethod]
        public void Filter_WhenDbContainsThreeStudents_AllOfThemAreValidByGivenExpression_IndexIs2_SizeIs1_CountShouldBe1()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();

            // Act
            int count;
            int index = 2;
            int size = 1;
            var students = this.repository.Filter<Student>(s => s.Grade >= 6, out count, index, size);

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Filter_WhenDbContainsThreeStudents_AllOfThemAreValidByGivenExpression_IndexIs0_SizeIs2_CountShouldBe2()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();

            // Act
            int count;
            int index = 0;
            int size = 2;
            var students = this.repository.Filter<Student>(s => s.Grade >= 6, out count, index, size);

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Filter_WhenDbContainsThreeStudents_AllOfThemAreValidByGivenExpression_IndexIs0_SizeIs4_CountShouldBe3()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();

            // Act
            int count;
            int index = 0;
            int size = 4;
            var students = this.repository.Filter<Student>(s => s.Grade >= 6, out count, index, size);

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void Filter_WhenDbContainsThreeStudents_AllOfThemAreValidByGivenExpression_IndexIs4_SizeIs1_CountShouldBe0()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();

            // Act
            int count;
            int index = 4;
            int size = 1;
            var students = this.repository.Filter<Student>(s => s.Grade >= 6, out count, index, size);

            // Assert
            Assert.IsNotNull(students);
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Constains_WhenExistStudentByGivenExpression_ShouldReturnTrue()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.SaveChanges();

            // Act
            var result = this.repository.Contains<Student>(s => s.LastName == "Petkov");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Constains_WhenNotExistStudentByGivenExpression_ShouldReturnFalse()
        {
            // Arrange

            // Act
            var result = this.repository.Contains<Student>(s => s.LastName == "Petkov");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Create_WhenStudentModelIsValid_ShouldAddStudentToDb()
        {
            // Arrange

            // Act
            var student = this.repository.Create(new Student
            {
                FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6
            });

            // Assert
            Assert.IsNotNull(student);
            Assert.IsTrue(this.dbContext.Students.Count() == 1);
            Assert.IsTrue(student.LastName == "Angelov");
            Assert.IsTrue(student.Id != 0);
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void Create_WhenStudentModelIsNotValid_MissingLastNameAndGrade_ShouldThrowValidationException()
        {
            // Arrange

            // Act
            var student = this.repository.Create(new Student() { FirstName = "Ivan", Age = 12 });            

            // Assert
        }

        [TestMethod]
        public void Delete_WhenDeleteFirstStudent_StudentsCountShouldBeDecreasedWithOne()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();
            var initialStudentsCount = this.dbContext.Students.Count();

            // Act
            var deletedStudentsCount = this.repository.Delete(this.dbContext.Students.First());
            var currentStudentsCount = this.dbContext.Students.Count();

            // Assert
            Assert.IsTrue(deletedStudentsCount == 1);
            Assert.AreEqual(initialStudentsCount - deletedStudentsCount, currentStudentsCount);
        }

        [TestMethod]
        public void Delete_WhenDeleteTwoOfThreeStudents_MatchingGiveExpression_StudentsCountShouldBeDecreasedToOne()
        {
            // Arrange
            this.dbContext.Students.Add(new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 });
            this.dbContext.Students.Add(new Student { FirstName = "Pesho", LastName = "Ivanov", Age = 16, Grade = 10 });
            this.dbContext.Students.Add(new Student { FirstName = "Ivan", LastName = "Angelov", Age = 12, Grade = 6 });
            this.dbContext.SaveChanges();
            var initialStudentsCount = this.dbContext.Students.Count();

            // Act
            var deletedStudentsCount = this.repository.Delete<Student>(s => s.Age >= 14);
            var currentStudentsCount = this.dbContext.Students.Count();

            // Assert
            Assert.IsTrue(deletedStudentsCount == 2);
            Assert.AreEqual(initialStudentsCount - deletedStudentsCount, currentStudentsCount);
        }

        [TestMethod]
        public void Update_WhenUpdateExistingStudent_ShouldBeModified()
        {
            // Arrange
            var student = new Student { FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8 };
            this.dbContext.Students.Add(student);
            this.dbContext.SaveChanges();

            // Act
            string lastName = "Georgiev";
            student.LastName = lastName;
            var updatedStudentsCount = this.repository.Update(student);

            // Assert
            Assert.IsTrue(updatedStudentsCount == 1);
            Assert.IsTrue(this.dbContext.Students.Any(s => s.LastName == lastName));
        }
    }
}
