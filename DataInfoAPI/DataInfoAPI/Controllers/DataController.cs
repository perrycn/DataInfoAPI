using System.Web.Http;

namespace DataInfoAPI.Controllers
{
    public class DataController : ApiController
    {
        // GET api/Data
        public IHttpActionResult GetData()
        {
            return Ok("Hello World");
        }
    }
}