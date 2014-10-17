namespace Bank
{
    public abstract class Customer
    {
        public Customer(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        private string name;
        private string id;

        public string Name { get; private set; }
        public string Id { get; private set; }
    }
}
