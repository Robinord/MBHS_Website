﻿namespace MBHS_Website.Models
{
	public class Grade
	{
		public int GradeId { get; set; }
		public string Mark { get; set; }
		public int ExamId { get; set; }
		public int StudentId { get; set; }
		public Exam Exam { get; set; }
		public Student Student { get; set; }


	}
}
