using E_Ticaret.DAL.Entities;

namespace E_Ticaret.UI.Areas.admin.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
