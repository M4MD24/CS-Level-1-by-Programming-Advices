using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsConcepts.PictureBox;

public partial class PictureBoxExample : Form {
    public PictureBoxExample() {
        InitializeComponent();
    }

    private void one_Click(
        object    sender,
        EventArgs e
    ) {
        number.Image = Image.FromFile(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsConcepts\PictureBox\resources\OneSquareFill.png"
        );
    }

    private void two_Click(
        object    sender,
        EventArgs e
    ) {
        number.Image = Image.FromFile(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsConcepts\PictureBox\resources\TwoSquareFill.png"
        );
    }

    private void three_Click(
        object    sender,
        EventArgs e
    ) {
        number.Image = Image.FromFile(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsConcepts\PictureBox\resources\ThreeSquareFill.png"
        );
    }
}