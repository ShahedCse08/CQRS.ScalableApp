using CQRS.ScalableApp.CosmosDB;
using CQRS.ScalableApp.Models;
using CQRS.ScalableApp.Models.Books.ETO;
using CQRS.ScalableApp.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace CQRS.ScalableApp.Books
{
    public class BookQueryAppService : ScalableAppAppService, IBookQueryAppService
    {
        private readonly IRepository<Book> _bookRepository;
        public BookQueryAppService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<PagedResultDto<BookDto>> GetListAsync(GetBookListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Book.Name);
            }

            // var books = await _bookRepository.GetListAsync();

            var context = new CosmoDBContext();
            List<BookEto> books = context.Books.ToList();
            
            // Perform further operations with the retrieved books
            



            var totalCount = input.Filter == null
                ? await _bookRepository.CountAsync()
                : await _bookRepository.CountAsync(
                    book => book.Name.Contains(input.Filter));

            return new PagedResultDto<BookDto>(
                totalCount,
                ObjectMapper.Map<List<BookEto>, List<BookDto>>(books)
            );
        }
    }
}
