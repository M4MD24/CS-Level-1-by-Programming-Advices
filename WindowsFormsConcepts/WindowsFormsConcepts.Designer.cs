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
        title                                   = new System.Windows.Forms.Label();
        textBox                                 = new System.Windows.Forms.Button();
        pictureBox                              = new System.Windows.Forms.Button();
        drawing                                 = new System.Windows.Forms.Button();
        maskedTextBox                           = new System.Windows.Forms.Button();
        comboBox                                = new System.Windows.Forms.Button();
        linkLabel                               = new System.Windows.Forms.Button();
        checkedListBox                          = new System.Windows.Forms.Button();
        dateTimeControls                        = new System.Windows.Forms.GroupBox();
        monthCalendar                           = new System.Windows.Forms.Button();
        dateTimePicker                          = new System.Windows.Forms.Button();
        timer                                   = new System.Windows.Forms.Button();
        notifyIcon                              = new System.Windows.Forms.Button();
        treeViewAndImageList                    = new System.Windows.Forms.Button();
        progressBar                             = new System.Windows.Forms.Button();
        listView                                = new System.Windows.Forms.Button();
        errorProvider                           = new System.Windows.Forms.Button();
        trackBar                                = new System.Windows.Forms.Button();
        introductionToControls                  = new System.Windows.Forms.GroupBox();
        checkBoxAndRadioButtonAndGroupBoxAndTag = new System.Windows.Forms.Button();
        messageBox                              = new System.Windows.Forms.Button();
        newForms                                = new System.Windows.Forms.Button();
        flatAppearance                          = new System.Windows.Forms.Button();
        textBoxesAndButtonsAndFormsAndLabels    = new System.Windows.Forms.Button();
        numericUpDown                           = new System.Windows.Forms.Button();
        tabControl                              = new System.Windows.Forms.Button();
        panel                                   = new System.Windows.Forms.Button();
        containers                              = new System.Windows.Forms.GroupBox();
        dateTimeControls.SuspendLayout();
        introductionToControls.SuspendLayout();
        containers.SuspendLayout();
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
        // textBox
        // 
        textBox.Location = new System.Drawing.Point(
            50,
            325
        );
        textBox.Name = "textBox";
        textBox.Size = new System.Drawing.Size(
            75,
            50
        );
        textBox.TabIndex                =  7;
        textBox.Text                    =  "TextBox";
        textBox.UseVisualStyleBackColor =  true;
        textBox.Click                   += textBox_Click;
        // 
        // pictureBox
        // 
        pictureBox.Location = new System.Drawing.Point(
            150,
            325
        );
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new System.Drawing.Size(
            100,
            50
        );
        pictureBox.TabIndex                =  8;
        pictureBox.Text                    =  "PictureBox";
        pictureBox.UseVisualStyleBackColor =  true;
        pictureBox.Click                   += pictureBox_Click;
        // 
        // drawing
        // 
        drawing.Location = new System.Drawing.Point(
            275,
            325
        );
        drawing.Name = "drawing";
        drawing.Size = new System.Drawing.Size(
            100,
            50
        );
        drawing.TabIndex                =  9;
        drawing.Text                    =  "Drawing";
        drawing.UseVisualStyleBackColor =  true;
        drawing.Click                   += drawing_Click;
        // 
        // maskedTextBox
        // 
        maskedTextBox.Location = new System.Drawing.Point(
            400,
            325
        );
        maskedTextBox.Name = "maskedTextBox";
        maskedTextBox.Size = new System.Drawing.Size(
            125,
            50
        );
        maskedTextBox.TabIndex                =  10;
        maskedTextBox.Text                    =  "MaskedTextBox";
        maskedTextBox.UseVisualStyleBackColor =  true;
        maskedTextBox.Click                   += maskedTextBox_Click;
        // 
        // comboBox
        // 
        comboBox.Location = new System.Drawing.Point(
            550,
            325
        );
        comboBox.Name = "comboBox";
        comboBox.Size = new System.Drawing.Size(
            100,
            50
        );
        comboBox.TabIndex                =  11;
        comboBox.Text                    =  "ComboBox";
        comboBox.UseVisualStyleBackColor =  true;
        comboBox.Click                   += comboBox_Click;
        // 
        // linkLabel
        // 
        linkLabel.Location = new System.Drawing.Point(
            675,
            325
        );
        linkLabel.Name = "linkLabel";
        linkLabel.Size = new System.Drawing.Size(
            100,
            50
        );
        linkLabel.TabIndex                =  12;
        linkLabel.Text                    =  "LinkLabel";
        linkLabel.UseVisualStyleBackColor =  true;
        linkLabel.Click                   += linkLabel_Click;
        // 
        // checkedListBox
        // 
        checkedListBox.Location = new System.Drawing.Point(
            50,
            425
        );
        checkedListBox.Name = "checkedListBox";
        checkedListBox.Size = new System.Drawing.Size(
            125,
            50
        );
        checkedListBox.TabIndex                =  13;
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
            200,
            400
        );
        dateTimeControls.Name = "dateTimeControls";
        dateTimeControls.Size = new System.Drawing.Size(
            325,
            100
        );
        dateTimeControls.TabIndex = 14;
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
        monthCalendar.TabIndex                =  16;
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
        dateTimePicker.TabIndex                =  15;
        dateTimePicker.Text                    =  "DateTimePicker";
        dateTimePicker.UseVisualStyleBackColor =  true;
        dateTimePicker.Click                   += dateTimePicker_Click;
        // 
        // timer
        // 
        timer.Location = new System.Drawing.Point(
            550,
            425
        );
        timer.Name = "timer";
        timer.Size = new System.Drawing.Size(
            75,
            50
        );
        timer.TabIndex                =  17;
        timer.Text                    =  "Timer";
        timer.UseVisualStyleBackColor =  true;
        timer.Click                   += timer_Click;
        // 
        // notifyIcon
        // 
        notifyIcon.Location = new System.Drawing.Point(
            650,
            425
        );
        notifyIcon.Name = "notifyIcon";
        notifyIcon.Size = new System.Drawing.Size(
            125,
            50
        );
        notifyIcon.TabIndex                =  18;
        notifyIcon.Text                    =  "NotifyIcon";
        notifyIcon.UseVisualStyleBackColor =  true;
        notifyIcon.Click                   += notifyIcon_Click;
        // 
        // treeViewAndImageList
        // 
        treeViewAndImageList.Location = new System.Drawing.Point(
            50,
            525
        );
        treeViewAndImageList.Name = "treeViewAndImageList";
        treeViewAndImageList.Size = new System.Drawing.Size(
            175,
            50
        );
        treeViewAndImageList.TabIndex                =  19;
        treeViewAndImageList.Text                    =  "TreeView and ImageList";
        treeViewAndImageList.UseVisualStyleBackColor =  true;
        treeViewAndImageList.Click                   += treeViewAndImageList_Click;
        // 
        // progressBar
        // 
        progressBar.Location = new System.Drawing.Point(
            250,
            525
        );
        progressBar.Name = "progressBar";
        progressBar.Size = new System.Drawing.Size(
            125,
            50
        );
        progressBar.TabIndex                =  20;
        progressBar.Text                    =  "ProgressBar";
        progressBar.UseVisualStyleBackColor =  true;
        progressBar.Click                   += progressBar_Click;
        // 
        // listView
        // 
        listView.Location = new System.Drawing.Point(
            400,
            525
        );
        listView.Name = "listView";
        listView.Size = new System.Drawing.Size(
            100,
            50
        );
        listView.TabIndex                =  21;
        listView.Text                    =  "ListView";
        listView.UseVisualStyleBackColor =  true;
        listView.Click                   += listView_Click;
        // 
        // errorProvider
        // 
        errorProvider.Location = new System.Drawing.Point(
            525,
            525
        );
        errorProvider.Name = "errorProvider";
        errorProvider.Size = new System.Drawing.Size(
            125,
            50
        );
        errorProvider.TabIndex                =  22;
        errorProvider.Text                    =  "ErrorProvider";
        errorProvider.UseVisualStyleBackColor =  true;
        errorProvider.Click                   += errorProvider_Click;
        // 
        // trackBar
        // 
        trackBar.Location = new System.Drawing.Point(
            675,
            525
        );
        trackBar.Name = "trackBar";
        trackBar.Size = new System.Drawing.Size(
            100,
            50
        );
        trackBar.TabIndex                =  23;
        trackBar.Text                    =  "TrackBar";
        trackBar.UseVisualStyleBackColor =  true;
        trackBar.Click                   += trackBar_Click;
        // 
        // introductionToControls
        // 
        introductionToControls.Controls.Add(
            checkBoxAndRadioButtonAndGroupBoxAndTag
        );
        introductionToControls.Controls.Add(
            messageBox
        );
        introductionToControls.Controls.Add(
            newForms
        );
        introductionToControls.Controls.Add(
            flatAppearance
        );
        introductionToControls.Controls.Add(
            textBoxesAndButtonsAndFormsAndLabels
        );
        introductionToControls.Location = new System.Drawing.Point(
            50,
            125
        );
        introductionToControls.Name = "introductionToControls";
        introductionToControls.Size = new System.Drawing.Size(
            725,
            175
        );
        introductionToControls.TabIndex = 1;
        introductionToControls.TabStop  = false;
        introductionToControls.Text     = "Introduction About Controls";
        // 
        // checkBoxAndRadioButtonAndGroupBoxAndTag
        // 
        checkBoxAndRadioButtonAndGroupBoxAndTag.Location = new System.Drawing.Point(
            250,
            97
        );
        checkBoxAndRadioButtonAndGroupBoxAndTag.Name = "checkBoxAndRadioButtonAndGroupBoxAndTag";
        checkBoxAndRadioButtonAndGroupBoxAndTag.Size = new System.Drawing.Size(
            450,
            50
        );
        checkBoxAndRadioButtonAndGroupBoxAndTag.TabIndex                =  6;
        checkBoxAndRadioButtonAndGroupBoxAndTag.Text                    =  "CheckBox and RadioButton and GroupBox and Tag";
        checkBoxAndRadioButtonAndGroupBoxAndTag.UseVisualStyleBackColor =  true;
        checkBoxAndRadioButtonAndGroupBoxAndTag.Click                   += checkBoxAndRadioButtonAndGroupBoxAndTag_Click;
        // 
        // messageBox
        // 
        messageBox.Location = new System.Drawing.Point(
            25,
            97
        );
        messageBox.Name = "messageBox";
        messageBox.Size = new System.Drawing.Size(
            200,
            50
        );
        messageBox.TabIndex                =  5;
        messageBox.Text                    =  "Message Box";
        messageBox.UseVisualStyleBackColor =  true;
        messageBox.Click                   += messageBox_Click;
        // 
        // newForms
        // 
        newForms.Location = new System.Drawing.Point(
            575,
            25
        );
        newForms.Name = "newForms";
        newForms.Size = new System.Drawing.Size(
            125,
            50
        );
        newForms.TabIndex                =  4;
        newForms.Text                    =  "New Forms";
        newForms.UseVisualStyleBackColor =  true;
        newForms.Click                   += newForms_Click;
        // 
        // flatAppearance
        // 
        flatAppearance.Location = new System.Drawing.Point(
            375,
            25
        );
        flatAppearance.Name = "flatAppearance";
        flatAppearance.Size = new System.Drawing.Size(
            175,
            50
        );
        flatAppearance.TabIndex                =  3;
        flatAppearance.Text                    =  "Flat Appearance";
        flatAppearance.UseVisualStyleBackColor =  true;
        flatAppearance.Click                   += flatAppearance_Click;
        // 
        // textBoxesAndButtonsAndFormsAndLabels
        // 
        textBoxesAndButtonsAndFormsAndLabels.Location = new System.Drawing.Point(
            25,
            25
        );
        textBoxesAndButtonsAndFormsAndLabels.Name = "textBoxesAndButtonsAndFormsAndLabels";
        textBoxesAndButtonsAndFormsAndLabels.Size = new System.Drawing.Size(
            325,
            50
        );
        textBoxesAndButtonsAndFormsAndLabels.TabIndex                =  2;
        textBoxesAndButtonsAndFormsAndLabels.Text                    =  "TextBoxes and Buttons and Forms and Labels";
        textBoxesAndButtonsAndFormsAndLabels.UseVisualStyleBackColor =  true;
        textBoxesAndButtonsAndFormsAndLabels.Click                   += textBoxesAndButtonsAndFormsAndLabels_Click;
        // 
        // numericUpDown
        // 
        numericUpDown.Location = new System.Drawing.Point(
            50,
            625
        );
        numericUpDown.Name = "numericUpDown";
        numericUpDown.Size = new System.Drawing.Size(
            150,
            50
        );
        numericUpDown.TabIndex                =  24;
        numericUpDown.Text                    =  "NumericUpDown";
        numericUpDown.UseVisualStyleBackColor =  true;
        numericUpDown.Click                   += numericUpDown_Click;
        // 
        // tabControl
        // 
        tabControl.Location = new System.Drawing.Point(
            33,
            25
        );
        tabControl.Name = "tabControl";
        tabControl.Size = new System.Drawing.Size(
            142,
            50
        );
        tabControl.TabIndex                =  26;
        tabControl.Text                    =  "TabControl";
        tabControl.UseVisualStyleBackColor =  true;
        tabControl.Click                   += tabControl_Click;
        // 
        // panel
        // 
        panel.Location = new System.Drawing.Point(
            200,
            25
        );
        panel.Name = "panel";
        panel.Size = new System.Drawing.Size(
            94,
            50
        );
        panel.TabIndex                =  27;
        panel.Text                    =  "Panel";
        panel.UseVisualStyleBackColor =  true;
        panel.Click                   += panel_Click;
        // 
        // containers
        // 
        containers.Controls.Add(
            panel
        );
        containers.Controls.Add(
            tabControl
        );
        containers.Location = new System.Drawing.Point(
            225,
            600
        );
        containers.Name = "containers";
        containers.Size = new System.Drawing.Size(
            325,
            100
        );
        containers.TabIndex = 25;
        containers.TabStop  = false;
        containers.Text     = "Containers";
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
            776
        );
        Controls.Add(
            containers
        );
        Controls.Add(
            numericUpDown
        );
        Controls.Add(
            introductionToControls
        );
        Controls.Add(
            trackBar
        );
        Controls.Add(
            errorProvider
        );
        Controls.Add(
            listView
        );
        Controls.Add(
            progressBar
        );
        Controls.Add(
            treeViewAndImageList
        );
        Controls.Add(
            notifyIcon
        );
        Controls.Add(
            timer
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
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Windows Forms Concepts";
        dateTimeControls.ResumeLayout(
            false
        );
        introductionToControls.ResumeLayout(
            false
        );
        containers.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.GroupBox containers;

    private System.Windows.Forms.Button panel;

    private System.Windows.Forms.Button tabControl;

    private System.Windows.Forms.Button numericUpDown;

    private System.Windows.Forms.Button checkBoxAndRadioButtonAndGroupBoxAndTag;

    private System.Windows.Forms.Button messageBox;

    private System.Windows.Forms.Button flatAppearance;

    private System.Windows.Forms.Button newForms;

    private System.Windows.Forms.GroupBox introductionToControls;

    private System.Windows.Forms.Button   textBoxesAndButtonsAndFormsAndLabels;

    private System.Windows.Forms.Button trackBar;

    private System.Windows.Forms.Button errorProvider;

    private System.Windows.Forms.Button listView;

    private System.Windows.Forms.Button progressBar;

    private System.Windows.Forms.Button treeViewAndImageList;

    private System.Windows.Forms.Button notifyIcon;

    private System.Windows.Forms.Button timer;

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

    private System.Windows.Forms.Label title;

    #endregion
}