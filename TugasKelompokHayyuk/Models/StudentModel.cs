using System;
using System.Collections.Generic;
using System.Text;

namespace TugasKelompokHayyuk.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public string StudentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ParentPhone { get; set; }
        public DateTime CreatedAt = DateTime.Now;
       
    }
}
 