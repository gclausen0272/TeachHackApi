using System.Collections.Generic;
using qrattend.Repository.Contract;
using qrattend.Entities;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
namespace qrattend.Repository.Implementation
{
    ///Roster repository 
    public class RosterRepository: IRosterRepository<Roster>  
    {  
        private LibraryContext _libraryContext;  

        ///sets up the repo with the database context
        public RosterRepository(LibraryContext context)  
        {  
            _libraryContext = context;  
        }  

        ///gets a list of all the Rosters
        public IEnumerable<Roster> GetAllRosters()  
        {  
            return _libraryContext.Rosters.ToList();  
        }

        ///adds a Roster to the database
        public Roster AddStudentToRoster( int studentID, int classId){
            Roster Roster = new Roster{StudentId = studentID, ClassId = classId};
            _libraryContext.Add(Roster);
            _libraryContext.SaveChanges();
            return Roster;
        }

        ///gets the roster by the class id 
        public IEnumerable<Roster> GetRosterByClassId(int classId){
            var rosters = _libraryContext.Rosters.ToList().Where(x => x.ClassId == classId);
            return rosters;

        }
    }  
}
