using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class Drawing {
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
        title     = new System.Windows.Forms.Label();
        line      = new System.Windows.Forms.GroupBox();
        rectangle = new System.Windows.Forms.GroupBox();
        ellipse   = new System.Windows.Forms.GroupBox();
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
        title.ForeColor = System.Drawing.Color.CadetBlue;
        title.Location = new System.Drawing.Point(
            275,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            200,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Drawing";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // line
        // 
        line.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        line.Location = new System.Drawing.Point(
            50,
            100
        );
        line.Name = "line";
        line.Size = new System.Drawing.Size(
            300,
            300
        );
        line.TabIndex =  1;
        line.TabStop  =  false;
        line.Text     =  "Line";
        line.Paint    += line_Paint;
        // 
        // rectangle
        // 
        rectangle.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        rectangle.Location = new System.Drawing.Point(
            400,
            100
        );
        rectangle.Name = "rectangle";
        rectangle.Size = new System.Drawing.Size(
            300,
            300
        );
        rectangle.TabIndex =  2;
        rectangle.TabStop  =  false;
        rectangle.Text     =  "Rectangle";
        rectangle.Paint    += rectangle_Paint;
        // 
        // ellipse
        // 
        ellipse.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        ellipse.Location = new System.Drawing.Point(
            50,
            425
        );
        ellipse.Name = "ellipse";
        ellipse.Size = new System.Drawing.Size(
            300,
            300
        );
        ellipse.TabIndex =  3;
        ellipse.TabStop  =  false;
        ellipse.Text     =  "Ellipse";
        ellipse.Paint    += ellipse_Paint;
        // 
        // Drawing
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            734,
            761
        );
        Controls.Add(
            ellipse
        );
        Controls.Add(
            rectangle
        );
        Controls.Add(
            line
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Drawing";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.GroupBox ellipse;

    private System.Windows.Forms.GroupBox rectangle;

    private System.Windows.Forms.GroupBox line;

    private System.Windows.Forms.Label title;

    #endregion
}