namespace PizzaOrderSystem;

partial class Main {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(
            typeof(Main)
        );
        title = new System.Windows.Forms.Label();
        SuspendLayout();
        //
        // title
        //
        title.Font = new System.Drawing.Font(
            "Corbel",
            30F,
            ((System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)),
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        title.ForeColor = System.Drawing.Color.DarkOrange;
        title.Location = new System.Drawing.Point(
            350,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            300,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Make Your Pizza";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // Main
        //
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            984,
            561
        );
        Controls.Add(
            title
        );
        Icon = ((System.Drawing.Icon) resources.GetObject(
                       "$this.Icon"
                   ));
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Pizza Order System";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label title;

    #endregion
}