using worksln.Application.Common.Mappings;
using worksln.Domain.Entities;

namespace worksln.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
