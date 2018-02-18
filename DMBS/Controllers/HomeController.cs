using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            //LocationService ls=new LocationService();
            //List<GetterModel>a=  ls.GetDistricts(5);
            OrganizationService os=new OrganizationService();
            //List<GetterModel>ab=  os.GetLowerAssortment(4194);

            List<OrganizationModel> organizations=new List<OrganizationModel>();
            Parallel.For(1, 81, i =>
            {
                OrganizationModel om = os.GetOrganizations(i.ToString(), "999999999", "0", "0", "", "1", "100", "", "");
                organizations.Add(om);
            });
            
            return View(organizations.FirstOrDefault().Data.ToList());
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
