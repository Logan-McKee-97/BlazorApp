using BlazorApp.Data;
public interface ITodoItemService
{
    Task<IEnumerable<TodoItem>> GetTodoItems();
    Task<IEnumerable<TodoItem>> AddTodoItem(TodoItem todoItem);
    Task<IEnumerable<TodoItem>> DeleteTodoItem(TodoItem todoItem);
    Task<IEnumerable<TodoItem>> UpdateTodoItem(TodoItem todoItem);

}