using System.ComponentModel.DataAnnotations;

namespace APIFun.Controllers.Data
{
    public class MarriottFood
    {
        [Key]
        public int FoodID { get; set; }
        public string EventName { get; set; }
        public string VendorName { get; set; }
        public int FoodRating { get; set; }
    }
}
