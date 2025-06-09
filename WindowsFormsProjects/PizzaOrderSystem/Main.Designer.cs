namespace PizzaOrderSystem;

partial class Main {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(
            typeof(Main)
        );
        title            = new System.Windows.Forms.Label();
        size             = new System.Windows.Forms.GroupBox();
        large            = new System.Windows.Forms.RadioButton();
        medium           = new System.Windows.Forms.RadioButton();
        small            = new System.Windows.Forms.RadioButton();
        toppings         = new System.Windows.Forms.GroupBox();
        greenPeppers     = new System.Windows.Forms.CheckBox();
        olives           = new System.Windows.Forms.CheckBox();
        onion            = new System.Windows.Forms.CheckBox();
        tomatoes         = new System.Windows.Forms.CheckBox();
        mushrooms        = new System.Windows.Forms.CheckBox();
        extraCheese      = new System.Windows.Forms.CheckBox();
        crustType        = new System.Windows.Forms.GroupBox();
        thick            = new System.Windows.Forms.RadioButton();
        thin             = new System.Windows.Forms.RadioButton();
        whereToEat       = new System.Windows.Forms.GroupBox();
        delivery         = new System.Windows.Forms.RadioButton();
        takeaway         = new System.Windows.Forms.RadioButton();
        dineInRestaurant = new System.Windows.Forms.RadioButton();
        size.SuspendLayout();
        toppings.SuspendLayout();
        crustType.SuspendLayout();
        whereToEat.SuspendLayout();
        SuspendLayout();
        // 
        // title
        // 
        title.Font = new System.Drawing.Font(
            "Corbel",
            30F,
            ((System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)),
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        title.ForeColor = System.Drawing.Color.DarkOrange;
        title.Location = new System.Drawing.Point(
            350,
            25
        );
        title.Margin = new System.Windows.Forms.Padding(
            4,
            0,
            4,
            0
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            300,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Make Your Pizza";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // size
        // 
        size.Controls.Add(
            large
        );
        size.Controls.Add(
            medium
        );
        size.Controls.Add(
            small
        );
        size.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        size.ForeColor = System.Drawing.Color.DarkOrange;
        size.Location = new System.Drawing.Point(
            50,
            125
        );
        size.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        size.Name = "size";
        size.Padding = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        size.Size = new System.Drawing.Size(
            150,
            135
        );
        size.TabIndex = 1;
        size.TabStop  = false;
        size.Text     = "Size";
        // 
        // large
        // 
        large.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        large.ForeColor = System.Drawing.Color.Black;
        large.Location = new System.Drawing.Point(
            15,
            95
        );
        large.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        large.Name = "large";
        large.Size = new System.Drawing.Size(
            100,
            25
        );
        large.TabIndex                = 4;
        large.TabStop                 = true;
        large.Text                    = "Large";
        large.UseVisualStyleBackColor = true;
        // 
        // medium
        // 
        medium.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        medium.ForeColor = System.Drawing.Color.Black;
        medium.Location = new System.Drawing.Point(
            15,
            60
        );
        medium.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        medium.Name = "medium";
        medium.Size = new System.Drawing.Size(
            100,
            25
        );
        medium.TabIndex                = 3;
        medium.TabStop                 = true;
        medium.Text                    = "Medium";
        medium.UseVisualStyleBackColor = true;
        // 
        // small
        // 
        small.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        small.ForeColor = System.Drawing.Color.Black;
        small.Location = new System.Drawing.Point(
            15,
            25
        );
        small.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        small.Name = "small";
        small.Size = new System.Drawing.Size(
            100,
            25
        );
        small.TabIndex                = 2;
        small.TabStop                 = true;
        small.Text                    = "Small";
        small.UseVisualStyleBackColor = true;
        // 
        // toppings
        // 
        toppings.Controls.Add(
            greenPeppers
        );
        toppings.Controls.Add(
            olives
        );
        toppings.Controls.Add(
            onion
        );
        toppings.Controls.Add(
            tomatoes
        );
        toppings.Controls.Add(
            mushrooms
        );
        toppings.Controls.Add(
            extraCheese
        );
        toppings.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        toppings.ForeColor = System.Drawing.Color.DarkOrange;
        toppings.Location = new System.Drawing.Point(
            225,
            125
        );
        toppings.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        toppings.Name = "toppings";
        toppings.Padding = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        toppings.Size = new System.Drawing.Size(
            250,
            135
        );
        toppings.TabIndex = 5;
        toppings.TabStop  = false;
        toppings.Text     = "Toppings";
        // 
        // greenPeppers
        // 
        greenPeppers.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        greenPeppers.ForeColor = System.Drawing.Color.Black;
        greenPeppers.Location = new System.Drawing.Point(
            125,
            95
        );
        greenPeppers.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        greenPeppers.Name = "greenPeppers";
        greenPeppers.Size = new System.Drawing.Size(
            110,
            25
        );
        greenPeppers.TabIndex                = 11;
        greenPeppers.Text                    = "Green Peppers";
        greenPeppers.UseVisualStyleBackColor = true;
        // 
        // olives
        // 
        olives.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        olives.ForeColor = System.Drawing.Color.Black;
        olives.Location = new System.Drawing.Point(
            125,
            60
        );
        olives.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        olives.Name = "olives";
        olives.Size = new System.Drawing.Size(
            100,
            25
        );
        olives.TabIndex                = 10;
        olives.Text                    = "Olives";
        olives.UseVisualStyleBackColor = true;
        // 
        // onion
        // 
        onion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        onion.ForeColor = System.Drawing.Color.Black;
        onion.Location = new System.Drawing.Point(
            125,
            25
        );
        onion.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        onion.Name = "onion";
        onion.Size = new System.Drawing.Size(
            100,
            25
        );
        onion.TabIndex                = 9;
        onion.Text                    = "Onion";
        onion.UseVisualStyleBackColor = true;
        // 
        // tomatoes
        // 
        tomatoes.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        tomatoes.ForeColor = System.Drawing.Color.Black;
        tomatoes.Location = new System.Drawing.Point(
            15,
            95
        );
        tomatoes.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        tomatoes.Name = "tomatoes";
        tomatoes.Size = new System.Drawing.Size(
            100,
            25
        );
        tomatoes.TabIndex                = 8;
        tomatoes.Text                    = "Tomatoes";
        tomatoes.UseVisualStyleBackColor = true;
        // 
        // mushrooms
        // 
        mushrooms.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        mushrooms.ForeColor = System.Drawing.Color.Black;
        mushrooms.Location = new System.Drawing.Point(
            15,
            60
        );
        mushrooms.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        mushrooms.Name = "mushrooms";
        mushrooms.Size = new System.Drawing.Size(
            100,
            25
        );
        mushrooms.TabIndex                = 7;
        mushrooms.Text                    = "Mushrooms";
        mushrooms.UseVisualStyleBackColor = true;
        // 
        // extraCheese
        // 
        extraCheese.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        extraCheese.ForeColor = System.Drawing.Color.Black;
        extraCheese.Location = new System.Drawing.Point(
            15,
            25
        );
        extraCheese.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        extraCheese.Name = "extraCheese";
        extraCheese.Size = new System.Drawing.Size(
            100,
            25
        );
        extraCheese.TabIndex                = 6;
        extraCheese.Text                    = "Extra Cheese";
        extraCheese.UseVisualStyleBackColor = true;
        // 
        // crustType
        // 
        crustType.Controls.Add(
            thick
        );
        crustType.Controls.Add(
            thin
        );
        crustType.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        crustType.ForeColor = System.Drawing.Color.DarkOrange;
        crustType.Location = new System.Drawing.Point(
            50,
            275
        );
        crustType.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        crustType.Name = "crustType";
        crustType.Padding = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        crustType.Size = new System.Drawing.Size(
            150,
            105
        );
        crustType.TabIndex = 12;
        crustType.TabStop  = false;
        crustType.Text     = "Crust Type";
        // 
        // thick
        // 
        thick.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        thick.ForeColor = System.Drawing.Color.Black;
        thick.Location = new System.Drawing.Point(
            15,
            60
        );
        thick.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        thick.Name = "thick";
        thick.Size = new System.Drawing.Size(
            100,
            25
        );
        thick.TabIndex                = 14;
        thick.TabStop                 = true;
        thick.Text                    = "Thick";
        thick.UseVisualStyleBackColor = true;
        // 
        // thin
        // 
        thin.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        thin.ForeColor = System.Drawing.Color.Black;
        thin.Location = new System.Drawing.Point(
            15,
            25
        );
        thin.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        thin.Name = "thin";
        thin.Size = new System.Drawing.Size(
            100,
            25
        );
        thin.TabIndex                = 13;
        thin.TabStop                 = true;
        thin.Text                    = "Thin";
        thin.UseVisualStyleBackColor = true;
        // 
        // whereToEat
        // 
        whereToEat.Controls.Add(
            delivery
        );
        whereToEat.Controls.Add(
            takeaway
        );
        whereToEat.Controls.Add(
            dineInRestaurant
        );
        whereToEat.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        whereToEat.ForeColor = System.Drawing.Color.DarkOrange;
        whereToEat.Location = new System.Drawing.Point(
            225,
            275
        );
        whereToEat.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        whereToEat.Name = "whereToEat";
        whereToEat.Padding = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        whereToEat.Size = new System.Drawing.Size(
            250,
            135
        );
        whereToEat.TabIndex = 15;
        whereToEat.TabStop  = false;
        whereToEat.Text     = "Where to Eat";
        // 
        // delivery
        // 
        delivery.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        delivery.ForeColor = System.Drawing.Color.Black;
        delivery.Location = new System.Drawing.Point(
            15,
            95
        );
        delivery.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        delivery.Name = "delivery";
        delivery.Size = new System.Drawing.Size(
            100,
            25
        );
        delivery.TabIndex                = 18;
        delivery.TabStop                 = true;
        delivery.Text                    = "Delivery";
        delivery.UseVisualStyleBackColor = true;
        // 
        // takeaway
        // 
        takeaway.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        takeaway.ForeColor = System.Drawing.Color.Black;
        takeaway.Location = new System.Drawing.Point(
            15,
            60
        );
        takeaway.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        takeaway.Name = "takeaway";
        takeaway.Size = new System.Drawing.Size(
            100,
            25
        );
        takeaway.TabIndex                = 17;
        takeaway.TabStop                 = true;
        takeaway.Text                    = "Takeaway";
        takeaway.UseVisualStyleBackColor = true;
        // 
        // dineInRestaurant
        // 
        dineInRestaurant.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        dineInRestaurant.ForeColor = System.Drawing.Color.Black;
        dineInRestaurant.Location = new System.Drawing.Point(
            15,
            25
        );
        dineInRestaurant.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        dineInRestaurant.Name = "dineInRestaurant";
        dineInRestaurant.Size = new System.Drawing.Size(
            125,
            25
        );
        dineInRestaurant.TabIndex                = 16;
        dineInRestaurant.TabStop                 = true;
        dineInRestaurant.Text                    = "Dine in Restaurant";
        dineInRestaurant.UseVisualStyleBackColor = true;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            984,
            561
        );
        Controls.Add(
            whereToEat
        );
        Controls.Add(
            crustType
        );
        Controls.Add(
            toppings
        );
        Controls.Add(
            size
        );
        Controls.Add(
            title
        );
        Icon = ((System.Drawing.Icon) resources.GetObject(
                       "$this.Icon"
                   ));
        Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          = "Pizza Order System";
        size.ResumeLayout(
            false
        );
        toppings.ResumeLayout(
            false
        );
        crustType.ResumeLayout(
            false
        );
        whereToEat.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.GroupBox    whereToEat;
    private System.Windows.Forms.RadioButton takeaway;
    private System.Windows.Forms.RadioButton dineInRestaurant;
    private System.Windows.Forms.RadioButton delivery;

    private System.Windows.Forms.GroupBox    crustType;
    private System.Windows.Forms.RadioButton thick;
    private System.Windows.Forms.RadioButton thin;

    private System.Windows.Forms.GroupBox toppings;
    private System.Windows.Forms.CheckBox onion;
    private System.Windows.Forms.CheckBox greenPeppers;
    private System.Windows.Forms.CheckBox olives;
    private System.Windows.Forms.CheckBox tomatoes;
    private System.Windows.Forms.CheckBox mushrooms;
    private System.Windows.Forms.CheckBox extraCheese;

    private System.Windows.Forms.GroupBox size;
    private System.Windows.Forms.RadioButton small;
    private System.Windows.Forms.RadioButton medium;
    private System.Windows.Forms.RadioButton large;

    private System.Windows.Forms.Label title;

    #endregion
}