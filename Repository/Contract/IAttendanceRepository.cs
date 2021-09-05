using System.Collections.Generic;

namespace qrattend.Repository.Contract
{
    ///attendance repository
    public interface IAttendanceRepository<T>  
    {  
        ///gets all attendance
        IEnumerable<T> GetAllAttendances();
        ///posts the attendance 
        List<string> PostAttendance(IEnumerable<int>  studentId, int classId, string date);

        ///gets by class and date
       List<string> GetAttendanceByClassAndDate(int classId, string date );

    }  
}
