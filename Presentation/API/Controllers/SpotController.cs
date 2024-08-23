using Business.Abstract;
using Business.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotController : ControllerBase
    {
        private readonly ISpot _spotRepository;  //depenceny injection
        public SpotController(ISpot SpotRepository)
        {
            _spotRepository=SpotRepository;
        }

        [HttpGet("AllSpot")]
        public async Task<IActionResult> getAllSpot()
        {
            var model =await  _spotRepository.GetSpotAll();
            return Ok(model);
        }

        [HttpGet("Capacity")]
        public async Task<IActionResult> getTotalCapacity(int ay,int yil)
        {
            var model = await _spotRepository.GetByTotalCapacity( ay, yil);
            return Ok(model);
        }

        [HttpGet("Period")]
        public async Task<IActionResult> getByPeriod(int ay, int yil)
        {
            var model = await _spotRepository.GetByPeriod(ay,yil);
            return Ok(model);
        }

    }
}
