using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IFlow _flowrepository;  //depenceny injection
        public InvoiceController(IFlow flowRepository)
        {
            _flowrepository=flowRepository;
        }

        [HttpGet("Invoice")]
        public async Task<IActionResult> createInvoice(int kurum_id, int ay, int yil)
        {
            var model = await _flowrepository.createInvoice(kurum_id,ay,yil);
            return Ok(model);
        }
    }
}
