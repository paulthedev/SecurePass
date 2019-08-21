using SecurePass.Shared;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecurePass.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IdentityAuthPage : ContentPage
    {
        public IdentityAuthPage()
        {
            InitializeComponent();
        }

        private void SetCode(object sender, EventArgs e)
        {
            var accessService = DependencyService.Get<IAccessService>();
            accessService.setCode(Code.Text);
        }
    }
}