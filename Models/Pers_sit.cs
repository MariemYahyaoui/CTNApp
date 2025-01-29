using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pers_sit
    {
        public int Matricule { get; set; }
        public int IdSit { get; set; }
        public DateTime DateSit { get; set; }

        // Relations
        [ForeignKey("Matricule")]
        public Personnel Personnel { get; set; }

        [ForeignKey("IdSit")]
        public Situation Situation { get; set; }
    }

}
