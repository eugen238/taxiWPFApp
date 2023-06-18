using Bogus;
using Newtonsoft.Json;
using Project_Work_WPF.Commands;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Project_Work_WPF.Views;
using MaterialDesignThemes.Wpf;

namespace Project_Work_WPF.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	class Admin_UserPage_ViewModel : BaseViewModel, IPageViewModel
	{
		public static double TotalProfit { get; set; } = 0;
		public static BindingList<GETDRIVERS_Result> Drivers { get; set; } = new BindingList<GETDRIVERS_Result>();

		public Admin_UserPage_ViewModel()
		{
			using(AdminEntities ctx = new AdminEntities())
			{
				foreach(var driver in ctx.GETDRIVERS())
				{
					Drivers.Add(driver);
				}
			}


		}



        static Predicate<object> DeleteDriver_Predicate = new Predicate<object>(x => selecteditem != null);

		public static object selecteditem { get; set; }


			
		static Random random = new Random();

		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		

		public RelayCommand Add_Driver_Command { get; set; } = new RelayCommand(x =>
		{
			Mediator.Notify("GoTo_AddDriver", "");
		});

		public RelayCommand DeleteDriver_Command { get; set; } = new RelayCommand(
			x =>
			{
				using(AdminEntities ctx = new AdminEntities())
				{
					GETDRIVERS_Result driver = selecteditem as GETDRIVERS_Result;
					ctx.DELETEDRIVER(driver.ID);
                }
            }, DeleteDriver_Predicate 
		);

		public RelayCommand Save_Data_Command { get; set; } = new RelayCommand(
			x =>
			{
				using (AdminEntities ctx = new AdminEntities())
				{

					BindingList<GETDRIVERS_Result> list = Drivers;

					foreach (var driver in list)
					{
						ctx.UPDATEDRIVER(driver.ID, driver.NAME, driver.SURNAME, driver.EMAIL, driver.AGE);
					}
				}
			});


    }
}
