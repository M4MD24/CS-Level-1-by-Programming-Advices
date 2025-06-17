using System.ComponentModel;

namespace WindowsFormsConcepts;

public partial class ErrorProviderExample : Form {
    public ErrorProviderExample() {
        InitializeComponent();
    }

    private void firstNameAnswer_Validating(
        object          sender,
        CancelEventArgs e
    ) {
        privateCheckNameValue(
            e,
            firstNameAnswer
        );
    }

    private void secondNameAnswer_Validating(
        object          sender,
        CancelEventArgs e
    ) {
        privateCheckNameValue(
            e,
            secondNameAnswer
        );
    }

    private void privateCheckNameValue(
        CancelEventArgs e,
        TextBox         field
    ) {
        if (
            string.IsNullOrWhiteSpace(
                field.Text
            )
        ) {
            e.Cancel = true;
            field.Focus();
            errorProviderSample.SetError(
                field,
                $"{
                    (
                        field == firstNameAnswer
                                ? "First"
                                : "Second"
                    )
                } name should have a value"
            );
        } else {
            e.Cancel = false;
            errorProviderSample.SetError(
                field,
                ""
            );
        }
    }
}