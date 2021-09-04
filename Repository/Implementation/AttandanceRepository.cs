using System.Collections.Generic;
using qrattend.Repository.Contract;
using qrattend.Entities;
using System.Linq;
using System;

namespace qrattend.Repository.Implementation
{
    ///attendance repository
    public class AttendanceRepository: IAttendanceRepository<Attendance>  
    {  
        private LibraryContext _libraryContext;  

        ///sets up the repo with the database context
        public AttendanceRepository(LibraryContext context)  
        {  
            _libraryContext = context;  
        }  

        ///gets a list of all the Attendances
        public IEnumerable<Attendance> GetAllAttendances()  
        {  
            return _libraryContext.Attendances.ToList();  
        }

        ///gets attendance by class and date 
        public List<string> GetAttendanceByClassAndDate(int classId, string date ){

            var attend =  _libraryContext.Attendances.ToList().Where(x=>x.ClassId == classId && x.Date == date);  
            return makeItReadable(attend, classId);
          
        }
        private Dictionary<int,string> studentDictionary(){
            Dictionary<int, string> Pairs = new Dictionary<int, string>();
            var students = _libraryContext.Students.ToDictionary(r =>r.Id, r=>r.FirstName+' '+ r.MiddleName + ' '+ r.LastName);
            return students;
        }

        ///make it readable 
        public List<string> makeItReadable(IEnumerable<Attendance> attend, int classId){
            var fullRoster = _libraryContext.Rosters.ToList().Where(x=> x.ClassId == classId);
            HashSet<int> students = new HashSet<int>();
            foreach(Attendance a in attend){
                students.Add(a.StudentId);
            }

            List<int> present = new List<int>();
            List<int> notPresent = new List<int>();
            foreach(Roster r in fullRoster){
                if (students.Contains(r.StudentId)){
                    present.Add(r.StudentId);
                }
                else{
                    notPresent.Add(r.StudentId);
                }

            }
            var studentDict = studentDictionary();
            List<string> finalAttendance = new List<string>();
            foreach(int i in present){
                string st = studentDict[i]+ " is present";
                finalAttendance.Add(st);
            }
            foreach(int i in notPresent){
                string st = studentDict[i]+ " is absent";
                finalAttendance.Add(st);

            }
            return finalAttendance;
        }

        ///adds a Attendance to the database
        public Attendance PostAttendance(int studentId, int classId, string date){
            //adds new Attendances and saves database
            Attendance Attendance = new Attendance{StudentId = studentId, ClassId = classId, Date = date};
            _libraryContext.Add(Attendance);
            _libraryContext.SaveChanges();
            return Attendance;
        }
    }  
}
