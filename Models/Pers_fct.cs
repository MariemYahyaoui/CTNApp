using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Pers_fct
    {
        public int Matricule { get; set; }
        public int IdFonctionnalite { get; set; }
        public DateTime DateFct { get; set; }

        // Relations
        [ForeignKey("Matricule")]
        public Personnel Personnel { get; set; }

        [ForeignKey("IdFonction")]
        public Fonction Fonction { get; set; }
    }
}
