using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodManageCodeFirst.Models
{
    public class CustomerCart
    {
        [Key]
        public int CId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public string CancelOrder { get; set; }
        public string PlaceOrder { get; set; }
        public virtual Item Food { get; set; }
        public virtual Registration User { get; set; }
    }
}
