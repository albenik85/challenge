namespace challenge.AppModel
{
    public abstract class BaseModel : IModel
    {
        string IModel.Id { get; set; }
    }
}
