﻿using System.ComponentModel.DataAnnotations;

namespace MBHS_Website.Models
{
    public class SubjectTeacher
	{
		[Key]
		public int SubjectTeacherId { get; set; }
		public int SubjectId { get; set; }
		public string TeacherId { get; set; }

        //Validation through data annotation to not allow for a Room name to be more than 30 characters
        [Required]
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        public string Room { get; set; }

		public Teacher? Teacher { get; set; }

		public Subject? Subject { get; set; }

		public ICollection<StudentSubjectTeacher>? StudentSubjectTeachers { get; set; }
    }
}
