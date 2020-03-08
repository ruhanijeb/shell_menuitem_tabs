using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shell_collectionview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabShell : Xamarin.Forms.Shell
    {
        public TabShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("myawesomepage", typeof(HomePage));
        }
        public void Handle_Navigating(object sender,ShellNavigatingEventArgs args)
        {

        }
    }
}