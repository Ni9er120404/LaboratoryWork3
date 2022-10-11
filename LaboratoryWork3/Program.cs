namespace LaboratoryWork3
{
	internal class Program
	{
		private static Student[]? Students { get; set; }

		public static Random Random { get; } = new(DateTime.Now.Millisecond);

		private static void Main()
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

			//PrintInfo(BIST);
			//PrintInfo(BIVT);
			//PrintInfo(BPI);

			List<Group> groups = new();
			List<Student> result = new();

			foreach (Group group in BIST)
			{
				groups.Add(group);
			}

			foreach (Group group in BIVT)
			{
				groups.Add(group);
			}

			foreach (Group group in BPI)
			{
				groups.Add(group);
			}
			List<object> studentss = new();
			for (int i = 0; i < groups.Count; i++)
			{
				var students = groups[i]!.Students!.Where(student => student!.UnifiedStateExams![0]!.Point >= 80
													   && student!.UnifiedStateExams[1]!.Point >= 80
													   && student!.UnifiedStateExams[2]!.Point >= 80);
				studentss.Add(students);
			}

			foreach (var item in studentss)
			{
				result.Add((Student)item);
			}

			result.ForEach(res => Console.WriteLine(res));
		}

		private static void PrintInfo(Group[] groups)
		{
			for (int i = 0; i < groups.Length; i++)
			{
				for (int j = 0; j < groups[i].Students!.Count; j++)
				{
					Console.Write($"{groups[i]!.Students![j]}\n\n");
				}
				Console.WriteLine("\n\n\n\n\n\n");
			}
		}

		private static void CompletionForStudents(Student[] students)
		{
			string[] list = { "Математика", "Русский", "Информатика" };


			for (int i = 0; i < students.Length; i++)
			{
				students[i] = new Student();
				for (int j = 0; j < 3; j++)
				{
					int num = Random.Next(0, 100);
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
					Name = i.ToString(),
					Students = new List<Student>()
				};

				for (int j = 0; j < Students?.Length / groups.Length; j++)
				{
					groups[i]?.Students?.Add(Students![j]);
				}
			}
		}
	}
}