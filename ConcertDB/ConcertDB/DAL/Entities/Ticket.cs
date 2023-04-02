using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket : Entity
    {
        public DateTime? UseDate { get; set; }
        public Boolean IsUsed { get; set; }



        [MaxLength(11)]
        [Required]
        public string? EntraceGate { get; set; }
    }
}
