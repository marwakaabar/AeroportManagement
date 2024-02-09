using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }

        public double Salary { get; set; }

        public string Function { get; set; }

        #region polymorphisme par heritage 

        //override tethat fel fils besh taamel biha l redéfinition k tebda aamla methode fel mere 
        public override void PassengerType()
        {
            Console.WriteLine("I am Passenger and i am staff member");
        }

        #endregion
    }
}
