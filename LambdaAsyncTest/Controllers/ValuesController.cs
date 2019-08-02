using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LambdaAsyncTest.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("sync")]
        public string GetSync()
        {
            return Get();
        }

        private string Get()
        {
            Thread.Sleep(TimeSpan.FromSeconds(20));
            return Program.ContainerId;
        }

        [HttpGet("async")]
        public async Task<string> GetAsync()
        {
            var result = await Task.FromResult(Get());
            return result;
        }
    }
}
