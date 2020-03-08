using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shell_collectionview
{
    [QueryProperty("Text","text")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        string _text;
        public HomePage()
        {
            InitializeComponent();
        }
        public string Text
        {
            get => _text;
            set => _text = textLabel.Text = value;
        }
    }
}