using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebUI.ViewComponents.ShoppingCardViewComponents
{
    public class _ShoppingCardProductListViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
