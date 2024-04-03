using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полигон_Для_Шрд.Classes
{
    [Table("Tasks")]
    public class Tasks
    {
        [Column("Id")]
        [Key]
        public int TaskId { get; set; }
        [Column("Task")]
        public string Task { get; set; }
        [Column("Answer")]
        public string Anwer { get; set; }
        public int? NumberOfClassId { get; set; }
        public  NumberOfClass? NumberOfClass { get; set; }
    }
}
