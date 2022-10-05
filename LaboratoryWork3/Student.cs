using System.Text;

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

		private Random Random { get; set; } = new(DateTime.Now.Millisecond);

		public UnifiedStateExam[]? UnifiedStateExams { get; set; } = new UnifiedStateExam[3];

		private string Complition()
		{
			int num = Random.Next(10, 20);
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			string numbers = "0123456789";
			StringBuilder stringBuilder = new();

			for(int i=0; i<num; i++)
			{
				stringBuilder.Append(text[i]);
			}

			return stringBuilder.ToString();
		}

		public Student()
		{
			int n = Random.Next(0, 1);
			string[] gen = { "М", "Ж" };
			LastName = Complition();
			FirstName = Complition();
			Patronymic = Complition();
			Gender = gen[n];
			Birthday = DateTime.Now;
			int i = Random.Next(1, 5);
			Course = i.ToString();
		}

		public override string ToString()
		{
			return $"{LastName}, {FirstName}, {Patronymic}, {Gender}, {Birthday}, {Group}, {Course}";
		}
	}
}