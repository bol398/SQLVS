using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQL
{
    public class StudentBetyg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BetygID { get; set; }
        public int StudentID { get; set; }
        public int KursID { get; set; }
        public Kurs Kurs { get; set; }
        public int Betyg { get; set; }
    }
}
