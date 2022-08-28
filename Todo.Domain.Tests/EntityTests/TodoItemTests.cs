using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests;

[TestClass]
public class TodoItemTests
{
   

    private readonly TodoItem _todoItem = new TodoItem("Titulo Teste", DateTime.Now, "yurimrrr");

    [TestMethod]
    public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
    {
        Assert.AreEqual(_todoItem.Done, false);
    }



}