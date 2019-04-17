using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Basics
{
    public class Employee
    {

        public Employee(string name, int numberID, string location)
        {
            this.Name = name;
            this.NumberID = numberID;
            Location temp;
            Enum.TryParse(location, out temp);
            this.location = temp;
            ValidateBadgeNumber(NumberID, temp);
        }

        public Employee(string name, int numberID, Location location)
        {
            this.Name = name;
            this.NumberID = numberID;
            this.location = location;
            ValidateBadgeNumber(NumberID, location);

        }

        private void ValidateBadgeNumber(int NumberID, Location location)
        {
            if(NumberID < 10000 || NumberID > 99999)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string Name { get; }
        public int NumberID { get; }
        public Location location { get; }

        public string LocationString()
        {
            return location.ToString();
        }

        public bool IsNorthOfWarsaw()
        {
            if(location == Location.Koszalin || location == Location.Szczecin)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
