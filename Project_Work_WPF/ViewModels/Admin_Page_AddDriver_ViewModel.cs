using Newtonsoft.Json;
using Project_Work_WPF.Commands;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Work_WPF.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	class Admin_Page_AddDriver_ViewModel : BaseViewModel, IPageViewModel
	{
		public static string Name { get; set; } = string.Empty;
		public static string Surname { get; set; } = string.Empty;
		public static string Email { get; set; } = string.Empty;
		public static int Age { get; set; } = 18;
		


		static Predicate<object> AddDriver_Predicate = new Predicate<object>(x => Name != string.Empty && Surname != string.Empty && Email != string.Empty);

		



		public RelayCommand AddDriver_Command { get; set; } = new RelayCommand(
			x =>
			{
				using(AdminEntities ctx = new AdminEntities())
				{
				ctx.INSERTDRIVER(Name,Surname,Email,Age);
				}
			}, AddDriver_Predicate
		);

		public RelayCommand GoTo_Drivers { get; set; } = new RelayCommand(
		x =>
		{
            using (AdminEntities ctx = new AdminEntities())
            {
                Admin_UserPage_ViewModel.Drivers.Clear();
                foreach (var driver in ctx.GETDRIVERS())
                {
                    Admin_UserPage_ViewModel.Drivers.Add(driver);
                }
            }
            Mediator.Notify("GoToAdmin_UserPage", "");
		});
	}
}
