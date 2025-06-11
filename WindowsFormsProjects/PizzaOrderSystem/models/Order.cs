namespace PizzaOrderSystem.models;

public class Order {
    public string size       = "",
                  toppings   = "",
                  crustType  = "",
                  whereToEat = "";
    public double totalPrice = 0.0;

    public bool isComplete() {
        return size       != "" &&
               crustType  != "" &&
               whereToEat != "";
    }
}