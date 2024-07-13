using Microsoft.AspNetCore.Mvc;
using MontyHallAPI.Model;
using MontyHallAPI.Services;

namespace MontyHallAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimulationController : ControllerBase
    {
        private readonly SimulationService _simulationService;

        public SimulationController()
        {
            _simulationService = new SimulationService();
        }

        [HttpPost]
        public ActionResult<SimulationResult> RunSimulation(SimulationRequest request)
        {
            var result = _simulationService.RunSimulation(request.NumberOfSimulations, request.ChangeDoor);
            return Ok(result);
        }
    }

}
