using E_Ticaret.DAL.Entities;
using E_Ticaret.UI.Models;

namespace E_Ticaret.UI.ViewModels
{
    public class CheckOutVM
    {
        public Order Order { get; set; }
        public IEnumerable<Cart> Carts { get; set; }
    }
}
