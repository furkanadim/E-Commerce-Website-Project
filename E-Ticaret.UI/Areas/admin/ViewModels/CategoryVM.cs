using E_Ticaret.DAL.Entities;

namespace E_Ticaret.UI.Areas.admin.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
