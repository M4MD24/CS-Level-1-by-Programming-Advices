using System.ComponentModel;

namespace WindowsFormsConcepts.IntroductionAboutControls;

partial class NewForms {
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
        title          = new System.Windows.Forms.Label();
        showForm       = new System.Windows.Forms.Button();
        showDialogForm = new System.Windows.Forms.Button();
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
        title.ForeColor = System.Drawing.Color.Chocolate;
        title.Location = new System.Drawing.Point(
            50,
            50
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            300,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "New Forms";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // showForm
        // 
        showForm.Location = new System.Drawing.Point(
            50,
            176
        );
        showForm.Name = "showForm";
        showForm.Size = new System.Drawing.Size(
            100,
            50
        );
        showForm.TabIndex                =  1;
        showForm.Text                    =  "Show Form";
        showForm.UseVisualStyleBackColor =  true;
        showForm.Click                   += showForm_Click;
        // 
        // showDialogForm
        // 
        showDialogForm.Location = new System.Drawing.Point(
            225,
            176
        );
        showDialogForm.Name = "showDialogForm";
        showDialogForm.Size = new System.Drawing.Size(
            125,
            50
        );
        showDialogForm.TabIndex                =  2;
        showDialogForm.Text                    =  "Show Dialog Form";
        showDialogForm.UseVisualStyleBackColor =  true;
        showDialogForm.Click                   += showDialogForm_Click;
        // 
        // NewForms
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            384,
            261
        );
        Controls.Add(
            showDialogForm
        );
        Controls.Add(
            showForm
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "New Forms";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button showDialogForm;

    private System.Windows.Forms.Button showForm;

    private System.Windows.Forms.Label title;

    #endregion
}