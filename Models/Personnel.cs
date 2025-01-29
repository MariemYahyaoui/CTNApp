using System.ComponentModel.DataAnnotations;

namespace CTNApp.Models
{
    public class Personnel
    {
        [Key]
        public int Matricule { get; set; }
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public ICollection<Pers_sit> Pers_sits { get; set; }
        public ICollection<Pers_fct> Pers_fcts { get; set; }
        public ICollection<Mouvement> Mouvements { get; set; }
    }
}
