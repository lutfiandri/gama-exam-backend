using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GamaExamBackend.Models
{
    public class ContestAttempt
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Answer { get; set; }
        [Column(TypeName = "int")]
        public int TimeLeft { get; set; } // detik

        [ForeignKey("Contest")]
        public int ContestId { get; set; }
        public Contest Contest { get; set; }

        [ForeignKey("DParticipant")]
        public int ParticipantId { get; set; }
        public DParticipant Participant { get; set; }
    }
}
