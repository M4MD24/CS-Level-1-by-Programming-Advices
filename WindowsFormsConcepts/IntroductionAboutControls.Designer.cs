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
        textBoxesAndButtonsAndFormsAndLabels    = new System.Windows.Forms.Button();
        title                                   = new System.Windows.Forms.Label();
        flatAppearance                          = new System.Windows.Forms.Button();
        newForms                                = new System.Windows.Forms.Button();
        messageBox                              = new System.Windows.Forms.Button();
        checkBoxAndRadioButtonAndGroupBoxAndTag = new System.Windows.Forms.Button();
        textBox                                 = new System.Windows.Forms.Button();
        pictureBox                              = new System.Windows.Forms.Button();
        drawing                                 = new System.Windows.Forms.Button();
        maskedTextBox                           = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxesAndButtonsAndFormsAndLabels
        // 
        textBoxesAndButtonsAndFormsAndLabels.Location = new System.Drawing.Point(
            50,
            150
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
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            700,
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
            150
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
            150
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
        // messageBox
        // 
        messageBox.Location = new System.Drawing.Point(
            650,
            150
        );
        messageBox.Name = "messageBox";
        messageBox.Size = new System.Drawing.Size(
            100,
            50
        );
        messageBox.TabIndex                =  4;
        messageBox.Text                    =  "Message Box";
        messageBox.UseVisualStyleBackColor =  true;
        messageBox.Click                   += messageBox_Click;
        // 
        // checkBoxAndRadioButtonAndGroupBoxAndTag
        // 
        checkBoxAndRadioButtonAndGroupBoxAndTag.Location = new System.Drawing.Point(
            50,
            225
        );
        checkBoxAndRadioButtonAndGroupBoxAndTag.Name = "checkBoxAndRadioButtonAndGroupBoxAndTag";
        checkBoxAndRadioButtonAndGroupBoxAndTag.Size = new System.Drawing.Size(
            350,
            50
        );
        checkBoxAndRadioButtonAndGroupBoxAndTag.TabIndex                =  5;
        checkBoxAndRadioButtonAndGroupBoxAndTag.Text                    =  "CheckBox and RadioButton and GroupBox and Tag";
        checkBoxAndRadioButtonAndGroupBoxAndTag.UseVisualStyleBackColor =  true;
        checkBoxAndRadioButtonAndGroupBoxAndTag.Click                   += checkBoxAndRadioButtonAndGroupBoxAndTag_Click;
        // 
        // textBox
        // 
        textBox.Location = new System.Drawing.Point(
            425,
            225
        );
        textBox.Name = "textBox";
        textBox.Size = new System.Drawing.Size(
            75,
            50
        );
        textBox.TabIndex                =  6;
        textBox.Text                    =  "TextBox";
        textBox.UseVisualStyleBackColor =  true;
        textBox.Click                   += textBox_Click;
        // 
        // pictureBox
        // 
        pictureBox.Location = new System.Drawing.Point(
            525,
            225
        );
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new System.Drawing.Size(
            100,
            50
        );
        pictureBox.TabIndex                =  7;
        pictureBox.Text                    =  "PictureBox";
        pictureBox.UseVisualStyleBackColor =  true;
        pictureBox.Click                   += pictureBox_Click;
        // 
        // drawing
        // 
        drawing.Location = new System.Drawing.Point(
            650,
            225
        );
        drawing.Name = "drawing";
        drawing.Size = new System.Drawing.Size(
            100,
            50
        );
        drawing.TabIndex                =  8;
        drawing.Text                    =  "Drawing";
        drawing.UseVisualStyleBackColor =  true;
        drawing.Click                   += drawing_Click;
        // 
        // maskedTextBox
        // 
        maskedTextBox.Location = new System.Drawing.Point(
            50,
            300
        );
        maskedTextBox.Name = "maskedTextBox";
        maskedTextBox.Size = new System.Drawing.Size(
            125,
            50
        );
        maskedTextBox.TabIndex                =  9;
        maskedTextBox.Text                    =  "MaskedTextBox";
        maskedTextBox.UseVisualStyleBackColor =  true;
        maskedTextBox.Click                   += maskedTextBox_Click;
        // 
        // IntroductionAboutControls
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            809,
            386
        );
        Controls.Add(
            maskedTextBox
        );
        Controls.Add(
            drawing
        );
        Controls.Add(
            pictureBox
        );
        Controls.Add(
            textBox
        );
        Controls.Add(
            checkBoxAndRadioButtonAndGroupBoxAndTag
        );
        Controls.Add(
            messageBox
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

    private System.Windows.Forms.Button maskedTextBox;

    private System.Windows.Forms.Button drawing;

    private System.Windows.Forms.Button pictureBox;

    private System.Windows.Forms.Button textBox;

    private System.Windows.Forms.Button checkBoxAndRadioButtonAndGroupBoxAndTag;

    private System.Windows.Forms.Button messageBox;

    private System.Windows.Forms.Button newForms;

    private System.Windows.Forms.Button flatAppearance;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.Button textBoxesAndButtonsAndFormsAndLabels;

    #endregion
}