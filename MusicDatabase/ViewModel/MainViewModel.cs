using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Model
{
    class MainViewModel : BaseModel
    {
        private ObservableCollection<Band> _ocBand = new ObservableCollection<Band>();
        private ObservableCollection<Album> _ocAlbum = new ObservableCollection<Album>();
        private ObservableCollection<Track> _ocTrack = new ObservableCollection<Track>();
        private Band _selectedBand;
        private Album _selectedAlbum;
        private Track _selectedTrack;

        internal ObservableCollection<Band> OcBand { get => _ocBand; set => _ocBand = value; }
        internal ObservableCollection<Album> OcAlbum { get => _ocAlbum; set => _ocAlbum = value; }
        internal ObservableCollection<Track> OcTrack { get => _ocTrack; set => _ocTrack = value; }
        internal Band SelectedBand { get => _selectedBand; set => _selectedBand = value; }
        internal Album SelectedAlbum { get => _selectedAlbum; set => _selectedAlbum = value; }
        internal Track SelectedTrack { get => _selectedTrack; set => _selectedTrack = value; }

        MainViewModel(){}


        void FillList()
        {

        }
    }
}
