using System.Collections.Generic;

namespace qrattend.Repository.Contract
{
    ///Roster repository 
    public interface IRosterRepository<T>  
    {  
        ///gets all Roster
        IEnumerable<T> GetAllRosters();

        ///gets the roster by the class id 
        IEnumerable<T>  GetRosterByClassId(int classId);

        ///adds student to the roster 
       T  AddStudentToRoster(int classId, int studentId);
    }  
}
