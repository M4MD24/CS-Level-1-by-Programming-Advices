using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class LinkLabelExample {
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
        linkLabel                       = new System.Windows.Forms.LinkLabel();
        title                           = new System.Windows.Forms.Label();
        linkLabelWithLinkBehavior       = new System.Windows.Forms.LinkLabel();
        linkLabelWithURL_AndVisitedLink = new System.Windows.Forms.LinkLabel();
        SuspendLayout();
        // 
        // linkLabel
        // 
        linkLabel.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        linkLabel.Location = new System.Drawing.Point(
            50,
            125
        );
        linkLabel.Name = "linkLabel";
        linkLabel.Size = new System.Drawing.Size(
            100,
            25
        );
        linkLabel.TabIndex = 1;
        linkLabel.TabStop  = true;
        linkLabel.Text     = "LinkLabel";
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
        title.ForeColor = System.Drawing.Color.Brown;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            275,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "LinkLabel";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // linkLabelWithLinkBehavior
        // 
        linkLabelWithLinkBehavior.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        linkLabelWithLinkBehavior.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        linkLabelWithLinkBehavior.Location = new System.Drawing.Point(
            50,
            175
        );
        linkLabelWithLinkBehavior.Name = "linkLabelWithLinkBehavior";
        linkLabelWithLinkBehavior.Size = new System.Drawing.Size(
            225,
            25
        );
        linkLabelWithLinkBehavior.TabIndex = 2;
        linkLabelWithLinkBehavior.TabStop  = true;
        linkLabelWithLinkBehavior.Text     = "LinkLabel with Link Behavior";
        // 
        // linkLabelWithURL_AndVisitedLink
        // 
        linkLabelWithURL_AndVisitedLink.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        linkLabelWithURL_AndVisitedLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        linkLabelWithURL_AndVisitedLink.Location = new System.Drawing.Point(
            50,
            225
        );
        linkLabelWithURL_AndVisitedLink.Name = "linkLabelWithURL_AndVisitedLink";
        linkLabelWithURL_AndVisitedLink.Size = new System.Drawing.Size(
            275,
            25
        );
        linkLabelWithURL_AndVisitedLink.TabIndex    =  3;
        linkLabelWithURL_AndVisitedLink.TabStop     =  true;
        linkLabelWithURL_AndVisitedLink.Text        =  "LinkLabel with URL and VisitedLink";
        linkLabelWithURL_AndVisitedLink.LinkClicked += linkLabelWithURL_AndVisitedLink_LinkClicked;
        // 
        // LinkLabelExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            359,
            286
        );
        Controls.Add(
            linkLabelWithURL_AndVisitedLink
        );
        Controls.Add(
            linkLabelWithLinkBehavior
        );
        Controls.Add(
            title
        );
        Controls.Add(
            linkLabel
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "LinkLabel";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.LinkLabel linkLabelWithURL_AndVisitedLink;

    private System.Windows.Forms.LinkLabel linkLabelWithLinkBehavior;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.LinkLabel linkLabel;

    #endregion
}