namespace OrganizaMed.Dominio.ModuloMedico
{
    public interface IRepositorioMedico
    {
        Task<Guid> InserirAsync(Medico medico);
        Task<bool> EditarAsync(Medico medico);
        Task<bool> ExcluirAsync(Medico medico);
        Task<List<Medico>> SelecionarTodosAsync(); 
        Task<Medico?> SelecionarPorIdAsync(Guid id);
        Task<List<Medico>> SelecionarMuitosPorId(IEnumerable<Guid> requestMedicos);
    }
}
