﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
     interface IUserService
    {
         void Add(User user);
         void Update(User user);
         void Delete(User user);

    }
}
