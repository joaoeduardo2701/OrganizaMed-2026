# ORGANIZA MED

## Descrição do Cenário

Uma clínica médica é um centro onde atividades, como cirurgias e consultas, são realizadas por profissionais médicos.
Os alunos da Academia do Programador 2024 foram contratados para criar um aplicativo web que mantenha e
organize o cronograma dessas atividades dentro da clínica.

Cada médico é identificado pelo CRM que é composto por cinco dígitos e a sigla do estado (78806-SP).

As atividades dos médicos têm um horário de início e término e existem dois tipos diferentes de atividades, vejamos:

* Realizar Consulta: Sempre realizada por um único médico.

* Realizar Cirurgia: Pode ser realizada por um médico individualmente ou por uma equipe de médicos.
Os médicos podem realizar atividades durante o dia inteiro, em todos os dias do ano. No entanto, cada vez que um
médico termina uma atividade, é necessário um tempo de descanso para recuperação. Independentemente da duração
da atividade, o período de recuperação será de 4 horas após realizar uma cirurgia e 10 minutos após realizar uma
consulta médica.

**Escopo da Solução**
* O aplicativo deve permitir agendar atividades em qualquer momento (futuro ou passado).
* Quando uma atividade é criada, deve ser possível indicar os horários de início e término, o tipo de atividade e o
médico (ou lista de médicos) que está realizando essa atividade.

**Diversão Opcional? Não é obrigatório, mas você pode ampliar o escopo da solução com alguns dos pontos abaixo:**
* É possível modificar os horários de uma atividade existente.
* É possível excluir uma atividade existente.
* O aplicativo indica quando a atividade de um médico entra em conflito com outras atividades do mesmo médico,
devido à sobreposição de horários.
* Esses conflitos ajudarão os usuários do aplicativo a ajustarem os horários das atividades para que o problema
possa ser resolvido.
* O aplicativo mostra uma lista dos 10 médicos que mais horas trabalharam dentro de um período. Valores Iniciais
da aplicação.
* Você pode definir alguns dados iniciais, como informações sobre os médicos, e até algumas atividades iniciais já
atribuídas.

**Lembretes**
* Não esqueçam em implementarem um código limpo com camadas, classes e métodos coesos.
* Criem testes unitários e testes de integração.
* Utilize quaisquer frameworks e bibliotecas que acharem convenientes.
* Organizem o código em projetos diferentes.
* Queremos ver a evolução do seu código, então commits significativos são bem-vindos.
Prazo de Entrega
   O candidato terá um prazo de 02/12/2024 para completar o teste e enviar o código fonte e documentação
associada para avaliação.

**Submissão**
* Crie um repositório privado no Github
* Por favor, adicione a conta @academiadoprogramador como 'developer'.
* Por favor, note que o aplicativo será executado em outras máquinas, então não mantenha referências locais.
* Inclua um arquivo README.md para ser usado para qualquer outra consideração ou explicação que queira
destacar sobre o processo de design/ implementação.
* Por último, mas não menos importante, inclua a URL do seu repositório no classroom
