using System;

namespace SchoolSystem
{
  
    class Program
    {
        //https://prod.liveshare.vsengsaas.visualstudio.com/join?1DA5960E02B24172AFABD562566BE8FEF8C6
        static void Main(string[] args)
        {
            //2: Skapa objekt
            School NTI1 = new School();
            School NTI2 = new School();
            NTI2.Name = "Johanneberg School";
            //3: Tilldela ett värde
            NTI1.Name = "NTI Kronhus School";
   


            Student student1 = new Student();
            student1.Id = 1337;
            student1.Name = "Urban";
            student1.Age = 18;

           
            NTI1.students.Add(student1);

            //Console.WriteLine("Eleven som tillhör NTI heter: " + NTI1.students[0].Name);

            Console.WriteLine(NTI2.students[0].Name);



            //4: Skriv ut 
            //Console.WriteLine(NTI1.Id);
            //Console.WriteLine(NTI1.Name);
            //Console.WriteLine(NTI1.Location);
            //Console.WriteLine(NTI1.SchoolType);





        }
    }
}
