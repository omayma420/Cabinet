using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.domain.entites
{
    public class patient
    {
        public patient()
        {
            this.rendezvous = new HashSet<rendezvous>();
        }
        [Key]
        public int id_pat { get; set; }
        public string nom_pat { get; set; }
        public string email_pat { get; set; }
        public string adresse_pat { get; set; }
        public string tel_pat { get; set; }


        //public int? id_dos { get; set; } // Clé étrangère vers Dossier

        // public dossier dossier { get; set; }

        public virtual ICollection<rendezvous> rendezvous { get; set; }
    }
}