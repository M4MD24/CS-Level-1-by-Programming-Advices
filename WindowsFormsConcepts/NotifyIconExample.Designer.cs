using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class NotifyIconExample {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(
        bool disposing
    ) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(
            disposing
        );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        components     = new System.ComponentModel.Container();
        title          = new System.Windows.Forms.Label();
        showNotifyIcon = new System.Windows.Forms.Button();
        notifyIconSample = new System.Windows.Forms.NotifyIcon(
            components
        );
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        title.ForeColor = System.Drawing.Color.DarkGreen;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            250,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "NotifyIcon";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // showNotifyIcon
        // 
        showNotifyIcon.Location = new System.Drawing.Point(
            100,
            100
        );
        showNotifyIcon.Name = "showNotifyIcon";
        showNotifyIcon.Size = new System.Drawing.Size(
            150,
            25
        );
        showNotifyIcon.TabIndex                =  1;
        showNotifyIcon.Text                    =  "Show NotifyIcon";
        showNotifyIcon.UseVisualStyleBackColor =  true;
        showNotifyIcon.Click                   += showNotifyIcon_Click;
        // 
        // notifyIconSample
        // 
        notifyIconSample.Text              =  "NotifyIcon Sample";
        notifyIconSample.Visible           =  true;
        notifyIconSample.BalloonTipClicked += notifyIconSample_BalloonTipClicked;
        // 
        // NotifyIconExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            334,
            161
        );
        Controls.Add(
            showNotifyIcon
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "NotifyIcon";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.NotifyIcon notifyIconSample;

    private System.Windows.Forms.Button showNotifyIcon;

    private System.Windows.Forms.Label title;

    #endregion
}