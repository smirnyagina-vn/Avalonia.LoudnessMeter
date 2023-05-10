using Avalonia.Controls;
using Avalonia.Media;
using System;

namespace Avalonia.LoudnessMeter.Views;

public partial class MainView : UserControl
{
    #region Private Members

    private Control mChannelConfigPopup;
    private Control mChannelConfigButton;
    private Control mMainGrid;

    #endregion

    public MainView()
    {
        InitializeComponent();

        mChannelConfigButton = this.FindControl<Control>("ChannelConfigurationButton") ?? throw new Exception("Cannot find channel configuration button by name");
        mChannelConfigPopup = this.FindControl<Control>("ChannelConfigurationPopup") ?? throw new Exception("Cannot find channel configuration popup by name");
        mMainGrid = this.FindControl<Control>("MainGrid") ?? throw new Exception("Cannot find channel configuration main grid by name");
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);

        var position = mChannelConfigButton.TranslatePoint(new Point(), mMainGrid) ??
                       throw new Exception("Cannot get TranslatePoint from ConfigurationButton");
        
        //mChannelConfigPopup.Margin = new Thickness(
        //    position.X, 
        //    0, 
        //    0, 
        //    mMainGrid.Bounds.Height - position.Y);
    }
}