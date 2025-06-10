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
        crustTypeInformation.Text  = "";
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

    private void small_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        sizeInformation.Text = small.Text;
    }

    private void medium_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        sizeInformation.Text = medium.Text;
    }

    private void large_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        sizeInformation.Text = large.Text;
    }

    private void thin_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        crustTypeInformation.Text = thin.Text;
    }

    private void thick_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        crustTypeInformation.Text = thick.Text;
    }

    private void dineInRestaurant_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        whereToEatInformation.Text = dineInRestaurant.Text;
    }

    private void takeaway_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        whereToEatInformation.Text = takeaway.Text;
    }

    private void delivery_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        whereToEatInformation.Text = delivery.Text;
    }
}