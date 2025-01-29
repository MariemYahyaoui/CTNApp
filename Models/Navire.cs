using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Navire
    {

        [Key]
        public int Id_Navire { get; set; } // Clé primaire
        public string Design_Navire { get; set; }

            // Relations
            public ICollection<Mouvement> Mouvements { get; set; }
        

    }
}
