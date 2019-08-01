using Microsoft.AspNetCore.Mvc;
using SampleApi.Services;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IFakeService _fakeService;

        public SampleController(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_fakeService.AThirdAction());
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var someValueIWontUse = $"This value is unused: {value}";

            var url = GetRouteUrl("Get", "Sample", new {});
            return Created(url, null);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var doSomethingResult = _fakeService.DoSomething();
            return Ok();
        }

        internal string GetRouteUrl(string action, string controller, object values)
        {
            var fragment = Url.Action(action, controller, values);
            return $"http://tonyranieri.com/api/{fragment}";
        }        
    }
}
