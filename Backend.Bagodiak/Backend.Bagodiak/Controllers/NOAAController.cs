using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Backend.Bagodiak.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Bagodiak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NOAAController : ControllerBase
    {
        private readonly IRequestService _requestService;

        public NOAAController(IRequestService requestService)
        {
            _requestService = requestService ?? throw new ArgumentNullException(nameof(IRequestService));
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage(HttpStatusCode.Conflict);
        }
    }
}
