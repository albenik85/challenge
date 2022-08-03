
namespace challenge.AppProcess
{
    using challenge.AppModel;
    using System.Collections.Generic;

    public interface INoteAppService
    {
        IEnumerable<NoteAppModel> GetNotes();
        NoteAppModel GetNote(string id);
        NoteAppModel CreateNote(string title, string content);
        NoteAppModel UpdateNote(NoteAppModel note);
        void RemoveNote(string id);
    }
}
