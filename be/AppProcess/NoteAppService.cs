namespace challenge.AppProcess
{
    using challenge.AppModel;
    using challenge.Database;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteAppService : INoteAppService
    {
        private INoteDbService _notesDb;

        public NoteAppService(INoteDbService notesDb)
        {
            _notesDb = notesDb;
        }
        NoteAppModel INoteAppService.CreateNote(string title, string content)
        {
            NoteDbModel dbnote = new NoteDbModel
            {
                Id = Guid.NewGuid().ToString(),
                Title = title,
                Content = content
            };

            _notesDb.CreateNote(dbnote);

            return new NoteAppModel { 
                id = dbnote.Id, 
                title = dbnote.Title, 
                content = dbnote.Content }; 
        }

        NoteAppModel INoteAppService.GetNote(string id)
        {
            var dbnote = _notesDb.GetNote(id);

            // DB Model in App Model umwandeln. Das ginge natürlich auch mit z.B. Automapper
            return new NoteAppModel
            {
                id = dbnote.Id,
                title = dbnote.Title,
                content = dbnote.Content
            };
        }

        IEnumerable<NoteAppModel> INoteAppService.GetNotes()
        {
            return _notesDb.GetNotes().Select(n => new NoteAppModel { id = n.Id, title = n.Title, content=n.Content }).ToList();
        }

        void INoteAppService.RemoveNote(string id)
        {
            _notesDb.RemoveNote(id);
        }

        NoteAppModel INoteAppService.UpdateNote(NoteAppModel note)
        {
            var dbnote = new NoteDbModel
            {
                Id = note.id,
                Title = note.title,
                Content = note.content
            };

            _notesDb.UpdateNote(dbnote);

            // DB Model in App Model umwandeln. Das ginge natürlich auch mit z.B. Automapper
            return new NoteAppModel
            {
                id = dbnote.Id,
                title = dbnote.Title,
                content = dbnote.Content
            };
        }
    }
}
