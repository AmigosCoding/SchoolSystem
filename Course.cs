using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Course
    {
        public static  int amountOfCourses { get; set; } = 0;
        public int Id { get; set; }

        public string Name { get; set; }

        public int CoursePoint { get; set; }

        public DateTime  CourseDate { get; set; }

        //public School school { get; set;  } = new School();

        public List<Student> courseStudents { get; set; } = new List<Student>();


        public Course( string aName, int aCoursePoint, DateTime aCourseDate) 
        {
            amountOfCourses++;
            Id = amountOfCourses;
            Name = aName;
            CoursePoint = aCoursePoint;
            CourseDate = aCourseDate;

        }






    }
}
