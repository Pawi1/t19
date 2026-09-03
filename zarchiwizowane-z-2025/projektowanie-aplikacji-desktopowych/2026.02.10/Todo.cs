using CommunityToolkit.Mvvm.ComponentModel;

namespace _2026102
{
    public partial class Todo : ObservableObject
    {
        public uint Id { get; }

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string? description;

        [ObservableProperty]
        private bool isDone;

        public Todo(string title, string? description)
        {
            Id = ItemList.GetNextId();
            this.title = title;
            this.description = description;
            isDone = false;
        }

        public Todo(uint id, string title, string? description, bool isDone)
        {
            Id = id;
            this.title = title;
            this.description = description;
            this.isDone = isDone;
        }
    }
}