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
        textBoxesAndButtons     = new System.Windows.Forms.Button();
        title                   = new System.Windows.Forms.Label();
        formattingAndAlignments = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxesAndButtons
        // 
        textBoxesAndButtons.Location = new System.Drawing.Point(
            50,
            175
        );
        textBoxesAndButtons.Name = "textBoxesAndButtons";
        textBoxesAndButtons.Size = new System.Drawing.Size(
            275,
            50
        );
        textBoxesAndButtons.TabIndex                =  1;
        textBoxesAndButtons.Text                    =  "TextBoxes and Buttons and Forms and Labels";
        textBoxesAndButtons.UseVisualStyleBackColor =  true;
        textBoxesAndButtons.Click                   += textBoxesAndButtons_Click;
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
        title.ForeColor = System.Drawing.Color.LimeGreen;
        title.Location = new System.Drawing.Point(
            50,
            50
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            550,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Windows Forms Concepts";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // formattingAndAlignments
        // 
        formattingAndAlignments.Location = new System.Drawing.Point(
            350,
            175
        );
        formattingAndAlignments.Name = "formattingAndAlignments";
        formattingAndAlignments.Size = new System.Drawing.Size(
            200,
            50
        );
        formattingAndAlignments.TabIndex                =  2;
        formattingAndAlignments.Text                    =  "Formatting and Alignments";
        formattingAndAlignments.UseVisualStyleBackColor =  true;
        formattingAndAlignments.Click                   += formattingAndAlignments_Click;
        // 
        // WindowsFormsConcepts
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            634,
            311
        );
        Controls.Add(
            formattingAndAlignments
        );
        Controls.Add(
            title
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

    private System.Windows.Forms.Button formattingAndAlignments;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.Button textBoxesAndButtons;

    #endregion
}