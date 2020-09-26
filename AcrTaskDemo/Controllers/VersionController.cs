using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcrTaskDemo.Controllers
{
    public class VersionController : Controller
    {
        public VersionController(ILogger<HomeController> logger)
        {
        }

        public string Index()
        {
            return RuntimeInformation.FrameworkDescription;
        }
    }
}
