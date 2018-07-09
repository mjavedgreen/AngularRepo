using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJS_Web_API_MVC.Models;

namespace AngularJS_Call_Controller_MVC.Controllers
{
    public class StoreItemController : ApiController
    {
        [Route("api/StoreItem/GetStoreItemById")]
        [HttpPost]
        public StoreItem GetStoreItemById(StoreItemModel storeItem)
        {
            DBEntities entities = new DBEntities();
            return (from c in entities.StoreItems
                    where (c.Id == storeItem.Id)
                    select c).FirstOrDefault();
        }
        [Route("api/StoreItem/GetStoreItems")]
        [HttpPost]
        public List<StoreItem> GetStoreItems()
        {
            DBEntities entities = new DBEntities();
            return (from c in entities.StoreItems
                    select c).ToList();
        }
    }
}
