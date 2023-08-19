using E_Ticaret.DAL.Entities;

namespace E_Ticaret.UI.ViewModels
{
    public class IndexVM
    {
        public IEnumerable<Slide> Slides { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
