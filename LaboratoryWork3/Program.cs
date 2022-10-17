namespace LaboratoryWork3
{
	internal class Program
	{
		private static Student[]? Students { get; set; }

		

		private static void Main()
		{
			Random Random  = new(DateTime.Now.Millisecond);
			//int num = Random.Next(60 * 20, 60 * 35);

			Students = new Student[25*60];
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

			List<Student> studentss = new();
			for (int i = 0; i < groups.Count; i++)
			{
				IEnumerable<Student> students = groups[i]!.Students!.Where(student => student!.UnifiedStateExams![0]!.Point >= 80
													   && student!.UnifiedStateExams[1]!.Point >= 80
													   && student!.UnifiedStateExams[2]!.Point >= 80);
				List<Student> n = students.ToList();
				studentss.AddRange(n);
			}

			foreach (var item in groups)
			{
				IEnumerable<Student> students = item!.Students!.Where(student => student!.UnifiedStateExams![0]!.Point >= 80
													   && student!.UnifiedStateExams[1]!.Point >= 80
													   && student!.UnifiedStateExams[2]!.Point >= 80);
				
				studentss.AddRange(students);
			}

			foreach (var item in studentss)
			{
				result.Add(item);
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

			Random random = new(DateTime.Now.Millisecond);

			for (int i = 0; i < students.Length; i++)
			{
				students[i] = new Student();
				for (int j = 0; j < 3; j++)
				{
					int num = random.Next(50, 100);
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