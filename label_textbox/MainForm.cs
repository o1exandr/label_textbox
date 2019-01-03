using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label_textbox
{
    public partial class fmMainForm : Form
    {
        public fmMainForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            // отримання даних з текстових вікон
            string textBoxData = "";
            textBoxData += string.Format("Multiline: {0}\n",
                txtMultiline.Text);
            textBoxData += string.Format("\nPassword: {0}\n",
                txtPassword.Text);
            textBoxData += string.Format("\nUppercase: {0}\n",
                txtUppercase.Text);

            // відображення отриманих даних
            MessageBox.Show(textBoxData, "Ось вміст елементів TextBox");
        }
    }
}
