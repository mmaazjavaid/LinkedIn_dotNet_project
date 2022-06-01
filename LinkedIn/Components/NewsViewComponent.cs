using Microsoft.AspNetCore.Mvc;
namespace LinkedIn.Components
{
    public class NewsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
