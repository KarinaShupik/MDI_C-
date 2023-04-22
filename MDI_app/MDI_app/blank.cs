using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MDI_app
{
    public partial class blank : Form
    {
        public blank()
        {
            InitializeComponent();
            //Свойству Text панели sbTime устанавливаем системное время,
            // конвертировав его в тип String
            toolStripStatusLabel2.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            //В тексте всплывающей подсказки выводим текущую дату
            toolStripStatusLabel2.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если переменная IsSaved имеет значение true, т. е. документ новый документ
            //был сохранен (Save As) или в открытом документе были сохранены изменения (Save), то выполняется условие
            if (IsSaved == true)
                //Появляется диалоговое окно, предлагающее сохранить документ.
                if (MessageBox.Show("Do you want save changes in " + this.DocName + "?",
                "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                //Если была нажата кнопка Yes, вызываем метод Save
                {
                    this.Save(this.DocName);
                }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Свойству Text панели sbAmount устанавливаем надпись "Аmount of symbols"
            //и длину текста в RichTextBox.
            toolStripStatusLabel1.Text = "Аmount of symbols" + richTextBox1.Text.Length.ToString();
        }
    }
}
