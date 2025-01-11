namespace Exercises.CustomGUI
{
  partial class CalculatorGUI
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      button1 = new Button();
      SuspendLayout();
      // 
      // button1
      // 
      button1.FlatAppearance.BorderSize = 0;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      button1.ForeColor = Color.LightGray;
      button1.Location = new Point(611, 9);
      button1.Margin = new Padding(0);
      button1.Name = "button1";
      button1.Size = new Size(30, 30);
      button1.TabIndex = 0;
      button1.Text = "X";
      button1.UseVisualStyleBackColor = true;
      // 
      // CalculatorGUI
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(45, 48, 72);
      ClientSize = new Size(650, 900);
      Controls.Add(button1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "CalculatorGUI";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form1";
      ResumeLayout(false);
    }

    #endregion

    private Button button1;
  }
}