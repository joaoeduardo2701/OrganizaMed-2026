using Microsoft.EntityFrameworkCore;
using OrganizaMed.Dominio.Compartilhado;
using OrganizaMed.Dominio.ModuloMedico;

namespace OrganizaMed.Infraestrutura.Orm.ModuloMedico
{
    public class RepositorioMedicoEmOrm(IContextoPersistencia contexto)
        : RepositorioBase<Medico>(contexto), IRepositorioMedico
    {
        public override Task<Medico?> SelecionarPorIdAsync(Guid id)
        {
            return registros.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Medico>> SelecionarMuitosPorId(IEnumerable<Guid> medicosRequisitados)
        {
            return await registros.Where(m => medicosRequisitados.Contains(m.Id)).ToListAsync();
        }
    }
}
