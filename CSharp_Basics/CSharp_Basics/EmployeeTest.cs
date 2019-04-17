using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class EmployeeTest
    {
        [Test]
        public void Employee_Creation_FieldProperlyField()
        {
            var employee = new Employee("Emka", 556, "Koszalin");
            var employee2 = new Employee("Sylwek", 334, "Koszalin");
            var employee3 = new Employee("Aleksandra", 224, "Wroclaw");
            var employee4 = new Employee("Bartek", 674, "Szczecin");


            Assert.That(employee.Name, Is.EqualTo("Emka"));
            Assert.That(employee.NumberID, Is.EqualTo(556));
            Assert.That(employee.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee2.Name, Is.EqualTo("Sylwek"));
            Assert.That(employee2.NumberID, Is.EqualTo(334));
            Assert.That(employee2.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee3.Name, Is.EqualTo("Aleksandra"));
            Assert.That(employee3.NumberID, Is.EqualTo(224));
            Assert.That(employee3.LocationString, Is.EqualTo("Wroclaw"));
            Assert.That(employee4.Name, Is.EqualTo("Bartek"));
            Assert.That(employee4.NumberID, Is.EqualTo(674));
            Assert.That(employee4.LocationString, Is.EqualTo("Szczecin"));
        }

        [Test]
        public void EmployeeIT_Creation_FieldProperlyField()
        {
            var employee5 = new ITEmployee("Emka", 556, "Koszalin", "C#");

            Assert.That(employee5.Name, Is.EqualTo("Emka"));
            Assert.That(employee5.NumberID, Is.EqualTo(556));
            Assert.That(employee5.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee5.ProgramingLanguage, Is.EqualTo("C#"));
        }

        [Test]
        public void EmployeeEnum_Creation_FieldProperlyField()
        {
            var employee6 = new Employee("Ania", 455, Location.Koszalin);
            Assert.That(employee6.Name, Is.EqualTo("Ania"));
            Assert.That(employee6.NumberID, Is.EqualTo(455));
            Assert.That(employee6.location, Is.EqualTo(Location.Koszalin));
        }

        [Test]
        public void EmployeeITEnum_Creation_FieldProperlyField()
        {
            var employee7 = new ITEmployee("Marta", 888, Location.Szczecin, "Python");
            Assert.That(employee7.Name, Is.EqualTo("Marta"));
            Assert.That(employee7.NumberID, Is.EqualTo(888));
            Assert.That(employee7.location, Is.EqualTo(Location.Szczecin));
            Assert.That(employee7.ProgramingLanguage, Is.EqualTo("Python"));
        }

        [TestCase(Location.Koszalin,true)]
        [TestCase(Location.Szczecin, true)]
        [TestCase(Location.Wroclaw, false)]
        [TestCase(Location.ZielonaGora, false)]
        public void IsNorth(Location loc, bool result)
        {
            var employee8 = new Employee("Kamil", 523, loc);

            Assert.That(employee8.IsNorthOfWarsaw, Is.EqualTo(result));
        }

        public void OutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Employee("dsf",badge, loc)
                )
        }

    }
}
