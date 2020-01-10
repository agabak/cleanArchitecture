using worksln.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace worksln.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
