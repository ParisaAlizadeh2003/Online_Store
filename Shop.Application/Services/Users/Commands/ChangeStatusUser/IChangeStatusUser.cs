﻿using Shop.Ccommon.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services.Users.Commands.ChangeStatusUser
{
    public interface IChangeStatusUser
    {
        ResultDto Execute(long UserId);
    }
}
