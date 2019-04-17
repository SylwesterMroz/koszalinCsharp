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
        }

        public Employee(string name, int numberID, Location location)
        {
            this.Name = name;
            this.NumberID = numberID;
            this.location = location;
        }
        public string Name { get; }
        public int NumberID { get; }
        public Location location { get; }

        public string LocationString()
        {
            return location.ToString();
        }

    }
}
