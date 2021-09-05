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

    ///attendance controller
    [Route("api/qrattend/")] 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]  
    public class AttendanceController : ControllerBase  
    {  
        private readonly IAttendanceRepository<Attendance> _AttendanceRepository;  

        ///controller
        public AttendanceController(IAttendanceRepository<Attendance> AttendanceRepository)  
        {  
            _AttendanceRepository = AttendanceRepository;  
        }  
        /// GET: api/qrattend/GetAllAttendance  
        [HttpGet]  
        [Route("GetAllAttendance")]  
        public IActionResult GetAllAttendance()  
        {     
            IEnumerable<Attendance> Attendances = _AttendanceRepository.GetAllAttendances();  
            return Ok(Attendances);  
        }

        ///get class attendance 
        [HttpGet]  
        [Route("GetAttendanceByClassAndDate")]  
        public IActionResult GetAttendanceByClassAndDate(int classId, string date )  
        {     
            IEnumerable<string> Attendances = _AttendanceRepository.GetAttendanceByClassAndDate(classId, date);  
            return Ok(Attendances);  
        }

        ///post attendance 
        [HttpGet]  
        [Route("PostAttendance")]  
        public IActionResult PostAttendance(string studentId, int classId, string date)  
        {  
            string[] strs = studentId.Split(',');
            List<int> studentIds = new List<int>();

            foreach(string s in strs){
                int i = Int32.Parse(s);
                studentIds.Add(i);
            }

            var resp = _AttendanceRepository.PostAttendance(studentIds, classId, date);  
            return Ok(resp);  
        }        
    } 
}