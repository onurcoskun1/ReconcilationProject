using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class Company : Controller
    {
        private readonly ICompanyService _companyService;

        public Company(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getcompanylist")]
        public IActionResult GetCompanyList()
        {
            var result = _companyService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
