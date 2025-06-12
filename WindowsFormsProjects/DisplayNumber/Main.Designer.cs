namespace DisplayNumber;

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
        image = new System.Windows.Forms.PictureBox();
        zero  = new System.Windows.Forms.RadioButton();
        one   = new System.Windows.Forms.RadioButton();
        two   = new System.Windows.Forms.RadioButton();
        three = new System.Windows.Forms.RadioButton();
        four  = new System.Windows.Forms.RadioButton();
        five  = new System.Windows.Forms.RadioButton();
        six   = new System.Windows.Forms.RadioButton();
        seven = new System.Windows.Forms.RadioButton();
        eight = new System.Windows.Forms.RadioButton();
        nine  = new System.Windows.Forms.RadioButton();
        name  = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize) image).BeginInit();
        SuspendLayout();
        // 
        // image
        // 
        image.Location = new System.Drawing.Point(
            400,
            50
        );
        image.Name = "image";
        image.Size = new System.Drawing.Size(
            300,
            300
        );
        image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        image.TabIndex = 0;
        image.TabStop  = false;
        // 
        // zero
        // 
        zero.Location = new System.Drawing.Point(
            50,
            375
        );
        zero.Name = "zero";
        zero.Size = new System.Drawing.Size(
            75,
            25
        );
        zero.TabIndex                =  1;
        zero.TabStop                 =  true;
        zero.Text                    =  "Zero";
        zero.UseVisualStyleBackColor =  true;
        zero.CheckedChanged          += zero_CheckedChanged;
        // 
        // one
        // 
        one.Location = new System.Drawing.Point(
            150,
            375
        );
        one.Name = "one";
        one.Size = new System.Drawing.Size(
            75,
            25
        );
        one.TabIndex                =  2;
        one.TabStop                 =  true;
        one.Text                    =  "One";
        one.UseVisualStyleBackColor =  true;
        one.CheckedChanged          += one_CheckedChanged;
        // 
        // two
        // 
        two.Location = new System.Drawing.Point(
            250,
            375
        );
        two.Name = "two";
        two.Size = new System.Drawing.Size(
            75,
            25
        );
        two.TabIndex                =  3;
        two.TabStop                 =  true;
        two.Text                    =  "Two";
        two.UseVisualStyleBackColor =  true;
        two.CheckedChanged          += two_CheckedChanged;
        // 
        // three
        // 
        three.Location = new System.Drawing.Point(
            350,
            375
        );
        three.Name = "three";
        three.Size = new System.Drawing.Size(
            75,
            25
        );
        three.TabIndex                =  4;
        three.TabStop                 =  true;
        three.Text                    =  "Three";
        three.UseVisualStyleBackColor =  true;
        three.CheckedChanged          += three_CheckedChanged;
        // 
        // four
        // 
        four.Location = new System.Drawing.Point(
            450,
            375
        );
        four.Name = "four";
        four.Size = new System.Drawing.Size(
            75,
            25
        );
        four.TabIndex                =  5;
        four.TabStop                 =  true;
        four.Text                    =  "Four";
        four.UseVisualStyleBackColor =  true;
        four.CheckedChanged          += four_CheckedChanged;
        // 
        // five
        // 
        five.Location = new System.Drawing.Point(
            550,
            375
        );
        five.Name = "five";
        five.Size = new System.Drawing.Size(
            75,
            25
        );
        five.TabIndex                =  6;
        five.TabStop                 =  true;
        five.Text                    =  "Five";
        five.UseVisualStyleBackColor =  true;
        five.CheckedChanged          += five_CheckedChanged;
        // 
        // six
        // 
        six.Location = new System.Drawing.Point(
            650,
            375
        );
        six.Name = "six";
        six.Size = new System.Drawing.Size(
            75,
            25
        );
        six.TabIndex                =  7;
        six.TabStop                 =  true;
        six.Text                    =  "Six";
        six.UseVisualStyleBackColor =  true;
        six.CheckedChanged          += six_CheckedChanged;
        // 
        // seven
        // 
        seven.Location = new System.Drawing.Point(
            750,
            375
        );
        seven.Name = "seven";
        seven.Size = new System.Drawing.Size(
            75,
            25
        );
        seven.TabIndex                =  8;
        seven.TabStop                 =  true;
        seven.Text                    =  "Seven";
        seven.UseVisualStyleBackColor =  true;
        seven.CheckedChanged          += seven_CheckedChanged;
        // 
        // eight
        // 
        eight.Location = new System.Drawing.Point(
            850,
            375
        );
        eight.Name = "eight";
        eight.Size = new System.Drawing.Size(
            75,
            25
        );
        eight.TabIndex                =  9;
        eight.TabStop                 =  true;
        eight.Text                    =  "Eight";
        eight.UseVisualStyleBackColor =  true;
        eight.CheckedChanged          += eight_CheckedChanged;
        // 
        // nine
        // 
        nine.Location = new System.Drawing.Point(
            950,
            375
        );
        nine.Name = "nine";
        nine.Size = new System.Drawing.Size(
            75,
            25
        );
        nine.TabIndex                =  10;
        nine.TabStop                 =  true;
        nine.Text                    =  "Nine";
        nine.UseVisualStyleBackColor =  true;
        nine.CheckedChanged          += nine_CheckedChanged;
        // 
        // name
        // 
        name.Font = new System.Drawing.Font(
            "Segoe UI",
            20.25F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        name.Location = new System.Drawing.Point(
            450,
            0
        );
        name.Name = "name";
        name.Size = new System.Drawing.Size(
            200,
            50
        );
        name.TabIndex  = 11;
        name.Text      = "Unknown";
        name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            1084,
            436
        );
        Controls.Add(
            name
        );
        Controls.Add(
            nine
        );
        Controls.Add(
            eight
        );
        Controls.Add(
            seven
        );
        Controls.Add(
            six
        );
        Controls.Add(
            five
        );
        Controls.Add(
            four
        );
        Controls.Add(
            three
        );
        Controls.Add(
            two
        );
        Controls.Add(
            one
        );
        Controls.Add(
            zero
        );
        Controls.Add(
            image
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "Display Number";
        Load          += Main_Load;
        ((System.ComponentModel.ISupportInitialize) image).EndInit();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label name;

    private System.Windows.Forms.RadioButton nine;

    private System.Windows.Forms.RadioButton seven;
    private System.Windows.Forms.RadioButton eight;

    private System.Windows.Forms.RadioButton four;
    private System.Windows.Forms.RadioButton five;
    private System.Windows.Forms.RadioButton six;

    private System.Windows.Forms.RadioButton three;

    private System.Windows.Forms.RadioButton two;

    private System.Windows.Forms.RadioButton one;

    private System.Windows.Forms.RadioButton zero;

    private System.Windows.Forms.PictureBox image;

    #endregion
}