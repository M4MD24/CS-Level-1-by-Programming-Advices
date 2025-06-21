using System.ComponentModel;

namespace WindowsFormsConcepts.MultipleDocumentsInterfaceContainer;

partial class MultipleDocumentsInterfaceContainerExample {
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
        showSingleFormOnly = new System.Windows.Forms.Button();
        label1             = new System.Windows.Forms.Label();
        ShowMultipleForms  = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // showSingleFormOnly
        // 
        showSingleFormOnly.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        showSingleFormOnly.Location = new System.Drawing.Point(
            150,
            173
        );
        showSingleFormOnly.Name = "showSingleFormOnly";
        showSingleFormOnly.Size = new System.Drawing.Size(
            225,
            50
        );
        showSingleFormOnly.TabIndex                =  1;
        showSingleFormOnly.Text                    =  "Show Single Form Only";
        showSingleFormOnly.UseVisualStyleBackColor =  true;
        showSingleFormOnly.Click                   += showSingleFormOnly_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        label1.ForeColor = System.Drawing.Color.ForestGreen;
        label1.Location = new System.Drawing.Point(
            50,
            57
        );
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(
            1000,
            50
        );
        label1.TabIndex = 0;
        label1.Text     = "Multiple Documents Interface (MDI) Container";
        // 
        // ShowMultipleForms
        // 
        ShowMultipleForms.Font = new System.Drawing.Font(
            "Segoe UI",
            10F,
            System.Drawing.FontStyle.Bold
        );
        ShowMultipleForms.Location = new System.Drawing.Point(
            725,
            173
        );
        ShowMultipleForms.Name = "ShowMultipleForms";
        ShowMultipleForms.Size = new System.Drawing.Size(
            225,
            50
        );
        ShowMultipleForms.TabIndex                =  3;
        ShowMultipleForms.Text                    =  "Show Multiple Forms";
        ShowMultipleForms.UseVisualStyleBackColor =  true;
        ShowMultipleForms.Click                   += ShowMultipleForms_Click;
        // 
        // MultipleDocumentsInterfaceContainerExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            1084,
            791
        );
        Controls.Add(
            ShowMultipleForms
        );
        Controls.Add(
            label1
        );
        Controls.Add(
            showSingleFormOnly
        );
        IsMdiContainer = true;
        StartPosition  = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text           = "MultipleDocumentsInterfaceContainer";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button ShowMultipleForms;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button showSingleFormOnly;

    #endregion
}