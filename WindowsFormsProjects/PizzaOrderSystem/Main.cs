namespace PizzaOrderSystem;

public partial class Main : Form {
    public Main() {
        InitializeComponent();
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
        crushTypeInformation.Text  = "";
        whereToEatInformation.Text = "";
        totalPriceInformation.Text = "";
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
}