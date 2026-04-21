using FluentValidation;

namespace OrganizaMed.Dominio.ModuloMedico
{
    public class ValidadorMedico : AbstractValidator<Medico>
    {
        public ValidadorMedico()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().WithMessage("O nome do médico é obrigatório")
                .Matches(@"^[\p{L}\s]+$").WithMessage("O nome do médico contém caracteres inválidos")
                .DependentRules(() =>
                {
                    RuleFor(m => m.Nome)
                        .Length(3, 100).WithMessage("O nome do médico deve conter entre 3 e 100 caracteres");
                });

            RuleFor(m => m.Crm)
                .NotEmpty().WithMessage("O CRM do médico é obrigatório")
                .DependentRules(() =>
                {
                    RuleFor(m => m.Crm)
                        .Matches(@"^\d{5}-[A-Za-z]{2}$").WithMessage("O CRM deve seguir o padrão 00000-UF");
                });
        }
    }
}
