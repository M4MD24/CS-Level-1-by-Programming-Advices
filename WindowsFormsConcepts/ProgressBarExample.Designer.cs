using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class ProgressBarExample {
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
        title       = new System.Windows.Forms.Label();
        progressBar = new System.Windows.Forms.ProgressBar();
        load        = new System.Windows.Forms.Button();
        resetLoad   = new System.Windows.Forms.Button();
        loadRate    = new System.Windows.Forms.Label();
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
        title.ForeColor = System.Drawing.Color.Crimson;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            400,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "ProgressBar";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // progressBar
        // 
        progressBar.Location = new System.Drawing.Point(
            50,
            175
        );
        progressBar.Name = "progressBar";
        progressBar.Size = new System.Drawing.Size(
            400,
            25
        );
        progressBar.TabIndex = 1;
        // 
        // load
        // 
        load.Location = new System.Drawing.Point(
            50,
            225
        );
        load.Name = "load";
        load.Size = new System.Drawing.Size(
            100,
            25
        );
        load.TabIndex                =  2;
        load.Text                    =  "Load";
        load.UseVisualStyleBackColor =  true;
        load.Click                   += load_Click;
        // 
        // resetLoad
        // 
        resetLoad.Location = new System.Drawing.Point(
            350,
            225
        );
        resetLoad.Name = "resetLoad";
        resetLoad.Size = new System.Drawing.Size(
            100,
            25
        );
        resetLoad.TabIndex                =  3;
        resetLoad.Text                    =  "Reset Load";
        resetLoad.UseVisualStyleBackColor =  true;
        resetLoad.Click                   += resetLoad_Click;
        // 
        // loadRate
        // 
        loadRate.Font = new System.Drawing.Font(
            "Segoe UI",
            14F,
            System.Drawing.FontStyle.Bold
        );
        loadRate.ForeColor = System.Drawing.Color.Firebrick;
        loadRate.Location = new System.Drawing.Point(
            175,
            125
        );
        loadRate.Name = "loadRate";
        loadRate.Size = new System.Drawing.Size(
            150,
            23
        );
        loadRate.TabIndex  = 4;
        loadRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ProgressBarExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            484,
            286
        );
        Controls.Add(
            loadRate
        );
        Controls.Add(
            resetLoad
        );
        Controls.Add(
            load
        );
        Controls.Add(
            progressBar
        );
        Controls.Add(
            title
        );
        Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "ProgressBar";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label loadRate;

    private System.Windows.Forms.Button resetLoad;

    private System.Windows.Forms.Button load;

    private System.Windows.Forms.ProgressBar progressBar;

    private System.Windows.Forms.Label title;

    #endregion
}