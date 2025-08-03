using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsConcepts;

public partial class Drawing : Form {
    public Drawing() {
        InitializeComponent();
    }

    private void line_Paint(
        object         sender,
        PaintEventArgs e
    ) {
        Color color = Color.Red;
        Pen pen = new Pen(
            color
        );
        pen.Width = 5;

        pen.StartCap = LineCap.Round;
        pen.EndCap   = LineCap.Round;

        e.Graphics.DrawLine(
            pen,
            50,
            150,
            250,
            150
        );
    }

    private void rectangle_Paint(
        object         sender,
        PaintEventArgs e
    ) {
        Color color = Color.Red;
        Pen pen = new Pen(
            color
        );
        pen.Width = 5;

        pen.StartCap = LineCap.Round;
        pen.EndCap   = LineCap.Round;

        e.Graphics.DrawRectangle(
            pen,
            75,
            75,
            150,
            150
        );
    }

    private void ellipse_Paint(
        object         sender,
        PaintEventArgs e
    ) {
        Color color = Color.Red;
        Pen pen = new Pen(
            color
        );
        pen.Width     = 5;
        pen.DashStyle = DashStyle.Dash;

        pen.StartCap = LineCap.Round;
        pen.EndCap   = LineCap.Round;

        e.Graphics.DrawEllipse(
            pen,
            75,
            75,
            150,
            150
        );
    }
}