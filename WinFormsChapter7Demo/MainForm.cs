using System.Collections.ObjectModel;

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
        // lets access this one by key name instead of index
        string? key = carImageList.Images.Keys[1];
        if (!string.IsNullOrEmpty(key))
        {
            carPictureBox.Image = carImageList.Images[key];
        }
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

    private void noneRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        carPictureBox.Image = null;
    }
}
