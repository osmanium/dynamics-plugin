﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kipon.Solid.Plugin.Entities;
using Kipon.Solid.Plugin.Extensions.Strings;

namespace Kipon.Solid.Plugin.Service
{
    public class AccountService : ServiceAPI.IAccountService
    {
        public void OnNameChanged(IAccountNameChanged target)
        {
            if (!string.IsNullOrEmpty(target.Name))
            {
                var names = target.Name.Split(' ').Select(r => r.FirstToUpper());
                target.Name = string.Join(" ", names);
            }
        }
    }
}