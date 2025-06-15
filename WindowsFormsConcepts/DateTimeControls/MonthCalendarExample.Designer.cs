using System.ComponentModel;

namespace WindowsFormsConcepts.DateTimeControls;

partial class MonthCalendarExample {
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
        title                            = new System.Windows.Forms.Label();
        monthCalendarWithShowWeekNumbers = new System.Windows.Forms.MonthCalendar();
        selectedRange                    = new System.Windows.Forms.Button();
        start                            = new System.Windows.Forms.Button();
        end                              = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold
        );
        title.ForeColor = System.Drawing.Color.Indigo;
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
        title.Text      = "Month Calendar";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // monthCalendarWithShowWeekNumbers
        // 
        monthCalendarWithShowWeekNumbers.Location = new System.Drawing.Point(
            50,
            125
        );
        monthCalendarWithShowWeekNumbers.Name            = "monthCalendarWithShowWeekNumbers";
        monthCalendarWithShowWeekNumbers.ShowWeekNumbers = true;
        monthCalendarWithShowWeekNumbers.TabIndex        = 1;
        // 
        // selectedRange
        // 
        selectedRange.Location = new System.Drawing.Point(
            325,
            125
        );
        selectedRange.Name = "selectedRange";
        selectedRange.Size = new System.Drawing.Size(
            125,
            25
        );
        selectedRange.TabIndex                =  2;
        selectedRange.Text                    =  "Selected Range";
        selectedRange.UseVisualStyleBackColor =  true;
        selectedRange.Click                   += selectedRange_Click;
        // 
        // start
        // 
        start.Location = new System.Drawing.Point(
            325,
            175
        );
        start.Name = "start";
        start.Size = new System.Drawing.Size(
            125,
            25
        );
        start.TabIndex                =  3;
        start.Text                    =  "Start";
        start.UseVisualStyleBackColor =  true;
        start.Click                   += start_Click;
        // 
        // end
        // 
        end.Location = new System.Drawing.Point(
            325,
            225
        );
        end.Name = "end";
        end.Size = new System.Drawing.Size(
            125,
            25
        );
        end.TabIndex                =  4;
        end.Text                    =  "End";
        end.UseVisualStyleBackColor =  true;
        end.Click                   += end_Click;
        // 
        // MonthCalendarExample
        // 
        ClientSize = new System.Drawing.Size(
            484,
            336
        );
        Controls.Add(
            end
        );
        Controls.Add(
            start
        );
        Controls.Add(
            selectedRange
        );
        Controls.Add(
            monthCalendarWithShowWeekNumbers
        );
        Controls.Add(
            title
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Month Calendar";
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button start;

    private System.Windows.Forms.Button end;

    private System.Windows.Forms.Button selectedRange;

    private System.Windows.Forms.MonthCalendar monthCalendarWithShowWeekNumbers;
    private System.Windows.Forms.Label         title;

    #endregion
}