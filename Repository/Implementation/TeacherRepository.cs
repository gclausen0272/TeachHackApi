using System.Collections.Generic;
using qrattend.Repository.Contract;
using qrattend.Entities;
using System.Linq;

namespace qrattend.Repository.Implementation
{
    ///teacher repository
    public class TeacherRepository: ITeacherRepository<Teacher>  
    {  
        private LibraryContext _libraryContext;  

        ///sets up the repo with the database context
        public TeacherRepository(LibraryContext context)  
        {  
            _libraryContext = context;  
        }  

        ///refreshes repo for testing
        public void TeacherRepositoryRefresh(LibraryContext context){
            _libraryContext = context;
        }

        ///gets a list of all the Teachers
        public IEnumerable<Teacher> GetAllTeachers()  
        {  
            return _libraryContext.Teachers.ToList();  
        }

        ///gets teacher by username and password 
        public Teacher GetByUserNameAndPassword(string userName, string password)  {
            IEnumerable<Teacher> teachers = _libraryContext.Teachers.ToList().Where(x=>x.UserName == userName && x.Password == password);
            if(teachers.Count() ==1){
                return teachers.FirstOrDefault();
            }
            return new Teacher{Id = -1, MiddleName = "", FirstName = "", LastName = "", UserName = "", Password = ""};     
        }

        ///adds a Teacher to the database
        public Teacher PostTeacher( string middleName, string firstname,string lastName, string userName, string password){

            //adds new Teachers and saves database
            Teacher Teacher = new Teacher{MiddleName = middleName, FirstName = firstname, LastName = lastName, UserName = userName, Password = password};
            _libraryContext.Add(Teacher);
            _libraryContext.SaveChanges();
            return Teacher;
        }
    }  
}
