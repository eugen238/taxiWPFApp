using BingMapsRESTToolkit;
using Bogus;
using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json;
using Project_Work_WPF.Commands;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Project_Work_WPF.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    class Admin_Page_DriverOnMap_ViewModel : BaseViewModel, IPageViewModel
    {
        public static double TotalProfit { get; set; } = 0;
        public static BindingList<GETCARS_Result> Cars { get; set; } = new BindingList<GETCARS_Result>();

        public Admin_Page_DriverOnMap_ViewModel()
        {
            using(AdminEntities ctx = new AdminEntities())
            {
                foreach(var car in ctx.GETCARS())
                {
                    Cars.Add(car);
                }
            }
        }

        static Predicate<object> DeleteCar_Predicate = new Predicate<object>(x => selecteditem != null);

        public static object selecteditem { get; set; }

        public static int customerId = 1;

        static Random random = new Random();

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        public RelayCommand Add_Car_Command { get; set; } = new RelayCommand(x =>
        {
            Mediator.Notify("GoTo_AddCar", "");
        });

        public RelayCommand DeleteCar_Command { get; set; } = new RelayCommand(
            x =>
            {
                using (AdminEntities ctx = new AdminEntities())
                {
                    CAR car = new CAR { ID = ((GETCARS_Result)selecteditem).ID, MARK = ((GETCARS_Result)selecteditem).MARK, MODEL = ((GETCARS_Result)selecteditem).MODEL, NUMBEROFCAR = ((GETCARS_Result)selecteditem) .NUMBEROFCAR};

                    
                    ctx.DELETECAR(car.ID);

                }
            }, DeleteCar_Predicate
        );

        public RelayCommand Save_Data_Command { get; set; } = new RelayCommand(
            x =>
            {
                using (AdminEntities ctx = new AdminEntities())
                {

                    BindingList<GETCARS_Result> list = Cars;

                    foreach (var car2 in list)
                    {
                        ctx.UPDATECAR(car2.ID, car2.MARK, car2.MODEL, car2.NUMBEROFCAR);
                    }
                }
            }
        );
    } }
