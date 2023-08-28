using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using ToDoListAPI.Models;
using DbConnection = ToDoListAPI.Connection.DbConnection;

namespace ToDoListAPI.Data
{
    public class DTask
    {
       DbConnection connection = new DbConnection();
        public async Task <List<TaskToDo>> ShowTasks()
        {
            List<TaskToDo> tasks = new List<TaskToDo>();

            using (var sql= new SqlConnection(connection.SqlString()))
            {
                using (var cmd = new SqlCommand("showTasks", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await sql.OpenAsync();
                   using(var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync()) {
                            TaskToDo task = new TaskToDo();
                            task.name = (string)item["name"];
                            task.dueDate = (DateTime)item["dueDate"];
                            tasks.Add(task);
                        }
                    }
                }
            }
            return tasks;
        }

        public async Task UpdateStatus(TaskToDo parameters)
        {
            using (var sql= new SqlConnection(connection.SqlString()))
            {
                using(var cmd= new SqlCommand("UpdateStatus", sql))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id",parameters.id);
                    cmd.Parameters.AddWithValue("@Status", parameters.status);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public async Task AddNewTask(TaskToDo parameters)
        {
            using(var sql= new SqlConnection(connection.SqlString()))
            {
                using(var cmd = new SqlCommand("AddTask", sql))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", parameters.name);
                    cmd.Parameters.AddWithValue("@DueDate", parameters.dueDate);
                    cmd.Parameters.AddWithValue("@Status", parameters.status);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteTask(int id)
        {
            using(var sql=new SqlConnection(connection.SqlString()))
            {
                using(var cmd=new SqlCommand("deleteTask", sql))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
