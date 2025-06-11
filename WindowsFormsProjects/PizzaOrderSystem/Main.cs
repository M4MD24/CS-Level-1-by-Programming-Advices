using PizzaOrderSystem.models;

namespace PizzaOrderSystem;

public partial class Main : Form {
    private readonly List<string?> choices = [];
    private          double        totalPrice;
    private          Order         currentOrder = new();

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
        order.Enabled = true;
        currentOrder  = new Order();
    }

    private void resetOrderInformation() {
        sizeInformation.Text = toppingsInformation.Text
                                       = crustTypeInformation.Text
                                                 = whereToEatInformation.Text = "";
        totalPriceInformation.Text = "0";
    }

    private void resetWhereToEat() {
        foreach (RadioButton radioButton in whereToEat.Controls.OfType<RadioButton>())
            radioButton.Checked = false;
        whereToEat.Enabled = true;
    }

    private void resetCrustType() {
        foreach (RadioButton radioButton in crustType.Controls.OfType<RadioButton>())
            radioButton.Checked = false;
        crustType.Enabled = true;
    }

    private void resetToppings() {
        foreach (CheckBox checkBox in toppings.Controls.OfType<CheckBox>())
            checkBox.Checked = false;
        toppings.Enabled = true;
    }

    private void resetSize() {
        foreach (RadioButton radioButton in size.Controls.OfType<RadioButton>())
            radioButton.Checked = false;
        size.Enabled = true;
    }

    private void small_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            small,
            sizeInformation
        );
    }

    private void medium_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            medium,
            sizeInformation
        );
    }

    private void large_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            large,
            sizeInformation
        );
    }

    private void thin_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            thin,
            crustTypeInformation
        );
    }

    private void thick_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            thick,
            crustTypeInformation
        );
    }

    private void dineInRestaurant_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            dineInRestaurant,
            whereToEatInformation
        );
    }

    private void takeaway_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            takeaway,
            whereToEatInformation
        );
    }

    private void delivery_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateOrderInformation(
            delivery,
            whereToEatInformation
        );
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
        totalPriceInformation.Text = (currentOrder.totalPrice = totalPrice).ToString();
    }

    private void updateOrderInformation(
        RadioButton radioButton,
        Label       information
    ) {
        information.Text = radioButton.Text;
        updateCurrentOrder(
            radioButton,
            information
        );
        totalPrice += radioButton.Checked
                              ? Convert.ToDouble(
                                  radioButton.Tag
                              )
                              : -Convert.ToDouble(
                                    radioButton.Tag
                                );
        updateTotalPriceInformation();
    }

    private void updateCurrentOrder(
        RadioButton radioButton,
        Label       information
    ) {
        if (information == sizeInformation)
            currentOrder.size = radioButton.Text;
        else if (information == toppingsInformation)
            currentOrder.toppings = radioButton.Text;
        else if (information == crustTypeInformation)
            currentOrder.crustType = radioButton.Text;
        else if (information == whereToEatInformation)
            currentOrder.whereToEat = radioButton.Text;
    }

    private void order_Click(
        object    sender,
        EventArgs e
    ) {
        if (
            MessageBox.Show(
                "Are you sure?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            ) == DialogResult.No
        )
            return;

        if (currentOrder.isComplete()) {
            size.Enabled       = false;
            toppings.Enabled   = false;
            crustType.Enabled  = false;
            whereToEat.Enabled = false;
            order.Enabled      = false;
        } else
            MessageBox.Show(
                "Your order is incomplete",
                "Order Status",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
    }
}