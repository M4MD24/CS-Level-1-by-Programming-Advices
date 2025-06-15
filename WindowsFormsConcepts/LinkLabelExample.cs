namespace WindowsFormsConcepts;

public partial class LinkLabelExample : Form {
    public LinkLabelExample() {
        InitializeComponent();
    }

    private void linkLabelWithURL_AndVisitedLink_LinkClicked(
        object                        sender,
        LinkLabelLinkClickedEventArgs e
    ) {
        linkLabel.LinkVisited = true;

        var processStartInformation = new System.Diagnostics.ProcessStartInfo {
            FileName        = "https://t.me/m4md24",
            UseShellExecute = true
        };
        System.Diagnostics.Process.Start(
            processStartInformation
        );
    }
}