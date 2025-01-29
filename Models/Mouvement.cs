using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Mouvement
    {
        public int Matricule { get; set; }
        public int IdNavire { get; set; }
        public DateTime DateEmb { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateRemb { get; set; }
        public string Remplaçant { get; set; }

        // Relations
        [ForeignKey("Matricule")]
        public Personnel Personnel { get; set; }

        [ForeignKey("Id_Navire")]
        public Navire Navire { get; set; }
    }
}
