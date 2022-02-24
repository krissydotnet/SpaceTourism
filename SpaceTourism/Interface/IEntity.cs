namespace SpaceTourism.Interface
{
    public interface IEntity
    {
        public int Index { get; set; }
    }
    public class Entity : IEntity
    {
        public int Index { get; set; }
    }
}
