using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime? CreatedDate{ get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
