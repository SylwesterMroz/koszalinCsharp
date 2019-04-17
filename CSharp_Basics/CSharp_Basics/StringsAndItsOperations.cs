using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        private string Poem = "Powiem szczerze, znajomych mam wielu,Ale tylko do Ciebie mogę powiedzieć: Mój przyjacielu.Po dodaniu imienia wiersz będzie już wierszykiem spersonalizowanym:Powiem szczerze, znajomych mam wielu,Ale tylko do Ciebie Andrzeju mogę powiedzieć: Mój przyjacielu.";
        
        /// <summary>
        /// String is diffrent then previues types we talk about
        /// values of string we are passing in quotation marks
        /// 
        /// Create new string with your name and then add them together
        /// </summary>
        [Test]
        public void Bascis_Of_Strings()
        {
            string Example = "This is example string";
        }

        /// <summary>
        ///  string is  first Reference Type you see (We will talk more about them later)
        ///  which means he doesn't have to have value.
        ///  use string.Empty;
        ///  create new strings itsEmpty and make it empty
        /// </summary>
        [Test]
        public void String_Initialization()
        {
            string itsEmpty = string.Empty;
            
            Assert.That(itsEmpty, Is.Not.Null);
        }

        /// <summary>
        /// + is not best way of adding string
        ///  use string.Concat();
        ///  put sentence together
        /// </summary>
        [Test]
        public void Adding_String()
        {
            string first = "pancakes.";
            string second = "I like ";
            string result = string.Concat(second, first);

            Assert.AreEqual(result, "I like pancakes.");
        }

        /// <summary>
        /// There is few more ways of cosntructing strings for example if you need add values of other variables inside you can do
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#Starting
        /// create string with both x and y insed
        /// </summary>
        [Test]
        public void String_Format()
        {
            int x = 500;
            int y = 453;
            string result = string.Format("Number x equals {0} \nNumber y equals {1}", x, y);

            StringAssert.Contains(x.ToString(), result);
            StringAssert.Contains(y.ToString(), result);
            //Console.WriteLine(result);
        }

        /// <summary>
        /// From theString return word "thing".
        /// hint use Substring() method
        /// </summary>
        [Test]
        public void Substrings()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";

           string result = theString.Substring(16,5);
           

            Assert.AreEqual("thing", result);
        }
    }
}
