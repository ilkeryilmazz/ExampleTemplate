using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleItemsController : ControllerBase
    {
        IExampleItemService _exampleItemService;

        public ExampleItemsController(IExampleItemService exampleItemService)
        {
            _exampleItemService = exampleItemService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _exampleItemService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetAll(int id)
        {
            var result = _exampleItemService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult GetAll(ExampleItem exampleItem)
        {
            var result = _exampleItemService.Add(exampleItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(ExampleItem exampleItem)
        {
            var result = _exampleItemService.Update(exampleItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(ExampleItem exampleItem)
        {
            var result = _exampleItemService.Delete(exampleItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
