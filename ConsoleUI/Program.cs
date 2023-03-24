using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Tim";
            owner.LastName = "Barton";
            owner.EmailAddress = "tim@testmail.com";
            owner.PhoneNumber = "555-1212";
   

            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out trash";
            chore.Owner = owner;
         

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteWork();

            Console.ReadLine();

            
        }
    }
}
