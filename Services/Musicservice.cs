using WebApis.Models;

namespace WebApis.Services
{
    public class Musicservice
    {
        public List<Music> _Music = new()
        {
            new Music
            {
                name= "Vatapi Ganapatim Bhajeham", raaga= "Melakartha", composer= "Muthuswami Dikshitar", taala= "Adi"
            },
            new Music
            {
             name= "Paluke Bangaramayena", raaga="Ananda Bhairavi", composer= "Kancharla Gopanna", taala="Adi"
            },
            new Music
            {
               name= "Jagatjala palam", raaga= "Nattai", composer= "Tyagaraja", taala="Adi"
            }
        };
        public List<Music> _AllSongs()
        {
            return _Music;
        }
        public List<Music> AddSongs(Music music)
        {
            _Music.Add(music);
            return _Music;
        }
        public List<Music> UpdateSongs(Music music)
        {
            var song = _Music.FirstOrDefault(x => x.name == music.name);
            if (song != null)
            {
                song.raaga = music.raaga;
                song.composer = music.composer;
                song.taala = music.taala;
            }
            return _Music;
        }
        public List<Music> DeleteSongs(string name)
        {
            var song = _Music.FirstOrDefault(x => x.name == name);
            if (song != null)
            {
                _Music.Remove(song);
            }
            return _Music;
        }
    }
}
