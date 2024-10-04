﻿using Shop.Ccommon.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services.Users.Commands.LoginUser
{
    public interface ILoginUser
    {
        ResultDto<LoginUserDto> Execute(RequestLoginDto request);
    }
}
