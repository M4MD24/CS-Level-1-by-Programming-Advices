using System.ComponentModel;

namespace WindowsFormsConcepts.PictureBox;

partial class PictureBoxExample {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(
            typeof(PictureBoxExample)
        );
        pictureBox = new System.Windows.Forms.Label();
        numberOne  = new System.Windows.Forms.PictureBox();
        numberTwo  = new System.Windows.Forms.PictureBox();
        number     = new System.Windows.Forms.PictureBox();
        one        = new System.Windows.Forms.Button();
        two        = new System.Windows.Forms.Button();
        three      = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize) numberOne).BeginInit();
        ((System.ComponentModel.ISupportInitialize) numberTwo).BeginInit();
        ((System.ComponentModel.ISupportInitialize) number).BeginInit();
        SuspendLayout();
        //
        // pictureBox
        //
        pictureBox.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        pictureBox.ForeColor = System.Drawing.Color.YellowGreen;
        pictureBox.Location = new System.Drawing.Point(
            300,
            25
        );
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new System.Drawing.Size(
            300,
            50
        );
        pictureBox.TabIndex  = 0;
        pictureBox.Text      = "PictureBox";
        pictureBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // numberOne
        //
        numberOne.Image = ((System.Drawing.Image) resources.GetObject(
                                  "numberOne.Image"
                              ));
        numberOne.Location = new System.Drawing.Point(
            50,
            100
        );
        numberOne.Name = "numberOne";
        numberOne.Size = new System.Drawing.Size(
            200,
            200
        );
        numberOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        numberOne.TabIndex = 1;
        numberOne.TabStop  = false;
        //
        // numberTwo
        //
        numberTwo.Image = ((System.Drawing.Image) resources.GetObject(
                                  "numberTwo.Image"
                              ));
        numberTwo.Location = new System.Drawing.Point(
            300,
            100
        );
        numberTwo.Name = "numberTwo";
        numberTwo.Size = new System.Drawing.Size(
            200,
            200
        );
        numberTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        numberTwo.TabIndex = 2;
        numberTwo.TabStop  = false;
        //
        // number
        //
        number.Location = new System.Drawing.Point(
            585,
            100
        );
        number.Name = "number";
        number.Size = new System.Drawing.Size(
            200,
            200
        );
        number.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        number.TabIndex = 3;
        number.TabStop  = false;
        //
        // one
        //
        one.Location = new System.Drawing.Point(
            550,
            315
        );
        one.Name = "one";
        one.Size = new System.Drawing.Size(
            75,
            25
        );
        one.TabIndex                =  4;
        one.Text                    =  "One";
        one.UseVisualStyleBackColor =  true;
        one.Click                   += one_Click;
        //
        // two
        //
        two.Location = new System.Drawing.Point(
            650,
            315
        );
        two.Name = "two";
        two.Size = new System.Drawing.Size(
            75,
            25
        );
        two.TabIndex                =  5;
        two.Text                    =  "Two";
        two.UseVisualStyleBackColor =  true;
        two.Click                   += two_Click;
        //
        // three
        //
        three.Location = new System.Drawing.Point(
            750,
            315
        );
        three.Name = "three";
        three.Size = new System.Drawing.Size(
            75,
            25
        );
        three.TabIndex                =  6;
        three.Text                    =  "Three";
        three.UseVisualStyleBackColor =  true;
        three.Click                   += three_Click;
        //
        // PictureBoxExample
        //
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            884,
            411
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
            number
        );
        Controls.Add(
            numberTwo
        );
        Controls.Add(
            numberOne
        );
        Controls.Add(
            pictureBox
        );
        Text = "PictureBox";
        ((System.ComponentModel.ISupportInitialize) numberOne).EndInit();
        ((System.ComponentModel.ISupportInitialize) numberTwo).EndInit();
        ((System.ComponentModel.ISupportInitialize) number).EndInit();
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.PictureBox numberOne;

    private System.Windows.Forms.Button two;
    private System.Windows.Forms.Button three;

    private System.Windows.Forms.Button one;

    private System.Windows.Forms.PictureBox number;

    private System.Windows.Forms.PictureBox numberTwo;

    private System.Windows.Forms.Label pictureBox;

    #endregion
}