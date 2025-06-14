namespace DisplayArrowDirection;

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
        name            = new System.Windows.Forms.Label();
        image           = new System.Windows.Forms.PictureBox();
        arrowDirections = new System.Windows.Forms.ComboBox();
        ((System.ComponentModel.ISupportInitialize) image).BeginInit();
        SuspendLayout();
        // 
        // name
        // 
        name.Font = new System.Drawing.Font(
            "Segoe UI",
            20.25F,
            System.Drawing.FontStyle.Bold
        );
        name.Location = new System.Drawing.Point(
            125,
            0
        );
        name.Name = "name";
        name.Size = new System.Drawing.Size(
            150,
            50
        );
        name.TabIndex  = 0;
        name.Text      = "Unknown";
        name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // image
        // 
        image.Location = new System.Drawing.Point(
            50,
            50
        );
        image.Name = "image";
        image.Size = new System.Drawing.Size(
            300,
            300
        );
        image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        image.TabIndex = 1;
        image.TabStop  = false;
        // 
        // arrowDirections
        // 
        arrowDirections.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
        arrowDirections.FormattingEnabled = true;
        arrowDirections.Location = new System.Drawing.Point(
            100,
            365
        );
        arrowDirections.Name = "arrowDirections";
        arrowDirections.Size = new System.Drawing.Size(
            200,
            23
        );
        arrowDirections.TabIndex             =  2;
        arrowDirections.SelectedIndexChanged += arrowDirections_SelectedIndexChanged;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            384,
            411
        );
        Controls.Add(
            arrowDirections
        );
        Controls.Add(
            image
        );
        Controls.Add(
            name
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "Display Arrow Direction";
        Load          += Main_Load;
        ((System.ComponentModel.ISupportInitialize) image).EndInit();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.ComboBox arrowDirections;

    private System.Windows.Forms.PictureBox image;

    private System.Windows.Forms.Label name;

    #endregion
}