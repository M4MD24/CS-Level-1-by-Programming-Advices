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
            submitCheckBoxStatus
        );
        Controls.Add(
            checkBoxExample
        );
        Controls.Add(
            title
        );
        Text = "CheckBox and RadioButton and GroupBox and Tag";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button submitCheckBoxStatus;

    private System.Windows.Forms.CheckBox checkBoxExample;

    private System.Windows.Forms.Label title;

    #endregion
}