using Project_Work_WPF.Commands;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using Project_Work_WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Work_WPF.ViewModels
{
	class Admin_Page_ViewModel : BaseViewModel, IPageViewModel
	{
		private List<IPageViewModel> _pageViewModels;

		public List<IPageViewModel> PageViewModels
		{
			get
			{
				if (_pageViewModels == null)
					_pageViewModels = new List<IPageViewModel>();

				return _pageViewModels;
			}
		}

		public IPageViewModel _currentPageViewModel { get; set; }

		public IPageViewModel CurrentPageViewModel
		{

			get
			{
				return _currentPageViewModel;
			}

			set
			{
				_currentPageViewModel = value;
				OnPropertyChanged("CurrentPageViewModel");
			}
		}

		private void ChangeViewModel(IPageViewModel viewModel)
		{
			if (!PageViewModels.Contains(viewModel))
				PageViewModels.Add(viewModel);

			CurrentPageViewModel = PageViewModels
				.FirstOrDefault(vm => vm == viewModel);
		}

		private void GoToAdmin_UserPage(object obj)
		{
			ChangeViewModel(PageViewModels[0]);
		}



        private void GoToAdmin_UseronMap(object obj)
		{
			ChangeViewModel(PageViewModels[1]);
		}

		private void GoTo_AddDriver(object obj)
		{
			Admin_Page_AddDriver_ViewModel.Name = string.Empty;
			Admin_Page_AddDriver_ViewModel.Surname = string.Empty;
			Admin_Page_AddDriver_ViewModel.Email = string.Empty;
			Admin_Page_AddDriver_ViewModel.Age = 18;
			ChangeViewModel(PageViewModels[2]);
		}	
		private void GoTo_AddCar(object obj)
		{
			Admin_Page_AddDriver_ViewModel.Name = string.Empty;
			Admin_Page_AddDriver_ViewModel.Surname = string.Empty;
			Admin_Page_AddDriver_ViewModel.Email = string.Empty;
			Admin_Page_AddDriver_ViewModel.Age = 18;
			ChangeViewModel(PageViewModels[3]);
		}



        private void GoTo_SetPrice(object obj)
		{ 
			ChangeViewModel(PageViewModels[4]);
		}

        public List<DateTime?> profit = new List<DateTime?>();
		public double num;
        private void GoTo_Statistic(object obj)
		{
			using(AdminEntities ctx = new AdminEntities())
			{
				Admin_Page_Company_Statistic_ViewModell.Statistics.Clear();
				ObjectParameter profit = new ObjectParameter("PROFIT", typeof(double));
				ctx.GETPROFIT(profit);
				Admin_Page_Company_Statistic_ViewModell.Profit = double.Parse(profit.Value.ToString());
                foreach (var item in ctx.GETSTATISTICS())
				{
					double PrecentWithout = (double)(item.SUM_COSTFORTAXI_ * 100);
                    Admin_Page_Company_Statistic_ViewModell.Statistics.Add(new Models.Statistics { DMY = item.TO_CHAR_TIME__YYYY_MM_DD__, Precent = PrecentWithout / Admin_Page_Company_Statistic_ViewModell.Profit, TotalProfit = (double)item.SUM_COSTFORTAXI_ });

                }




            }
			ChangeViewModel(PageViewModels[5]);
		}





		public RelayCommand GoToAdmin_User { get; set; } = new RelayCommand(x =>
		  {
			  Mediator.Notify("GoToAdmin_UserPage", "");
		  }
		);	





        public RelayCommand GoToAdmin_UserOnMap { get; set; } = new RelayCommand(x =>
		{
			Mediator.Notify("GoTo_UserOnMap", "");
		}
		);

		public RelayCommand GoToAdmin_SetPrice { get; set; } = new RelayCommand(x =>
		{
			Mediator.Notify("GoTo_SetPrice", "");
		}
		);

		public RelayCommand GoTo_Login { get; set; } = new RelayCommand(x =>
			{
				Mediator.Notify("GoToLogIn", "");
			}
		);

		public RelayCommand GoToCompany_Statistic { get; set; } = new RelayCommand(x =>
		{
			Mediator.Notify("GoTo_Statistic", "");
		}
		);


		public Admin_Page_ViewModel()
		{
			PageViewModels.Add(new Admin_UserPage_ViewModel());
            PageViewModels.Add(new Admin_Page_DriverOnMap_ViewModel());
			PageViewModels.Add(new  Admin_Page_AddDriver_ViewModel());
			PageViewModels.Add(new  Admin_Page_AddCar_ViewModel());
			PageViewModels.Add(new Admin_Page_SetPrice_ViewModel());
			PageViewModels.Add(new Admin_Page_Company_Statistic_ViewModell());


            Mediator.Subscribe("GoToAdmin_UserPage", GoToAdmin_UserPage);
            Mediator.Subscribe("GoTo_UserOnMap", GoToAdmin_UseronMap);
			Mediator.Subscribe("GoTo_AddDriver", GoTo_AddDriver);
			Mediator.Subscribe("GoTo_AddCar", GoTo_AddCar);
			Mediator.Subscribe("GoTo_SetPrice", GoTo_SetPrice);
			Mediator.Subscribe("GoTo_Statistic", GoTo_Statistic);


            Mediator.Notify("GoToAdmin_UserPage", "");

		}
	}
}
