using HildaVilla.Api.Data;
using HildaVilla.Api.Models;
using HildaVilla.Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HildaVilla.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        // GET: api/<VillaController>
        [HttpGet("GetAllVilla")]
        public ActionResult<IEnumerable<VillaDto>> Get()
        {
            return Ok(VillaStore.villaList);
        }

        // GET api/<VillaController>/5
        [HttpGet("GetVillaById")]
        public ActionResult<VillaDto> GetByID(int id)
        {
            
            if (id == 0) return BadRequest("id cant be 0");

            var villa = VillaStore.villaList.FirstOrDefault(x => x.Id == id)!;

            if (villa == null) return NotFound("id cant be empty or null");

            return Ok(villa) ;

        }

        // POST api/<VillaController>
        [HttpPost("AddVilla")]
        public IActionResult Post([FromBody] VillaDto villaDto)
        {
            //var villaList = VillaStore.villaList.Find(villaDto.Id);

            return Ok("agregado con exito");
        }

        // PUT api/<VillaController>/5
        [HttpPut("UpdateVilla")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VillaController>/5
        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
        }
    }
}
