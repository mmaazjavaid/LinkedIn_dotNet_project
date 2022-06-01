using Microsoft.AspNetCore.Mvc;
using LinkedIn.Models;
namespace LinkedIn.Components
{
    public class JobsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Jobs> jobs = new List<Jobs>();
            jobs.Add(new Jobs
            {
                CompanyLogo = "/images/tesla.jpg",
                CompanyName = "Tesla",
                Title = "On site Engineer",
                EmployementType = "full-time",
                JobType = "Hybrid",
                Location = "lahore ,Pakistan"
            });
            jobs.Add(new Jobs
            {
                CompanyLogo = "/images/microsoft.jpg",
                CompanyName = "Microsoft",
                Title = "Software Engineer",
                EmployementType = "full-time",
                JobType = "Remote",
                Location = "lahore ,Pakistan"
            });
            jobs.Add(new Jobs
            {
                CompanyLogo = "/images/twitter.png",
                CompanyName = "Twitter",
                Title = "AI Engineer required",
                EmployementType = "full-time",
                JobType = "on-site",
                Location = "lahore ,Pakistan"
            });
            jobs.Add(new Jobs
            {
                CompanyLogo = "/images/google.png",
                CompanyName = "Google",
                Title = "Robotics Engineer urgent hiring",
                EmployementType = "full-time",
                JobType = "Hybrid",
                Location = "lahore ,Pakistan"
            });
            return View("Default", jobs);
        }
    }
}
