using Grow.AI.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grow.AI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public int GetPerson(int id)
        {
            return id * id;
        }

        [HttpPost]
        public SimpleReponse AddPerson([FromBody] PersonInfo personInfo)
        {
            return new SimpleReponse
            {
                Id = personInfo.Id,
                Name = personInfo.Name,
                Degree = personInfo.Educations.First().Degree,
                DegreeField = personInfo.Educations.First().DegreeField
            };
        }
    }
}
