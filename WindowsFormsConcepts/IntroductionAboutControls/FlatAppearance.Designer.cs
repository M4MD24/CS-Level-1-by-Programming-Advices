using System.ComponentModel;

namespace WindowsFormsConcepts.IntroductionAboutControls;

partial class FlatAppearance {
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
        title                          = new System.Windows.Forms.Label();
        customButtonWithFlatAppearance = new System.Windows.Forms.Button();
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
        title.ForeColor = System.Drawing.Color.DeepSkyBlue;
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
        title.Text      = "Flat Appearance";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // customButtonWithFlatAppearance
        // 
        customButtonWithFlatAppearance.BackColor                         = System.Drawing.Color.Crimson;
        customButtonWithFlatAppearance.FlatAppearance.BorderColor        = System.Drawing.Color.Black;
        customButtonWithFlatAppearance.FlatAppearance.BorderSize         = 4;
        customButtonWithFlatAppearance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
        customButtonWithFlatAppearance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
        customButtonWithFlatAppearance.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat;
        customButtonWithFlatAppearance.Location = new System.Drawing.Point(
            100,
            275
        );
        customButtonWithFlatAppearance.Name = "customButtonWithFlatAppearance";
        customButtonWithFlatAppearance.Size = new System.Drawing.Size(
            300,
            50
        );
        customButtonWithFlatAppearance.TabIndex                = 1;
        customButtonWithFlatAppearance.Text                    = "Custom Button with Flat Appearance";
        customButtonWithFlatAppearance.UseVisualStyleBackColor = false;
        // 
        // FlatAppearance
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor     = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(
            484,
            361
        );
        Controls.Add(
            customButtonWithFlatAppearance
        );
        Controls.Add(
            title
        );
        Location = new System.Drawing.Point(
            15,
            15
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Flat Appearance";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button customButtonWithFlatAppearance;

    private System.Windows.Forms.Label title;

    #endregion
}