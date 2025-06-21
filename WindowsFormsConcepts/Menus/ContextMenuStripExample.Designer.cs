using System.ComponentModel;

namespace WindowsFormsConcepts.Menus;

partial class ContextMenuStripExample {
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
        components    = new System.ComponentModel.Container();
        title         = new System.Windows.Forms.Label();
        firstTextBox  = new System.Windows.Forms.TextBox();
        secondTextBox = new System.Windows.Forms.TextBox();
        contextMenuStripForTextBoxes = new System.Windows.Forms.ContextMenuStrip(
            components
        );
        contextMenuStripForForm = new System.Windows.Forms.ContextMenuStrip(
            components
        );
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
        title.ForeColor = System.Drawing.Color.MediumVioletRed;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            400,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "ContextMenuStrip";
        title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // firstTextBox
        // 
        firstTextBox.Location = new System.Drawing.Point(
            150,
            147
        );
        firstTextBox.Name = "firstTextBox";
        firstTextBox.Size = new System.Drawing.Size(
            200,
            23
        );
        firstTextBox.TabIndex = 1;
        // 
        // secondTextBox
        // 
        secondTextBox.Location = new System.Drawing.Point(
            150,
            200
        );
        secondTextBox.Name = "secondTextBox";
        secondTextBox.Size = new System.Drawing.Size(
            200,
            23
        );
        secondTextBox.TabIndex = 2;
        // 
        // contextMenuStripForTextBoxes
        // 
        contextMenuStripForTextBoxes.Name = "contextMenuStripForTextBoxes";
        contextMenuStripForTextBoxes.Size = new System.Drawing.Size(
            61,
            4
        );
        // 
        // contextMenuStripForForm
        // 
        contextMenuStripForForm.Name = "contextMenuStripForForm";
        contextMenuStripForForm.Size = new System.Drawing.Size(
            181,
            26
        );
        // 
        // ContextMenuStripExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            484,
            336
        );
        Controls.Add(
            secondTextBox
        );
        Controls.Add(
            firstTextBox
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "ContextMenuExample";
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ContextMenuStrip contextMenuStripForForm;

    private System.Windows.Forms.ContextMenuStrip contextMenuStripForTextBoxes;

    private System.Windows.Forms.TextBox secondTextBox;

    private System.Windows.Forms.TextBox firstTextBox;

    private System.Windows.Forms.Label title;

    #endregion
}