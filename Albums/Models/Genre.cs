using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albums.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public String GenreName { get; set; }

        // lista de albumes
        public virtual ICollection<Album> Albums { get; set; }
    }
}