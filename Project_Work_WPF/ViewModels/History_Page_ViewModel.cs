using Project_Work_WPF.Commands;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Work_WPF.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	class History_Page_ViewModel : BaseViewModel, IPageViewModel
	{
		public static TAXIUSER user { get; set; }
		public List<USERHISTORY> HistoryForGrid { get; set; }
        public static List<GETHISTORY_Result> SelectHistory()
		{
			using(UserEntities ctx = new UserEntities())
			{
				using(Tables tables = new Tables())
				{
                    user = tables.TAXIUSER.Where(e => e.USERLOGIN == Login_Page_ViewModel.StaticUsername).FirstOrDefault();
                }
                List<GETHISTORY_Result> list = new List<GETHISTORY_Result>();

				foreach(var item in ctx.GETHISTORY(user.ID)) {
					list.Add(item);
				}

				return list;
			}
		}

		private RelayCommand _goTo1;

		public RelayCommand Log_Out
		{ 
			get
			{
				return _goTo1 ?? (_goTo1 = new RelayCommand(x =>
				{
					Mediator.Notify("GoToUser", "");
				}));
			} 
		}
		bool tf = false;
		public History_Page_ViewModel()
		{
		}
	}
}
