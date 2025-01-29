using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Situation
    {
        [Key]
        public int Id_Sit { get; set; } 
        public string Design_Sit { get; set; }

        
        public ICollection<Pers_sit> Pers_sits { get; set; }
    }
}
