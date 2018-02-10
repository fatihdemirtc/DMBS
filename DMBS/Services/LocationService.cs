using System.Collections.Generic;
using DMBS.Data.Models;
using DMBS.Presentation.Core;
using Newtonsoft.Json;

namespace DMBS.Presentation.Services
{
    public class LocationService
    {
        public List<GetterModel> GetDistricts(int cityId)
        {
            WebServiceManager wsm=new WebServiceManager();
            string jsonDistrict = wsm.PostManager("https://derbis.dernekler.gov.tr/IstatistikDerneklerWeb/IlIlceleriniYukle",new {ilPk = cityId });
            List<GetterModel> listDistricts = JsonConvert.DeserializeObject<List<GetterModel>>(jsonDistrict);
            return listDistricts;
        }
    }
}
