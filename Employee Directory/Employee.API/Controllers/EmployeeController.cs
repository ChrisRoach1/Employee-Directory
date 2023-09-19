using AutoMapper;
using EmployeeAPI.Context;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Domain;
using SharedLibrary.DTO;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmpDirContext _context;
        private readonly IMapper _mapper;


        public EmployeeController(EmpDirContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<EmployeeDto>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var employeeList = _context.Employee.ToList();


            return Ok(_mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(employeeList));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<EmployeeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult Get(int id)
        {
            var employee = _context.Employee.Find(id);

            if(employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }

        }

    }
}
