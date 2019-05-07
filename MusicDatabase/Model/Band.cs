using MusicDatabase.Persistenz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Model
{
    class Band
    {
        private int _id;
        private string _bandName;

        public Band()
        {

        }
        public Band(int id)
        {
            _id = id;
            DBBand.Fill(this);
        }

        public Band(int id, string bandName) : this(id)
        {
            _bandName = bandName;
        }

        public int Id { get => _id; set => _id = value; }
        public string BandName { get => _bandName; set => _bandName = value; }
    }
}
