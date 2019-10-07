using System;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace SQL
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var schoolContext = new SchoolContext())
            {

                var allaKurserFörStudent = (from students in schoolContext.Students
                                            join kursstudents in schoolContext.KursStudents on students.StudentID equals kursstudents.StudentID
                                            join kurser in schoolContext.Kurser on kursstudents.KursID equals kurser.KursID
                                            where kursstudents.StudentID == int.Parse(Console.ReadLine())
                                            select kurser);

                foreach(var kurs in allaKurserFörStudent)
                    Console.WriteLine(kurs.Namn);
                //testsdadasdsa
                //testsdadasdsad
            
            } 
        }
       
    }
}
 