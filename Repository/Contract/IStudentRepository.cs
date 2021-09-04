using System.Collections.Generic;

namespace qrattend.Repository.Contract
{
    ///student repository 
    public interface IStudentRepository<T>  
    {  
        ///gets all student
        IEnumerable<T> GetAllStudents();

        ///posts the student 
        T PostStudent(string middleName, string firstname,string lastName);
    }  
}
