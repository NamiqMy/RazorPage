using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Pages
{
    public class ProductModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = ProductRepository.GetProducts();
        }
    }
}
