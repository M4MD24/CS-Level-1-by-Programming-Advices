using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class CheckedListBoxExample {
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
        items              = new System.Windows.Forms.CheckedListBox();
        title              = new System.Windows.Forms.Label();
        addItem            = new System.Windows.Forms.Button();
        showItems          = new System.Windows.Forms.Button();
        checkAllItems      = new System.Windows.Forms.Button();
        uncheckAllItems    = new System.Windows.Forms.Button();
        removeSelectedItem = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // items
        // 
        items.FormattingEnabled = true;
        items.Location = new System.Drawing.Point(
            50,
            107
        );
        items.Name = "items";
        items.Size = new System.Drawing.Size(
            500,
            148
        );
        items.TabIndex = 1;
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
        title.ForeColor = System.Drawing.Color.Tomato;
        title.Location = new System.Drawing.Point(
            125,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            350,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "CheckedListBox";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // addItem
        // 
        addItem.Location = new System.Drawing.Point(
            50,
            275
        );
        addItem.Name = "addItem";
        addItem.Size = new System.Drawing.Size(
            150,
            25
        );
        addItem.TabIndex                =  2;
        addItem.Text                    =  "Add Item";
        addItem.UseVisualStyleBackColor =  true;
        addItem.Click                   += addItem_Click;
        // 
        // showItems
        // 
        showItems.Location = new System.Drawing.Point(
            450,
            275
        );
        showItems.Name = "showItems";
        showItems.Size = new System.Drawing.Size(
            100,
            25
        );
        showItems.TabIndex                =  3;
        showItems.Text                    =  "Show Items";
        showItems.UseVisualStyleBackColor =  true;
        showItems.Click                   += showItems_Click;
        // 
        // checkAllItems
        // 
        checkAllItems.Location = new System.Drawing.Point(
            250,
            275
        );
        checkAllItems.Name = "checkAllItems";
        checkAllItems.Size = new System.Drawing.Size(
            150,
            25
        );
        checkAllItems.TabIndex                =  4;
        checkAllItems.Text                    =  "Check All Items";
        checkAllItems.UseVisualStyleBackColor =  true;
        checkAllItems.Click                   += checkAllItems_Click;
        // 
        // uncheckAllItems
        // 
        uncheckAllItems.Location = new System.Drawing.Point(
            250,
            325
        );
        uncheckAllItems.Name = "uncheckAllItems";
        uncheckAllItems.Size = new System.Drawing.Size(
            150,
            25
        );
        uncheckAllItems.TabIndex                =  5;
        uncheckAllItems.Text                    =  "Uncheck All Items";
        uncheckAllItems.UseVisualStyleBackColor =  true;
        uncheckAllItems.Click                   += uncheckAllItems_Click;
        // 
        // removeSelectedItem
        // 
        removeSelectedItem.Location = new System.Drawing.Point(
            50,
            325
        );
        removeSelectedItem.Name = "removeSelectedItem";
        removeSelectedItem.Size = new System.Drawing.Size(
            150,
            25
        );
        removeSelectedItem.TabIndex                =  6;
        removeSelectedItem.Text                    =  "Remove Selected Item";
        removeSelectedItem.UseVisualStyleBackColor =  true;
        removeSelectedItem.Click                   += removeSelectedItem_Click;
        // 
        // CheckedListBoxExample
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
            removeSelectedItem
        );
        Controls.Add(
            uncheckAllItems
        );
        Controls.Add(
            checkAllItems
        );
        Controls.Add(
            showItems
        );
        Controls.Add(
            addItem
        );
        Controls.Add(
            title
        );
        Controls.Add(
            items
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "CheckedListBox";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button removeSelectedItem;

    private System.Windows.Forms.Button uncheckAllItems;

    private System.Windows.Forms.Button checkAllItems;

    private System.Windows.Forms.Button showItems;

    private System.Windows.Forms.Button addItem;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.CheckedListBox items;

    #endregion
}