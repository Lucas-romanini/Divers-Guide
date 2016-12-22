using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGrepo
{
   public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int LevelID { get; set; }
        public string ProfilePic { get; set; }
        public string About { get; set; }
        public int TLF { get; set; }
    }
}
