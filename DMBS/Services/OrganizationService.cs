using DMBS.Presentation.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using DMBS.Data.Models;

namespace DMBS.Presentation.Services
{
    public class OrganizationService
    {
        /// <summary>
        /// Getter All Lower Assortment with Higher Assortment Id
        /// </summary>
        /// <param name="assortmentId">Higher Assortment Id</param>
        /// <returns></returns>
        public List<GetterModel> GetLowerAssortment(int assortmentId)
        {
            WebServiceManager wsm = new WebServiceManager();
            string jsonLowerAssortment = wsm.PostManager("https://derbis.dernekler.gov.tr/IstatistikDerneklerWeb/GetAltNeviler", new { neviPk = assortmentId });
            List<GetterModel> listLowerAssortments = JsonConvert.DeserializeObject<List<GetterModel>>(jsonLowerAssortment);
            return listLowerAssortments;
        }

        /// <summary>
        ///  Getter All of Organizations with Parameters
        /// </summary>
        /// <param name="city">City Plate Code</param>
        /// <param name="district">District Code</param>
        /// <param name="assortment">Assortment Code</param>
        /// <param name="lowerAssortment">Lower Assortment Code</param>
        /// <param name="sort">Sort Filter</param>
        /// <param name="page">Page Filter</param>
        /// <param name="pageSize">Page Size Filter</param>
        /// <param name="group">Group</param>
        /// <param name="filter">Filter</param>
        /// <returns></returns>
        public OrganizationModel GetOrganizations(string city,string district,string assortment,string lowerAssortment,
            string sort,string page,string pageSize,string group,string filter)
        {
            WebServiceManager wsm = new WebServiceManager();
            object body = new
            {
                sort = sort,
                page = page,
                pageSize = pageSize,
                group = group,
                filter = filter,
                serializedData = JsonConvert.SerializeObject(new
                {
                    secilenTeskilatPk = city,
                    secilenIlcePk = district,
                    neviler = assortment,
                    altneviler = lowerAssortment
                })
            };
            string jsonOrganizations = wsm.PostManager("https://derbis.dernekler.gov.tr/IstatistikDerneklerWeb/GetIlFaaliyetDernek", body);
            OrganizationModel Organizations = JsonConvert.DeserializeObject<OrganizationModel>(jsonOrganizations);
            return Organizations;
            
        }
    }
}
