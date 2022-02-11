using System;

namespace SchoolSystem
{
  
    class Program
    {
        static void Main(string[] args)
        {
            School ntiHighSchool = new School(1, "Nti kronhus", "Sweden", "High School");
            Student student1 = new Student(1337, "Sven", 99);
            Door door1 = new Door();
            door1.DoorName = "Main Door";
            door1.DoorId = 1;

            student1.enterThroughTheDoor(door1);

            
            
        }
    }
}
