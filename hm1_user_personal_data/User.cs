using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm1_user_personal_data
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}; {Weight} kg; {Country}";
        }
    }

}
