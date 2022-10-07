namespace LaboratoryWork3
{
	internal class Student
	{
		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public string? Patronymic { get; set; }

		public string? Gender { get; set; }

		public string? Birthday { get; set; }

		public Group? Group { get; set; }

		public string? Course { get; set; }

		private readonly Random Random = new();

		public UnifiedStateExam[]? UnifiedStateExams { get; set; } = new UnifiedStateExam[3];

		public int Summ { get; private set; }

		public Student()
		{
			Complition[] complitions = new Complition[3];
			for (int i = 0; i < complitions.Length; i++)
			{
				complitions[i] = new Complition();
			}
			int n = Random.Next(0, 2);
			string[] gen = { "М", "Ж" };
			LastName = complitions[0].ToString();
			FirstName = complitions[1].ToString();
			Patronymic = complitions[2].ToString();
			Gender = gen[n];
			Birthday = DateTime.Now.ToString("dd.MM.yyyy");
			int a = Random.Next(1, 5);
			Course = a.ToString();
		}

		public override string ToString()
		{
			return $"{LastName}, "
				+ $"{FirstName}, "
				+ $"{Patronymic}, "
				+ $"{Gender}, "
				+ $"{Birthday}, "
				+ $"{Group}, "
				+ $"{Course}, "
				+ $"{UnifiedStateExams![0]}, "
				+ $"{UnifiedStateExams![1]}, "
				+ $"{UnifiedStateExams![2]}";
		}
	}
}