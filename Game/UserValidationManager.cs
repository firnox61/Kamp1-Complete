using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.Id == 1 && user.Ad == "Enes" && user.Soyad == "Eroglu" && user.DogumYili == 2000 && user.TcNo == "26485213500")
            {
                //Console.WriteLine("Kullanıcı doğru");
                return true;
            }
            else
            {
                return false;
                //Console.WriteLine("Kullanıcı yanlış");

            }
        }
    }
}
