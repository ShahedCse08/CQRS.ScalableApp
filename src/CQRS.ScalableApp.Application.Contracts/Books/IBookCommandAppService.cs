using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.ScalableApp.Books
{
    public interface IBookCommandAppService
    {
        Task<BookDto> CreateAsync(CreateUpdateBookDto input);
    }
}
