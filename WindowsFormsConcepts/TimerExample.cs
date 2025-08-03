using System;
using System.Windows.Forms;

namespace WindowsFormsConcepts;

public partial class TimerExample : Form {
    private enum Mode {
        Start,
        Pause,
        Continue,
        End
    }

    private Mode currentMode = Mode.End;
    private long count;

    public TimerExample() {
        InitializeComponent();
    }

    private void timerSample_Tick(
        object    sender,
        EventArgs e
    ) {
        counter.Text = (++count).ToString();
    }

    private void startAndContinue_Click(
        object    sender,
        EventArgs e
    ) {
        switch (currentMode) {
            case Mode.End:
                currentMode              = Mode.Start;
                timerSample.Enabled      = true;
                startAndContinue.Text    = @"Continue";
                startAndContinue.Enabled = false;
                pauseAndEnd.Enabled      = true;
            break;
            case Mode.Pause:
                currentMode              = Mode.Continue;
                timerSample.Enabled      = true;
                startAndContinue.Enabled = false;
                pauseAndEnd.Enabled      = true;
                pauseAndEnd.Text         = @"Pause";
            break;
        }
    }

    private void pauseAndEnd_Click(
        object    sender,
        EventArgs e
    ) {
        switch (currentMode) {
            case Mode.Start:
            case Mode.Continue:
                currentMode              = Mode.Pause;
                timerSample.Enabled      = false;
                startAndContinue.Enabled = true;
                pauseAndEnd.Text         = @"End";
            break;
            case Mode.Pause:
                currentMode = Mode.End;
                timerSample.Stop();
                count                    = 0;
                counter.Text             = count.ToString();
                startAndContinue.Enabled = true;
                startAndContinue.Text    = @"Start";
                pauseAndEnd.Enabled      = false;
                pauseAndEnd.Text    = @"Pause";
            break;
        }
    }
}