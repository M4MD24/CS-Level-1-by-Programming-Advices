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
        comboBox                                = new System.Windows.Forms.Button();
        linkLabel                               = new System.Windows.Forms.Button();
        checkedListBox                          = new System.Windows.Forms.Button();
        dateTimePicker                          = new System.Windows.Forms.Button();
        dateTimeControls                        = new System.Windows.Forms.GroupBox();
        monthCalendar                           = new System.Windows.Forms.Button();
        dateTimeControls.SuspendLayout();
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
            150,
            50
        );
        maskedTextBox.TabIndex                =  9;
        maskedTextBox.Text                    =  "MaskedTextBox";
        maskedTextBox.UseVisualStyleBackColor =  true;
        maskedTextBox.Click                   += maskedTextBox_Click;
        // 
        // comboBox
        // 
        comboBox.Location = new System.Drawing.Point(
            225,
            300
        );
        comboBox.Name = "comboBox";
        comboBox.Size = new System.Drawing.Size(
            150,
            50
        );
        comboBox.TabIndex                =  10;
        comboBox.Text                    =  "ComboBox";
        comboBox.UseVisualStyleBackColor =  true;
        comboBox.Click                   += comboBox_Click;
        // 
        // linkLabel
        // 
        linkLabel.Location = new System.Drawing.Point(
            400,
            300
        );
        linkLabel.Name = "linkLabel";
        linkLabel.Size = new System.Drawing.Size(
            150,
            50
        );
        linkLabel.TabIndex                =  11;
        linkLabel.Text                    =  "LinkLabel";
        linkLabel.UseVisualStyleBackColor =  true;
        linkLabel.Click                   += linkLabel_Click;
        // 
        // checkedListBox
        // 
        checkedListBox.Location = new System.Drawing.Point(
            575,
            300
        );
        checkedListBox.Name = "checkedListBox";
        checkedListBox.Size = new System.Drawing.Size(
            175,
            50
        );
        checkedListBox.TabIndex                =  12;
        checkedListBox.Text                    =  "CheckedListBox";
        checkedListBox.UseVisualStyleBackColor =  true;
        checkedListBox.Click                   += checkedListBox_Click;
        // 
        // dateTimePicker
        // 
        dateTimePicker.Location = new System.Drawing.Point(
            25,
            25
        );
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new System.Drawing.Size(
            150,
            50
        );
        dateTimePicker.TabIndex                =  13;
        dateTimePicker.Text                    =  "DateTime Picker";
        dateTimePicker.UseVisualStyleBackColor =  true;
        dateTimePicker.Click                   += dateTimePicker_Click;
        // 
        // dateTimeControls
        // 
        dateTimeControls.Controls.Add(
            monthCalendar
        );
        dateTimeControls.Controls.Add(
            dateTimePicker
        );
        dateTimeControls.Location = new System.Drawing.Point(
            50,
            375
        );
        dateTimeControls.Name = "dateTimeControls";
        dateTimeControls.Size = new System.Drawing.Size(
            375,
            100
        );
        dateTimeControls.TabIndex = 14;
        dateTimeControls.TabStop  = false;
        dateTimeControls.Text     = "DateTime Controls";
        // 
        // monthCalendar
        // 
        monthCalendar.Location = new System.Drawing.Point(
            200,
            25
        );
        monthCalendar.Name = "monthCalendar";
        monthCalendar.Size = new System.Drawing.Size(
            150,
            50
        );
        monthCalendar.TabIndex                =  14;
        monthCalendar.Text                    =  "Month Calendar";
        monthCalendar.UseVisualStyleBackColor =  true;
        monthCalendar.Click                   += monthCalendar_Click;
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
            561
        );
        Controls.Add(
            dateTimeControls
        );
        Controls.Add(
            checkedListBox
        );
        Controls.Add(
            linkLabel
        );
        Controls.Add(
            comboBox
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
        dateTimeControls.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button monthCalendar;

    private System.Windows.Forms.GroupBox dateTimeControls;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Button dateTimePicker;

    private System.Windows.Forms.Button checkedListBox;

    private System.Windows.Forms.Button linkLabel;

    private System.Windows.Forms.Button comboBox;

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