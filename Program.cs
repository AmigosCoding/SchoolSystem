using System;
using System.Linq;

namespace SchoolSystem
{
  
    class Program
    {
        static void Main(string[] args)
        {
            School ntiHighSchool = new School(1, "Nti kronhus", "Sweden", "High School");
            Student student1 = new Student(1337, "Sven", 99);
            Door door1 = new Door();
            //door1.DoorName = "Main Door";
            //door1.DoorId = 1;
            //student1.enterThroughTheDoor(door1);

            Course programmering2 = new Course("Programmering 2 TE19C", 200, new DateTime(2022,10,12));
            Course programmering3 = new Course("Programmering 3 TE18C", 400, new DateTime(2022,10,12));
            ntiHighSchool.courses.Add(programmering2);
            ntiHighSchool.courses.Add(programmering3);

            //foreach(var schoolCourse in ntiHighSchool.courses)
            //{
            //    Console.WriteLine(schoolCourse.Id);
            //    Console.WriteLine(schoolCourse.Name);
            //    Console.WriteLine(schoolCourse.CoursePoint);
            //    Console.WriteLine("-------------------------");
            //}

            foreach(var schoolCourse in ntiHighSchool.courses)
            {
                if(schoolCourse.Id == 2)
                {
                    Console.WriteLine(schoolCourse.Name);
                }
            }

            var searchedCourse = ntiHighSchool.courses.FirstOrDefault(course => course.Id == 2);

            //Console.WriteLine(searchedCourse.Name);



            

            

        }
        
    }
}
