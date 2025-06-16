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
        textBox                   = new System.Windows.Forms.Button();
        pictureBox                = new System.Windows.Forms.Button();
        drawing                   = new System.Windows.Forms.Button();
        maskedTextBox             = new System.Windows.Forms.Button();
        comboBox                  = new System.Windows.Forms.Button();
        linkLabel                 = new System.Windows.Forms.Button();
        checkedListBox            = new System.Windows.Forms.Button();
        dateTimeControls          = new System.Windows.Forms.GroupBox();
        monthCalendar             = new System.Windows.Forms.Button();
        dateTimePicker            = new System.Windows.Forms.Button();
        dateTimeControls.SuspendLayout();
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
            50,
            27
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            725,
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
            150
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
        // textBox
        // 
        textBox.Location = new System.Drawing.Point(
            275,
            150
        );
        textBox.Name = "textBox";
        textBox.Size = new System.Drawing.Size(
            100,
            50
        );
        textBox.TabIndex                =  2;
        textBox.Text                    =  "TextBox";
        textBox.UseVisualStyleBackColor =  true;
        textBox.Click                   += textBox_Click;
        // 
        // pictureBox
        // 
        pictureBox.Location = new System.Drawing.Point(
            400,
            150
        );
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new System.Drawing.Size(
            100,
            50
        );
        pictureBox.TabIndex                =  3;
        pictureBox.Text                    =  "PictureBox";
        pictureBox.UseVisualStyleBackColor =  true;
        pictureBox.Click                   += pictureBox_Click;
        // 
        // drawing
        // 
        drawing.Location = new System.Drawing.Point(
            525,
            150
        );
        drawing.Name = "drawing";
        drawing.Size = new System.Drawing.Size(
            100,
            50
        );
        drawing.TabIndex                =  4;
        drawing.Text                    =  "Drawing";
        drawing.UseVisualStyleBackColor =  true;
        drawing.Click                   += drawing_Click;
        // 
        // maskedTextBox
        // 
        maskedTextBox.Location = new System.Drawing.Point(
            650,
            150
        );
        maskedTextBox.Name = "maskedTextBox";
        maskedTextBox.Size = new System.Drawing.Size(
            125,
            50
        );
        maskedTextBox.TabIndex                =  5;
        maskedTextBox.Text                    =  "MaskedTextBox";
        maskedTextBox.UseVisualStyleBackColor =  true;
        maskedTextBox.Click                   += maskedTextBox_Click;
        // 
        // comboBox
        // 
        comboBox.Location = new System.Drawing.Point(
            50,
            250
        );
        comboBox.Name = "comboBox";
        comboBox.Size = new System.Drawing.Size(
            100,
            50
        );
        comboBox.TabIndex                =  6;
        comboBox.Text                    =  "ComboBox";
        comboBox.UseVisualStyleBackColor =  true;
        comboBox.Click                   += comboBox_Click;
        // 
        // linkLabel
        // 
        linkLabel.Location = new System.Drawing.Point(
            175,
            250
        );
        linkLabel.Name = "linkLabel";
        linkLabel.Size = new System.Drawing.Size(
            100,
            50
        );
        linkLabel.TabIndex                =  7;
        linkLabel.Text                    =  "LinkLabel";
        linkLabel.UseVisualStyleBackColor =  true;
        linkLabel.Click                   += linkLabel_Click;
        // 
        // checkedListBox
        // 
        checkedListBox.Location = new System.Drawing.Point(
            300,
            250
        );
        checkedListBox.Name = "checkedListBox";
        checkedListBox.Size = new System.Drawing.Size(
            125,
            50
        );
        checkedListBox.TabIndex                =  8;
        checkedListBox.Text                    =  "CheckedListBox";
        checkedListBox.UseVisualStyleBackColor =  true;
        checkedListBox.Click                   += checkedListBox_Click;
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
            450,
            225
        );
        dateTimeControls.Name = "dateTimeControls";
        dateTimeControls.Size = new System.Drawing.Size(
            325,
            100
        );
        dateTimeControls.TabIndex = 9;
        dateTimeControls.TabStop  = false;
        dateTimeControls.Text     = "DateTime Controls";
        // 
        // monthCalendar
        // 
        monthCalendar.Location = new System.Drawing.Point(
            175,
            25
        );
        monthCalendar.Name = "monthCalendar";
        monthCalendar.Size = new System.Drawing.Size(
            125,
            50
        );
        monthCalendar.TabIndex                =  11;
        monthCalendar.Text                    =  "MonthCalendar";
        monthCalendar.UseVisualStyleBackColor =  true;
        monthCalendar.Click                   += monthCalendar_Click;
        // 
        // dateTimePicker
        // 
        dateTimePicker.Location = new System.Drawing.Point(
            25,
            25
        );
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new System.Drawing.Size(
            125,
            50
        );
        dateTimePicker.TabIndex                =  10;
        dateTimePicker.Text                    =  "DateTimePicker";
        dateTimePicker.UseVisualStyleBackColor =  true;
        dateTimePicker.Click                   += dateTimePicker_Click;
        // 
        // WindowsFormsConcepts
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            809,
            361
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
            introductionAboutControls
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Windows Forms Concepts";
        dateTimeControls.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button monthCalendar;

    private System.Windows.Forms.Button dateTimePicker;

    private System.Windows.Forms.GroupBox dateTimeControls;

    private System.Windows.Forms.Button checkedListBox;

    private System.Windows.Forms.Button linkLabel;

    private System.Windows.Forms.Button comboBox;

    private System.Windows.Forms.Button maskedTextBox;

    private System.Windows.Forms.Button drawing;

    private System.Windows.Forms.Button pictureBox;

    private System.Windows.Forms.Button textBox;

    private System.Windows.Forms.Button introductionAboutControls;

    private System.Windows.Forms.Label title;

    #endregion
}