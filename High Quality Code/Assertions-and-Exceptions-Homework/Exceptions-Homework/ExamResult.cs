using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0 || minGrade < 0)
        {
            throw new ArgumentException("Grade cannot be less than 0");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Max Grade must not be less than Min Grade");
        }
        if (comments == null || comments == "")
        {
            throw new NullReferenceException("Comments null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
