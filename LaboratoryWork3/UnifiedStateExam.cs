﻿namespace LaboratoryWork3
{
	internal class UnifiedStateExam
	{
		public string? Name { get; set; }

		public int Point { get; set; }

		public override string ToString()
		{
			return $"{Name}, {Point}";
		}
	}
}