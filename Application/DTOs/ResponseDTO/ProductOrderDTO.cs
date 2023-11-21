
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.ResponseDTO
{
    public class ProductOrderDTO
    {
        [Key]
        public int Orderid { get; set; }
      
        [Required]

        public string? OrderNo { get; set; }
        public string? ProductName { get; set; }
        public string? Adresss { get; set; }

        public DateTime DateOrder { get; set; }
        public DateTime Datecreate { get; set; }
      /*  public string IsValid()
        {
            if (string.IsNullOrWhiteSpace(OrderNo))
                return "Name is Required";

            if (OrderNo == null)
                return "Customer Id Required";
            return base.ToString();
        }*/

    }
}

