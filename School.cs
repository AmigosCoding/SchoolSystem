using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    //1: Skapa klassen
    class School 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public string SchoolType { get; set; }

        public List<Student> students { get; set; } = new List<Student>();

        public List<Course> courses { get; set; } = new List<Course>();



        //2: Skapandet av Konstruktör

        public School(int aId, string aName, string aLocation, string aSchoolType)
        {
            this.Id = aId;
            this.Name = aName;
            this.Location = aLocation;
            this.SchoolType = aSchoolType;

        }



    } 
}
