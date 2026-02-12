using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace _2026102
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<Todo> Todos => ItemList.Items;

        [ObservableProperty]
        private string newTitle = "";

        [ObservableProperty]
        private string? newDescription;

        [ObservableProperty]
        private Todo? selectedTodo;

        [RelayCommand]
        private void AddTodo()
        {
            if (string.IsNullOrWhiteSpace(NewTitle))
                return;

            ItemList.Add(new Todo(NewTitle, NewDescription));
            NewTitle = "";
            NewDescription = null;
        }

        [RelayCommand]
        private void RemoveSelected()
        {
            if (SelectedTodo is null) return;
            ItemList.Remove(SelectedTodo);
            SelectedTodo = null;
        }

        [RelayCommand]
        private void ToggleDone(Todo? todo)
        {
            if (todo is null) return;
            todo.IsDone = !todo.IsDone;
        }

        [RelayCommand]
        private void ClearAll() => ItemList.Clear();
    }
}