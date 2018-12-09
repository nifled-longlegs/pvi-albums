using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Albums.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public String AlbumArtistName { get; set; }
        public String AlbumTitle { get; set; }
        public String AlbumLogo { get; set; }

        //Foreign key
        [ForeignKey("Genre")]
        public int GenreRefId { get; set; }
        public Genre Genre { get; set; }

        // lista de canciones
        public virtual ICollection<Song> Songs { get; set; }
    }
}