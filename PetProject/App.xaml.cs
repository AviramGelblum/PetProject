using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PetProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ObservableCollection<Dog> dogs = new ObservableCollection<Dog>();

        void AppStartup(object sender, StartupEventArgs args)
        {
            LoadData();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        public ObservableCollection<Dog> Dogs
        {
            get { return this.dogs; }
            set { this.dogs = value; }
        }

        private void LoadData() {
            Dog Johnny = new Dog("Johnny",1325);
            Dog Diamond = new Dog("Diamond",1327);
            this.Dogs.Add(Johnny);
            this.Dogs.Add(Diamond);
        }
            

    }
}
