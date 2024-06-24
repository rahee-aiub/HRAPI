using HR.ApplicationLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ApplicationLayer.Services
{
    public class CommonService : ICommonService
    {
        public (string hashedPassword, string salt) HashPassword(string password)
        {
            return PasswordHasher.HashPassword(password);
        }
        public bool VerifyPassword(string hashpassword,string saltpassword,string storedSalt)
        {
            return PasswordHasher.VerifyPassword(hashpassword, saltpassword, storedSalt);
        }
    }
}
