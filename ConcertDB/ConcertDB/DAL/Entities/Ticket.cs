using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket : Entity
    {
        public DateTime? UseDate { get; set; }
        public Boolean IsUsed { get; set; }
        public int? EntraceGate { get; set; }
    }
}
