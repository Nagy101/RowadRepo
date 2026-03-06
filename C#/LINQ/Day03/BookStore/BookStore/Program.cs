using System;
using static System.Net.Mime.MediaTypeNames;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Code First vs Database First
            //Code First is preferred because it allows developers to design the application using C# classes first
            //and Entity Framework automatically generates the database from these classes.
            //It is more flexible, supports migrations, works well with version control systems like Git
            //and is ideal for new projects where the database is not yet created.
            #endregion
            #region Fluent API vs Data Annotations
            //Fluent API is used instead of Data Annotations because it provides more flexibility and full control over model configuration.
            //It allows developers to define complex relationships, constraints
            //and database rules while keeping the model classes clean and separated from database configuration logic.
            #endregion
        }
    }
}
