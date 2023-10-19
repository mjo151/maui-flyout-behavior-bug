namespace MauiFlyoutBug;

public partial class MainFlyoutPage : FlyoutPage
{
	public MainFlyoutPage()
	{
		InitializeComponent();

        this.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Split;

        this.flyoutPage.ToggleFlyoutBehavior += FlyoutPage_ToggleFlyoutBehavior;

		this.Detail = new NavigationPage(new DetailPage1());
    }

    private void FlyoutPage_ToggleFlyoutBehavior(object sender, EventArgs e)
    {
		this.ToggleFlyoutMode();
    }

    private void ToggleFlyoutMode()
	{
		if (this.FlyoutLayoutBehavior == FlyoutLayoutBehavior.Split)
		{
			this.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;
		}
		else
		{
			this.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Split;
        }
	}
}
