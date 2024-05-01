using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.domain.entites
{
    public class medecin
    {
        public medecin()
        {
            this.rendezvous = new HashSet<rendezvous>();
        }
        [Key]
        public int id_med { get; set; }
        public string nom_med { get; set; }
        public string email_med { get; set; }
        public string adresse_med { get; set; }
        public string tel_med { get; set; }
        public Nullable<int> id_spec { get; set; }

        public virtual specialite specialite { get; set; }
       
        public virtual ICollection<rendezvous> rendezvous { get; set; }

        public medecin(int id_med, string nom_med, string email_med, string adresse_med, string tel_med, int? id_spec, specialite specialite, ICollection<rendezvous> rendezvous)
        {
            this.id_med = id_med;
            this.nom_med = nom_med;
            this.email_med = email_med;
            this.adresse_med = adresse_med;
            this.tel_med = tel_med;
            this.id_spec = id_spec;
            this.specialite = specialite;
            this.rendezvous = rendezvous;
        }

    }
}
