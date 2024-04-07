using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полигон_Для_Шрд.Classes
{
    [Table("NumbersOfClasses")]
    public class NumberOfClass
    {
        [Column("Number_of_class_id")]
        [Key]
        public int NumberOfClassId { get; set; }
        [Column("Number_of_class")]
        public int NumberOfClassSchool { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public List<Tasks> Tasks { get; set; } = new();
    }
}
