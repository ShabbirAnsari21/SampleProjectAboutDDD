using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Model.RequestModel;

namespace SampleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<SchoolController> _logger;
        private readonly IMapper _mapper;
        public SchoolController(IMediator mediator, ILogger<SchoolController> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost("AddSchool")]
        public async Task<ActionResult> AddSchool(AddSchoolRequest addSchoolRequest)
        {
            return Ok(addSchoolRequest);
        }
    }
}
