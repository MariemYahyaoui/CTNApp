using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Role
    {
        [Key]
        public int Id_Role { get; set; } 
        public string Design_Role { get; set; }
        public ICollection<Personnel> Personnels { get; set; }

    }
}
