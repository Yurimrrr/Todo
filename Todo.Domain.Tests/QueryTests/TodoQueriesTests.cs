using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.HandlerTests;

[TestClass]
public class TodoQueriesTests
{
    private List<TodoItem> _items;

    public TodoQueriesTests(List<TodoItem> items)
    {
        _items = new List<TodoItem>();
        _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuario1"));
        _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "yurimrrr"));
        _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "usuario1"));
        _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuario2"));
        _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "yurimrrr"));
    }

    [TestMethod]
    public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_yurimrrr()
    {
        var result = _items.AsQueryable().Where(TodoQueries.GetAll("yurimrrr"));
        Assert.AreEqual(2, result.Count());
    }


}