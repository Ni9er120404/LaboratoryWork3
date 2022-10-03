namespace LaboratoryWork3
{
	internal class Student
	{
		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public string? Patronymic { get; set; }

		public string? Gender { get; set; }

		public DateTime Birthday { get; set; }

		public Group? Group { get; set; }

		public string? Course { get; set; }

		public USE[]? USEs { get; set; } 
	}
}