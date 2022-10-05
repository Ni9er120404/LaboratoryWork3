namespace LaboratoryWork3
{
	internal class Program
	{
		private static Student[]? Students { get; set; }

		public static Random Random { get; } = new(DateTime.Now.Millisecond);

		private static void Main(string[] args)
		{


			int num = Random.Next(60 * 20, 60 * 35);

			Students = new Student[num];
			CompletionForStudents(Students);

			Group[] BIST = new Group[20];
			CompletionForGroup(BIST);

			Group[] BIVT = new Group[20];
			CompletionForGroup(BIVT);

			Group[] BPI = new Group[20];
			CompletionForGroup(BPI);

			for (int i = 0; i < BIST.Length; i++)
			{
				for (int j = 0; j < BIST[i].Students!.Count; j++)
				{
					Console.Write($"{BIST[i]!.Students![j]}\n");
				}
				Console.WriteLine("\n\n\n\n\n\n");
			}
		}

		private static void CompletionForStudents(Student[] students)
		{
			string[] list = { "Математика", "Русский", "Информатика" };
			int num = Random.Next(0, 100);

			for (int i = 0; i < students.Length; i++)
			{
				students[i] = new Student();
				for (int j = 0; j < 3; j++)
				{
					students[i]!.UnifiedStateExams![j] = new UnifiedStateExam();
					students[i].UnifiedStateExams![j].Name = list[j];
					students[i].UnifiedStateExams![j].Point = num;
				}
			}
		}

		private static void CompletionForGroup(Group[] groups)
		{
			for (int i = 0; i < groups.Length; i++)
			{
				groups[i] = new Group
				{
					Students = new List<Student>()
				};

				for (int j = 0; j < Students?.Length / groups.Length; j++)
				{
					groups[i]?.Students?.Add(Students![i]);
				}
			}
		}
	}
}