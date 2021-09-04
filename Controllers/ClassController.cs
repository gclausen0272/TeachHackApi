using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using qrattend.Entities;
using qrattend.Repository.Contract;
using System.Web.Http.Cors;
using qrattend.Repository.Implementation;
namespace qrattend.Controllers
{

    ///class controller 
    [Route("api/qrattend/")] 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]  
    public class ClassController : ControllerBase  
    {  
        private readonly IClassRepository<Class> _ClassRepository;  

        ///controls class 
        public ClassController(IClassRepository<Class> ClassRepository)  
        {  
            _ClassRepository = ClassRepository;  
        }  
        /// GET: api/qrattend/GetAllClass  
        [HttpGet]  
        [Route("GetAllClass")]  
        public IActionResult GetAllClass()  
        {     
            IEnumerable<Class> Classs = _ClassRepository.GetAllClasses();  
            return Ok(Classs);  
        }
        
        [HttpGet]  
        [Route("GetTeacherClasses")]  
        public IActionResult GetTeacherClasses(int teacherId)  
        {     
            IEnumerable<Class> Classs = _ClassRepository.GetTeacherClasses(teacherId);  
            return Ok(Classs);  
        }
        ///posts class 
        [HttpPost]  
        [Route("PostClass")]  
        public IActionResult PostClass(int teacherId, string className)  
        {  
            var resp = _ClassRepository.PostClass(teacherId, className);  
            return Ok(resp);  
        }        
    } 
}