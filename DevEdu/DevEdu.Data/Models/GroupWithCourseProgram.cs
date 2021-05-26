using System;
using System.Collections.Generic;
using System.Text;

namespace DevEdu.Data.Models
{
    public class GroupWithCourseProgram
    {
        public int? Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan TimeStart { get; set; }
        public int Duration { get; set; }
        public int CourseProgramId { get; set; }
        public string Title { get; set; }
    }
}
