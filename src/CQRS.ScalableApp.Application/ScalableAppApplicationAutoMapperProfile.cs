using AutoMapper;
using CQRS.ScalableApp.Books;
using CQRS.ScalableApp.Models;
using CQRS.ScalableApp.Models.Books.ETO;
using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Models.Players.ETO;
using CQRS.ScalableApp.MyHandler;
using CQRS.ScalableApp.Players.Dtos;

namespace CQRS.ScalableApp;

public class ScalableAppApplicationAutoMapperProfile : Profile
{
    public ScalableAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<PlayerDto, Player>().ReverseMap();
        CreateMap<Player, PlayerEto>().ReverseMap();

        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<CreateUpdateBookDto, Book>().ReverseMap();
        CreateMap< Book, CreateUpdateBookDto>().ReverseMap();

        CreateMap<Book, BookEto>().ReverseMap();
        CreateMap<BookEto, BookDto>().ReverseMap();

    }
}
