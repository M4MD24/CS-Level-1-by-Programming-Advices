using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class MaskedTextBoxExample {
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
        title                                 = new System.Windows.Forms.Label();
        maskedTextBoxWithShortDate            = new System.Windows.Forms.MaskedTextBox();
        maskedTextBoxWithCustomAndBeepOnError = new System.Windows.Forms.MaskedTextBox();
        submit                                = new System.Windows.Forms.Button();
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
        title.ForeColor = System.Drawing.Color.CornflowerBlue;
        title.Location = new System.Drawing.Point(
            225,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            350,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "MaskedTextBox";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // maskedTextBoxWithShortDate
        // 
        maskedTextBoxWithShortDate.Location = new System.Drawing.Point(
            50,
            100
        );
        maskedTextBoxWithShortDate.Mask = "00/00/0000";
        maskedTextBoxWithShortDate.Name = "maskedTextBoxWithShortDate";
        maskedTextBoxWithShortDate.Size = new System.Drawing.Size(
            100,
            23
        );
        maskedTextBoxWithShortDate.TabIndex       = 1;
        maskedTextBoxWithShortDate.ValidatingType = typeof(System.DateTime);
        // 
        // maskedTextBoxWithCustomAndBeepOnError
        // 
        maskedTextBoxWithCustomAndBeepOnError.BeepOnError = true;
        maskedTextBoxWithCustomAndBeepOnError.Location = new System.Drawing.Point(
            50,
            175
        );
        maskedTextBoxWithCustomAndBeepOnError.Mask = "00/00/1400";
        maskedTextBoxWithCustomAndBeepOnError.Name = "maskedTextBoxWithCustomAndBeepOnError";
        maskedTextBoxWithCustomAndBeepOnError.Size = new System.Drawing.Size(
            150,
            23
        );
        maskedTextBoxWithCustomAndBeepOnError.TabIndex = 2;
        // 
        // submit
        // 
        submit.Location = new System.Drawing.Point(
            50,
            210
        );
        submit.Name = "submit";
        submit.Size = new System.Drawing.Size(
            100,
            25
        );
        submit.TabIndex                =  3;
        submit.Text                    =  "Submit";
        submit.UseVisualStyleBackColor =  true;
        submit.Click                   += submit_Click;
        // 
        // MaskedTextBoxExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            784,
            361
        );
        Controls.Add(
            submit
        );
        Controls.Add(
            maskedTextBoxWithCustomAndBeepOnError
        );
        Controls.Add(
            maskedTextBoxWithShortDate
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "MaskedTextBox";
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Button submit;

    private System.Windows.Forms.MaskedTextBox maskedTextBoxWithCustomAndBeepOnError;

    private System.Windows.Forms.MaskedTextBox maskedTextBoxWithShortDate;

    private System.Windows.Forms.Label title;

    #endregion
}