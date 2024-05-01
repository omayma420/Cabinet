using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.domain.entites
{
    public class rendezvous
    {
        [Key]
        public int id_ren { get; set; }
        public Nullable<System.DateTime> date_ren { get; set; }
        public string heure_ren { get; set; }
        public int id_pat { get; set; }
        public int id_med { get; set; }

        public virtual medecin medecin { get; set;}
        public virtual patient patient { get; set; }
    }
}
