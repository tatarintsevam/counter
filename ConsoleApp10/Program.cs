using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ConsoleApp10
{
    public class MainForm : Form
    {
        private Button clickButton;
        private Label LabelOne;
        private int counter = 0;

        public MainForm()
        {
            this.Size = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Надпись количества кликов
            //
            LabelOne = new Label();
            LabelOne.Text = "Кликов: 0";
            LabelOne.Location = new Point(100, 50);
            LabelOne.Size = new Size(100, 30);
            LabelOne.Font = new Font("Arial", 12);
            LabelOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; 

            // Кнопка чтобы увеличивать количество кликов
            clickButton = new Button();
            clickButton.Text = "Кликни сюда";
            clickButton.Location = new Point(90, 100);
            clickButton.Size = new Size(120, 40);
            clickButton.BackColor = Color.LightGreen;
            clickButton.Click += ClickButton_Click;

            this.Controls.Add(LabelOne);
            this.Controls.Add(clickButton);
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            counter++;
            LabelOne.Text = $" Всего кликов: {counter}";

            if (counter % 2 == 0)
                clickButton.BackColor = Color.LightGreen;
            else
                clickButton.BackColor = Color.LightCoral;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

}
