namespace challenge.Controllers
{
    using challenge.AppModel;
    using challenge.AppProcess;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private INoteAppService _noteService;
        private ILogger<NoteController> _logger;

        public NoteController(ILogger<NoteController> logger, INoteAppService noteService)
        {
            _logger = logger;
            _noteService = noteService;
        }

        [HttpGet(Name = "GetNotes")]
        public IEnumerable<NoteAppModel> GetNotes()
        {
            return _noteService.GetNotes();
        }

        [HttpPost(Name = "PostNote")]
        public NoteAppModel Post(string title, string content)
        {
            return _noteService.CreateNote(title, content);
        }

        [HttpPut(Name = "PutNote")]
        public NoteAppModel PutNote(NoteAppModel note)
        {
            return _noteService.UpdateNote(note);
        }

        [HttpDelete(Name = "DeleteNote")]
        public void DeleteNote(string id)
        {
            _noteService.RemoveNote(id);
        }
    }
}