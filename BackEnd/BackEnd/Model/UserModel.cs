using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Model
{
    public class UserModel
    {
 
        public int Id { get; set; }


        public string? Uname { get; set; }

   
        public string? Password { get; set; }

        public int? Rid { get; set; }


        public DateTime? CreatedDate { get; set; }
        public string? IsActive { get; set; }
    }
}
