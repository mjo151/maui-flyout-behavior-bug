﻿namespace MauiFlyoutBug;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainFlyoutPage();
	}
}

