using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using KonVertObjs;

namespace ZwypConvertCS1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // must read in all Conversions before can build main screen
            bool readRes = ZwTools.readAppData();
            if (readRes)
                Content = ZwCX.buildMainScreen();

        }
    }
}
