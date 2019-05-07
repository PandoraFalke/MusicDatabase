using MusicDatabase.Persistenz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Model
{
    class Track
    {
        private int _id;
        private int _albumId;
        private string _trackName;
        private string _trackNumber;

        /// <summary>
        /// Constructors
        /// </summary>
        public Track() { }
        public Track(int tId, int aId)
        {
            _id = tId;
            _albumId = aId;
            DBTrack.Fill(this);
        }
        public Track(int id, int albumId, string trackName, string trackNumber)
        {
            Id = id;
            AlbumId = albumId;
            TrackName = trackName;
            TrackNumber = trackNumber;
        }




        /// <summary>
        /// Getter//Setter
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        public int AlbumId { get => _albumId; set => _albumId = value; }
        public string TrackName { get => _trackName; set => _trackName = value; }
        public string TrackNumber { get => _trackNumber; set => _trackNumber = value; }
    }
}
