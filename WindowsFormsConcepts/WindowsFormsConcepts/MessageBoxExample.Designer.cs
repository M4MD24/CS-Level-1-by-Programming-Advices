using System.ComponentModel;

namespace WindowsFormsConcepts;

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
        title                                                         = new System.Windows.Forms.Label();
        showMessageBox                                                = new System.Windows.Forms.Button();
        showMessageBoxWithTitle                                       = new System.Windows.Forms.Button();
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton = new System.Windows.Forms.Button();
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
        // showMessageBoxWithTitle
        // 
        showMessageBoxWithTitle.Location = new System.Drawing.Point(
            350,
            150
        );
        showMessageBoxWithTitle.Name = "showMessageBoxWithTitle";
        showMessageBoxWithTitle.Size = new System.Drawing.Size(
            200,
            50
        );
        showMessageBoxWithTitle.TabIndex                =  2;
        showMessageBoxWithTitle.Text                    =  "Show MessageBox with Title";
        showMessageBoxWithTitle.UseVisualStyleBackColor =  true;
        showMessageBoxWithTitle.Click                   += showMessageBoxWithTitle_Click;
        // 
        // showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton
        // 
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.Location = new System.Drawing.Point(
            50,
            225
        );
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.Name = "showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton";
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.Size = new System.Drawing.Size(
            500,
            50
        );
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.TabIndex                =  3;
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.Text                    =  "Show MessageBox with Title and Other Buttons and Icon and Default Button";
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.UseVisualStyleBackColor =  true;
        showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton.Click                   += showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton_Click;
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
            showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton
        );
        Controls.Add(
            showMessageBoxWithTitle
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

    private System.Windows.Forms.Button showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton;

    private System.Windows.Forms.Button showMessageBoxWithTitle;

    private System.Windows.Forms.Button showMessageBox;

    private System.Windows.Forms.Label title;

    #endregion
}