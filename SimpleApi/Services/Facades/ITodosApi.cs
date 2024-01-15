using Refit;
using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public interface ITodosApi
{
    [Get("/todos")]
    Task<IEnumerable<Todo>> GetAllTodos();
}