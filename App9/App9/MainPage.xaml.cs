using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App9
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> a = new List<string>();
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
            a.Add("\"A good coder learn from others work\"");
            a.Add("\"Learn by doing copy paste of others code\"");
            a.Add("\"Always think big to get big things\"");
            
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            
            if(count>=0 && count < 3)
            {
                label.Text = a[count];
                count++;
            }
            
        }
    }
}
