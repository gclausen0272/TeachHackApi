using System.Collections.Generic;

namespace qrattend.Repository.Contract
{
    ///class repository 
    public interface IClassRepository<T>  
    {  
        ///gets all classes 
        IEnumerable<T> GetAllClasses();
        IEnumerable<T> GetTeacherClasses(int teacherId);
        ///posts the class 
        T PostClass(int teacherId, string className);
    }  
}
