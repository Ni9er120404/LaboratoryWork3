namespace LaboratoryWork3
{
	internal class Program
	{
		private static Student[]? Students { get; set; }

		private static void Main(string[] args)
		{
			Random random = new(DateTime.Now.Millisecond);

			int num = random.Next(60 * 20, 60 * 35);

			Students = new Student[num];
			CompletionForStudents(Students);

			Group[] BIST = new Group[20];
			CompletionForBIST(BIST);

			Group[] BIVT = new Group[20];
			Group[] BPI = new Group[20];


		}

		private static void CompletionForStudents(Student[] students)
		{
			for (int i = 0; i < students.Length; i++)
			{
				students[i] = new Student();
			}
		}

		private static void CompletionForBIST(Group[] BIST)
		{
			for (int i = 0; i < BIST.Length; i++)
			{
				BIST[i] = new Group
				{
					Students = new List<Student>()
				};

				for (int j = 0; j < Students?.Length / BIST.Length; j++)
				{
					BIST[i]?.Students?.Add(Students![i]);
				}

			}
		}
	}
}