using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int TelNumber { get; set; }

        public string? EmailAddress { get; set; }

        public int Id { get; set; }

        public IList<Flight> flights { get; set; }

        #region Polymorphisme par signature

        public bool checkProfile(String nom, String prenom)
        {
            return LastName.Equals(nom) && FirstName.Equals(prenom);
        }

        public bool checkProfile1(String nom, String prenom,String mail)
        {
            //return LastName.Equals(nom) && FirstName.Equals(prenom) && EmailAddress.Equals(mail);
            //ou
            return checkProfile(nom, prenom) && EmailAddress.Equals(mail);
        }

        public bool checkProfile2(String nom, String prenom, String mail=null)
        {
            if (mail == null)
                return checkProfile(nom,prenom);
            else 
                return checkProfile1(nom,prenom,mail);
            //ou
            //return (mail!=null)? checkProfile1(nom,prenom,mail):checkProfile(nom,prenom);
        }

        #endregion

        #region Polymorphisme par heritage

        //virtual autorise la redéfinition de la methode

        public virtual void PassengerType()
        {
            Console.WriteLine("I am Passenger");
        }

        #endregion

    }

}
