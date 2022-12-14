using System.Text;

namespace LaboratoryWork3
{
	internal class Completion
	{
		private readonly string Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		public string? Info { get; set; }

		private static readonly Random Random = new();

		public Completion()
		{
			int num = Random.Next(10, 20);
			StringBuilder stringBuilder = new();

			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append(Text[Random.Next(0, Text.Length)]);
			}

			Info = stringBuilder.ToString();
		}

		public override string ToString()
		{
			return $"{Info}";
		}
	}
}