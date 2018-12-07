using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThaiNationalIDCard;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/read/card")]
        public IHttpActionResult getReaderCard() {
            ThaiIDCard idcard = new ThaiIDCard();
            Personal personal = idcard.readAllPhoto();
            return Json(personal);
        }
    }
}
