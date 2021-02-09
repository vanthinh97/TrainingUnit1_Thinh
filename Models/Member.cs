namespace TrainingUnit1.Models
{
    abstract class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        public abstract void Show();
    }
}
