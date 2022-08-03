namespace challenge.Database
{
    using System.Collections.Generic;
    using System.Linq;

    public class NoteDbService : INoteDbService
    {
        private ChallengeDbContext _ctx;

        public NoteDbService(ChallengeDbContext ctx)
        {
            _ctx = ctx;
        }

        void INoteDbService.CreateNote(NoteDbModel note)
        {
            _ctx.Notes.Add(note);
            _ctx.SaveChanges();
        }

        NoteDbModel INoteDbService.GetNote(string id)
        {
            return _ctx.Notes.First(n => n.Id == id);
        }

        IEnumerable<NoteDbModel> INoteDbService.GetNotes()
        {
            return _ctx.Notes.ToList();
        }

        void INoteDbService.RemoveNote(string id)
        {
            var dbnote = _ctx.Notes.First(n => n.Id == id);
            _ctx.Remove(dbnote);

            _ctx.SaveChanges();
        }

        void INoteDbService.UpdateNote(NoteDbModel note)
        {
            var dbnote = _ctx.Notes.First(n => n.Id == note.Id);

            dbnote.Title = note.Title;
            dbnote.Content = note.Content;

            _ctx.SaveChanges();
        }
    }
}
