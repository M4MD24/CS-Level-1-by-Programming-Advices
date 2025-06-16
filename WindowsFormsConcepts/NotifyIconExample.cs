namespace WindowsFormsConcepts;

public partial class NotifyIconExample : Form {
    public NotifyIconExample() {
        InitializeComponent();
    }

    private void showNotifyIcon_Click(
        object    sender,
        EventArgs e
    ) {
        notifyIconSample.Icon            = SystemIcons.Application;
        notifyIconSample.BalloonTipIcon  = ToolTipIcon.Info;
        notifyIconSample.BalloonTipTitle = @"Title Position";
        notifyIconSample.BalloonTipText  = @"Text Position";
        notifyIconSample.ShowBalloonTip(
            1000
        );
    }

    private void notifyIconSample_BalloonTipClicked(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            @"You Clicked NotifyIcon",
            @"Simple Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}