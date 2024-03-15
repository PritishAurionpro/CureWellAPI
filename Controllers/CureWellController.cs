using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CureWell.Models;
using CureWell.Services;
using Microsoft.AspNetCore.Mvc;

namespace CureWell.Controllers
{
    [ApiController]
    [Route("api")]
    public class CureWellController : ControllerBase
    {
        private ICureWellService _cureWellService;

        public CureWellController(ICureWellService cureWellService)
        {
            _cureWellService = cureWellService;
        }

        [HttpGet("get")]
        [Route("doctors")]
        public IActionResult GetAllDoctors() 
        {
            var doctors = _cureWellService.GetAllDoctors();
            if (doctors.Count == 0)
                return BadRequest("No doctors Added yet");
            return Ok(doctors);
        }
        [HttpGet]
        [Route("specializations")]
        public IActionResult GetAllSpecialization()
        {
            var specializations = _cureWellService.GetAllSpecialization();
            if(specializations != null)
                return Ok(specializations);
            return NotFound("No Specialization added yet");
        }
        [HttpGet]
        [Route("surgeries/{date}")]
        public IActionResult GetAllSurgeryForToday([Bind(Prefix = "date")]DateTime date) 
        {
            var surgeries = _cureWellService.GetAllSurgeryForToday(date);
            if(surgeries != null)
                return Ok(surgeries);
            return NotFound("No Surgeries for the date");
        }

        [HttpPost]
        [Route("doctors")]
        public IActionResult CreateDoctor([FromBody] Doctor doctor) 
        {
            var createdDoctor = _cureWellService.AddDoctor(doctor);
            if(createdDoctor != null)
                return Ok(createdDoctor);
            return BadRequest("Some issue while adding records");
        }
        [HttpPost]
        [Route("specialization")]
        public IActionResult AddSpecialization([FromBody] Specialization specialization) 
        {
            var addedSpecialization = _cureWellService.AddSpecialization(specialization);
            if(addedSpecialization != null)
                return Ok(addedSpecialization);
            return BadRequest("Some issue while adding records");
        }
        [HttpPost]
        [Route("Surgery")]
        public IActionResult AddSurgery([FromBody] Surgery surgery) 
        {
            var addedSurgery = _cureWellService.AddSurgery(surgery);
            if(addedSurgery != null)
                return Ok(addedSurgery);
            return BadRequest("Some issue while adding records");
        }
        [HttpPut]
        [Route("doctors/{doctorId}")]
        public IActionResult UpdateDoctor([Bind(Prefix = "doctorId")] int doctorId,[FromBody] Doctor doctor)
        {
            _cureWellService.UpdateDoctorDetails(doctorId, doctor);
            return Ok("Doctor updated");
        }

        [HttpPut]
        [Route("surgeries/{surgeryId}")]
        public IActionResult UpdateSurgery([Bind(Prefix = "surgeryId")] int surgeryId, [FromBody] Surgery surgery)
        {
            _cureWellService.UpdateSurgery(surgeryId, surgery);
            return Ok("Surgery updated");
        }
        [HttpDelete]
        [Route("doctors/{doctorId}")]
        public IActionResult DeleteDoctor([Bind(Prefix = "doctorId")] int doctorId) 
        {
            _cureWellService.DeleteDoctor(doctorId);
            return Ok();
        }
        
        
    }
}