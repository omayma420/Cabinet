using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.domain.entites
{
    public class specialite
    {
        public specialite()
        {
            
        }
        [Key]
        public int id_spec { get; set; }
        public string nom_spec { get; set; }

        
        
        // Constructeur par défaut


        // Constructeur avec paramètres pour initialiser les propriétés
        public specialite(int idSpec, string nomSpec)
        {
            this.id_spec = idSpec;
            this.nom_spec = nomSpec;
        }
    }
}
