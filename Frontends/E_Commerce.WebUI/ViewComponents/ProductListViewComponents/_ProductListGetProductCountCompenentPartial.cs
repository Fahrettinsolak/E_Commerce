using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListGetProductCountCompenentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(int productCount)
        {
            return View(productCount);
        }
    }
}
