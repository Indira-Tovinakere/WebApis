using Microsoft.AspNetCore.Mvc;
using WebApis.Services;
using WebApis.Models;

namespace WebApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Musicinfo : ControllerBase
    {
        private readonly Musicservice _musicservice;
        public readonly ILogger<Musicinfo> _logger;
        public Musicinfo(ILogger<Musicinfo> logger, Musicservice musicservice)
        {
            _logger = logger;
            _musicservice = musicservice;
        }
        [HttpGet(Name = "GetMusicInfo")]
        public ActionResult<List<Music>> Get()
        {
            var songs = _musicservice._AllSongs();
            return Ok(songs);
        }
        [HttpPost(Name = "AddMusicInfo")]
        public ActionResult<List<Music>> Post([FromBody] Music music)
        {
            return _musicservice.AddSongs(music);
        }
        [HttpDelete(Name = "DeleteMusicInfo")]
        public ActionResult<List<Music>> Delete([FromBody] string name)
        {
           return _musicservice.DeleteSongs(name);
        }
        [HttpPut(Name = "UpdateMusicInfo")]
        public ActionResult<List<Music>> Put([FromBody]Music music)
        {
           return _musicservice.UpdateSongs(music);
        }
    }
}


