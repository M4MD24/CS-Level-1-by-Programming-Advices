using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class WindowsFormsConcepts {
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
        title                     = new System.Windows.Forms.Label();
        introductionAboutControls = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Segoe UI",
            27F,
            System.Drawing.FontStyle.Bold
        );
        title.ForeColor = System.Drawing.Color.DarkOrange;
        title.Location = new System.Drawing.Point(
            125,
            27
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            500,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Windows Forms Concepts";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // introductionAboutControls
        // 
        introductionAboutControls.Location = new System.Drawing.Point(
            50,
            275
        );
        introductionAboutControls.Name = "introductionAboutControls";
        introductionAboutControls.Size = new System.Drawing.Size(
            200,
            50
        );
        introductionAboutControls.TabIndex                =  1;
        introductionAboutControls.Text                    =  "Introduction About Controls";
        introductionAboutControls.UseVisualStyleBackColor =  true;
        introductionAboutControls.Click                   += introductionAboutControls_Click;
        // 
        // WindowsFormsConcepts
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            784,
            361
        );
        Controls.Add(
            introductionAboutControls
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Windows Forms Concepts";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button introductionAboutControls;

    private System.Windows.Forms.Label title;

    #endregion
}