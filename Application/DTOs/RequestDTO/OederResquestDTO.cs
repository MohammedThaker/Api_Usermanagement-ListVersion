
using Application.DTOs.Base;

namespace Application.DTOs.ResponseDTO
{
    public class OederResquestDTO: UserDTO
    {
            public string? OrderNo { get; set; }
            public string? ProductName { get; set; }
            public string? Adresss { get; set; }
        public Task IsValid()
        {
            if (OrderNo == null)
              throw new ArgumentNullException(nameof(OrderNo));
            if (ProductName == null)
                throw new ArgumentNullException(nameof(OrderNo));
             
            return IsValid();
        }

    }
}
