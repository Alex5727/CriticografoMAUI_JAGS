using CriticografoMAUI_JAGS.Views;

namespace CriticografoMAUI_JAGS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CriticografoView());

        }
    }
}
