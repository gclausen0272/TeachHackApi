using System.Collections.Generic;

namespace qrattend.Repository.Contract
{
    ///teacher repository 
    public interface ITeacherRepository<T>  
    {  
        ///gets all the teachers 
        IEnumerable<T> GetAllTeachers();
        ///gets all teacher by username and password 
        T GetByUserNameAndPassword(string userName, string password);
        ///posts the teacher 
        T PostTeacher(string middleName, string firstname,string lastName, string userName, string password);
    }  
}
