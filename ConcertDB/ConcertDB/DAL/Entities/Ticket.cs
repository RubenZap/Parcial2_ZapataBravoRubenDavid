using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertDB.DAL.Entities
{
    public class Ticket 
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? UseDate { get; set; }
        public Boolean IsUsed { get; set; }



        [MaxLength(11)]
        [Required]
        public string? EntraceGate { get; set; }
    }
}
