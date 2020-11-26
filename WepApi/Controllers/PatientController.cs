using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concrete;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientDataService _patientDataService;

        public PatientController(IPatientDataService patientDataService)
        {
            _patientDataService = patientDataService;
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result= _patientDataService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _patientDataService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest();
        }

        [HttpPost("Save")]
        public IActionResult Save(PatientData patientData)
        {
           var result= patientData.Id == 0 ? _patientDataService.Create(patientData) : _patientDataService.Update(patientData);
           if (result.Success)
           {
               return Ok(patientData);
           }
           return BadRequest();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(PatientData patientData)
        {
            var result = _patientDataService.Delete(patientData);
            if (result.Success)
            {
                return Ok(patientData);
            }
            return BadRequest();
        }
    }
}
