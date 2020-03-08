using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmHelpers;

namespace Shell_collectionview.ViewModels
{
    public class TabsShellViewModel
    {
        public ICommand NavigateCommand { get; set; }
        public TabsShellViewModel()
        {
            NavigateCommand = new Command<string>(InvokeNavigateCommand);
        }
        public void InvokeNavigateCommand(string id)
        {
            Shell.Current.GoToAsync($"app:///home/tabs/favorites/myfavorites?text={id}", true);
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
