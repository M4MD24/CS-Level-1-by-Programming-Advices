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
        title              = new System.Windows.Forms.Label();
        listView           = new System.Windows.Forms.ListView();
        add                = new System.Windows.Forms.Button();
        select             = new System.Windows.Forms.Button();
        remove             = new System.Windows.Forms.Button();
        fillRandomItems    = new System.Windows.Forms.Button();
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
        // listView
        // 
        listView.Location = new System.Drawing.Point(
            50,
            100
        );
        listView.Name = "listView";
        listView.Size = new System.Drawing.Size(
            800,
            250
        );
        listView.TabIndex                        = 1;
        listView.UseCompatibleStateImageBehavior = false;
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
        add.TabIndex                = 4;
        add.Text                    = "Add";
        add.UseVisualStyleBackColor = true;
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
        select.TabIndex                = 6;
        select.Text                    = "Select";
        select.UseVisualStyleBackColor = true;
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
        remove.TabIndex                = 5;
        remove.Text                    = "Remove";
        remove.UseVisualStyleBackColor = true;
        // 
        // fillRandomItems
        // 
        fillRandomItems.Location = new System.Drawing.Point(
            50,
            425
        );
        fillRandomItems.Name = "fillRandomItems";
        fillRandomItems.Size = new System.Drawing.Size(
            125,
            25
        );
        fillRandomItems.TabIndex                = 6;
        fillRandomItems.Text                    = "Fill Random Items";
        fillRandomItems.UseVisualStyleBackColor = true;
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
        view.TabIndex = 7;
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
        details.TabIndex                = 4;
        details.TabStop                 = true;
        details.Text                    = "Details";
        details.UseVisualStyleBackColor = true;
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
        list.TabIndex                = 3;
        list.TabStop                 = true;
        list.Text                    = "List";
        list.UseVisualStyleBackColor = true;
        // 
        // tile
        // 
        tile.Location = new System.Drawing.Point(
            150,
            30
        );
        tile.Name = "tile";
        tile.Size = new System.Drawing.Size(
            50,
            25
        );
        tile.TabIndex                = 2;
        tile.TabStop                 = true;
        tile.Text                    = "Tile";
        tile.UseVisualStyleBackColor = true;
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
        smallIcon.TabIndex                = 1;
        smallIcon.TabStop                 = true;
        smallIcon.Text                    = "Small Icon";
        smallIcon.UseVisualStyleBackColor = true;
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
        largeIcon.TabIndex                = 0;
        largeIcon.TabStop                 = true;
        largeIcon.Text                    = "Large Icon";
        largeIcon.UseVisualStyleBackColor = true;
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
        enteredDescription.MaxLength = 20;
        enteredDescription.Multiline = true;
        enteredDescription.Name      = "enteredDescription";
        enteredDescription.Size = new System.Drawing.Size(
            150,
            75
        );
        enteredDescription.TabIndex = 8;
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
        color.TabIndex = 8;
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
        green.TabIndex                = 2;
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
        blue.TabIndex                = 1;
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
        red.TabIndex                = 0;
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
            fillRandomItems
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
            listView
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "ListView";
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

    private System.Windows.Forms.Button fillRandomItems;

    private System.Windows.Forms.Button remove;

    private System.Windows.Forms.Button add;

    private System.Windows.Forms.Button select;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.ListView listView;

    #endregion
}