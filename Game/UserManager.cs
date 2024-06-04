using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{//bir manager sınıfının içinde başka bir manager sınıf kullanıcaksan asla onu new leme
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;
        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(User user)
        {
            if(_userValidationService.Validate(user)==true)
            {
                Console.WriteLine("Kullanıcı başarılı bir şekilde eklendi");
            }
            else { Console.WriteLine("Kullanıcı doğrulama başarısız"); }

            
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı başarılı bir şekilde silndi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı başarılı bir şekilde güncellendi");
        }
    }
}
