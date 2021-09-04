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
    public class StudentController : ControllerBase  
    {  
        private readonly IStudentRepository<Student> _StudentRepository; 
        ///the controller  
        public StudentController(IStudentRepository<Student> StudentRepository)  
        {  
            _StudentRepository = StudentRepository;  
        }  
        /// GET: api/qrattend/GetAllStudent  
        [HttpGet]  
        [Route("GetAllStudent")]  
        public IActionResult GetAllStudent()  
        {     
            IEnumerable<Student> Students = _StudentRepository.GetAllStudents();  
            return Ok(Students);  
        }

        ///posts a student 
        [HttpPost]  
        [Route("PostStudent")]  
        public IActionResult PostStudent(string middleName, string firstName,string lastName)  
        {  
            var resp = _StudentRepository.PostStudent(middleName, firstName, lastName);  
            return Ok(resp);  
        }        
    } 
}