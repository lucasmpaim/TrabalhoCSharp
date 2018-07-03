using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {

        void Application_Start(object sender, StartupEventArgs args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DatabaseContext>());

            using (var context = new DatabaseContext())
            {
                context.Database.Initialize(true);
            }

        }

    }
}
