using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Student : Person
    {

        public int Age { get; set; }

        public List<Course> studentCourses { get; set; } = new List<Course>();


        public Student(int aId, string aName, int aAge)
        {
            this.Id = aId;
            this.Name = aName;
            this.Age = aAge;
        }

        public void enterThroughTheDoor(Door doorObj)
        {
            doorObj.enterTheBuilding(this);
        }

    }
}
