using Microsoft.AspNetCore.Mvc;
using LinkedIn.Models;
namespace LinkedIn.Components
{
    public class NewsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<News> news = new List<News>();
            News n = new News{ Name="Maaz Javaid",Likes=30,PersonImage= "/images/person.jpg", NewsImage="/images/twitter.png"};
            news.Add(n);
            News n1 = new News { Name = "Usama Ijaz", Likes = 30, PersonImage = "/images/person.jpg", NewsImage = "/images/tesla.jpg" };
            news.Add(n1);
            News n2 = new News { Name = "Faizan Ijaz", Likes = 50, PersonImage = "/images/person1.jpg", NewsImage = "/images/twitter.png" };
            news.Add(n2);
            News n3 = new News { Name = "Matee ur rehman", Likes = 60, PersonImage = "/images/person2.jpg", NewsImage = "/images/tesla.jpg" };
            news.Add(n3);
            News n4 = new News { Name = "Wahabi", Likes = 30, PersonImage = "/images/person3.jpg", NewsImage = "/images/twitter.png" };
            news.Add(n4);
            News n5 = new News { Name = "Umer Waqar", Likes = 37, PersonImage = "/images/person4.jpg", NewsImage = "/images/tesla.jpg" };
            news.Add(n5);
            return View("Default",news);
        }
    }
}
