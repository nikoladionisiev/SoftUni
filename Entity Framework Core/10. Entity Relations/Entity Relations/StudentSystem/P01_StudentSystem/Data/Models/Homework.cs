using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        //fk student
        public int StudentId { get; set; }
        public Student Student { get; set; }

        //fk course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
