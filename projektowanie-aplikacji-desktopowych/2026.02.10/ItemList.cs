using System.Collections.ObjectModel;

namespace _2026102
{
    public static class ItemList
    {
        private static readonly ObservableCollection<Todo> todoList = new();
        private static uint nextId = 0;

        public static ObservableCollection<Todo> Items => todoList;

        public static uint GetNextId() => nextId++;

        public static void Add(Todo item) => todoList.Add(item);

        public static void Remove(Todo item) => todoList.Remove(item);

        public static void Clear() => todoList.Clear();

        public static void Change(Todo item)
        {
            for (int i = 0; i < todoList.Count; i++)
                if (todoList[i].Id == item.Id) { todoList[i] = item; break; }
        }
    }
}