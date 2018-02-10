using System.Collections.Generic;
using System.Diagnostics;
using DMBS.Data.Models;
using DMBS.Models;
using DMBS.Presentation.Services;
using Microsoft.AspNetCore.Mvc;

namespace DMBS.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            LocationService ls=new LocationService();
            List<GetterModel>a=  ls.GetDistricts(5);
            OrganizationService os=new OrganizationService();
            List<GetterModel>ab=  os.GetLowerAssortment(4194);
            OrganizationModel om=os.GetOrganizations("34", "999999999", "4212", "0","","1","100","","");
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
