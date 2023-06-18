using Project_Work_WPF.Commands;
using Project_Work_WPF.Navigation;
using Project_Work_WPF.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Work_WPF.ViewModels
{
    [AddINotifyPropertyChangedInterface]
     class User_ViewModel : BaseViewModel, IPageViewModel
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string Name { get; set; }
        public static string Surname { get;set; }
        public static string Number { get; set; }
        public RelayCommand Save_Command { get; set; }
        public RelayCommand<Window> Close_Command { get; set; }
        static bool departure_finished = true;

        public static TAXIUSER user { get; set; }

        Predicate<object> departure_finished_object = new Predicate<object>(x => departure_finished == true);


        public void Save()
        {
            using(UserEntities ctx = new UserEntities())
            {
                ctx.UPDATEUSER(user.ID,Login, Password, Name, Surname, Number);
            }
        }

        private void Close(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        public User_ViewModel() {

            Save_Command = new RelayCommand(
                a =>
            {
                 Save();
            }, departure_finished_object
            );


            this.Close_Command = new RelayCommand<Window>(this.Close);
        }
    }
}
