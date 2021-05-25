using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GamaExamBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Institute { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string DoneContestIds { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string CreatedContestIds { get; set; }
    }
}
