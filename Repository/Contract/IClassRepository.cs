using System.Collections.Generic;

namespace qrattend.Repository.Contract
{
    ///class repository 
    public interface IClassRepository<T>  
    {  
        ///gets all classes 
        IEnumerable<T> GetAllClasses();
        ///posts the class 
        T PostClass(int teacherId, string className);
    }  
}
