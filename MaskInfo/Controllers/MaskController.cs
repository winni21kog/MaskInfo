using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MaskInfo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaskInfo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MaskController : ControllerBase
    {
        private readonly MaskService _maskService;

        public MaskController(MaskService maskService)
        {
            _maskService = maskService;
        }

        public async Task<IActionResult> Get()
        {
            try
            {
                var maskCount = _maskService.GetMaskInfo();
                return Ok(maskCount);
            }
            catch(HttpRequestException ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}