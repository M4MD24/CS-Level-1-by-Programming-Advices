using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class TextBoxExample {
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
        textBoxWithPasswordCharacter           = new System.Windows.Forms.TextBox();
        title                                  = new System.Windows.Forms.Label();
        textBoxWithReadOnly                    = new System.Windows.Forms.TextBox();
        textBoxWithMaximumLength               = new System.Windows.Forms.TextBox();
        textBoxWithRightToLeft                 = new System.Windows.Forms.TextBox();
        textBoxWithTextAlignment               = new System.Windows.Forms.TextBox();
        textBoxWithMultiline                   = new System.Windows.Forms.TextBox();
        textBoxWithMultilineAndWithoutWordWrap = new System.Windows.Forms.TextBox();
        textBoxesWithDocks                     = new System.Windows.Forms.GroupBox();
        textBox5                               = new System.Windows.Forms.TextBox();
        textBox4                               = new System.Windows.Forms.TextBox();
        textBox3                               = new System.Windows.Forms.TextBox();
        textBox2                               = new System.Windows.Forms.TextBox();
        textBox1                               = new System.Windows.Forms.TextBox();
        focus                                  = new System.Windows.Forms.Button();
        textBoxesWithDocks.SuspendLayout();
        SuspendLayout();
        // 
        // textBoxWithPasswordCharacter
        // 
        textBoxWithPasswordCharacter.Location = new System.Drawing.Point(
            50,
            125
        );
        textBoxWithPasswordCharacter.Name         = "textBoxWithPasswordCharacter";
        textBoxWithPasswordCharacter.PasswordChar = '-';
        textBoxWithPasswordCharacter.Size = new System.Drawing.Size(
            200,
            23
        );
        textBoxWithPasswordCharacter.TabIndex = 0;
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
        title.ForeColor = System.Drawing.Color.ForestGreen;
        title.Location = new System.Drawing.Point(
            300,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            200,
            50
        );
        title.TabIndex  = 1;
        title.Text      = "TextBox";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBoxWithReadOnly
        // 
        textBoxWithReadOnly.Location = new System.Drawing.Point(
            50,
            175
        );
        textBoxWithReadOnly.Name     = "textBoxWithReadOnly";
        textBoxWithReadOnly.ReadOnly = true;
        textBoxWithReadOnly.Size = new System.Drawing.Size(
            200,
            23
        );
        textBoxWithReadOnly.TabIndex = 2;
        textBoxWithReadOnly.Text     = "Mohamed Sadawy";
        // 
        // textBoxWithMaximumLength
        // 
        textBoxWithMaximumLength.Location = new System.Drawing.Point(
            50,
            225
        );
        textBoxWithMaximumLength.MaxLength = 20;
        textBoxWithMaximumLength.Name      = "textBoxWithMaximumLength";
        textBoxWithMaximumLength.Size = new System.Drawing.Size(
            200,
            23
        );
        textBoxWithMaximumLength.TabIndex = 3;
        // 
        // textBoxWithRightToLeft
        // 
        textBoxWithRightToLeft.Location = new System.Drawing.Point(
            50,
            275
        );
        textBoxWithRightToLeft.Name        = "textBoxWithRightToLeft";
        textBoxWithRightToLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        textBoxWithRightToLeft.Size = new System.Drawing.Size(
            200,
            23
        );
        textBoxWithRightToLeft.TabIndex = 4;
        // 
        // textBoxWithTextAlignment
        // 
        textBoxWithTextAlignment.Location = new System.Drawing.Point(
            50,
            325
        );
        textBoxWithTextAlignment.Name = "textBoxWithTextAlignment";
        textBoxWithTextAlignment.Size = new System.Drawing.Size(
            200,
            23
        );
        textBoxWithTextAlignment.TabIndex  = 5;
        textBoxWithTextAlignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBoxWithMultiline
        // 
        textBoxWithMultiline.Location = new System.Drawing.Point(
            300,
            125
        );
        textBoxWithMultiline.Multiline = true;
        textBoxWithMultiline.Name      = "textBoxWithMultiline";
        textBoxWithMultiline.Size = new System.Drawing.Size(
            200,
            123
        );
        textBoxWithMultiline.TabIndex = 6;
        // 
        // textBoxWithMultilineAndWithoutWordWrap
        // 
        textBoxWithMultilineAndWithoutWordWrap.Location = new System.Drawing.Point(
            300,
            275
        );
        textBoxWithMultilineAndWithoutWordWrap.Multiline = true;
        textBoxWithMultilineAndWithoutWordWrap.Name      = "textBoxWithMultilineAndWithoutWordWrap";
        textBoxWithMultilineAndWithoutWordWrap.Size = new System.Drawing.Size(
            200,
            123
        );
        textBoxWithMultilineAndWithoutWordWrap.TabIndex = 7;
        textBoxWithMultilineAndWithoutWordWrap.WordWrap = false;
        // 
        // textBoxesWithDocks
        // 
        textBoxesWithDocks.Controls.Add(
            textBox5
        );
        textBoxesWithDocks.Controls.Add(
            textBox4
        );
        textBoxesWithDocks.Controls.Add(
            textBox3
        );
        textBoxesWithDocks.Controls.Add(
            textBox2
        );
        textBoxesWithDocks.Controls.Add(
            textBox1
        );
        textBoxesWithDocks.Location = new System.Drawing.Point(
            550,
            125
        );
        textBoxesWithDocks.Name = "textBoxesWithDocks";
        textBoxesWithDocks.Size = new System.Drawing.Size(
            200,
            92
        );
        textBoxesWithDocks.TabIndex = 8;
        textBoxesWithDocks.TabStop  = false;
        textBoxesWithDocks.Text     = "TextBoxes with Docks";
        // 
        // textBox5
        // 
        textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
        textBox5.Location = new System.Drawing.Point(
            53,
            42
        );
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(
            94,
            23
        );
        textBox5.TabIndex = 13;
        // 
        // textBox4
        // 
        textBox4.Dock = System.Windows.Forms.DockStyle.Right;
        textBox4.Location = new System.Drawing.Point(
            147,
            42
        );
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(
            50,
            23
        );
        textBox4.TabIndex = 12;
        // 
        // textBox3
        // 
        textBox3.Dock = System.Windows.Forms.DockStyle.Left;
        textBox3.Location = new System.Drawing.Point(
            3,
            42
        );
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(
            50,
            23
        );
        textBox3.TabIndex = 11;
        // 
        // textBox2
        // 
        textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
        textBox2.Location = new System.Drawing.Point(
            3,
            66
        );
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(
            194,
            23
        );
        textBox2.TabIndex = 10;
        // 
        // textBox1
        // 
        textBox1.Dock = System.Windows.Forms.DockStyle.Top;
        textBox1.Location = new System.Drawing.Point(
            3,
            19
        );
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(
            194,
            23
        );
        textBox1.TabIndex = 9;
        // 
        // focus
        // 
        focus.Location = new System.Drawing.Point(
            650,
            373
        );
        focus.Name = "focus";
        focus.Size = new System.Drawing.Size(
            100,
            25
        );
        focus.TabIndex                =  9;
        focus.Text                    =  "Focus";
        focus.UseVisualStyleBackColor =  true;
        focus.Click                   += focus_Click;
        // 
        // TextBoxExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            784,
            461
        );
        Controls.Add(
            focus
        );
        Controls.Add(
            textBoxesWithDocks
        );
        Controls.Add(
            textBoxWithMultilineAndWithoutWordWrap
        );
        Controls.Add(
            textBoxWithMultiline
        );
        Controls.Add(
            textBoxWithTextAlignment
        );
        Controls.Add(
            textBoxWithRightToLeft
        );
        Controls.Add(
            textBoxWithMaximumLength
        );
        Controls.Add(
            textBoxWithReadOnly
        );
        Controls.Add(
            title
        );
        Controls.Add(
            textBoxWithPasswordCharacter
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "TextBox";
        textBoxesWithDocks.ResumeLayout(
            false
        );
        textBoxesWithDocks.PerformLayout();
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Button focus;

    private System.Windows.Forms.GroupBox textBoxesWithDocks;

    private System.Windows.Forms.TextBox textBox5;

    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.TextBox textBoxWithMultilineAndWithoutWordWrap;

    private System.Windows.Forms.TextBox textBoxWithMultiline;

    private System.Windows.Forms.TextBox textBoxWithTextAlignment;

    private System.Windows.Forms.TextBox textBoxWithRightToLeft;

    private System.Windows.Forms.TextBox textBoxWithMaximumLength;

    private System.Windows.Forms.TextBox textBoxWithReadOnly;

    private System.Windows.Forms.TextBox textBoxWithPasswordCharacter;
    private System.Windows.Forms.Label   title;

    #endregion
}