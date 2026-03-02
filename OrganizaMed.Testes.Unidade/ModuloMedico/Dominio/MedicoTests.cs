using FluentValidation.TestHelper;
using OrganizaMed.Dominio.ModuloMedico;

namespace OrganizaMed.Testes.Unidade.ModuloMedico.Dominio
{
    [Trait("Categoria", "Testes de Validação do Médico")]
    public class MedicoTests
    {
        private ValidadorMedico _validador;

        public MedicoTests()
        {
            _validador = new ValidadorMedico();
        }

        [Fact]
        public void Deve_Passar_Medico_Valido()
        {
            Medico medico = new Medico("José Testes da Silva", "12345-sc");

            _validador.TestValidate(medico).ShouldNotHaveAnyValidationErrors();
        }

        [Fact]
        public void Deve_Falhar_Quando_Nome_Nulo()
        {
            Medico medico = new Medico("", "12345-SC");

            var resultado = _validador.TestValidate(medico);

            resultado.ShouldHaveValidationErrorFor(m => m.Nome)
                .WithErrorMessage("O nome do médico é obrigatório");
        }

        [Fact]
        public void Deve_Falhar_Quando_Nome_Menor_Que_Tres_Caracteres()
        {
            Medico medico = new Medico("F", "12345-SC");

            var resultado = _validador.TestValidate(medico);

            resultado.ShouldHaveValidationErrorFor(m => m.Nome)
                .WithErrorMessage("O nome do médico deve conter entre 2 e 100 caracteres");
        }

        [Fact]
        public void Deve_Falhar_Quando_CRM_Estiver_Vazio()
        {
            Medico medico = new Medico("José Testes da Silva", "");

            var resultado = _validador.TestValidate(medico);

            resultado.ShouldHaveValidationErrorFor(m => m.Crm)
                .WithErrorMessage("O CRM do médico é obrigatório");
        }   

        [Fact]
        public void Deve_Falhar_Quando_CRM_Nao_Estiver_No_Formato_Certo()
        {
            Medico medico = new Medico("José Testes da Silva", "1235-SC");

            var resultado = _validador.TestValidate(medico);

            resultado.ShouldHaveValidationErrorFor(m => m.Crm)
                .WithErrorMessage("O CRM deve seguir o padrão 00000-UF");
        }
    }
}
