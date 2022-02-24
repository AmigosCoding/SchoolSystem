using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Door
    {
        public int DoorId { get; set; }

        public string DoorName { get; set; }



        public void enterTheBuilding(Student studentObj)
        {
            Console.WriteLine($"The student {studentObj.Name} has entered through {DoorName}");

        }
    }
}
