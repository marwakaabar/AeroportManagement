using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domain
{
    //deuxieme methode nhot l enum fouk l classe
   /* public enum PlaneType
    {
        //1er methode pour creer une enumeration
        Boing,
        Airbus
    }*/
    public class Plane
    {
        
        #region exemple


        /* private int capacity;
   public int getCapacity()
      {
          return capacity;
      }

      public void setCapacity(int capacity) { 
          this.capacity = capacity;
      }*/
        #endregion

        #region prop versions
        //prop+2tabulation
        //light version
        //public int MyProperty { get; set; }

        //full version nestaamlouha k yebda aandi traitement besh naamlou f set par exemple
        //propfull+2tab
        //private int myVar;

        /* public int MyProperty2
         {
             get { return myVar; }
             set { myVar = value; }
         }*/

        //security
        //propg+2tab
        // public int MyProperty1 { get; private set; }

        #endregion

        //prop de base
        public int Capacity { get; set; }
        public PlaneType planeType { get; set; }

        public DateTime ManufactureDate { get; set; }

        public int PlaneId { get; set; }

        
        //proprieté de navigation
        public IList<Flight>flights  { get; set; }   //IList pour optimiser le code 
    }

}
