using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class TrackBarExample {
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
        title     = new System.Windows.Forms.Label();
        trackBar  = new System.Windows.Forms.TrackBar();
        indicator = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize) trackBar).BeginInit();
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
        title.ForeColor = System.Drawing.Color.DarkRed;
        title.Location = new System.Drawing.Point(
            375,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            250,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "TrackBar";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // trackBar
        // 
        trackBar.Location = new System.Drawing.Point(
            50,
            175
        );
        trackBar.Maximum = 100;
        trackBar.Name    = "trackBar";
        trackBar.Size = new System.Drawing.Size(
            900,
            45
        );
        trackBar.TabIndex =  1;
        trackBar.Scroll   += trackBar_Scroll;
        // 
        // indicator
        // 
        indicator.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        indicator.ForeColor = System.Drawing.Color.DarkRed;
        indicator.Location = new System.Drawing.Point(
            475,
            125
        );
        indicator.Name = "indicator";
        indicator.Size = new System.Drawing.Size(
            50,
            23
        );
        indicator.TabIndex  = 2;
        indicator.Text      = "0";
        indicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TrackBarExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            984,
            261
        );
        Controls.Add(
            indicator
        );
        Controls.Add(
            trackBar
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "TrackBar";
        ((System.ComponentModel.ISupportInitialize) trackBar).EndInit();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Label indicator;

    private System.Windows.Forms.TrackBar trackBar;

    private System.Windows.Forms.Label title;

    #endregion
}