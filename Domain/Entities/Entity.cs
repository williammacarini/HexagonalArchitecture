namespace Domain.Entities
{
    public class Entity
    {
        public Guid Id { get; protected set; }
        public bool Disabled { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public void SetDisabled() => Disabled = true;
    }
}
