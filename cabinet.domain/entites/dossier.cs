using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.domain.entites
{
    public class dossier
    {
        [Key]
        public int id_dos { get; set; }
        public string condition_dos { get; set; }
        public string allergie_dos { get; set; }
        public string sang_dos { get; set; }
        public string diagnostic { get; set; }
        public Nullable<int> id_pat { get; set; }

        public virtual patient patient { get; set; }





    }
}