using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GuidGenerator.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GuidGeneratorController : ControllerBase
    {
        [HttpGet("{total:int?}")]
        public async Task<IActionResult> Generate(int? total = 0)
        {
            var result = await Task.Run(() =>
            {
                var listGuids = new List<Guid>();

                total = total <= 1 ? 1 : total;
                int i = 0;
                do
                {
                    listGuids.Add(Guid.NewGuid());
                    i++;
                } while (i < total);

                return listGuids;
            });

            return Ok(result);
        }
    }
}
