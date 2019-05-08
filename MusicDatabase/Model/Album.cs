using MusicDatabase.Persistenz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Model
{
    class Album
    {
        /// <summary>
        /// test Test
        /// </summary>
        private int _id;
        private int _bandId;
        private string _albumName;
        private string _genre;
        private DateTime _date; 
        
        /// <summary>
        /// Constructors
        /// </summary>

        public Album() { }
        public Album(int aId, int bId)
        {
            _id = aId;
            _bandId = bId;
            DBAlbum.Fill(this);
        }
        public Album(int id, int bandId, string albumName, string genre, DateTime date)
        {
            Id = id;
            BandId = bandId;
            AlbumName = albumName;
            Genre = genre;
            Date = date;
        }




        /// <summary>
        /// Getter / Setter
        /// </summary>
       
        public int Id { get => _id; set => _id = value; }
        public int BandId { get => _bandId; set => _bandId = value; }
        public string AlbumName { get => _albumName; set => _albumName = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
