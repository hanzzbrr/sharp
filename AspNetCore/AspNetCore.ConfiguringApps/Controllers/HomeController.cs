using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProMVC2_ConfiguringApps.Infrastracture;

namespace ProMVC2_ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService up) => uptime = up;

        public ViewResult Index() => View(new Dictionary<string, string>
        {
            ["Message"] = "This is the Index action",
            ["Uptime"] = $"{uptime.Uptime}"
        });
    }
}
