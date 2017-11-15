using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlipAnimation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlipAnimation : ContentPage
    {
        public FlipAnimation()
        {
            InitializeComponent();
        }
        void Login_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Login", "Ok");
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Register", "Ok");
        }

        private void ChangePass_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "", "Ok");
        }

        private void ForgetPass_Clicked(object sender, EventArgs e)
        {

        }
    }
}