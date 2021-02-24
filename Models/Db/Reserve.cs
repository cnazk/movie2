using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Reserve
    {
        [Required]
        public int Id { get; set; }

        


        [Required]
        public string CinemaName { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
