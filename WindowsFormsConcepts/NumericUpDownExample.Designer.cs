using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class NumericUpDownExample {
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
        title         = new System.Windows.Forms.Label();
        numericUpDown = new System.Windows.Forms.NumericUpDown();
        counter       = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize) numericUpDown).BeginInit();
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
        title.ForeColor = System.Drawing.Color.DarkViolet;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            350,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "NumericUpDown";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // numericUpDown
        // 
        numericUpDown.Location = new System.Drawing.Point(
            150,
            190
        );
        numericUpDown.Maximum = new decimal(
            new int[] {
                276447231,
                23283,
                0,
                0
            }
        );
        numericUpDown.Minimum = new decimal(
            new int[] {
                276447231,
                23283,
                0,
                -2147483648
            }
        );
        numericUpDown.Name = "numericUpDown";
        numericUpDown.Size = new System.Drawing.Size(
            150,
            23
        );
        numericUpDown.TabIndex     =  2;
        numericUpDown.TextAlign    =  System.Windows.Forms.HorizontalAlignment.Center;
        numericUpDown.ValueChanged += numericUpDown_ValueChanged;
        // 
        // counter
        // 
        counter.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        counter.ForeColor = System.Drawing.Color.DarkViolet;
        counter.Location = new System.Drawing.Point(
            150,
            129
        );
        counter.Name = "counter";
        counter.Size = new System.Drawing.Size(
            150,
            30
        );
        counter.TabIndex  = 1;
        counter.Text      = "0";
        counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // NumericUpDownExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            434,
            261
        );
        Controls.Add(
            counter
        );
        Controls.Add(
            numericUpDown
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "NumericUpDown";
        ((System.ComponentModel.ISupportInitialize) numericUpDown).EndInit();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label counter;

    private System.Windows.Forms.NumericUpDown numericUpDown;

    private System.Windows.Forms.Label title;

    #endregion
}