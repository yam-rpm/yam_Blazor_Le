namespace _01_Lerlings_Aufgabe.Data;
    public class TodoService {
        private List<Todo> Todo {  get; set; }

        public TodoService() {
            Todo = CreateTodoList();
        }

        private List<Todo> CreateTodoList() {
            var rng = new Random();
            return Enumerable.Range(1, 3).Select(index =>
            {
                var id = index;
                return new Todo
                {
                    Id = id,
                    Title = "Todo" + id.ToString(),
                    Description = "Hello world",
                    isCompleted = false
                };
            }).ToList();
}

        public List<Todo> GetTodos()
        {
            return Todo;
        }

        public Task<Todo[]> GetTodosAsync(CancellationToken ct = default)
        {
            return Task.FromResult(Todo.ToArray());
        }
}
