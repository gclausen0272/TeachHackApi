using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qrattend.Entities 
{ 
    ///xml to do 

    public class Class 
    {
        ///xml to do 
        public int Id { get; set; }
        ///xml to do 
        public int  TeacherId { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string ClassName { get; set; }
    }
}