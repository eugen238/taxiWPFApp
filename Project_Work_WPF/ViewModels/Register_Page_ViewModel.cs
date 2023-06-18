﻿using Project_Work_WPF.Commands;
using Project_Work_WPF.Navigation;
using Project_Work_WPF.Views;
using PropertyChanged;
using System;
using System.Media;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace Project_Work_WPF.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class Register_Page_ViewModel : BaseViewModel, IPageViewModel
	{
		public static string Surname { get; set; } = string.Empty;
		public static string Name { get; set; } = string.Empty;
		public static string PhoneNumber { get; set; } = string.Empty;
		public static string Login { get; set; } = string.Empty;
		public static string Password { get; set; } = string.Empty;
        public string Passwordd { get; set; } = string.Empty;

		public RelayCommand Register_Command { get; set; }





		static void Register(object obj)
		{
			try
			{
				MainViewModel.Add_User(Login, Password,Name,Surname,PhoneNumber);
				Completed_Window completed_Window = new Completed_Window();

				completed_Window.Left = Application.Current.MainWindow.Left;
				completed_Window.Top = Application.Current.MainWindow.Top;

				completed_Window.Left += Application.Current.MainWindow.Width / 2;
				completed_Window.Top += Application.Current.MainWindow.Height / 2;

				new SoundPlayer(Properties.Resources.Completed_Sound_Effect).Play();
				completed_Window.ShowDialog();

				GoTo_SignIn.Execute(obj);

			}
			catch (Exception a)
			{
				Error_Window error_Window = new Error_Window();
				error_Window.Left = Application.Current.MainWindow.Left;
				error_Window.Top = Application.Current.MainWindow.Top;

				error_Window.Left += Application.Current.MainWindow.Width / 2;
				error_Window.Top += Application.Current.MainWindow.Height / 2;

				new SoundPlayer(Properties.Resources.Error_Sound_Effect).Play();
				error_Window.ShowDialog();
			} 
		}

		Action<object> Register_Actoin = Register;

		Predicate<object> Register_Predicate = new Predicate<object>(x => Login != string.Empty &&
																		  Password != string.Empty &&
																		  Name != string.Empty && Surname != string.Empty && PhoneNumber != string.Empty);

        public bool Hidden = false;
        public System.Windows.Visibility password_box_visibility { get; set; } = System.Windows.Visibility.Visible;
        public System.Windows.Visibility password_box_visibility_2 { get; set; } = System.Windows.Visibility.Collapsed;
        private void Hide_Button_Click(object obj)
        {
            Passwordd = Password;

            if (!Hidden)
            {
                password_box_visibility = System.Windows.Visibility.Hidden;
                password_box_visibility_2 = System.Windows.Visibility.Visible;

                Hidden = true;
            }

            else
            {
                password_box_visibility = System.Windows.Visibility.Visible;
                password_box_visibility_2 = System.Windows.Visibility.Hidden;

                Hidden = false;
            }

        }






        public static ICommand GoTo_SignIn
		{
			get
			{
				return new RelayCommand(x =>
				{
					Login = string.Empty;
					Password = string.Empty;
					Name = string.Empty;
					Surname = string.Empty;
					PhoneNumber = string.Empty;

					Mediator.Notify("GoToLogIn", "");
				});
			}
		}

		public RelayCommand Hide { get; set; }

		public Register_Page_ViewModel()
		{
			Register_Command = new RelayCommand(Register_Actoin, Register_Predicate);

		}
	}
}
