using System.ComponentModel;

namespace WindowsFormsConcepts.DateTimeControls;

partial class DateTimePickerExample {
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
        title          = new System.Windows.Forms.Label();
        dateTimePicker = new System.Windows.Forms.DateTimePicker();
        showShortDate  = new System.Windows.Forms.Button();
        showLongDate   = new System.Windows.Forms.Button();
        dates          = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Fira Code",
            27F,
            System.Drawing.FontStyle.Bold
        );
        title.ForeColor = System.Drawing.Color.LightSeaGreen;
        title.Location = new System.Drawing.Point(
            50,
            32
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            400,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "DateTime Picker";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateTimePicker
        // 
        dateTimePicker.Location = new System.Drawing.Point(
            150,
            300
        );
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new System.Drawing.Size(
            200,
            23
        );
        dateTimePicker.TabIndex     =  1;
        dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
        // 
        // showShortDate
        // 
        showShortDate.Location = new System.Drawing.Point(
            50,
            350
        );
        showShortDate.Name = "showShortDate";
        showShortDate.Size = new System.Drawing.Size(
            125,
            25
        );
        showShortDate.TabIndex                =  2;
        showShortDate.Text                    =  "Show Short Date";
        showShortDate.UseVisualStyleBackColor =  true;
        showShortDate.Click                   += showShortDate_Click;
        // 
        // showLongDate
        // 
        showLongDate.Location = new System.Drawing.Point(
            325,
            350
        );
        showLongDate.Name = "showLongDate";
        showLongDate.Size = new System.Drawing.Size(
            125,
            25
        );
        showLongDate.TabIndex                =  3;
        showLongDate.Text                    =  "Show Long Date";
        showLongDate.UseVisualStyleBackColor =  true;
        showLongDate.Click                   += showLongDate_Click;
        // 
        // dates
        // 
        dates.Location = new System.Drawing.Point(
            50,
            125
        );
        dates.Name = "dates";
        dates.Size = new System.Drawing.Size(
            400,
            150
        );
        dates.TabIndex = 4;
        // 
        // DateTimePickerExample
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            484,
            411
        );
        Controls.Add(
            dates
        );
        Controls.Add(
            showLongDate
        );
        Controls.Add(
            showShortDate
        );
        Controls.Add(
            dateTimePicker
        );
        Controls.Add(
            title
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "DateTimePicker";
        Load          += DateTimePickerExample_Load;
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label dates;

    private System.Windows.Forms.Button showShortDate;

    private System.Windows.Forms.Button showLongDate;

    private System.Windows.Forms.DateTimePicker dateTimePicker;

    private System.Windows.Forms.Label title;

    #endregion
}