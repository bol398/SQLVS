using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQL
{
    public class Kurs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KursID { get; set; }
        public int Rum { get; set; }
        public string Namn { get; set; }
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
