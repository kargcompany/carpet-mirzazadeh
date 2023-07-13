﻿using Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services.ProductsSite.Queries.GetDetailProductModalForSite
{
    public interface IGetProductDetailModalSiteService
    {
        Task<ResultDto<DetailProductModalSiteDto>> Execute(string idProduct);
    }
}
