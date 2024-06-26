﻿namespace MBHS_Website.Models
{
	public class Subject
	{
		public int SubjectId { get; set; }
		public string Title { get; set; }
		public string Department { get; set; }
		public ICollection<Exam> Exams { get; set;}
		public ICollection<SubjectTeacher> SubjectTeachers { get; set; }	
	}
}
