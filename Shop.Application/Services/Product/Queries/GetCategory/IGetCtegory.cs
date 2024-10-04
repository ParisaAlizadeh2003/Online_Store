﻿using Shop.Ccommon.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services.Product.Queries.GetCategory
{
    public interface IGetCtegory
    {
        Task<ResultDto<CategoriesDto>> ExecuteAsync(long? parentId , int Page = 1 , int PageSize = 20);
    }
}
