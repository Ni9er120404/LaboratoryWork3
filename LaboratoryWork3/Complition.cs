using System.Text;

namespace LaboratoryWork3
{
	internal class Complition
	{
		private readonly Random Random = new();

		private readonly string Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		public string? Info { get; set; }

		public Complition()
		{
			int num = Random.Next(10, 20);
			StringBuilder stringBuilder = new();

			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append(Text[i]);
			}

			Info = stringBuilder.ToString();
		}

		public override string ToString()
		{
			return $"{Info}";
		}
	}
}