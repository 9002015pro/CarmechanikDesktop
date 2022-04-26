using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanik.com.vkirillov.carmechanik.obj
{
    public class Staff
    {

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public long Passport { get; set; }
        public DateTime DateBirth { get; set; }
        public bool Gender { get; set; } 
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
