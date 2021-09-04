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


    ///Teacher controller 
    [Route("api/qrattend/")] 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]  
    public class TeacherController : ControllerBase  
    {  
        private readonly ITeacherRepository<Teacher> _TeacherRepository;  

        ///teacher controller 
        public TeacherController(ITeacherRepository<Teacher> TeacherRepository)  
        {  
            _TeacherRepository = TeacherRepository;  
        }  
        /// GET: api/qrattend/GetAllTeacher  
        [HttpGet]  
        [Route("GetAllTeacher")]  
        public IActionResult GetAllTeacher()  
        {     
            IEnumerable<Teacher> Teachers = _TeacherRepository.GetAllTeachers();  
            return Ok(Teachers);  
        }

        ///get teacher by username and password 
        [HttpPost]  
        [Route("GetByUserNameAndPassWord")]  
        public IActionResult GetByUserNameAndPassword(string userName, string password)  
        {     
            Teacher teacher = _TeacherRepository.GetByUserNameAndPassword(userName, password);  
            if(teacher.Id >0){
                return Ok(teacher);
            } else {
                return NotFound();
            }
        }

        ///posts a teacher 
        [HttpPost]  
        [Route("PostTeacher")]  
        public IActionResult PostTeacher(string middleName, string firstName,string lastName, string userName, string password)  
        {  
            var resp = _TeacherRepository.PostTeacher(middleName, firstName, lastName,userName, password);  
            return Ok(resp);  
        }        
    } 
}