using System.Collections.Generic;
using qrattend.Repository.Contract;
using qrattend.Entities;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
namespace qrattend.Repository.Implementation
{
    ///student repository 
    public class StudentRepository: IStudentRepository<Student>  
    {  
        private LibraryContext _libraryContext;  

        ///sets up the repo with the database context
        public StudentRepository(LibraryContext context)  
        {  
            _libraryContext = context;  
        }  

        ///refreshes repo for testing
        public void StudentRepositoryRefresh(LibraryContext context){
            _libraryContext = context;
        }

        ///gets a list of all the Students
        public IEnumerable<Student> GetAllStudents()  
        {  
            return _libraryContext.Students.ToList();  
        }

        ///adds a Student to the database
        public Student PostStudent( string middleName, string firstname,string lastName){
            Student Student = new Student{MiddleName = middleName, FirstName = firstname, LastName = lastName};
            _libraryContext.Add(Student);
            _libraryContext.SaveChanges();
            return Student;
        }
    }  
}
