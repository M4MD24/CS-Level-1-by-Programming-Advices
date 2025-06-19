using System.ComponentModel;

namespace WindowsFormsConcepts.IntroductionAboutControls;

partial class TextBoxesAndButtonsAndFormsAndLabels {
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
        pasteByClick                  = new System.Windows.Forms.Button();
        paster                        = new System.Windows.Forms.TextBox();
        copyist                       = new System.Windows.Forms.TextBox();
        pasteByHover                  = new System.Windows.Forms.Button();
        disablePaster                 = new System.Windows.Forms.Button();
        enablePaster                  = new System.Windows.Forms.Button();
        hidePaster                    = new System.Windows.Forms.Button();
        showPaster                    = new System.Windows.Forms.Button();
        changePasterBackgroundToRed   = new System.Windows.Forms.Button();
        changePasterBackgroundToWhite = new System.Windows.Forms.Button();
        changeFormText                = new System.Windows.Forms.Button();
        title                         = new System.Windows.Forms.Label();
        changeTitle                   = new System.Windows.Forms.Button();
        disableChangeByTextChanged    = new System.Windows.Forms.Button();
        enableChangeByTextChanged     = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // pasteByClick
        // 
        pasteByClick.Location = new System.Drawing.Point(
            50,
            375
        );
        pasteByClick.Name = "pasteByClick";
        pasteByClick.Size = new System.Drawing.Size(
            100,
            50
        );
        pasteByClick.TabIndex                =  2;
        pasteByClick.Text                    =  "Paste by Click";
        pasteByClick.UseVisualStyleBackColor =  true;
        pasteByClick.Click                   += pasteByClick_Click;
        // 
        // paster
        // 
        paster.Location = new System.Drawing.Point(
            50,
            125
        );
        paster.Name = "paster";
        paster.Size = new System.Drawing.Size(
            400,
            23
        );
        paster.TabIndex = 0;
        // 
        // copyist
        // 
        copyist.Enabled = false;
        copyist.Location = new System.Drawing.Point(
            625,
            125
        );
        copyist.Name = "copyist";
        copyist.Size = new System.Drawing.Size(
            400,
            23
        );
        copyist.TabIndex = 13;
        copyist.TabStop  = false;
        // 
        // pasteByHover
        // 
        pasteByHover.Location = new System.Drawing.Point(
            50,
            300
        );
        pasteByHover.Name = "pasteByHover";
        pasteByHover.Size = new System.Drawing.Size(
            100,
            50
        );
        pasteByHover.TabIndex                =  1;
        pasteByHover.Text                    =  "Paste by Hover";
        pasteByHover.UseVisualStyleBackColor =  true;
        pasteByHover.MouseHover              += pasteByHover_MouseHover;
        // 
        // disablePaster
        // 
        disablePaster.Location = new System.Drawing.Point(
            175,
            300
        );
        disablePaster.Name = "disablePaster";
        disablePaster.Size = new System.Drawing.Size(
            100,
            50
        );
        disablePaster.TabIndex                =  3;
        disablePaster.Text                    =  "Disable Paster";
        disablePaster.UseVisualStyleBackColor =  true;
        disablePaster.Click                   += disablePaster_Click;
        // 
        // enablePaster
        // 
        enablePaster.Location = new System.Drawing.Point(
            175,
            375
        );
        enablePaster.Name = "enablePaster";
        enablePaster.Size = new System.Drawing.Size(
            100,
            50
        );
        enablePaster.TabIndex                =  4;
        enablePaster.Text                    =  "Enable Paster";
        enablePaster.UseVisualStyleBackColor =  true;
        enablePaster.Click                   += enablePaster_Click;
        // 
        // hidePaster
        // 
        hidePaster.Location = new System.Drawing.Point(
            300,
            300
        );
        hidePaster.Name = "hidePaster";
        hidePaster.Size = new System.Drawing.Size(
            100,
            50
        );
        hidePaster.TabIndex                =  5;
        hidePaster.Text                    =  "Hide Paster";
        hidePaster.UseVisualStyleBackColor =  true;
        hidePaster.Click                   += hidePaster_Click;
        // 
        // showPaster
        // 
        showPaster.Location = new System.Drawing.Point(
            300,
            375
        );
        showPaster.Name = "showPaster";
        showPaster.Size = new System.Drawing.Size(
            100,
            50
        );
        showPaster.TabIndex                =  6;
        showPaster.Text                    =  "Show Paster";
        showPaster.UseVisualStyleBackColor =  true;
        showPaster.Click                   += showPaster_Click;
        // 
        // changePasterBackgroundToRed
        // 
        changePasterBackgroundToRed.Location = new System.Drawing.Point(
            425,
            300
        );
        changePasterBackgroundToRed.Name = "changePasterBackgroundToRed";
        changePasterBackgroundToRed.Size = new System.Drawing.Size(
            200,
            50
        );
        changePasterBackgroundToRed.TabIndex                =  7;
        changePasterBackgroundToRed.Text                    =  "Change Paster Background to Red";
        changePasterBackgroundToRed.UseVisualStyleBackColor =  true;
        changePasterBackgroundToRed.Click                   += changePasterBackgroundToRed_Click;
        // 
        // changePasterBackgroundToWhite
        // 
        changePasterBackgroundToWhite.Location = new System.Drawing.Point(
            425,
            375
        );
        changePasterBackgroundToWhite.Name = "changePasterBackgroundToWhite";
        changePasterBackgroundToWhite.Size = new System.Drawing.Size(
            225,
            50
        );
        changePasterBackgroundToWhite.TabIndex                =  8;
        changePasterBackgroundToWhite.Text                    =  "Change Paster Background to White";
        changePasterBackgroundToWhite.UseVisualStyleBackColor =  true;
        changePasterBackgroundToWhite.Click                   += changePasterBackgroundToWhite_Click;
        // 
        // changeFormText
        // 
        changeFormText.Location = new System.Drawing.Point(
            650,
            300
        );
        changeFormText.Name = "changeFormText";
        changeFormText.Size = new System.Drawing.Size(
            150,
            50
        );
        changeFormText.TabIndex                =  9;
        changeFormText.Text                    =  "Change Form Text";
        changeFormText.UseVisualStyleBackColor =  true;
        changeFormText.Click                   += changeFormText_Click;
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold
        );
        title.ForeColor = System.Drawing.Color.Red;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            975,
            50
        );
        title.TabIndex  = 14;
        title.Text      = "TextBoxes and Buttons and Forms and Labels";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // changeTitle
        // 
        changeTitle.Location = new System.Drawing.Point(
            675,
            375
        );
        changeTitle.Name = "changeTitle";
        changeTitle.Size = new System.Drawing.Size(
            125,
            50
        );
        changeTitle.TabIndex                =  10;
        changeTitle.Text                    =  "Change Title";
        changeTitle.UseVisualStyleBackColor =  true;
        changeTitle.Click                   += changeTitle_Click;
        // 
        // disableChangeByTextChanged
        // 
        disableChangeByTextChanged.Location = new System.Drawing.Point(
            825,
            375
        );
        disableChangeByTextChanged.Name = "disableChangeByTextChanged";
        disableChangeByTextChanged.Size = new System.Drawing.Size(
            200,
            50
        );
        disableChangeByTextChanged.TabIndex                =  12;
        disableChangeByTextChanged.Text                    =  "Disable Change by Text Changed";
        disableChangeByTextChanged.UseVisualStyleBackColor =  true;
        disableChangeByTextChanged.Click                   += disableChangeByTextChanged_Click;
        // 
        // enableChangeByTextChanged
        // 
        enableChangeByTextChanged.Location = new System.Drawing.Point(
            825,
            300
        );
        enableChangeByTextChanged.Name = "enableChangeByTextChanged";
        enableChangeByTextChanged.Size = new System.Drawing.Size(
            200,
            50
        );
        enableChangeByTextChanged.TabIndex                =  11;
        enableChangeByTextChanged.Text                    =  "Enable Change by Text Changed";
        enableChangeByTextChanged.UseVisualStyleBackColor =  true;
        enableChangeByTextChanged.Click                   += enableChangeByTextChanged_Click;
        // 
        // TextBoxesAndButtonsAndFormsAndLabels
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            1084,
            461
        );
        Controls.Add(
            enableChangeByTextChanged
        );
        Controls.Add(
            disableChangeByTextChanged
        );
        Controls.Add(
            changeTitle
        );
        Controls.Add(
            title
        );
        Controls.Add(
            changeFormText
        );
        Controls.Add(
            changePasterBackgroundToWhite
        );
        Controls.Add(
            changePasterBackgroundToRed
        );
        Controls.Add(
            showPaster
        );
        Controls.Add(
            hidePaster
        );
        Controls.Add(
            enablePaster
        );
        Controls.Add(
            disablePaster
        );
        Controls.Add(
            pasteByHover
        );
        Controls.Add(
            copyist
        );
        Controls.Add(
            paster
        );
        Controls.Add(
            pasteByClick
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "TextBoxes and Buttons and Forms and Labels";
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.Button enableChangeByTextChanged;

    private System.Windows.Forms.Button disableChangeByTextChanged;

    private System.Windows.Forms.Button changeTitle;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.Button changeFormText;

    private System.Windows.Forms.Button changePasterBackgroundToWhite;

    private System.Windows.Forms.Button changePasterBackgroundToRed;

    private System.Windows.Forms.Button showPaster;

    private System.Windows.Forms.Button hidePaster;

    private System.Windows.Forms.Button enablePaster;

    private System.Windows.Forms.Button disablePaster;

    private System.Windows.Forms.Button pasteByHover;

    private System.Windows.Forms.TextBox copyist;

    private System.Windows.Forms.TextBox paster;

    private System.Windows.Forms.Button pasteByClick;

    #endregion
}