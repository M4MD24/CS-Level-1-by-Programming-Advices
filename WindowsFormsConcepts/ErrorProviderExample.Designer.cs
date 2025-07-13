using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class ErrorProviderExample {
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
        components = new System.ComponentModel.Container();
        title      = new System.Windows.Forms.Label();
        errorProviderSample = new System.Windows.Forms.ErrorProvider(
            components
        );
        firstNameAnswer    = new System.Windows.Forms.TextBox();
        secondNameAnswer   = new System.Windows.Forms.TextBox();
        firstNameQuestion  = new System.Windows.Forms.Label();
        secondNameQuestion = new System.Windows.Forms.Label();
        fullName           = new System.Windows.Forms.GroupBox();
        ((System.ComponentModel.ISupportInitialize) errorProviderSample).BeginInit();
        fullName.SuspendLayout();
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
        title.ForeColor = System.Drawing.Color.HotPink;
        title.Location = new System.Drawing.Point(
            75,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            350,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "ErrorProvider";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // errorProviderSample
        // 
        errorProviderSample.ContainerControl = this;
        // 
        // firstNameAnswer
        // 
        firstNameAnswer.Location = new System.Drawing.Point(
            135,
            30
        );
        firstNameAnswer.Name = "firstNameAnswer";
        firstNameAnswer.Size = new System.Drawing.Size(
            180,
            23
        );
        firstNameAnswer.TabIndex   =  2;
        firstNameAnswer.Validating += firstNameAnswer_Validating;
        // 
        // secondNameAnswer
        // 
        secondNameAnswer.Location = new System.Drawing.Point(
            135,
            70
        );
        secondNameAnswer.Name = "secondNameAnswer";
        secondNameAnswer.Size = new System.Drawing.Size(
            180,
            23
        );
        secondNameAnswer.TabIndex   =  4;
        secondNameAnswer.Validating += secondNameAnswer_Validating;
        // 
        // firstNameQuestion
        // 
        firstNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        firstNameQuestion.Location = new System.Drawing.Point(
            25,
            30
        );
        firstNameQuestion.Name = "firstNameQuestion";
        firstNameQuestion.Size = new System.Drawing.Size(
            103,
            23
        );
        firstNameQuestion.TabIndex = 1;
        firstNameQuestion.Text     = "First Name:";
        // 
        // secondNameQuestion
        // 
        secondNameQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            10F
        );
        secondNameQuestion.Location = new System.Drawing.Point(
            25,
            70
        );
        secondNameQuestion.Name = "secondNameQuestion";
        secondNameQuestion.Size = new System.Drawing.Size(
            100,
            23
        );
        secondNameQuestion.TabIndex = 3;
        secondNameQuestion.Text     = "Second Name:";
        // 
        // fullName
        // 
        fullName.Controls.Add(
            secondNameQuestion
        );
        fullName.Controls.Add(
            firstNameAnswer
        );
        fullName.Controls.Add(
            firstNameQuestion
        );
        fullName.Controls.Add(
            secondNameAnswer
        );
        fullName.Location = new System.Drawing.Point(
            75,
            125
        );
        fullName.Name = "fullName";
        fullName.Size = new System.Drawing.Size(
            350,
            115
        );
        fullName.TabIndex = 6;
        fullName.TabStop  = false;
        fullName.Text     = "Full Name";
        // 
        // ErrorProviderExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            484,
            286
        );
        Controls.Add(
            fullName
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "ErrorProvider";
        ((System.ComponentModel.ISupportInitialize) errorProviderSample).EndInit();
        fullName.ResumeLayout(
            false
        );
        fullName.PerformLayout();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.TextBox secondNameAnswer;

    private System.Windows.Forms.Label    firstNameQuestion;
    private System.Windows.Forms.GroupBox fullName;

    private System.Windows.Forms.TextBox firstNameAnswer;
    private System.Windows.Forms.Label   secondNameQuestion;

    private System.Windows.Forms.ErrorProvider errorProviderSample;

    private System.Windows.Forms.Label title;

    #endregion
}