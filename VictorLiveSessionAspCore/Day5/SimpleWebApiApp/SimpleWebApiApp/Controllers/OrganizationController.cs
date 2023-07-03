using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApiApp.Data;
using SimpleWebApiApp.Repository;

namespace SimpleWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {

        private IOrganizationRepository _organizationRepository;
        public OrganizationController(IOrganizationRepository repository) { 
        
            _organizationRepository = repository;
        }

        [HttpGet]
        public IActionResult Get() { 
        
            var organizations = _organizationRepository.GetOrganizations();
            return Ok(organizations);
        }

        [HttpGet("{organizationId}")]
        public IActionResult GetById(int organizationId)
        {

            var organizations = _organizationRepository.GetOrganizations();
            var ograniztion = organizations.Single(o => o.Id == organizationId);
            if (ograniztion == null)
                return NotFound();
            return Ok(ograniztion);

        }

        [HttpPost]
        public IActionResult Post(Organization organization)
        {
            _organizationRepository.AddOrganization(organization);
            return Ok();
        }


        [HttpPut("{organizationId}")]
        public IActionResult Put(int organizationId, Organization newOrgansation) {

            _organizationRepository.UpdateOrganization(organizationId, newOrgansation);

            return Ok();
        }

        [HttpDelete("{organizationId}")]
        public IActionResult Delete(int organizationId)
        {
            _organizationRepository.Remove(organizationId);
            return Ok();
        }
    }
}
