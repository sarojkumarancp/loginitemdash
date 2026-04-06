using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logindashboarditem.Models
{
    [Table("Items")]
    public class ItemMaster
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
