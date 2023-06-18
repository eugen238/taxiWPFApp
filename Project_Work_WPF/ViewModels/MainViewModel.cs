using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;
using Bogus;
using Bogus.DataSets;
using Project_Work_WPF.CustomExceptions;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using Project_Work_WPF.Views;
using PropertyChanged;

namespace Project_Work_WPF.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class MainViewModel : BaseViewModel
	{
		public static string Logged_As = "User";

		public  static void Add_User(string login, string password,string name, string surname, string phonenumber)
        {

			using (UserEntities ctx = new UserEntities())
			{
				ctx.INSERTUSER(login,password,name,surname,phonenumber);
				//TYPEOFUSER type = ctx.TYPEOFUSER.Where(b => b.TYPEID == 1).FirstOrDefault();
				//if (type.TAXIUSER is null)
				//{
				//	type.TAXIUSER = new List<TAXIUSER>();
				//}
				//int count = ctx.TAXIUSER.Count();
				//type.TAXIUSER.Add(new TAXIUSER {ID = count, USERLOGIN = login, USERNAME = name, USERNUMBER = phonenumber, USERPASSWORD = password, USERSURNAME = surname });
				//ctx.SaveChanges();
			}
		}



		public static bool Check_User(string username, string password)
		{
			using(UserEntities ctx = new UserEntities())
			{
                if (ctx.CHECKUSER(username, password).Count() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

		}
		public static bool Check_Admin(string username, string password)
		{

            using (AdminEntities ctx = new AdminEntities())
            {

                if (ctx.CHECKADMIN(username,password).Count() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


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

		private void GoToLogIn(object obj)
		{
			(PageViewModels[0] as Login_Page_ViewModel).Password = string.Empty;
			(PageViewModels[0] as Login_Page_ViewModel).Username = string.Empty;
			(PageViewModels[0] as Login_Page_ViewModel).password_box_visibility = System.Windows.Visibility.Visible;
			(PageViewModels[0] as Login_Page_ViewModel).password_box_visibility_2 = System.Windows.Visibility.Collapsed;
			ChangeViewModel(PageViewModels[0]);
		}

		private void GoToUser(object obj)
		{
			(PageViewModels[1] as User_Page_ViewModel).Route.Clear();
			(PageViewModels[1] as User_Page_ViewModel).From = string.Empty;
			(PageViewModels[1] as User_Page_ViewModel).To = string.Empty;
			(PageViewModels[1] as User_Page_ViewModel).Price = string.Empty;
			User_Page_ViewModel.rotate_cliked = false;
			(PageViewModels[1] as User_Page_ViewModel).GetCurrentLocation();
			ChangeViewModel(PageViewModels[1]);
		}

		private void GoToRegister(object obj)
		{
            (PageViewModels[2] as Register_Page_ViewModel).Passwordd = string.Empty;
            (PageViewModels[2] as Register_Page_ViewModel).password_box_visibility = System.Windows.Visibility.Visible;
            (PageViewModels[2] as Register_Page_ViewModel).password_box_visibility_2 = System.Windows.Visibility.Collapsed;
            (PageViewModels[2] as Register_Page_ViewModel).Hidden = false;
			ChangeViewModel(PageViewModels[2]);
		}

		private void GoToHistory(object obj)
		{
			ChangeViewModel(PageViewModels[3]);
		}

		private void GoToAdmin(object obj)
		{
			ChangeViewModel(PageViewModels[4]);
		}

        private void GoToAccount(object obj)
        {
            using (UserEntities ctx = new UserEntities())
            {
				GETUSER_Result getuser = ctx.GETUSER(Login_Page_ViewModel.StaticUsername).FirstOrDefault();
                ObjectParameter decryptedpassword = new ObjectParameter("DECRYPTEDPASSWORD", typeof(string));
				ctx.GETDECTYPTEDPASSWORD(getuser.USERPASSWORD,decryptedpassword);
                User_ViewModel.Login = getuser.USERLOGIN;
				User_ViewModel.Password = (string)decryptedpassword.Value;
                User_ViewModel.Name = getuser.USERNAME;
                User_ViewModel.Surname = getuser.USERSURNAME;
                User_ViewModel.Number = getuser.USERNUMBER;
            }
            UserWindow user = new UserWindow();
			user.ShowDialog();
			

        }

        public MainViewModel()
		{
			// Add available pages and set page 
			PageViewModels.Add(new Login_Page_ViewModel());
			PageViewModels.Add(new User_Page_ViewModel());
			PageViewModels.Add(new Register_Page_ViewModel());
			PageViewModels.Add(new History_Page_ViewModel());
			PageViewModels.Add(new Admin_Page_ViewModel());
			PageViewModels.Add(new User_ViewModel());
			ChangeViewModel(PageViewModels[0]);


			Mediator.Subscribe("GoToLogIn", GoToLogIn);
			Mediator.Subscribe("GoToUser", GoToUser);
			Mediator.Subscribe("GoToRegister", GoToRegister);
			Mediator.Subscribe("GoToHistory", GoToHistory);
			Mediator.Subscribe("GoToAdmin", GoToAdmin);
			Mediator.Subscribe("GoToAccount", GoToAccount);
		}

	}
}
