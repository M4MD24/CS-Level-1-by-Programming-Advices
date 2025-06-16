using System.ComponentModel;

namespace WindowsFormsConcepts;

partial class TimerExample {
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
        timerSample = new System.Windows.Forms.Timer(
            components
        );
        title            = new System.Windows.Forms.Label();
        counter          = new System.Windows.Forms.Label();
        startAndContinue = new System.Windows.Forms.Button();
        pauseAndEnd      = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // timerSample
        // 
        timerSample.Tick += timerSample_Tick;
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
        title.ForeColor = System.Drawing.Color.DarkOrchid;
        title.Location = new System.Drawing.Point(
            50,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            175,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Timer";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // counter
        // 
        counter.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        counter.Location = new System.Drawing.Point(
            50,
            100
        );
        counter.Name = "counter";
        counter.Size = new System.Drawing.Size(
            175,
            25
        );
        counter.TabIndex  = 1;
        counter.Text      = "0";
        counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // startAndContinue
        // 
        startAndContinue.Location = new System.Drawing.Point(
            50,
            150
        );
        startAndContinue.Name = "startAndContinue";
        startAndContinue.Size = new System.Drawing.Size(
            75,
            25
        );
        startAndContinue.TabIndex                =  2;
        startAndContinue.Text                    =  "Start";
        startAndContinue.UseVisualStyleBackColor =  true;
        startAndContinue.Click                   += startAndContinue_Click;
        // 
        // pauseAndEnd
        // 
        pauseAndEnd.Enabled = false;
        pauseAndEnd.Location = new System.Drawing.Point(
            150,
            150
        );
        pauseAndEnd.Name = "pauseAndEnd";
        pauseAndEnd.Size = new System.Drawing.Size(
            75,
            25
        );
        pauseAndEnd.TabIndex                =  3;
        pauseAndEnd.Text                    =  "Pause";
        pauseAndEnd.UseVisualStyleBackColor =  true;
        pauseAndEnd.Click                   += pauseAndEnd_Click;
        // 
        // TimerExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            259,
            211
        );
        Controls.Add(
            pauseAndEnd
        );
        Controls.Add(
            startAndContinue
        );
        Controls.Add(
            counter
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Timer";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button startAndContinue;

    private System.Windows.Forms.Button pauseAndEnd;

    private System.Windows.Forms.Label counter;

    private System.Windows.Forms.Label title;

    private System.Windows.Forms.Timer timerSample;

    #endregion
}