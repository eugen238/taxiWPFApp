using Newtonsoft.Json;
using Project_Work_WPF.Commands;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Work_WPF.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    class Admin_Page_AddCar_ViewModel : BaseViewModel, IPageViewModel
    {
        public static string Mark { get; set; } = string.Empty;
        public static string Model { get; set; } = string.Empty;
        public static int NumberOfCar { get; set; } = 0;



        static Predicate<object> AddCar_Predicate = new Predicate<object>(x => Mark != string.Empty && Model != string.Empty);





        public RelayCommand AddCar_Command { get; set; } = new RelayCommand(
            x =>
            {
                using(AdminEntities ctx = new AdminEntities())
                {
                    ctx.INSERTCAR(Mark, Model, NumberOfCar);
                }
            }, AddCar_Predicate
        );

        public RelayCommand GoTo_Cars { get; set; } = new RelayCommand(
        x =>
        {
            using(AdminEntities ctx = new AdminEntities())
            {
                Admin_Page_DriverOnMap_ViewModel.Cars.Clear();
                foreach (var car in ctx.GETCARS())
                {
                    Admin_Page_DriverOnMap_ViewModel.Cars.Add(car);
                }
            }
            Mediator.Notify("GoTo_UserOnMap", "");
        });
    }
}
