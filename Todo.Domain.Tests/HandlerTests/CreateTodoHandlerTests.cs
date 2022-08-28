using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests;

[TestClass]
public class CreateTodoHandlerTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", DateTime.Now, "");
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da tarefa", DateTime.Now, "Usuario qualquer");
    private readonly TodoHandler handler = new TodoHandler(new FakeTodoRepository());

    public CreateTodoHandlerTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }

    [TestMethod]
    public void Dado_um_comando_invalido_deve_interromper_a_execucao()
    {
        var result = (GenericCommandResult)handler.Handle(_invalidCommand);
       Assert.AreEqual(result.Success, false);
    }

    [TestMethod]
    public void Dado_um_comando_valido_deve_criar_a_tarefa()
    {
        var result = (GenericCommandResult)handler.Handle(_validCommand);
        Assert.AreEqual(result.Success, true);
    }


}