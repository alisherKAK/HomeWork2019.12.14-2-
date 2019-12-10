namespace HomeWork2019._12._14_2_.DataAccess
{
    using HomeWork2019._12._14_2_.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InstagramContext : DbContext
    {
        // Контекст настроен для использования строки подключения "InstagramContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "HomeWork2019._12._14_2_.DataAccess.InstagramContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "InstagramContext" 
        // в файле конфигурации приложения.
        public InstagramContext()
            : base("name=InstagramContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}