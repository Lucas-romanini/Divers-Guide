using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGrepo
{
   public class UsersFac : AutoFac<Users>
    {
        public bool UserExist(string email)
        {
            if (GetBy("Email", email).Count > 0)
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
