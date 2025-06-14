using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class ComboBoxExample {
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
        title                            = new System.Windows.Forms.Label();
        comboBox                         = new System.Windows.Forms.ComboBox();
        comboBoxWithFropDownStyle        = new System.Windows.Forms.ComboBox();
        comboBoxWithSorted               = new System.Windows.Forms.ComboBox();
        addMoreOptions                   = new System.Windows.Forms.Button();
        comboBoxWithAddMoreOptions       = new System.Windows.Forms.ComboBox();
        comboBoxWithSelectedIndexChanged = new System.Windows.Forms.ComboBox();
        comboBoxWithSelectedIndex        = new System.Windows.Forms.ComboBox();
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
        title.ForeColor = System.Drawing.Color.MidnightBlue;
        title.Location = new System.Drawing.Point(
            94,
            30
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            250,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "ComboBox";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // comboBox
        // 
        comboBox.FormattingEnabled = true;
        comboBox.Items.AddRange(
            new object[] {
                "Option 1",
                "Option 2",
                "Option 3"
            }
        );
        comboBox.Location = new System.Drawing.Point(
            50,
            125
        );
        comboBox.Name = "comboBox";
        comboBox.Size = new System.Drawing.Size(
            150,
            23
        );
        comboBox.TabIndex = 1;
        // 
        // comboBoxWithFropDownStyle
        // 
        comboBoxWithFropDownStyle.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBoxWithFropDownStyle.FormattingEnabled = true;
        comboBoxWithFropDownStyle.Items.AddRange(
            new object[] {
                "Option 1",
                "Option 2",
                "Option 3"
            }
        );
        comboBoxWithFropDownStyle.Location = new System.Drawing.Point(
            50,
            250
        );
        comboBoxWithFropDownStyle.Name = "comboBoxWithFropDownStyle";
        comboBoxWithFropDownStyle.Size = new System.Drawing.Size(
            150,
            23
        );
        comboBoxWithFropDownStyle.TabIndex = 2;
        // 
        // comboBoxWithSorted
        // 
        comboBoxWithSorted.FormattingEnabled = true;
        comboBoxWithSorted.Items.AddRange(
            new object[] {
                "Option 1",
                "Option 2",
                "Option 3"
            }
        );
        comboBoxWithSorted.Location = new System.Drawing.Point(
            50,
            350
        );
        comboBoxWithSorted.Name = "comboBoxWithSorted";
        comboBoxWithSorted.Size = new System.Drawing.Size(
            150,
            23
        );
        comboBoxWithSorted.Sorted   = true;
        comboBoxWithSorted.TabIndex = 3;
        // 
        // addMoreOptions
        // 
        addMoreOptions.Location = new System.Drawing.Point(
            259,
            125
        );
        addMoreOptions.Name = "addMoreOptions";
        addMoreOptions.Size = new System.Drawing.Size(
            150,
            25
        );
        addMoreOptions.TabIndex                =  4;
        addMoreOptions.Text                    =  "Add More Options";
        addMoreOptions.UseVisualStyleBackColor =  true;
        addMoreOptions.Click                   += addMoreOptions_Click;
        // 
        // comboBoxWithAddMoreOptions
        // 
        comboBoxWithAddMoreOptions.FormattingEnabled = true;
        comboBoxWithAddMoreOptions.Location = new System.Drawing.Point(
            259,
            160
        );
        comboBoxWithAddMoreOptions.Name = "comboBoxWithAddMoreOptions";
        comboBoxWithAddMoreOptions.Size = new System.Drawing.Size(
            150,
            23
        );
        comboBoxWithAddMoreOptions.TabIndex = 5;
        // 
        // comboBoxWithSelectedIndexChanged
        // 
        comboBoxWithSelectedIndexChanged.FormattingEnabled = true;
        comboBoxWithSelectedIndexChanged.Items.AddRange(
            new object[] {
                "Option 1",
                "Option 2",
                "Option 3"
            }
        );
        comboBoxWithSelectedIndexChanged.Location = new System.Drawing.Point(
            259,
            250
        );
        comboBoxWithSelectedIndexChanged.Name = "comboBoxWithSelectedIndexChanged";
        comboBoxWithSelectedIndexChanged.Size = new System.Drawing.Size(
            150,
            23
        );
        comboBoxWithSelectedIndexChanged.TabIndex             =  6;
        comboBoxWithSelectedIndexChanged.SelectedIndexChanged += comboBoxWithSelectedIndexChanged_SelectedIndexChanged;
        // 
        // comboBoxWithSelectedIndex
        // 
        comboBoxWithSelectedIndex.FormattingEnabled = true;
        comboBoxWithSelectedIndex.Items.AddRange(
            new object[] {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4",
                "Option 5"
            }
        );
        comboBoxWithSelectedIndex.Location = new System.Drawing.Point(
            259,
            350
        );
        comboBoxWithSelectedIndex.Name = "comboBoxWithSelectedIndex";
        comboBoxWithSelectedIndex.Size = new System.Drawing.Size(
            150,
            23
        );
        comboBoxWithSelectedIndex.TabIndex = 7;
        // 
        // ComboBoxExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            434,
            461
        );
        Controls.Add(
            comboBoxWithSelectedIndex
        );
        Controls.Add(
            comboBoxWithSelectedIndexChanged
        );
        Controls.Add(
            comboBoxWithAddMoreOptions
        );
        Controls.Add(
            addMoreOptions
        );
        Controls.Add(
            comboBoxWithSorted
        );
        Controls.Add(
            comboBoxWithFropDownStyle
        );
        Controls.Add(
            comboBox
        );
        Controls.Add(
            title
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "ComboBox";
        Load          += ComboBoxExample_Load;
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.ComboBox comboBoxWithSelectedIndex;

    private System.Windows.Forms.ComboBox comboBoxWithSelectedIndexChanged;

    private System.Windows.Forms.ComboBox comboBoxWithAddMoreOptions;

    private System.Windows.Forms.Button addMoreOptions;

    private System.Windows.Forms.ComboBox comboBoxWithSorted;

    private System.Windows.Forms.ComboBox comboBoxWithFropDownStyle;

    private System.Windows.Forms.ComboBox comboBox;

    private System.Windows.Forms.Label title;

    #endregion
}