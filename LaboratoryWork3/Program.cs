namespace LaboratoryWork3
{
	internal class Program
	{
		private static Student[,]? Students1 { get; set; }

		private static Student[,]? Students2 { get; set; }

		private static Student[,]? Students3 { get; set; }

		private static void Main()
		{
			Students1 = new Student[25, 20];
			CompletionForStudents(Students1);

			Students2 = new Student[25, 20];
			CompletionForStudents(Students2);

			Students3 = new Student[25, 20];
			CompletionForStudents(Students3);

			Group[] BIST = new Group[20];
			CompletionForGroup(BIST, Students1);

			Group[] BIVT = new Group[20];
			CompletionForGroup(BIVT, Students2);

			Group[] BPI = new Group[20];
			CompletionForGroup(BPI, Students3);

			IEnumerable<Group> groups = BIVT.Concat(BIST).Concat(BPI);

			foreach (var item in groups)
			{
				var n = from a in item.Students
						where a!.UnifiedStateExams![0]!.Point >= 80
						&& a.UnifiedStateExams[1].Point >= 80
						&& a.UnifiedStateExams[2].Point >= 80
						select a;

				foreach (var el in n) { Console.WriteLine(el); }
			}
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

		private static void CompletionForStudents(Student[,] students)
		{
			string[] list = { "Математика", "Русский", "Информатика" };

			Random random = new();

			for (int i = 0; i < students.GetLength(0); i++)
			{
				for (int k = 0; k < students.GetLength(1); k++)
				{
					students[i, k] = new Student();
					for (int j = 0; j < 3; j++)
					{
						int num = random.Next(50, 100);
						students[i, k]!.UnifiedStateExams![j] = new UnifiedStateExam();
						students[i, k].UnifiedStateExams![j].Name = list[j];
						students[i, k].UnifiedStateExams![j].Point = num;
					}
				}
			}
		}

		private static void CompletionForGroup(Group[] groups, Student[,] Students)
		{
			for (int i = 0; i < groups.Length;)
			{
				groups[i] = new Group
				{
					Name = i.ToString(),
					Students = new List<Student>()
				};

				for (int j = 0; j < Students.GetLength(1); j++)
				{
					groups[i]?.Students?.Add(Students![i, j]);
				}
				i++;
			}
		}
	}
}