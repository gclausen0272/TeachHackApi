using System.Threading.Tasks;
using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using qrattend.Entities;
using qrattend.Repository.Contract;
using System.Web.Http.Cors;
using qrattend.Repository.Implementation;
namespace qrattend.Controllers
{

    ///the controller 
    [Route("api/qrattend/")] 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]  
    public class RosterController : ControllerBase  
    {  
        private readonly IRosterRepository<Roster> _RosterRepository; 
        ///the controller  
        public RosterController(IRosterRepository<Roster> RosterRepository)  
        {  
            _RosterRepository = RosterRepository;  
        }  
        /// GET: api/qrattend/GetAllRoster  
        [HttpGet]  
        [Route("GetAllRoster")]  
        public IActionResult GetAllRoster()  
        {     
            IEnumerable<Roster> Rosters = _RosterRepository.GetAllRosters();  
            return Ok(Rosters);  
        }

        ///gets roster for class 
         [HttpGet]  
        [Route("GetRosterByClassId")]  
        public IActionResult GetRosterByClassId(int classId)  
        {     
            IEnumerable<Roster> Rosters = _RosterRepository.GetRosterByClassId(classId);  
            return Ok(Rosters);  
        }       

        ///posts a Roster 
        [HttpPost]  
        [Route("AddStudentToRoster")]  
        public IActionResult AddStudentToRoster(int classId, int studentId)  
        {  
            var resp = _RosterRepository.AddStudentToRoster(classId, studentId);  
            return Ok(resp);  
        }        
    } 
}