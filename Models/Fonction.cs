using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Fonction
    {
        [Key]
        public int Id_Fct { get; set; } 
        public string Design_Fct { get; set; }

        public ICollection<Pers_fct> Pers_fcts { get; set; }
    }

}
