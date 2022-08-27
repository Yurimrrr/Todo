﻿using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests;

[TestClass]
public class CreateTodoHandlerTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", DateTime.Now, "");
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da tarefa", DateTime.Now, "Usuario qualquer");

    public CreateTodoHandlerTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }

    [TestMethod]
    public void Dado_um_comando_invalido_deve_interromper_a_execucao()
    {
        var handler = new TodoHandler(new FakeTodoRepository()); //Mock ou fake repository
        var result = (GenericCommandResult)handler.Handle(_invalidCommand);
       // Assert.AreEqual(result.Success);
    }

    [TestMethod]
    public void Dado_um_comando_valido_deve_criar_a_tarefa()
    {
        var handler = new TodoHandler(new FakeTodoRepository()); //Mock ou fake repository
        Assert.Fail();
    }


}