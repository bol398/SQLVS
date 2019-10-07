using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQL
{
    public class KursStudent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KursStudentID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int KursID { get; set; }

        public Kurs Kurs { get; set; }
    }
}
