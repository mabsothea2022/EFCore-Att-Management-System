﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystem.Entities
{
    public class UserAccount
    {
        public int UserAccountID { get; set; }
        public String? Username { get; set; }
        public String? Password { get; set; }
    }
}
