using System.ComponentModel;

namespace WindowsFormsConcepts.Dialogs;

partial class DialogsExample {
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
        title                     = new System.Windows.Forms.Label();
        text                      = new System.Windows.Forms.Label();
        changeForeColor           = new System.Windows.Forms.Button();
        changeBackgroundColor     = new System.Windows.Forms.Button();
        colorDialog               = new System.Windows.Forms.GroupBox();
        changeFont                = new System.Windows.Forms.Button();
        colorDialogSample         = new System.Windows.Forms.ColorDialog();
        fontDialogSample          = new System.Windows.Forms.FontDialog();
        saveFile                  = new System.Windows.Forms.Button();
        saveFileDialogSample      = new System.Windows.Forms.SaveFileDialog();
        openFile                  = new System.Windows.Forms.Button();
        openFileDialogSample      = new System.Windows.Forms.OpenFileDialog();
        folderBrowserDialogSample = new System.Windows.Forms.FolderBrowserDialog();
        folderBrowser             = new System.Windows.Forms.Button();
        colorDialog.SuspendLayout();
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
        title.ForeColor = System.Drawing.Color.DarkSlateGray;
        title.Location = new System.Drawing.Point(
            200,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            200,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Dialogs";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // text
        // 
        text.BackColor = System.Drawing.Color.Black;
        text.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        text.ForeColor = System.Drawing.Color.White;
        text.Location = new System.Drawing.Point(
            250,
            125
        );
        text.Name = "text";
        text.Size = new System.Drawing.Size(
            100,
            50
        );
        text.TabIndex  = 1;
        text.Text      = "Text";
        text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // changeForeColor
        // 
        changeForeColor.Location = new System.Drawing.Point(
            25,
            25
        );
        changeForeColor.Name = "changeForeColor";
        changeForeColor.Size = new System.Drawing.Size(
            175,
            30
        );
        changeForeColor.TabIndex                =  3;
        changeForeColor.Text                    =  "Change ForeColor";
        changeForeColor.UseVisualStyleBackColor =  true;
        changeForeColor.Click                   += changeForeColor_Click;
        // 
        // changeBackgroundColor
        // 
        changeBackgroundColor.Location = new System.Drawing.Point(
            25,
            75
        );
        changeBackgroundColor.Name = "changeBackgroundColor";
        changeBackgroundColor.Size = new System.Drawing.Size(
            175,
            30
        );
        changeBackgroundColor.TabIndex                =  4;
        changeBackgroundColor.Text                    =  "Change Background Color";
        changeBackgroundColor.UseVisualStyleBackColor =  true;
        changeBackgroundColor.Click                   += changeBackgroundColor_Click;
        // 
        // colorDialog
        // 
        colorDialog.Controls.Add(
            changeForeColor
        );
        colorDialog.Controls.Add(
            changeBackgroundColor
        );
        colorDialog.Location = new System.Drawing.Point(
            25,
            225
        );
        colorDialog.Name = "colorDialog";
        colorDialog.Size = new System.Drawing.Size(
            225,
            125
        );
        colorDialog.TabIndex = 2;
        colorDialog.TabStop  = false;
        colorDialog.Text     = "ColorDialog";
        // 
        // changeFont
        // 
        changeFont.Location = new System.Drawing.Point(
            275,
            250
        );
        changeFont.Name = "changeFont";
        changeFont.Size = new System.Drawing.Size(
            125,
            30
        );
        changeFont.TabIndex                =  5;
        changeFont.Text                    =  "Change Font";
        changeFont.UseVisualStyleBackColor =  true;
        changeFont.Click                   += changeFont_Click;
        // 
        // fontDialogSample
        // 
        fontDialogSample.Apply += fontDialogSample_Apply;
        // 
        // saveFile
        // 
        saveFile.Location = new System.Drawing.Point(
            275,
            300
        );
        saveFile.Name = "saveFile";
        saveFile.Size = new System.Drawing.Size(
            125,
            30
        );
        saveFile.TabIndex                =  6;
        saveFile.Text                    =  "Save File";
        saveFile.UseVisualStyleBackColor =  true;
        saveFile.Click                   += saveFile_Click;
        // 
        // openFile
        // 
        openFile.Location = new System.Drawing.Point(
            425,
            250
        );
        openFile.Name = "openFile";
        openFile.Size = new System.Drawing.Size(
            125,
            30
        );
        openFile.TabIndex                =  7;
        openFile.Text                    =  "Open File";
        openFile.UseVisualStyleBackColor =  true;
        openFile.Click                   += openFile_Click;
        // 
        // folderBrowser
        // 
        folderBrowser.Location = new System.Drawing.Point(
            425,
            300
        );
        folderBrowser.Name = "folderBrowser";
        folderBrowser.Size = new System.Drawing.Size(
            125,
            30
        );
        folderBrowser.TabIndex                =  8;
        folderBrowser.Text                    =  "Folder Browser";
        folderBrowser.UseVisualStyleBackColor =  true;
        folderBrowser.Click                   += folderBrowser_Click;
        // 
        // DialogsExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            584,
            386
        );
        Controls.Add(
            folderBrowser
        );
        Controls.Add(
            openFile
        );
        Controls.Add(
            saveFile
        );
        Controls.Add(
            changeFont
        );
        Controls.Add(
            colorDialog
        );
        Controls.Add(
            text
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Dialogs";
        colorDialog.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button folderBrowser;

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSample;

    private System.Windows.Forms.OpenFileDialog openFileDialogSample;

    private System.Windows.Forms.Button openFile;

    private System.Windows.Forms.SaveFileDialog saveFileDialogSample;

    private System.Windows.Forms.Button saveFile;

    private System.Windows.Forms.FontDialog fontDialogSample;

    private System.Windows.Forms.ColorDialog colorDialogSample;

    private System.Windows.Forms.GroupBox colorDialog;
    private System.Windows.Forms.Button   changeFont;

    private System.Windows.Forms.Button changeBackgroundColor;

    private System.Windows.Forms.Button changeForeColor;

    private System.Windows.Forms.Label text;

    private System.Windows.Forms.Label title;

    #endregion
}