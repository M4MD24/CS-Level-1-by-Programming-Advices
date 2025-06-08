namespace WindowsFormsConcepts;

partial class IntroductionAboutControls {
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
        textBoxesAndButtonsAndFormsAndLabels = new System.Windows.Forms.Button();
        title                                = new System.Windows.Forms.Label();
        flatAppearance                       = new System.Windows.Forms.Button();
        newForms                             = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxesAndButtonsAndFormsAndLabels
        // 
        textBoxesAndButtonsAndFormsAndLabels.Location = new System.Drawing.Point(
            50,
            175
        );
        textBoxesAndButtonsAndFormsAndLabels.Name = "textBoxesAndButtonsAndFormsAndLabels";
        textBoxesAndButtonsAndFormsAndLabels.Size = new System.Drawing.Size(
            275,
            50
        );
        textBoxesAndButtonsAndFormsAndLabels.TabIndex                =  1;
        textBoxesAndButtonsAndFormsAndLabels.Text                    =  "TextBoxes and Buttons and Forms and Labels";
        textBoxesAndButtonsAndFormsAndLabels.UseVisualStyleBackColor =  true;
        textBoxesAndButtonsAndFormsAndLabels.Click                   += textBoxesAndButtons_Click;
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
            650,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Introduction About Controls";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // flatAppearance
        // 
        flatAppearance.Location = new System.Drawing.Point(
            350,
            175
        );
        flatAppearance.Name = "flatAppearance";
        flatAppearance.Size = new System.Drawing.Size(
            150,
            50
        );
        flatAppearance.TabIndex                =  2;
        flatAppearance.Text                    =  "Flat Appearance";
        flatAppearance.UseVisualStyleBackColor =  true;
        flatAppearance.Click                   += formattingAndAlignments_Click;
        // 
        // newForms
        // 
        newForms.Location = new System.Drawing.Point(
            525,
            175
        );
        newForms.Name = "newForms";
        newForms.Size = new System.Drawing.Size(
            100,
            50
        );
        newForms.TabIndex                =  3;
        newForms.Text                    =  "New Forms";
        newForms.UseVisualStyleBackColor =  true;
        newForms.Click                   += newForms_Click;
        // 
        // IntroductionAboutControls
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            734,
            311
        );
        Controls.Add(
            newForms
        );
        Controls.Add(
            flatAppearance
        );
        Controls.Add(
            title
        );
        Controls.Add(
            textBoxesAndButtonsAndFormsAndLabels
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Introduction About Controls";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button newForms;

    private System.Windows.Forms.Button flatAppearance;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.Button textBoxesAndButtonsAndFormsAndLabels;

    #endregion
}