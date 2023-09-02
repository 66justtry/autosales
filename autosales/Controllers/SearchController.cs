using Microsoft.AspNetCore.Mvc;

namespace autosales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var queryList = HttpContext.Request.Query.ToList();
            
            foreach (var query in queryList)
            {
                switch (query.Key)
                {
                    case "id":
                        break;
                    default:
                        break;
                }
            }
            return new List<string> { "ddd", "yyy" };
        }
    }
}
