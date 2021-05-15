using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamaExamBackend.Models
{
    public class Contest
    {
        public int Id { get; set; } // id di database itu nanti jadinya int apa string yak? :v sementara int aja dulu lah ya wkwk
        public string Title { get; set; }
        public int Duration { get; set; } // menit
        public int NumOfQuestion { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // public List<Question> Questions { get; set; } // -> ini berarti gajadi ada kan ya
        public ICollection<Question> QuestionList { get; set; }
    }
}
