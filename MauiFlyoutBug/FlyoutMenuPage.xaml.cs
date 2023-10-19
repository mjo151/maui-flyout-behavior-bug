namespace MauiFlyoutBug;

public partial class FlyoutMenuPage : ContentPage
{
	public FlyoutMenuPage()
	{
		InitializeComponent();
	}

    void ToggleFlyoutBehaviorButton_Clicked(System.Object sender, System.EventArgs e)
    {
		this.ToggleFlyoutBehavior?.Invoke(this, EventArgs.Empty);
    }

	public event EventHandler ToggleFlyoutBehavior;
}
