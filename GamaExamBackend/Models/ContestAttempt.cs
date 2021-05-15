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

        [ForeignKey("Contest")]
        public int ContestId { get; set; }
        public Contest Contest { get; set; }

        [ForeignKey("Contest")]
        public int ParticipantId { get; set; }
        public DParticipant Participant { get; set; }
    }
}
