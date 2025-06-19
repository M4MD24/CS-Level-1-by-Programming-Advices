using System.ComponentModel;

namespace WindowsFormsConcepts.Containers;

partial class PanelExample {
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
        title = new System.Windows.Forms.Label();
        panel = new System.Windows.Forms.Panel();
        text7 = new System.Windows.Forms.Label();
        text6 = new System.Windows.Forms.Label();
        text5 = new System.Windows.Forms.Label();
        text4 = new System.Windows.Forms.Label();
        text3 = new System.Windows.Forms.Label();
        text2 = new System.Windows.Forms.Label();
        text1 = new System.Windows.Forms.Label();
        panel.SuspendLayout();
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold
        );
        title.ForeColor = System.Drawing.Color.Olive;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            150,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Panel";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel
        // 
        panel.AutoScroll = true;
        panel.Controls.Add(
            text7
        );
        panel.Controls.Add(
            text6
        );
        panel.Controls.Add(
            text5
        );
        panel.Controls.Add(
            text4
        );
        panel.Controls.Add(
            text3
        );
        panel.Controls.Add(
            text2
        );
        panel.Controls.Add(
            text1
        );
        panel.Location = new System.Drawing.Point(
            50,
            100
        );
        panel.Name = "panel";
        panel.Size = new System.Drawing.Size(
            150,
            225
        );
        panel.TabIndex = 1;
        // 
        // text7
        // 
        text7.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text7.Location = new System.Drawing.Point(
            18,
            300
        );
        text7.Name = "text7";
        text7.Size = new System.Drawing.Size(
            100,
            25
        );
        text7.TabIndex  = 8;
        text7.Text      = "Text Seven";
        text7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text6
        // 
        text6.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text6.Location = new System.Drawing.Point(
            18,
            250
        );
        text6.Name = "text6";
        text6.Size = new System.Drawing.Size(
            100,
            25
        );
        text6.TabIndex  = 7;
        text6.Text      = "Text Six";
        text6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text5
        // 
        text5.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text5.Location = new System.Drawing.Point(
            18,
            200
        );
        text5.Name = "text5";
        text5.Size = new System.Drawing.Size(
            100,
            25
        );
        text5.TabIndex  = 6;
        text5.Text      = "Text Five";
        text5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text4
        // 
        text4.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text4.Location = new System.Drawing.Point(
            18,
            150
        );
        text4.Name = "text4";
        text4.Size = new System.Drawing.Size(
            100,
            25
        );
        text4.TabIndex  = 5;
        text4.Text      = "Text Four";
        text4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text3
        // 
        text3.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text3.Location = new System.Drawing.Point(
            18,
            100
        );
        text3.Name = "text3";
        text3.Size = new System.Drawing.Size(
            100,
            25
        );
        text3.TabIndex  = 4;
        text3.Text      = "Text Three";
        text3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text2
        // 
        text2.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text2.Location = new System.Drawing.Point(
            18,
            50
        );
        text2.Name = "text2";
        text2.Size = new System.Drawing.Size(
            100,
            25
        );
        text2.TabIndex  = 3;
        text2.Text      = "Text Two";
        text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text1
        // 
        text1.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        text1.Location = new System.Drawing.Point(
            18,
            0
        );
        text1.Name = "text1";
        text1.Size = new System.Drawing.Size(
            100,
            25
        );
        text1.TabIndex  = 2;
        text1.Text      = "Text One";
        text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // PanelExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            234,
            361
        );
        Controls.Add(
            panel
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Panel";
        panel.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label text7;

    private System.Windows.Forms.Label text5;

    private System.Windows.Forms.Label text2;
    private System.Windows.Forms.Label text3;
    private System.Windows.Forms.Label text4;
    private System.Windows.Forms.Label text6;

    private System.Windows.Forms.Label text1;

    private System.Windows.Forms.Panel panel;

    private System.Windows.Forms.Label title;

    #endregion
}