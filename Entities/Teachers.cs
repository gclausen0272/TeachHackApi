using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qrattend.Entities 
{ 
        ///xml to do 
    public class Teacher 
    {
        ///xml to do 
        public int Id { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string FirstName { get; set; }

        ///xml to do 
        [StringLength(2083)]
        public string MiddleName { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string LastName { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string PictureUrl { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string UserName { get; set; }
        ///xml to do 
        [StringLength(2083)]
        public string Password { get; set; }
    }
}