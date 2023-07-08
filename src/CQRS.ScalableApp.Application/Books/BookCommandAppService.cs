using CQRS.ScalableApp.Models;
using CQRS.ScalableApp.Models.Players.ETO;
using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;
using CQRS.ScalableApp.Models.Books.ETO;

namespace CQRS.ScalableApp.Books
{
    public class BookCommandAppService : ScalableAppAppService, IBookCommandAppService


    {
        private readonly IRepository<Book> _bookRepository;

        private readonly IDistributedEventBus _distributedEventBus;
        public BookCommandAppService(IRepository<Book> bookRepository, IDistributedEventBus distributedEventBus)
        {
            _bookRepository = bookRepository;
            _distributedEventBus = distributedEventBus;

        }
        public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
            var addedItem = await _bookRepository.InsertAsync(book,true);
            var bookDto = ObjectMapper.Map<Book, BookDto>(addedItem);
            var bookEto = ObjectMapper.Map<Book, BookEto>(book);
            await _distributedEventBus.PublishAsync(bookEto);
            return bookDto;
        }


    }



}
