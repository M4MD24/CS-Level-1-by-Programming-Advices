namespace WindowsFormsConcepts.ListView.models;

public class Item {
    private string title       = "",
                   description = "",
                   color       = "";

    public Item() {}

    public Item(
        string title,
        string description,
        string color
    ) {
        this.title       = title;
        this.description = description;
        this.color       = color;
    }

    public string getTitle() {
        return title;
    }

    public void setTitle(
        string titleValue
    ) {
        title = titleValue;
    }

    public string getDescription() {
        return description;
    }

    public void setDescription(
        string descriptionValue
    ) {
        description = descriptionValue;
    }

    public string getColor() {
        return color;
    }

    public void setColor(
        string colorValue
    ) {
        color = colorValue;
    }
}