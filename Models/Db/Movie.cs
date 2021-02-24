using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Genre { get; set; }
        
        [Required]
        public int Duration { get; set; }
        
        [Required]
        public string Summary { get; set; }

        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
       
    }
}
