﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CQRS.ScalableApp.Books
{
    public interface IBookQueryAppService
    {
        Task<PagedResultDto<BookDto>> GetListAsync(GetBookListDto input);
    }
}
