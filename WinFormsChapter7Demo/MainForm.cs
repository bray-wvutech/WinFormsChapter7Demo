namespace WinFormsChapter7Demo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        carPictureBox.Image = carImageList.Images[0];
    }

    private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        carPictureBox.Image = carImageList.Images[1];
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        carPictureBox.Image = carImageList.Images[2];
    }

    private void redRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        carPictureBox.Image = carImageList.Images[3];
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }
}
