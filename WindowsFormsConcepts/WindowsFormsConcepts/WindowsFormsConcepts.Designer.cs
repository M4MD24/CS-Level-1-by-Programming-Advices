namespace WindowsFormsConcepts;

partial class WindowsFormsConcepts {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        textBoxesAndButtons = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxesAndButtons
        // 
        textBoxesAndButtons.Location = new System.Drawing.Point(
            50,
            50
        );
        textBoxesAndButtons.Name = "textBoxesAndButtons";
        textBoxesAndButtons.Size = new System.Drawing.Size(
            150,
            50
        );
        textBoxesAndButtons.TabIndex                =  0;
        textBoxesAndButtons.Text                    =  "TextBoxes and Buttons";
        textBoxesAndButtons.UseVisualStyleBackColor =  true;
        textBoxesAndButtons.Click                   += textBoxesAndButtons_Click;
        // 
        // WindowsFormsConcepts
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            800,
            450
        );
        Controls.Add(
            textBoxesAndButtons
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Windows Forms Concepts";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button textBoxesAndButtons;

    #endregion
}