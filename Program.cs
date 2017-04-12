using System;
using System.Threading.Tasks;

namespace AsyncTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = TaskWaiter("Task1", 2);
            var task2 = TaskWaiter("Task2", 6);
            var task3 = TaskWaiter("Task3", 4);

            Console.Read();
        }

        private static async Task<string> TaskWaiter(string taskId, int seconds)
        {
            await Task.Delay(seconds * 1000);

            Console.WriteLine("Task terminada: " + taskId + " ::: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));

            return taskId;
        }
    }
}
