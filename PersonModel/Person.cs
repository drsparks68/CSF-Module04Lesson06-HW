using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonModel
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }

        public string FullName
        {
            get
            {
                string output = $"{ FirstName } { MiddleInitial } { LastName }";
                return output;
            }
        }




    }
}
