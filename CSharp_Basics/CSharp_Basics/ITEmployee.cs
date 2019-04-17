using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class ITEmployee : Employee
    {
        public string ProgramingLanguage { get; }
        public ITEmployee(string name, int numberID, string location, string programingLanguage) : base(name, numberID, location)
        {
            this.ProgramingLanguage = programingLanguage;
        }

        public ITEmployee(string name, int numberID, Location location, string programingLanguage) : base(name, numberID, location)
        {
            this.ProgramingLanguage = programingLanguage;
        }
    }
}
