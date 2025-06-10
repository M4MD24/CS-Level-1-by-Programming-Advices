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
        title                 = new System.Windows.Forms.Label();
        size                  = new System.Windows.Forms.GroupBox();
        large                 = new System.Windows.Forms.RadioButton();
        medium                = new System.Windows.Forms.RadioButton();
        small                 = new System.Windows.Forms.RadioButton();
        toppings              = new System.Windows.Forms.GroupBox();
        greenPeppers          = new System.Windows.Forms.CheckBox();
        olives                = new System.Windows.Forms.CheckBox();
        onion                 = new System.Windows.Forms.CheckBox();
        tomatoes              = new System.Windows.Forms.CheckBox();
        mushrooms             = new System.Windows.Forms.CheckBox();
        extraCheese           = new System.Windows.Forms.CheckBox();
        crustType             = new System.Windows.Forms.GroupBox();
        thick                 = new System.Windows.Forms.RadioButton();
        thin                  = new System.Windows.Forms.RadioButton();
        whereToEat            = new System.Windows.Forms.GroupBox();
        delivery              = new System.Windows.Forms.RadioButton();
        takeaway              = new System.Windows.Forms.RadioButton();
        dineInRestaurant      = new System.Windows.Forms.RadioButton();
        orderInformation      = new System.Windows.Forms.GroupBox();
        symbol                = new System.Windows.Forms.Label();
        totalPriceInformation = new System.Windows.Forms.Label();
        totalPriceQuestion    = new System.Windows.Forms.Label();
        whereToEatInformation = new System.Windows.Forms.Label();
        whereToEatQuestion    = new System.Windows.Forms.Label();
        crustTypeInformation  = new System.Windows.Forms.Label();
        crustTypeQuestion     = new System.Windows.Forms.Label();
        toppingsInformation   = new System.Windows.Forms.Label();
        toppingsQuestion      = new System.Windows.Forms.Label();
        sizeInformation       = new System.Windows.Forms.Label();
        sizeQuestion          = new System.Windows.Forms.Label();
        order                 = new System.Windows.Forms.Button();
        reset                 = new System.Windows.Forms.Button();
        size.SuspendLayout();
        toppings.SuspendLayout();
        crustType.SuspendLayout();
        whereToEat.SuspendLayout();
        orderInformation.SuspendLayout();
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
            270,
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
            12F,
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
        large.TabIndex                =  4;
        large.Text                    =  "Large";
        large.UseVisualStyleBackColor =  true;
        large.CheckedChanged          += large_CheckedChanged;
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
        medium.TabIndex                =  3;
        medium.Text                    =  "Medium";
        medium.UseVisualStyleBackColor =  true;
        medium.CheckedChanged          += medium_CheckedChanged;
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
        small.TabIndex                =  2;
        small.Text                    =  "Small";
        small.UseVisualStyleBackColor =  true;
        small.CheckedChanged          += small_CheckedChanged;
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
            12F,
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
            12F,
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
        thick.TabIndex                =  14;
        thick.TabStop                 =  true;
        thick.Text                    =  "Thick";
        thick.UseVisualStyleBackColor =  true;
        thick.CheckedChanged          += thick_CheckedChanged;
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
        thin.TabIndex                =  13;
        thin.TabStop                 =  true;
        thin.Text                    =  "Thin";
        thin.UseVisualStyleBackColor =  true;
        thin.CheckedChanged          += thin_CheckedChanged;
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
            12F,
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
        delivery.TabIndex                =  18;
        delivery.TabStop                 =  true;
        delivery.Text                    =  "Delivery";
        delivery.UseVisualStyleBackColor =  true;
        delivery.CheckedChanged          += delivery_CheckedChanged;
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
        takeaway.TabIndex                =  17;
        takeaway.TabStop                 =  true;
        takeaway.Text                    =  "Takeaway";
        takeaway.UseVisualStyleBackColor =  true;
        takeaway.CheckedChanged          += takeaway_CheckedChanged;
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
        dineInRestaurant.TabIndex                =  16;
        dineInRestaurant.TabStop                 =  true;
        dineInRestaurant.Text                    =  "Dine in Restaurant";
        dineInRestaurant.UseVisualStyleBackColor =  true;
        dineInRestaurant.CheckedChanged          += dineInRestaurant_CheckedChanged;
        // 
        // orderInformation
        // 
        orderInformation.Controls.Add(
            symbol
        );
        orderInformation.Controls.Add(
            totalPriceInformation
        );
        orderInformation.Controls.Add(
            totalPriceQuestion
        );
        orderInformation.Controls.Add(
            whereToEatInformation
        );
        orderInformation.Controls.Add(
            whereToEatQuestion
        );
        orderInformation.Controls.Add(
            crustTypeInformation
        );
        orderInformation.Controls.Add(
            crustTypeQuestion
        );
        orderInformation.Controls.Add(
            toppingsInformation
        );
        orderInformation.Controls.Add(
            toppingsQuestion
        );
        orderInformation.Controls.Add(
            sizeInformation
        );
        orderInformation.Controls.Add(
            sizeQuestion
        );
        orderInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        orderInformation.ForeColor = System.Drawing.Color.DarkOrange;
        orderInformation.Location = new System.Drawing.Point(
            525,
            125
        );
        orderInformation.Margin = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        orderInformation.Name = "orderInformation";
        orderInformation.Padding = new System.Windows.Forms.Padding(
            4,
            3,
            4,
            3
        );
        orderInformation.Size = new System.Drawing.Size(
            250,
            240
        );
        orderInformation.TabIndex = 19;
        orderInformation.TabStop  = false;
        orderInformation.Text     = "Order Information";
        // 
        // symbol
        // 
        symbol.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        symbol.ForeColor  = System.Drawing.Color.DarkOrange;
        symbol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        symbol.Location = new System.Drawing.Point(
            125,
            200
        );
        symbol.Name = "symbol";
        symbol.Size = new System.Drawing.Size(
            30,
            25
        );
        symbol.TabIndex  = 30;
        symbol.Text      = "EGP";
        symbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // totalPriceInformation
        // 
        totalPriceInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        totalPriceInformation.ForeColor = System.Drawing.Color.Black;
        totalPriceInformation.Location = new System.Drawing.Point(
            90,
            200
        );
        totalPriceInformation.Name = "totalPriceInformation";
        totalPriceInformation.Size = new System.Drawing.Size(
            30,
            25
        );
        totalPriceInformation.TabIndex  = 29;
        totalPriceInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // totalPriceQuestion
        // 
        totalPriceQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        totalPriceQuestion.Location = new System.Drawing.Point(
            15,
            200
        );
        totalPriceQuestion.Name = "totalPriceQuestion";
        totalPriceQuestion.Size = new System.Drawing.Size(
            70,
            25
        );
        totalPriceQuestion.TabIndex  = 28;
        totalPriceQuestion.Text      = "Total Price:";
        totalPriceQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // whereToEatInformation
        // 
        whereToEatInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        whereToEatInformation.ForeColor  = System.Drawing.Color.Black;
        whereToEatInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        whereToEatInformation.Location = new System.Drawing.Point(
            105,
            165
        );
        whereToEatInformation.Name = "whereToEatInformation";
        whereToEatInformation.Size = new System.Drawing.Size(
            130,
            25
        );
        whereToEatInformation.TabIndex  = 27;
        whereToEatInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // whereToEatQuestion
        // 
        whereToEatQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        whereToEatQuestion.Location = new System.Drawing.Point(
            15,
            165
        );
        whereToEatQuestion.Name = "whereToEatQuestion";
        whereToEatQuestion.Size = new System.Drawing.Size(
            85,
            25
        );
        whereToEatQuestion.TabIndex  = 26;
        whereToEatQuestion.Text      = "Where to Eat:";
        whereToEatQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // crustTypeInformation
        // 
        crustTypeInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        crustTypeInformation.ForeColor  = System.Drawing.Color.Black;
        crustTypeInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        crustTypeInformation.Location = new System.Drawing.Point(
            90,
            130
        );
        crustTypeInformation.Name = "crustTypeInformation";
        crustTypeInformation.Size = new System.Drawing.Size(
            145,
            25
        );
        crustTypeInformation.TabIndex  = 25;
        crustTypeInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // crustTypeQuestion
        // 
        crustTypeQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        crustTypeQuestion.Location = new System.Drawing.Point(
            15,
            130
        );
        crustTypeQuestion.Name = "crustTypeQuestion";
        crustTypeQuestion.Size = new System.Drawing.Size(
            70,
            25
        );
        crustTypeQuestion.TabIndex  = 24;
        crustTypeQuestion.Text      = "Crust Type:";
        crustTypeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // toppingsInformation
        // 
        toppingsInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        toppingsInformation.ForeColor  = System.Drawing.Color.Black;
        toppingsInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        toppingsInformation.Location = new System.Drawing.Point(
            15,
            90
        );
        toppingsInformation.Name = "toppingsInformation";
        toppingsInformation.Size = new System.Drawing.Size(
            220,
            30
        );
        toppingsInformation.TabIndex = 23;
        // 
        // toppingsQuestion
        // 
        toppingsQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        toppingsQuestion.Location = new System.Drawing.Point(
            15,
            60
        );
        toppingsQuestion.Name = "toppingsQuestion";
        toppingsQuestion.Size = new System.Drawing.Size(
            60,
            25
        );
        toppingsQuestion.TabIndex  = 22;
        toppingsQuestion.Text      = "Toppings:";
        toppingsQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // sizeInformation
        // 
        sizeInformation.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        sizeInformation.ForeColor  = System.Drawing.Color.Black;
        sizeInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        sizeInformation.Location = new System.Drawing.Point(
            55,
            25
        );
        sizeInformation.Name = "sizeInformation";
        sizeInformation.Size = new System.Drawing.Size(
            180,
            25
        );
        sizeInformation.TabIndex  = 21;
        sizeInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // sizeQuestion
        // 
        sizeQuestion.Font = new System.Drawing.Font(
            "Segoe UI",
            9F,
            System.Drawing.FontStyle.Bold
        );
        sizeQuestion.Location = new System.Drawing.Point(
            15,
            25
        );
        sizeQuestion.Name = "sizeQuestion";
        sizeQuestion.Size = new System.Drawing.Size(
            35,
            25
        );
        sizeQuestion.TabIndex  = 20;
        sizeQuestion.Text      = "Size:";
        sizeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // order
        // 
        order.Font = new System.Drawing.Font(
            "Corbel",
            12F,
            ((System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)),
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        order.ForeColor = System.Drawing.Color.DarkOrange;
        order.Location = new System.Drawing.Point(
            270,
            500
        );
        order.Name = "order";
        order.Size = new System.Drawing.Size(
            100,
            30
        );
        order.TabIndex                = 32;
        order.Text                    = "Order";
        order.UseVisualStyleBackColor = false;
        // 
        // reset
        // 
        reset.Font = new System.Drawing.Font(
            "Corbel",
            12F,
            ((System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)),
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        reset.ForeColor = System.Drawing.Color.DarkOrange;
        reset.Location = new System.Drawing.Point(
            470,
            500
        );
        reset.Name = "reset";
        reset.Size = new System.Drawing.Size(
            100,
            30
        );
        reset.TabIndex                =  31;
        reset.Text                    =  "Reset";
        reset.UseVisualStyleBackColor =  false;
        reset.Click                   += reset_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            824,
            561
        );
        Controls.Add(
            reset
        );
        Controls.Add(
            order
        );
        Controls.Add(
            orderInformation
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
        orderInformation.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label totalPriceInformation;

    private System.Windows.Forms.Label symbol;

    private System.Windows.Forms.Label totalPriceQuestion;

    private System.Windows.Forms.Button reset;

    private System.Windows.Forms.Button order;

    private System.Windows.Forms.Label whereToEatInformation;
    private System.Windows.Forms.Label whereToEatQuestion;

    private System.Windows.Forms.Label crustTypeInformation;
    private System.Windows.Forms.Label crustTypeQuestion;

    private System.Windows.Forms.Label toppingsInformation;
    private System.Windows.Forms.Label toppingsQuestion;

    private System.Windows.Forms.Label sizeInformation;

    private System.Windows.Forms.Label sizeQuestion;

    private System.Windows.Forms.GroupBox orderInformation;

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

    private System.Windows.Forms.GroupBox    size;
    private System.Windows.Forms.RadioButton small;
    private System.Windows.Forms.RadioButton medium;
    private System.Windows.Forms.RadioButton large;

    private System.Windows.Forms.Label title;

    #endregion
}