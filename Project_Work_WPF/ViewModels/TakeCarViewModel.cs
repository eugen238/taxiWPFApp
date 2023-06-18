using PropertyChanged;
using Project_Work_WPF.Models;
using Project_Work_WPF.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using Project_Work_WPF.Commands;
using System.Windows;

namespace Project_Work_WPF.ViewModels
{
    [AddINotifyPropertyChangedInterface]
     class TakeCarViewModel : BaseViewModel, IPageViewModel
    {

        public ObservableCollection<string> cars { get; set; } = new ObservableCollection<string>();
        public RelayCommand Choose_Command { get; set; }
        public static string staticMark { get; set; }
        public static string staticModel { get; set; }

        public string MarkModel { get; set; }


        public RelayCommand<Window> Close_Command { get; set; }

        public void setCar()
        {
            string[] words = MarkModel.Split(' ');
            staticMark = words[0];
            staticModel = words[1];
        }
        private void Close(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        public TakeCarViewModel() {  
        using(UserEntities ctx = new UserEntities())
            {
                foreach(GETCARSNAMES_Result car in ctx.GETCARSNAMES())
                {
                    string str = $"{car.MODEL} {car.MARK}";
                    cars.Add(str);
                }

                Choose_Command = new RelayCommand(
                    e=>
                    {
                        setCar();
                    }
                    );
                this.Close_Command = new RelayCommand<Window>(this.Close);
            }
        }
    }
}
