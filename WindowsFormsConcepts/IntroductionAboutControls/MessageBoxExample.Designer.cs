using System.ComponentModel;

namespace WindowsFormsConcepts.IntroductionAboutControls;

partial class MessageBoxExample {
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
        title                                                           = new System.Windows.Forms.Label();
        showMessageBox                                                  = new System.Windows.Forms.Button();
        showMessageBoxWithCaption                                       = new System.Windows.Forms.Button();
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton = new System.Windows.Forms.Button();
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
        title.ForeColor = System.Drawing.Color.Purple;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            500,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "MessageBox";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // showMessageBox
        // 
        showMessageBox.Location = new System.Drawing.Point(
            50,
            150
        );
        showMessageBox.Name = "showMessageBox";
        showMessageBox.Size = new System.Drawing.Size(
            150,
            50
        );
        showMessageBox.TabIndex                =  1;
        showMessageBox.Text                    =  "Show MessageBox";
        showMessageBox.UseVisualStyleBackColor =  true;
        showMessageBox.Click                   += showMessageBox_Click;
        // 
        // showMessageBoxWithCaption
        // 
        showMessageBoxWithCaption.Location = new System.Drawing.Point(
            350,
            150
        );
        showMessageBoxWithCaption.Name = "showMessageBoxWithCaption";
        showMessageBoxWithCaption.Size = new System.Drawing.Size(
            200,
            50
        );
        showMessageBoxWithCaption.TabIndex                =  2;
        showMessageBoxWithCaption.Text                    =  "Show MessageBox with Caption";
        showMessageBoxWithCaption.UseVisualStyleBackColor =  true;
        showMessageBoxWithCaption.Click                   += showMessageBoxWithCaption_Click;
        // 
        // showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton
        // 
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.Location = new System.Drawing.Point(
            50,
            225
        );
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.Name = "showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton";
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.Size = new System.Drawing.Size(
            500,
            50
        );
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.TabIndex                =  3;
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.Text                    =  "Show MessageBox with Title and Other Buttons and Icon and Default Button";
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.UseVisualStyleBackColor =  true;
        showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton.Click                   += showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton_Click;
        // 
        // MessageBoxExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            584,
            311
        );
        Controls.Add(
            showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton
        );
        Controls.Add(
            showMessageBoxWithCaption
        );
        Controls.Add(
            showMessageBox
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "MessageBox";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton;

    private System.Windows.Forms.Button showMessageBoxWithCaption;

    private System.Windows.Forms.Button showMessageBox;

    private System.Windows.Forms.Label title;

    #endregion
}