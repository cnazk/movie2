using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Image
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Url { get; set; }
        
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
