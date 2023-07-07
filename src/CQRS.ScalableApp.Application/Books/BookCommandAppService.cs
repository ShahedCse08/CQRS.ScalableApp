using CQRS.ScalableApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace CQRS.ScalableApp.Books
{
    public class BookCommandAppService : ScalableAppAppService
    {
        private readonly IRepository<Book> _bookRepository;
        public BookCommandAppService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
            await _bookRepository.InsertAsync(book);
            return ObjectMapper.Map<Book, BookDto>(book);
        }
    }



}
