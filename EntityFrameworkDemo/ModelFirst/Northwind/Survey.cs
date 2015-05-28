using EntityFrameworkDemo.CodeFirst.CodeFirst.Northwind;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.CodeFirst.CodeFirst.Northwind
{
    public partial class Survey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SurveyID { get; set; }

        [StringLength(5)]
        public string CustomerID { get; set; }

        [Required]
        public DateTime SurveyDate { get; set; }

        [Required]
        [StringLength(500)]
        public string Answer1 { get; set; }

        [Required]
        [StringLength(500)]
        public string Answer2 { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
