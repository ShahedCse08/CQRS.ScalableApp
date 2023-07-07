using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using CQRS.ScalableApp.Books;

namespace CQRS.ScalableApp.Web.Pages.Books
{
    public class CreateModalModel : PageModel
    {
        [BindProperty]
        public CreateBookViewModel Book { get; set; }

        private readonly IBookCommandAppService _authorAppService;

        public CreateModalModel(IBookCommandAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }

        public void OnGet()
        {
            Book = new CreateBookViewModel();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = new CreateUpdateBookDto() { Name = Book.Name, Price = Book.Price };
            await _authorAppService.CreateAsync(dto);
            return null;
        }

        public class CreateBookViewModel
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
    }
}
