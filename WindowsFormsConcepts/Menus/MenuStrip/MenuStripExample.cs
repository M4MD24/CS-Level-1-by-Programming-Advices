using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsConcepts.Menus.MenuStrip;

public partial class MenuStripExample : Form {
    public MenuStripExample() {
        InitializeComponent();
        loadMenuStrip();
    }

    private void loadMenuStrip() {
        menuStripSample = new System.Windows.Forms.MenuStrip();

        ToolStripMenuItem fileMenu = new ToolStripMenuItem(
            "&File"
        );

        const string IMAGES_PATH = "D:\\Projects\\Learn\\ProgrammingAdvices\\CS-Level-1-by-Programming-Advices\\WindowsFormsConcepts\\Menus\\MenuStrip\\resources\\";

        ToolStripMenuItem newFile = new(
                              "&New File",
                              Image.FromFile(
                                  IMAGES_PATH + "FileNew.png"
                              )
                          ),
                          fileText = new(
                              "&Text",
                              Image.FromFile(
                                  IMAGES_PATH + "FileText.png"
                              )
                          ),
                          fileImage = new(
                              "&Image",
                              Image.FromFile(
                                  IMAGES_PATH + "FileImage.png"
                              )
                          ),
                          openFile = new(
                              "&Open",
                              Image.FromFile(
                                  IMAGES_PATH + "OpenFileFolder.png"
                              )
                          ),
                          exit = new(
                              "&Exit",
                              Image.FromFile(
                                  IMAGES_PATH + "Exit.png"
                              )
                          );

        newFile.DropDownItems.Add(
            fileText
        );
        newFile.DropDownItems.Add(
            fileImage
        );
        fileMenu.DropDownItems.Add(
            newFile
        );
        fileMenu.DropDownItems.Add(
            openFile
        );
        fileMenu.DropDownItems.Add(
            new ToolStripSeparator()
        );
        fileMenu.DropDownItems.Add(
            exit
        );

        menuStripSample.Items.Add(
            fileMenu
        );

        Controls.Add(
            menuStripSample
        );

        MainMenuStrip = menuStripSample;

        fileText.Click  += newTextFile_Click!;
        fileImage.Click += newTextImage_Click!;
        openFile.Click  += openFile_Click!;
        exit.Click += (
            _,
            _
        ) => Close();

        exit.ShortcutKeys = Keys.Control | Keys.Alt | Keys.A;
    }

    private void openFile_Click(
        object    sender,
        EventArgs e
    ) {
        showMessage(
            "You have opened the file",
            "Open File"
        );
    }

    private void newTextFile_Click(
        object    sender,
        EventArgs e
    ) {
        showMessage(
            "You have created the text file",
            "Text File"
        );
    }

    private void newTextImage_Click(
        object    sender,
        EventArgs e
    ) {
        showMessage(
            "You have created the image file",
            "Image File"
        );
    }

    private void showMessage(
        string text,
        string caption
    ) {
        MessageBox.Show(
            text,
            caption,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}