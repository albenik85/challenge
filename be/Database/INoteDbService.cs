namespace challenge.Database
{
    using System.Collections.Generic;

    public interface INoteDbService
    {
        IEnumerable<NoteDbModel> GetNotes();
        NoteDbModel GetNote(string id);
        void CreateNote(NoteDbModel note);
        void UpdateNote(NoteDbModel note);
        void RemoveNote(string id);
    }
}
