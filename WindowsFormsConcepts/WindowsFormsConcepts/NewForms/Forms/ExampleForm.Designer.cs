using System.ComponentModel;

namespace WindowsFormsConcepts.Forms;

partial class ExampleForm {
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
        title = new System.Windows.Forms.Label();
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
        title.ForeColor = System.Drawing.Color.Navy;
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
        title.Text      = "Example Form";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ExampleForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            384,
            161
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Example Form";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label title;

    #endregion
}