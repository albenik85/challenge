namespace challenge.AppModel
{
    /// <summary>
    /// The model for the application logic.
    /// 
    /// Properties are in lowercase to simplyfy json to ui model handling on client side
    /// </summary>
    public class NoteAppModel : BaseModel
    {
        public string id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}
