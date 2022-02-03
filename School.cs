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


    }
}
