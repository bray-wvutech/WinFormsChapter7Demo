namespace WinFormsChapter7Demo;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        carImageList = new ImageList(components);
        colorGroupBox = new GroupBox();
        redRadioButton = new RadioButton();
        radioButton2 = new RadioButton();
        blueRadioButton = new RadioButton();
        radioButton1 = new RadioButton();
        carPictureBox = new PictureBox();
        colorGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
        SuspendLayout();
        // 
        // carImageList
        // 
        carImageList.ColorDepth = ColorDepth.Depth32Bit;
        carImageList.ImageStream = (ImageListStreamer)resources.GetObject("carImageList.ImageStream");
        carImageList.TransparentColor = Color.Transparent;
        carImageList.Images.SetKeyName(0, "Blackcar.png");
        carImageList.Images.SetKeyName(1, "Bluecar.png");
        carImageList.Images.SetKeyName(2, "Greencar.png");
        carImageList.Images.SetKeyName(3, "Redcar.png");
        // 
        // colorGroupBox
        // 
        colorGroupBox.Controls.Add(redRadioButton);
        colorGroupBox.Controls.Add(radioButton2);
        colorGroupBox.Controls.Add(blueRadioButton);
        colorGroupBox.Controls.Add(radioButton1);
        colorGroupBox.Location = new Point(12, 12);
        colorGroupBox.Name = "colorGroupBox";
        colorGroupBox.Size = new Size(107, 182);
        colorGroupBox.TabIndex = 0;
        colorGroupBox.TabStop = false;
        colorGroupBox.Text = "&Color";
        // 
        // redRadioButton
        // 
        redRadioButton.AutoSize = true;
        redRadioButton.Location = new Point(15, 125);
        redRadioButton.Name = "redRadioButton";
        redRadioButton.Size = new Size(56, 24);
        redRadioButton.TabIndex = 3;
        redRadioButton.TabStop = true;
        redRadioButton.Text = "Red";
        redRadioButton.UseVisualStyleBackColor = true;
        redRadioButton.CheckedChanged += redRadioButton_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(15, 95);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(69, 24);
        radioButton2.TabIndex = 2;
        radioButton2.TabStop = true;
        radioButton2.Text = "Green";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // blueRadioButton
        // 
        blueRadioButton.AutoSize = true;
        blueRadioButton.Location = new Point(15, 65);
        blueRadioButton.Name = "blueRadioButton";
        blueRadioButton.Size = new Size(59, 24);
        blueRadioButton.TabIndex = 1;
        blueRadioButton.TabStop = true;
        blueRadioButton.Text = "Blue";
        blueRadioButton.UseVisualStyleBackColor = true;
        blueRadioButton.CheckedChanged += blueRadioButton_CheckedChanged;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(15, 35);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(65, 24);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "Black";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // carPictureBox
        // 
        carPictureBox.Location = new Point(138, 24);
        carPictureBox.Name = "carPictureBox";
        carPictureBox.Size = new Size(548, 341);
        carPictureBox.TabIndex = 1;
        carPictureBox.TabStop = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(carPictureBox);
        Controls.Add(colorGroupBox);
        Name = "MainForm";
        Text = "Chapter 7 Demo";
        Load += MainForm_Load;
        colorGroupBox.ResumeLayout(false);
        colorGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ImageList carImageList;
    private GroupBox colorGroupBox;
    private RadioButton blueRadioButton;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton redRadioButton;
    private PictureBox carPictureBox;
}
