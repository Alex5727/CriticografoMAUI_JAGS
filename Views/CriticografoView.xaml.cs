using CriticografoMAUI_JAGS.ViewModel;

namespace CriticografoMAUI_JAGS.Views;

public partial class CriticografoView : ContentPage
{
	public CriticografoView()
	{
		InitializeComponent();
        VMcriticografo vmCrt = new VMcriticografo();

        BindingContext = vmCrt;
    }
}