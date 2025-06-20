using System.ComponentModel;

namespace WindowsFormsConcepts.Menus;

partial class MenuStripExample {
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
        title                         = new System.Windows.Forms.Label();
        newToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
        openToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator            = new System.Windows.Forms.ToolStripSeparator();
        saveToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        saveAsToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1           = new System.Windows.Forms.ToolStripSeparator();
        printToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
        printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        editToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        undoToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        redoToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator3           = new System.Windows.Forms.ToolStripSeparator();
        cutToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
        copyToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        pasteToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator2           = new System.Windows.Forms.ToolStripSeparator();
        exitToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        fileToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
        menuStripSample               = new System.Windows.Forms.MenuStrip();
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
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            250,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "MenuStrip";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripMenuItem.Name                  = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        newToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        newToolStripMenuItem.Text = "&New";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripMenuItem.Name                  = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        openToolStripMenuItem.Text = "&Open";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(
            143,
            6
        );
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripMenuItem.Name                  = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        saveToolStripMenuItem.Text = "&Save";
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        saveAsToolStripMenuItem.Text = "Save &As";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(
            143,
            6
        );
        // 
        // printToolStripMenuItem
        // 
        printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        printToolStripMenuItem.Name                  = "printToolStripMenuItem";
        printToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
        printToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        printToolStripMenuItem.Text = "&Print";
        // 
        // printPreviewToolStripMenuItem
        // 
        printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        printPreviewToolStripMenuItem.Name                  = "printPreviewToolStripMenuItem";
        printPreviewToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        printPreviewToolStripMenuItem.Text = "Print Pre&view";
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                undoToolStripMenuItem,
                redoToolStripMenuItem,
                toolStripSeparator3,
                cutToolStripMenuItem,
                copyToolStripMenuItem,
                pasteToolStripMenuItem
            }
        );
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new System.Drawing.Size(
            39,
            20
        );
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name         = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undoToolStripMenuItem.Size = new System.Drawing.Size(
            144,
            22
        );
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name         = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
        redoToolStripMenuItem.Size = new System.Drawing.Size(
            144,
            22
        );
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new System.Drawing.Size(
            141,
            6
        );
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        cutToolStripMenuItem.Name                  = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
        cutToolStripMenuItem.Size = new System.Drawing.Size(
            144,
            22
        );
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        copyToolStripMenuItem.Name                  = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
        copyToolStripMenuItem.Size = new System.Drawing.Size(
            144,
            22
        );
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        pasteToolStripMenuItem.Name                  = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
        pasteToolStripMenuItem.Size = new System.Drawing.Size(
            144,
            22
        );
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(
            143,
            6
        );
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(
            146,
            22
        );
        exitToolStripMenuItem.Text = "E&xit";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(
            new System.Windows.Forms.ToolStripItem[] {
                newToolStripMenuItem,
                openToolStripMenuItem,
                toolStripSeparator,
                saveToolStripMenuItem,
                saveAsToolStripMenuItem,
                toolStripSeparator1,
                printToolStripMenuItem,
                printPreviewToolStripMenuItem,
                toolStripSeparator2,
                exitToolStripMenuItem
            }
        );
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(
            37,
            20
        );
        fileToolStripMenuItem.Text = "&File";
        // 
        // menuStripSample
        // 
        menuStripSample.Location = new System.Drawing.Point(
            0,
            0
        );
        menuStripSample.Name = "menuStripSample";
        menuStripSample.Size = new System.Drawing.Size(
            334,
            24
        );
        menuStripSample.TabIndex = 1;
        menuStripSample.Text     = "menuStripSample";
        // 
        // MenuStripExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            334,
            161
        );
        Controls.Add(
            title
        );
        Controls.Add(
            menuStripSample
        );
        MainMenuStrip = menuStripSample;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "MenuStrip";
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.MenuStrip menuStripSample;

    private System.Windows.Forms.ToolStripMenuItem  fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem  saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem  printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem  exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem  cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem  pasteToolStripMenuItem;

    private System.Windows.Forms.Label title;

    #endregion
}