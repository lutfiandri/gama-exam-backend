using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamaExamBackend.Models
{
    public class Contest
    {
        public int Id { get; set; } // id di database itu nanti jadinya int apa string yak? :v sementara int aja dulu lah ya wkwk
        public string Title { get; set; }
        public int Duration { get; set; } // menit
        public int NumOfQuestion { get; set; }
        public List<Question> Questions { get; set; }        
    }
}
