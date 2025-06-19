using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class TabControlExample {
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
        title                 = new System.Windows.Forms.Label();
        tabControl            = new System.Windows.Forms.TabControl();
        enterInformation      = new System.Windows.Forms.TabPage();
        secondNameQuestion    = new System.Windows.Forms.Label();
        secondNameAnswer      = new System.Windows.Forms.TextBox();
        firstNameQuestion     = new System.Windows.Forms.Label();
        firstNameAnswer       = new System.Windows.Forms.TextBox();
        information           = new System.Windows.Forms.TabPage();
        firstName             = new System.Windows.Forms.Label();
        secondName            = new System.Windows.Forms.Label();
        secondNameInformation = new System.Windows.Forms.Label();
        firstNameInformation  = new System.Windows.Forms.Label();
        settings              = new System.Windows.Forms.TabPage();
        clear                 = new System.Windows.Forms.Button();
        tabControl.SuspendLayout();
        enterInformation.SuspendLayout();
        information.SuspendLayout();
        settings.SuspendLayout();
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Segoe UI",
            27F,
            System.Drawing.FontStyle.Bold
        );
        title.ForeColor = System.Drawing.Color.RosyBrown;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            350,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "TabControl";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(
            enterInformation
        );
        tabControl.Controls.Add(
            information
        );
        tabControl.Controls.Add(
            settings
        );
        tabControl.ItemSize = new System.Drawing.Size(
            75,
            25
        );
        tabControl.Location = new System.Drawing.Point(
            50,
            100
        );
        tabControl.Name          = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new System.Drawing.Size(
            350,
            150
        );
        tabControl.TabIndex = 1;
        // 
        // enterInformation
        // 
        enterInformation.Controls.Add(
            secondNameQuestion
        );
        enterInformation.Controls.Add(
            secondNameAnswer
        );
        enterInformation.Controls.Add(
            firstNameQuestion
        );
        enterInformation.Controls.Add(
            firstNameAnswer
        );
        enterInformation.Location = new System.Drawing.Point(
            4,
            29
        );
        enterInformation.Name = "enterInformation";
        enterInformation.Padding = new System.Windows.Forms.Padding(
            3
        );
        enterInformation.Size = new System.Drawing.Size(
            342,
            117
        );
        enterInformation.TabIndex                = 0;
        enterInformation.Text                    = "Enter Information";
        enterInformation.UseVisualStyleBackColor = true;
        // 
        // secondNameQuestion
        // 
        secondNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        secondNameQuestion.Location = new System.Drawing.Point(
            25,
            65
        );
        secondNameQuestion.Name = "secondNameQuestion";
        secondNameQuestion.Size = new System.Drawing.Size(
            90,
            23
        );
        secondNameQuestion.TabIndex  = 4;
        secondNameQuestion.Text      = "Second Name:";
        secondNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // secondNameAnswer
        // 
        secondNameAnswer.Location = new System.Drawing.Point(
            125,
            65
        );
        secondNameAnswer.Name = "secondNameAnswer";
        secondNameAnswer.Size = new System.Drawing.Size(
            185,
            23
        );
        secondNameAnswer.TabIndex    =  5;
        secondNameAnswer.TextChanged += secondNameAnswer_TextChanged;
        // 
        // firstNameQuestion
        // 
        firstNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        firstNameQuestion.Location = new System.Drawing.Point(
            25,
            25
        );
        firstNameQuestion.Name = "firstNameQuestion";
        firstNameQuestion.Size = new System.Drawing.Size(
            70,
            23
        );
        firstNameQuestion.TabIndex  = 2;
        firstNameQuestion.Text      = "First Name:";
        firstNameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // firstNameAnswer
        // 
        firstNameAnswer.Location = new System.Drawing.Point(
            125,
            25
        );
        firstNameAnswer.Name = "firstNameAnswer";
        firstNameAnswer.Size = new System.Drawing.Size(
            185,
            23
        );
        firstNameAnswer.TabIndex    =  3;
        firstNameAnswer.TextChanged += firstNameAnswer_TextChanged;
        // 
        // information
        // 
        information.Controls.Add(
            firstName
        );
        information.Controls.Add(
            secondName
        );
        information.Controls.Add(
            secondNameInformation
        );
        information.Controls.Add(
            firstNameInformation
        );
        information.Location = new System.Drawing.Point(
            4,
            29
        );
        information.Name = "information";
        information.Padding = new System.Windows.Forms.Padding(
            3
        );
        information.Size = new System.Drawing.Size(
            342,
            117
        );
        information.TabIndex                = 1;
        information.Text                    = "Information";
        information.UseVisualStyleBackColor = true;
        // 
        // firstName
        // 
        firstName.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        firstName.Location = new System.Drawing.Point(
            125,
            25
        );
        firstName.Name = "firstName";
        firstName.Size = new System.Drawing.Size(
            185,
            23
        );
        firstName.TabIndex  = 7;
        firstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // secondName
        // 
        secondName.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        secondName.Location = new System.Drawing.Point(
            125,
            65
        );
        secondName.Name = "secondName";
        secondName.Size = new System.Drawing.Size(
            185,
            23
        );
        secondName.TabIndex  = 9;
        secondName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // secondNameInformation
        // 
        secondNameInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        secondNameInformation.Location = new System.Drawing.Point(
            25,
            65
        );
        secondNameInformation.Name = "secondNameInformation";
        secondNameInformation.Size = new System.Drawing.Size(
            90,
            23
        );
        secondNameInformation.TabIndex  = 8;
        secondNameInformation.Text      = "Second Name:";
        secondNameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // firstNameInformation
        // 
        firstNameInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        firstNameInformation.Location = new System.Drawing.Point(
            25,
            25
        );
        firstNameInformation.Name = "firstNameInformation";
        firstNameInformation.Size = new System.Drawing.Size(
            70,
            23
        );
        firstNameInformation.TabIndex  = 6;
        firstNameInformation.Text      = "First Name:";
        firstNameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // settings
        // 
        settings.Controls.Add(
            clear
        );
        settings.Location = new System.Drawing.Point(
            4,
            29
        );
        settings.Name = "settings";
        settings.Padding = new System.Windows.Forms.Padding(
            3
        );
        settings.Size = new System.Drawing.Size(
            342,
            117
        );
        settings.TabIndex                = 2;
        settings.Text                    = "Settings";
        settings.UseVisualStyleBackColor = true;
        // 
        // clear
        // 
        clear.Location = new System.Drawing.Point(
            118,
            30
        );
        clear.Name = "clear";
        clear.Size = new System.Drawing.Size(
            100,
            51
        );
        clear.TabIndex                =  10;
        clear.Text                    =  "Clear";
        clear.UseVisualStyleBackColor =  true;
        clear.Click                   += clear_Click;
        // 
        // TabControlExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            434,
            286
        );
        Controls.Add(
            tabControl
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "TabControl";
        tabControl.ResumeLayout(
            false
        );
        enterInformation.ResumeLayout(
            false
        );
        enterInformation.PerformLayout();
        information.ResumeLayout(
            false
        );
        settings.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label  firstName;
    private System.Windows.Forms.Button clear;

    private System.Windows.Forms.Label secondName;

    private System.Windows.Forms.Label secondNameInformation;
    private System.Windows.Forms.Label firstNameInformation;

    private System.Windows.Forms.Label   secondNameQuestion;
    private System.Windows.Forms.TextBox secondNameAnswer;

    private System.Windows.Forms.Label firstNameQuestion;

    private System.Windows.Forms.TextBox firstNameAnswer;

    private System.Windows.Forms.TabPage settings;

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage    enterInformation;
    private System.Windows.Forms.TabPage    information;

    private System.Windows.Forms.Label title;

    #endregion
}