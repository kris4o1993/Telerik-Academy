namespace SchoolSystem.Models
{
    public class Mark : BaseModel
    {
        public string Subject { get; set; }

        public decimal Value { get; set; }

        public virtual Student Student { get; set; }
    }
}