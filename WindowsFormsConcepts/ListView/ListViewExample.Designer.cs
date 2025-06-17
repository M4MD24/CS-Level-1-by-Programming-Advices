using System.ComponentModel;

namespace WindowsFormsConcepts.ListView;

partial class ListViewExample {
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
        components = new System.ComponentModel.Container();
        title      = new System.Windows.Forms.Label();
        items      = new System.Windows.Forms.ListView();
        largeImages = new System.Windows.Forms.ImageList(
            components
        );
        smallImages = new System.Windows.Forms.ImageList(
            components
        );
        add                = new System.Windows.Forms.Button();
        select             = new System.Windows.Forms.Button();
        remove             = new System.Windows.Forms.Button();
        addRandomItem      = new System.Windows.Forms.Button();
        view               = new System.Windows.Forms.GroupBox();
        details            = new System.Windows.Forms.RadioButton();
        list               = new System.Windows.Forms.RadioButton();
        tile               = new System.Windows.Forms.RadioButton();
        smallIcon          = new System.Windows.Forms.RadioButton();
        largeIcon          = new System.Windows.Forms.RadioButton();
        enteredTitle       = new System.Windows.Forms.TextBox();
        enteredDescription = new System.Windows.Forms.TextBox();
        color              = new System.Windows.Forms.GroupBox();
        green              = new System.Windows.Forms.RadioButton();
        blue               = new System.Windows.Forms.RadioButton();
        red                = new System.Windows.Forms.RadioButton();
        view.SuspendLayout();
        color.SuspendLayout();
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
        title.ForeColor = System.Drawing.Color.DimGray;
        title.Location = new System.Drawing.Point(
            325,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            250,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "ListView";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // items
        // 
        items.LargeImageList = largeImages;
        items.Location = new System.Drawing.Point(
            50,
            100
        );
        items.Name = "items";
        items.Size = new System.Drawing.Size(
            800,
            250
        );
        items.SmallImageList                  = smallImages;
        items.TabIndex                        = 1;
        items.UseCompatibleStateImageBehavior = false;
        items.View                            = System.Windows.Forms.View.Tile;
        // 
        // largeImages
        // 
        largeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        largeImages.ImageSize = new System.Drawing.Size(
            16,
            16
        );
        largeImages.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // smallImages
        // 
        smallImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        smallImages.ImageSize = new System.Drawing.Size(
            16,
            16
        );
        smallImages.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // add
        // 
        add.Location = new System.Drawing.Point(
            50,
            375
        );
        add.Name = "add";
        add.Size = new System.Drawing.Size(
            75,
            25
        );
        add.TabIndex                =  8;
        add.Text                    =  "Add";
        add.UseVisualStyleBackColor =  true;
        add.Click                   += add_Click;
        // 
        // select
        // 
        select.Location = new System.Drawing.Point(
            250,
            375
        );
        select.Name = "select";
        select.Size = new System.Drawing.Size(
            75,
            25
        );
        select.TabIndex                =  10;
        select.Text                    =  "Select";
        select.UseVisualStyleBackColor =  true;
        select.Click                   += select_Click;
        // 
        // remove
        // 
        remove.Location = new System.Drawing.Point(
            150,
            375
        );
        remove.Name = "remove";
        remove.Size = new System.Drawing.Size(
            75,
            25
        );
        remove.TabIndex                =  9;
        remove.Text                    =  "Remove";
        remove.UseVisualStyleBackColor =  true;
        remove.Click                   += remove_Click;
        // 
        // addRandomItem
        // 
        addRandomItem.Location = new System.Drawing.Point(
            50,
            425
        );
        addRandomItem.Name = "addRandomItem";
        addRandomItem.Size = new System.Drawing.Size(
            125,
            25
        );
        addRandomItem.TabIndex                =  11;
        addRandomItem.Text                    =  "Add Random Item";
        addRandomItem.UseVisualStyleBackColor =  true;
        addRandomItem.Click                   += addRandomItem_Click;
        // 
        // view
        // 
        view.Controls.Add(
            details
        );
        view.Controls.Add(
            list
        );
        view.Controls.Add(
            tile
        );
        view.Controls.Add(
            smallIcon
        );
        view.Controls.Add(
            largeIcon
        );
        view.Location = new System.Drawing.Point(
            525,
            375
        );
        view.Name = "view";
        view.Size = new System.Drawing.Size(
            325,
            125
        );
        view.TabIndex = 12;
        view.TabStop  = false;
        view.Text     = "View";
        // 
        // details
        // 
        details.Location = new System.Drawing.Point(
            225,
            30
        );
        details.Name = "details";
        details.Size = new System.Drawing.Size(
            75,
            25
        );
        details.TabIndex                =  17;
        details.Text                    =  "Details";
        details.UseVisualStyleBackColor =  true;
        details.CheckedChanged          += details_CheckedChanged;
        // 
        // list
        // 
        list.Location = new System.Drawing.Point(
            150,
            80
        );
        list.Name = "list";
        list.Size = new System.Drawing.Size(
            50,
            25
        );
        list.TabIndex                =  16;
        list.Text                    =  "List";
        list.UseVisualStyleBackColor =  true;
        list.CheckedChanged          += list_CheckedChanged;
        // 
        // tile
        // 
        tile.Checked = true;
        tile.Location = new System.Drawing.Point(
            150,
            30
        );
        tile.Name = "tile";
        tile.Size = new System.Drawing.Size(
            50,
            25
        );
        tile.TabIndex                =  15;
        tile.TabStop                 =  true;
        tile.Text                    =  "Tile";
        tile.UseVisualStyleBackColor =  true;
        tile.CheckedChanged          += tile_CheckedChanged;
        // 
        // smallIcon
        // 
        smallIcon.Location = new System.Drawing.Point(
            25,
            80
        );
        smallIcon.Name = "smallIcon";
        smallIcon.Size = new System.Drawing.Size(
            100,
            25
        );
        smallIcon.TabIndex                =  14;
        smallIcon.Text                    =  "Small Icon";
        smallIcon.UseVisualStyleBackColor =  true;
        smallIcon.CheckedChanged          += smallIcon_CheckedChanged;
        // 
        // largeIcon
        // 
        largeIcon.Location = new System.Drawing.Point(
            25,
            30
        );
        largeIcon.Name = "largeIcon";
        largeIcon.Size = new System.Drawing.Size(
            100,
            25
        );
        largeIcon.TabIndex                =  13;
        largeIcon.Text                    =  "Large Icon";
        largeIcon.UseVisualStyleBackColor =  true;
        largeIcon.CheckedChanged          += largeIcon_CheckedChanged;
        // 
        // enteredTitle
        // 
        enteredTitle.Location = new System.Drawing.Point(
            350,
            375
        );
        enteredTitle.MaxLength = 20;
        enteredTitle.Name      = "enteredTitle";
        enteredTitle.Size = new System.Drawing.Size(
            150,
            23
        );
        enteredTitle.TabIndex = 2;
        // 
        // enteredDescription
        // 
        enteredDescription.Location = new System.Drawing.Point(
            350,
            425
        );
        enteredDescription.MaxLength = 40;
        enteredDescription.Multiline = true;
        enteredDescription.Name      = "enteredDescription";
        enteredDescription.Size = new System.Drawing.Size(
            150,
            75
        );
        enteredDescription.TabIndex = 3;
        enteredDescription.WordWrap = false;
        // 
        // color
        // 
        color.Controls.Add(
            green
        );
        color.Controls.Add(
            blue
        );
        color.Controls.Add(
            red
        );
        color.Location = new System.Drawing.Point(
            350,
            525
        );
        color.Name = "color";
        color.Size = new System.Drawing.Size(
            150,
            135
        );
        color.TabIndex = 4;
        color.TabStop  = false;
        color.Text     = "Color";
        // 
        // green
        // 
        green.Location = new System.Drawing.Point(
            35,
            95
        );
        green.Name = "green";
        green.Size = new System.Drawing.Size(
            60,
            25
        );
        green.TabIndex                = 7;
        green.TabStop                 = true;
        green.Text                    = "Green";
        green.UseVisualStyleBackColor = true;
        // 
        // blue
        // 
        blue.Location = new System.Drawing.Point(
            35,
            60
        );
        blue.Name = "blue";
        blue.Size = new System.Drawing.Size(
            50,
            25
        );
        blue.TabIndex                = 6;
        blue.TabStop                 = true;
        blue.Text                    = "Blue";
        blue.UseVisualStyleBackColor = true;
        // 
        // red
        // 
        red.Location = new System.Drawing.Point(
            35,
            25
        );
        red.Name = "red";
        red.Size = new System.Drawing.Size(
            50,
            25
        );
        red.TabIndex                = 5;
        red.TabStop                 = true;
        red.Text                    = "Red";
        red.UseVisualStyleBackColor = true;
        // 
        // ListViewExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            884,
            686
        );
        Controls.Add(
            color
        );
        Controls.Add(
            enteredDescription
        );
        Controls.Add(
            enteredTitle
        );
        Controls.Add(
            view
        );
        Controls.Add(
            addRandomItem
        );
        Controls.Add(
            remove
        );
        Controls.Add(
            select
        );
        Controls.Add(
            add
        );
        Controls.Add(
            items
        );
        Controls.Add(
            title
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "ListView";
        Load          += ListViewExample_Load;
        view.ResumeLayout(
            false
        );
        color.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
        PerformLayout();
    }

    private System.Windows.Forms.ImageList largeImages;

    private System.Windows.Forms.ImageList smallImages;

    private System.Windows.Forms.RadioButton green;

    private System.Windows.Forms.GroupBox    color;
    private System.Windows.Forms.RadioButton blue;
    private System.Windows.Forms.RadioButton red;

    private System.Windows.Forms.TextBox enteredDescription;

    private System.Windows.Forms.TextBox enteredTitle;

    private System.Windows.Forms.RadioButton details;

    private System.Windows.Forms.RadioButton list;

    private System.Windows.Forms.RadioButton tile;

    private System.Windows.Forms.RadioButton largeIcon;
    private System.Windows.Forms.RadioButton smallIcon;

    private System.Windows.Forms.GroupBox view;

    private System.Windows.Forms.Button addRandomItem;

    private System.Windows.Forms.Button remove;

    private System.Windows.Forms.Button add;

    private System.Windows.Forms.Button select;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.ListView items;

    #endregion
}