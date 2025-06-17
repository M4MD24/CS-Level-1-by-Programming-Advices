using System.ComponentModel;

namespace WindowsFormsConcepts.TreeViewAndImageList;

partial class TreeViewAndImageList {
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
        nodes      = new System.Windows.Forms.TreeView();
        imageListSample = new System.Windows.Forms.ImageList(
            components
        );
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
        title.ForeColor = System.Drawing.Color.Orchid;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            525,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "TreeView and ImageList";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // nodes
        // 
        nodes.Location = new System.Drawing.Point(
            50,
            125
        );
        nodes.Name = "nodes";
        nodes.Size = new System.Drawing.Size(
            525,
            300
        );
        nodes.TabIndex      =  1;
        nodes.AfterCheck    += nodes_AfterCheck;
        nodes.AfterCollapse += nodes_AfterCollapse;
        nodes.AfterExpand   += nodes_AfterExpand;
        // 
        // imageListSample
        // 
        imageListSample.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageListSample.ImageSize = new System.Drawing.Size(
            16,
            16
        );
        imageListSample.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // TreeViewAndImageList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            609,
            486
        );
        Controls.Add(
            nodes
        );
        Controls.Add(
            title
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "TreeViewAndImageList";
        Load          += TreeViewAndImageList_Load;
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.ImageList imageListSample;

    private System.Windows.Forms.TreeView nodes;

    private System.Windows.Forms.Label title;

    #endregion
}