using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Albums.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        
        public String SongTitle { get; set; }

        //Foreign key
        [ForeignKey("Album")]
        public int AlbumRefId { get; set; }
        public Album Album { get; set; }
    }
}