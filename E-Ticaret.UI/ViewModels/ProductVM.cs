using E_Ticaret.DAL.Entities;

namespace E_Ticaret.UI.ViewModels
{
    public class ProductVM
    {
        internal IQueryable<Product> product;

        public Product Product { get; set; }
        public IEnumerable<Product> RelatedProducts { get; set; }
    }
}
