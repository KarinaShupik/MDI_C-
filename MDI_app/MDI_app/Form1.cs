using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MDI_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            toolBarMain.MouseHover += toolBarMain_MouseHover;
            findCWordsToolStripMenuItem.Click += new EventHandler(findCWordsToolStripMenuItem_Click);

        }




        private void SaveAsRTF()
        {
            blank frm = (blank)this.ActiveMdiChild;
            // Show the SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF files (*.rtf)|*.rtf|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the text as RTF
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(frm.richTextBox1.Rtf);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        //---------------------------------------------------------------------arrange icons-----------//
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }
        //-------------------------------------------------------------------------------------------//


        //-----------------------------------------cut-copy-paste-delete-select all-------------------------//
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }
        //-------------------------------------------------------------------------------------------//
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Можно программно задавать доступные для обзора расширения файлов
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";


            //Если выбран диалог открытия файла, выполняем условие
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Создаем новый документ
                blank frm = new blank();
                //Вызываем метод Open формы blank
                frm.Open(openFileDialog1.FileName);
                //Указываем, что родительской формой является форма frmmain
                frm.MdiParent = this;
                //Присваиваем переменной DocName имя открываемого файла
                frm.DocName = openFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DocName;
                //Вызываем форму frm
                frm.Show();
                saveToolStripMenuItem.Enabled = true;
            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Вызываем метод Save формы blank
            frm.Save(frm.DocName);
            frm.IsSaved = true;

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            //Можно программно задавать доступные для обзора расширения файлов
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            //Если выбран диалог открытия файла, выполняем условие
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Переключаем фокус на данную форму.
                blank frm = (blank)this.ActiveMdiChild;
                //Вызываем метод Save формы blank
                frm.Save(saveFileDialog1.FileName);
                //Указываем, что родительской формой является форма frmmain
                frm.MdiParent = this;
                //Присваиваем переменной FileName имя сохраняемого файла
                frm.DocName = saveFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DocName;
                frm.IsSaved = true;

            }

        }

        private void formatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Указываем, что родительской формой является форма frmmain
            frm.MdiParent = this;
            //Вызываем диалог
            fontDialog1.ShowColor = true;
            //Связываем свойства SelectionFont и SelectionColor элемента RichTextBox
            //с соответствующими свойствами диалога
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            //Если выбран диалог открытия файла, выполняем условие
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            //Показываем форму
            frm.Show();
        }

        private void colorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы FindForm
            FindForm frm = new FindForm();
            //Если выбран результат DialogResult.Cancel, закрываем форму (до этого
            //мы использовали DialogResult.OK)
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            ////Переключаем фокус на данную форму.
            blank form = (blank)this.ActiveMdiChild;
            ////Указываем, что родительской формой является форма frmmain
            form.MdiParent = this;
            //Вводим переменную для поиска в определенной части текста —
            //поиск слова будет осуществляться от текущей позиции курсора
            int start = form.richTextBox1.SelectionStart;
            //Вызываем предопределенный метод Find элемента richTextBox1.
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы About
            About frm = new About();
            frm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //New
            if (e.ClickedItem.Equals(tbNew))
            {
                newToolStripMenuItem_Click(this, new EventArgs());
            }
            //Open
            if (e.ClickedItem.Equals(tbOpen))
            {
                openToolStripMenuItem_Click(this, new EventArgs());
            }
            //Save
            if (e.ClickedItem.Equals(tbSave))
            {
                saveToolStripMenuItem_Click(this, new EventArgs());
            }
            //Cut
            if (e.ClickedItem.Equals(tbCut))
            {
                cutToolStripMenuItem_Click(this, new EventArgs());
            }
            //Copy
            if (e.ClickedItem.Equals(tbCopy))
            {
                copyToolStripMenuItem_Click(this, new EventArgs());
            }
            //Paste
            if (e.ClickedItem.Equals(tbPaste))
            {
                pasteToolStripMenuItem_Click(this, new EventArgs());
            }
        }

        private void uKRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                // Update the text of the menu item itself
                if (translationsUKR.ContainsKey(menuItem.Text))
                {
                    menuItem.Text = translationsUKR[menuItem.Text];
                }

                // Update the text of each sub-item
                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    if (translationsUKR.ContainsKey(subItem.Text))
                    {
                        subItem.Text = translationsUKR[subItem.Text];
                    }
                }
            }
        }

        private void pLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                // Update the text of the menu item itself
                if (translationsPL.ContainsKey(menuItem.Text))
                {
                    menuItem.Text = translationsPL[menuItem.Text];
                }

                // Update the text of each sub-item
                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    if (translationsPL.ContainsKey(subItem.Text))
                    {
                        subItem.Text = translationsPL[subItem.Text];
                    }
                }
            }
        }

        private void toolBarMain_MouseHover(object sender, EventArgs e)
        {
            // Get the current ToolStripItem that the mouse is hovering over
            ToolStripItem currentItem = toolBarMain.GetItemAt(toolBarMain.PointToClient(Cursor.Position));

            // Update the text if it exists in the translations dictionary
            if (currentItem != null && translationsUKR.ContainsKey(currentItem.Text))
            {
                currentItem.Text = translationsUKR[currentItem.Text];
            }
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void saveAsRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                saveFileDialog.Title = "Save As RTF";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, frm.richTextBox1.Rtf);
                }
            }
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image from the file into a Bitmap object
                Bitmap image = new Bitmap(openFileDialog.FileName);

                // Copy the image to the clipboard
                Clipboard.SetImage(image);

                // Paste the image into the RichTextBox control
                frm.richTextBox1.Paste();
            }
        }

        private void findCWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            Dictionary<string, Color> keywords = new Dictionary<string, Color>();
            keywords.Add("int", Color.Blue);
            keywords.Add("float", Color.Blue);
            keywords.Add("if", Color.Blue);
            keywords.Add("else", Color.Blue);
            keywords.Add("while", Color.Blue);
            keywords.Add("for", Color.Blue);
            keywords.Add("auto", Color.Blue);
            keywords.Add("bool", Color.Blue);
            keywords.Add("break", Color.Blue);
            keywords.Add("case", Color.Blue);
            keywords.Add("catch", Color.Blue);
            keywords.Add("char", Color.Blue);
            keywords.Add("class", Color.Blue);
            keywords.Add("const", Color.Blue);
            keywords.Add("continue", Color.Blue);
            keywords.Add("default", Color.Blue);
            keywords.Add("delete", Color.Blue);
            keywords.Add("do", Color.Blue);
            keywords.Add("double", Color.Blue);
            keywords.Add("enum", Color.Blue);
            keywords.Add("explicit", Color.Blue);
            keywords.Add("extern", Color.Blue);
            keywords.Add("false", Color.Blue);
            keywords.Add("final", Color.Blue);
            keywords.Add("friend", Color.Blue);
            keywords.Add("goto", Color.Blue);
            keywords.Add("inline", Color.Blue);
            keywords.Add("long", Color.Blue);
            keywords.Add("mutable", Color.Blue);
            keywords.Add("namespace", Color.Blue);
            keywords.Add("new", Color.Blue);
            keywords.Add("nullptr", Color.Blue);
            keywords.Add("operator", Color.Blue);
            keywords.Add("override", Color.Blue);
            keywords.Add("private", Color.Blue);
            keywords.Add("protected", Color.Blue);
            keywords.Add("public", Color.Blue);
            keywords.Add("register", Color.Blue);
            keywords.Add("return", Color.Blue);
            keywords.Add("short", Color.Blue);
            keywords.Add("signed", Color.Blue);
            keywords.Add("sizeof", Color.Blue);
            keywords.Add("static", Color.Blue);
            keywords.Add("struct", Color.Blue);
            keywords.Add("switch", Color.Blue);
            keywords.Add("template", Color.Blue);
            keywords.Add("this", Color.Blue);
            keywords.Add("throw", Color.Blue);
            keywords.Add("true", Color.Blue);
            keywords.Add("try", Color.Blue);
            keywords.Add("typedef", Color.Blue);
            keywords.Add("typeid", Color.Blue);
            keywords.Add("typename", Color.Blue);
            keywords.Add("union", Color.Blue);
            keywords.Add("unsigned", Color.Blue);
            keywords.Add("using", Color.Blue);
            keywords.Add("virtual", Color.Blue);
            keywords.Add("void", Color.Blue);
            keywords.Add("volatile", Color.Blue);
            keywords.Add("wchar_t", Color.Blue);


            // Define a regular expression to match keywords
            string pattern = "\\b(" + string.Join("|", keywords.Keys.Select(k => Regex.Escape(k))) + ")\\b";

            // Loop through the text in the richtextbox and apply the formatting to keywords
            foreach (Match m in Regex.Matches(frm.richTextBox1.Text, pattern))
            {
                frm.richTextBox1.Select(m.Index, m.Length);
                frm.richTextBox1.SelectionColor = keywords[m.Value];
            }
        }
    }
}
