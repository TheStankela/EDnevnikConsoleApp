namespace EDnevnikConsoleApp.Models
{
	public class Subject
	{
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
		public string Name { get; set; }
	}
}
