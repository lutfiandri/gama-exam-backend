using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamaExamBackend.Models;

namespace GamaExamBackend.Models
{
    public class DBExamContext : DbContext
    {
        public DBExamContext(DbContextOptions<DBExamContext> options):base(options)
        {

        }

        public DbSet<DCreator> dCreators { get; set; }
        public DbSet<DParticipant> dParticipants { get; set; }
        public DbSet<Question> dQuestions { get; set; }
        public DbSet<Contest> dContests { get; set; }
        public DbSet<User> dUser { get; set; }

    }
}
