using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qrattend.Entities 
{ 
    ///xml to do 
    public class Attendance 
    {
        ///xml to do 
        public int Id { get; set; }
        ///xml to do 
        public int ClassId { get; set; }
        ///xml to do 
        public int StudentId { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string Date { get; set; }
    }
}