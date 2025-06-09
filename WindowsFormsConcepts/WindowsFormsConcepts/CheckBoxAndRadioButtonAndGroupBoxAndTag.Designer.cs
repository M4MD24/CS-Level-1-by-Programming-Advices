using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class CheckBoxAndRadioButtonAndGroupBoxAndTag {
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
        title                = new System.Windows.Forms.Label();
        checkBoxExample      = new System.Windows.Forms.CheckBox();
        submitCheckBoxStatus = new System.Windows.Forms.Button();
        groupBoxExample      = new System.Windows.Forms.GroupBox();
        thirdChoice          = new System.Windows.Forms.RadioButton();
        secondChoice         = new System.Windows.Forms.RadioButton();
        firstChoice          = new System.Windows.Forms.RadioButton();
        submitChoice         = new System.Windows.Forms.Button();
        groupBoxExample.SuspendLayout();
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
        title.ForeColor = System.Drawing.Color.DeepPink;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            1050,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "CheckBox and RadioButton and GroupBox and Tag";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // checkBoxExample
        // 
        checkBoxExample.Location = new System.Drawing.Point(
            50,
            125
        );
        checkBoxExample.Name = "checkBoxExample";
        checkBoxExample.Size = new System.Drawing.Size(
            125,
            25
        );
        checkBoxExample.TabIndex                =  1;
        checkBoxExample.Text                    =  "CheckBox Example";
        checkBoxExample.UseVisualStyleBackColor =  true;
        checkBoxExample.CheckedChanged          += checkBoxExample_CheckedChanged;
        // 
        // submitCheckBoxStatus
        // 
        submitCheckBoxStatus.Enabled = false;
        submitCheckBoxStatus.Location = new System.Drawing.Point(
            50,
            165
        );
        submitCheckBoxStatus.Name = "submitCheckBoxStatus";
        submitCheckBoxStatus.Size = new System.Drawing.Size(
            150,
            25
        );
        submitCheckBoxStatus.TabIndex                =  2;
        submitCheckBoxStatus.Text                    =  "Submit CheckBox Status";
        submitCheckBoxStatus.UseVisualStyleBackColor =  true;
        submitCheckBoxStatus.Click                   += submitCheckBoxStatus_Click;
        // 
        // groupBoxExample
        // 
        groupBoxExample.Controls.Add(
            thirdChoice
        );
        groupBoxExample.Controls.Add(
            secondChoice
        );
        groupBoxExample.Controls.Add(
            firstChoice
        );
        groupBoxExample.Location = new System.Drawing.Point(
            250,
            125
        );
        groupBoxExample.Name = "groupBoxExample";
        groupBoxExample.Size = new System.Drawing.Size(
            150,
            150
        );
        groupBoxExample.TabIndex = 3;
        groupBoxExample.TabStop  = false;
        groupBoxExample.Text     = "GroupBox Example";
        // 
        // thirdChoice
        // 
        thirdChoice.Location = new System.Drawing.Point(
            25,
            100
        );
        thirdChoice.Name = "thirdChoice";
        thirdChoice.Size = new System.Drawing.Size(
            105,
            25
        );
        thirdChoice.TabIndex                = 2;
        thirdChoice.TabStop                 = true;
        thirdChoice.Text                    = "Third Choice";
        thirdChoice.UseVisualStyleBackColor = true;
        // 
        // secondChoice
        // 
        secondChoice.Location = new System.Drawing.Point(
            25,
            65
        );
        secondChoice.Name = "secondChoice";
        secondChoice.Size = new System.Drawing.Size(
            105,
            25
        );
        secondChoice.TabIndex                = 1;
        secondChoice.TabStop                 = true;
        secondChoice.Text                    = "Second Choice";
        secondChoice.UseVisualStyleBackColor = true;
        // 
        // firstChoice
        // 
        firstChoice.Location = new System.Drawing.Point(
            25,
            30
        );
        firstChoice.Name = "firstChoice";
        firstChoice.Size = new System.Drawing.Size(
            105,
            25
        );
        firstChoice.TabIndex                = 0;
        firstChoice.TabStop                 = true;
        firstChoice.Text                    = "First Choice";
        firstChoice.UseVisualStyleBackColor = true;
        // 
        // submitChoice
        // 
        submitChoice.Location = new System.Drawing.Point(
            275,
            290
        );
        submitChoice.Name = "submitChoice";
        submitChoice.Size = new System.Drawing.Size(
            100,
            25
        );
        submitChoice.TabIndex                =  3;
        submitChoice.Text                    =  "Submit Choice";
        submitChoice.UseVisualStyleBackColor =  true;
        submitChoice.Click                   += submitChoice_Click;
        // 
        // CheckBoxAndRadioButtonAndGroupBoxAndTag
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            1134,
            561
        );
        Controls.Add(
            submitChoice
        );
        Controls.Add(
            groupBoxExample
        );
        Controls.Add(
            submitCheckBoxStatus
        );
        Controls.Add(
            checkBoxExample
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "CheckBox and RadioButton and GroupBox and Tag";
        groupBoxExample.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.RadioButton firstChoice;
    private System.Windows.Forms.RadioButton secondChoice;
    private System.Windows.Forms.RadioButton thirdChoice;
    private System.Windows.Forms.Button      submitChoice;

    private System.Windows.Forms.GroupBox groupBoxExample;

    private System.Windows.Forms.Button submitCheckBoxStatus;

    private System.Windows.Forms.CheckBox checkBoxExample;

    private System.Windows.Forms.Label title;

    #endregion
}