namespace OrganizaMed.Dominio.Compartilhado
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }

        public EntidadeBase() 
        {
            Id = Guid.NewGuid();
        }
    }
}
