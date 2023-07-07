using AutoMapper;
using CQRS.ScalableApp.Books;

namespace CQRS.ScalableApp.Web;

public class ScalableAppWebAutoMapperProfile : Profile
{
    public ScalableAppWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.


        CreateMap<BookDto, CreateUpdateBookDto>();

        // ADD a NEW MAPPING
        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel,
                    CreateUpdateBookDto>();
    }
}
