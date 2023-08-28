namespace ToDoListAPI.Models
{
    public class TaskToDo
    {
        public TaskToDo() { }   
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public DateTime dueDate { get; set; }
    }
}
