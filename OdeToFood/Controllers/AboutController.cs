using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+91 8884004488";
        }

        public string Address()
        {
            return "Viman Nagar ,Pune";
        }
    }
}
