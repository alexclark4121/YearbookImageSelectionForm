using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase
{
    public class PersonModel   //maind model for the table headings and the input fields // 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageNumber { get; set; }
        public string School { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName } { ImageNumber } { School }";
            }
        }
    }
}
