namespace PizzaOrderSystem;

public partial class Main : Form {
    private List<string?> choices = [];
    private double        totalPrice;

    public Main() {
        InitializeComponent();
    }

    private void Main_Load(
        object    sender,
        EventArgs e
    ) {
        initializeTags();
    }

    private void initializeTags() {
        small.Tag            = 1;
        medium.Tag           = 2;
        large.Tag            = 3;
        extraCheese.Tag      = "Extra Cheese,2.25";
        mushrooms.Tag        = "Mushrooms,2.5";
        tomatoes.Tag         = "Tomatoes,2.75";
        onion.Tag            = "Onion,2.5";
        olives.Tag           = "Olives,3";
        greenPeppers.Tag     = "Green Peppers,2";
        thin.Tag             = 1;
        thick.Tag            = 2;
        dineInRestaurant.Tag = 0;
        takeaway.Tag         = 1;
        delivery.Tag         = 2;
    }

    private void reset_Click(
        object    sender,
        EventArgs e
    ) {
        resetSize();
        resetToppings();
        resetCrustType();
        resetWhereToEat();
        resetOrderInformation();
    }

    private void resetOrderInformation() {
        sizeInformation.Text       = "";
        toppingsInformation.Text   = "";
        crustTypeInformation.Text  = "";
        whereToEatInformation.Text = "";
        totalPriceInformation.Text = "0";
    }

    private void resetWhereToEat() {
        dineInRestaurant.Checked = false;
        takeaway.Checked         = false;
        delivery.Checked         = false;
    }

    private void resetCrustType() {
        thin.Checked  = false;
        thick.Checked = false;
    }

    private void resetToppings() {
        extraCheese.Checked  = false;
        mushrooms.Checked    = false;
        tomatoes.Checked     = false;
        onion.Checked        = false;
        olives.Checked       = false;
        greenPeppers.Checked = false;
    }

    private void resetSize() {
        small.Checked  = false;
        medium.Checked = false;
        large.Checked  = false;
    }

    private void small_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        sizeInformation.Text = small.Text;
        if (small.Checked)
            totalPrice += Convert.ToDouble(
                small.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                small.Tag
            );
        updateTotalPriceInformation();
    }

    private void medium_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        sizeInformation.Text = medium.Text;
        if (medium.Checked)
            totalPrice += Convert.ToDouble(
                medium.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                medium.Tag
            );
        updateTotalPriceInformation();
    }

    private void large_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        sizeInformation.Text = large.Text;
        if (large.Checked)
            totalPrice += Convert.ToDouble(
                large.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                large.Tag
            );
        updateTotalPriceInformation();
    }

    private void thin_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        crustTypeInformation.Text = thin.Text;
        if (thin.Checked)
            totalPrice += Convert.ToDouble(
                thin.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                thin.Tag
            );
        updateTotalPriceInformation();
    }

    private void thick_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        crustTypeInformation.Text = thick.Text;
        if (thick.Checked)
            totalPrice += Convert.ToDouble(
                thick.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                thick.Tag
            );
        updateTotalPriceInformation();
    }

    private void dineInRestaurant_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        whereToEatInformation.Text = dineInRestaurant.Text;
        if (dineInRestaurant.Checked)
            totalPrice += Convert.ToDouble(
                dineInRestaurant.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                dineInRestaurant.Tag
            );
        updateTotalPriceInformation();
    }

    private void takeaway_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        whereToEatInformation.Text = takeaway.Text;
        if (takeaway.Checked)
            totalPrice += Convert.ToDouble(
                takeaway.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                takeaway.Tag
            );
        updateTotalPriceInformation();
    }

    private void delivery_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        whereToEatInformation.Text = delivery.Text;
        if (delivery.Checked)
            totalPrice += Convert.ToDouble(
                delivery.Tag
            );
        else
            totalPrice -= Convert.ToDouble(
                delivery.Tag
            );
        updateTotalPriceInformation();
    }

    private void extraCheese_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateToppings(
            extraCheese
        );
    }

    private void mushrooms_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateToppings(
            mushrooms
        );
    }

    private void tomatoes_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateToppings(
            tomatoes
        );
    }

    private void onion_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateToppings(
            onion
        );
    }

    private void olives_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateToppings(
            olives
        );
    }

    private void greenPeppers_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateToppings(
            greenPeppers
        );
    }

    private void updateToppings(
        CheckBox choice
    ) {
        string[] data = choice.Tag!
                              .ToString()!
                              .Split(
                                  ','
                              );
        string name = data[0];
        double price = double.Parse(
            data[1]
        );

        if (choice.Checked) {
            choices.Add(
                name
            );
            totalPrice += price;
        } else {
            choices.Remove(
                name
            );
            totalPrice -= price;
        }

        updateToppingsInformation();
        updateTotalPriceInformation();
    }

    private void updateToppingsInformation() {
        toppingsInformation.Text = string.Join(
            ", ",
            choices
        );
    }

    private void updateTotalPriceInformation() {
        totalPriceInformation.Text = totalPrice.ToString();
    }
}