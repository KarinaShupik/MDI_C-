using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace MDI_app
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        Dictionary<string, string> translationsUKR = new Dictionary<string, string>()
            {
                { "File", "Файл" },
                { "New", "Новий" },
                { "Open", "Відкрити" },
                { "Save", "Зберегти" },
                { "Save As", "Зберегти як" },
                { "Exit", "Вийти" },
                { "Edit", "Редагувати" },
                { "Cut", "Вирізати" },
                { "Copy", "Копіювати" },
                { "Paste", "Вставити" },
                { "Select All", "Виділити все" },
                { "Delete", "Видалити" },
                { "Settings", "Налаштування" },
                { "Format", "Форматування" },
                { "Color", "Колір" },
                { "Find", "Знайти" },
                { "Languages", "Мови" },
                { "Window", "Вікно" },
                { "Arrange Icons", "Впорядкувати значки" },
                { "Cascade", "Каскадом" },
                { "Tile Horizontal", "Плиткою горизонтально" },
                { "Tile Vertical", "Плиткою вертикально" },
                { "About", "Про програму" },
                { "Create New", "Створити новий документ" },
                { "Alignment", "Вирівнювання" },
                { "Left", "Ліворуч" },
                { "Right", "Праворуч" },
                { "Center", "По центру" },
                { "Add image", "Додати картинку" },
                { "Find C words", "Знайти С-подібні слова" }
            };

        Dictionary<string, string> translationsPL = new Dictionary<string, string>()
            {
                { "File", "Plik" },
                { "New", "Nowy" },
                { "Open", "Otwórz" },
                { "Save", "Zapisz" },
                { "Save As", "Zapisz jako" },
                { "Exit", "Wyjdź" },
                { "Edit", "Edytuj" },
                { "Cut", "Wytnij" },
                { "Copy", "Kopiuj" },
                { "Paste", "Wklej" },
                { "Select All", "Zaznacz wszystko" },
                { "Delete", "Usuń" },
                { "Settings", "Ustawienia" },
                { "Format", "Format" },
                { "Color", "Kolor" },
                { "Find", "Znajdź" },
                { "Languages", "Języki" },
                { "Window", "Okno" },
                { "Arrange Icons", "Ustaw ikony" },
                { "Cascade", "Kaskadowo" },
                { "Tile Horizontal", "Ułoż w poziomie" },
                { "Tile Vertical", "Ułoż w pionie" },
                { "About", "O programie" },
                { "Create New", "Utwórz nowy dokument" },
                { "Alignment", "Wyrównanie" },
                { "Left", "Do lewej" },
                { "Right", "Do prawej" },
                { "Center", "Do środka" },
                { "Add image", "Dodaj zdjęcie" },
                { "Find C words", "Znajdź C-słowa" }
            };

        

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uKRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.untitled1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untitled2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untitled3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untitled4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untitled5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolBarMain = new System.Windows.Forms.ToolStrip();
            this.tbNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.findCWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolBarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuCut,
            this.settingsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAsRTFToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveAsRTFToolStripMenuItem
            // 
            this.saveAsRTFToolStripMenuItem.Name = "saveAsRTFToolStripMenuItem";
            this.saveAsRTFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsRTFToolStripMenuItem.Text = "Save As RTF";
            this.saveAsRTFToolStripMenuItem.Click += new System.EventHandler(this.saveAsRTFToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImageToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShowShortcutKeys = false;
            this.mnuCut.Size = new System.Drawing.Size(49, 24);
            this.mnuCut.Text = "Edit";
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addImageToolStripMenuItem.Text = "Add image";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem1,
            this.colorToolStripMenuItem,
            this.findToolStripMenuItem,
            this.languagesToolStripMenuItem,
            this.alignmentToolStripMenuItem,
            this.findCWordsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // formatToolStripMenuItem1
            // 
            this.formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            this.formatToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.formatToolStripMenuItem1.Text = "Format";
            this.formatToolStripMenuItem1.Click += new System.EventHandler(this.formatToolStripMenuItem1_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click_1);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uKRToolStripMenuItem,
            this.pLToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // uKRToolStripMenuItem
            // 
            this.uKRToolStripMenuItem.Name = "uKRToolStripMenuItem";
            this.uKRToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.uKRToolStripMenuItem.Text = "UKR";
            this.uKRToolStripMenuItem.Click += new System.EventHandler(this.uKRToolStripMenuItem_Click);
            // 
            // pLToolStripMenuItem
            // 
            this.pLToolStripMenuItem.Name = "pLToolStripMenuItem";
            this.pLToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.pLToolStripMenuItem.Text = "PL";
            this.pLToolStripMenuItem.Click += new System.EventHandler(this.pLToolStripMenuItem_Click);
            // 
            // alignmentToolStripMenuItem
            // 
            this.alignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem,
            this.centerToolStripMenuItem});
            this.alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alignmentToolStripMenuItem.Text = "Alignment";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.untitled1ToolStripMenuItem,
            this.untitled2ToolStripMenuItem,
            this.untitled3ToolStripMenuItem,
            this.untitled4ToolStripMenuItem,
            this.untitled5ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Arrange Icons";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // untitled1ToolStripMenuItem
            // 
            this.untitled1ToolStripMenuItem.Name = "untitled1ToolStripMenuItem";
            this.untitled1ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.untitled1ToolStripMenuItem.Text = "1 Untitled 1";
            // 
            // untitled2ToolStripMenuItem
            // 
            this.untitled2ToolStripMenuItem.Name = "untitled2ToolStripMenuItem";
            this.untitled2ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.untitled2ToolStripMenuItem.Text = "2 Untitled 2";
            // 
            // untitled3ToolStripMenuItem
            // 
            this.untitled3ToolStripMenuItem.Name = "untitled3ToolStripMenuItem";
            this.untitled3ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.untitled3ToolStripMenuItem.Text = "3 Untitled 3";
            // 
            // untitled4ToolStripMenuItem
            // 
            this.untitled4ToolStripMenuItem.Name = "untitled4ToolStripMenuItem";
            this.untitled4ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.untitled4ToolStripMenuItem.Text = "4 Untitled 4";
            // 
            // untitled5ToolStripMenuItem
            // 
            this.untitled5ToolStripMenuItem.Name = "untitled5ToolStripMenuItem";
            this.untitled5ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.untitled5ToolStripMenuItem.Text = "5 Untitled 5";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Text files";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // toolBarMain
            // 
            this.toolBarMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.tbSave,
            this.tbCut,
            this.tbCopy,
            this.tbPaste});
            this.toolBarMain.Location = new System.Drawing.Point(0, 28);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Size = new System.Drawing.Size(800, 27);
            this.toolBarMain.TabIndex = 3;
            this.toolBarMain.Text = "toolStrip1";
            this.toolBarMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolBarMain.MouseHover += new System.EventHandler(this.toolBarMain_MouseHover);
            // 
            // tbNew
            // 
            this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNew.Image = ((System.Drawing.Image)(resources.GetObject("tbNew.Image")));
            this.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(29, 24);
            this.tbNew.Text = "Create New";
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(29, 24);
            this.tbOpen.Text = "Open";
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(29, 24);
            this.tbSave.Text = "Save";
            // 
            // tbCut
            // 
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Image = ((System.Drawing.Image)(resources.GetObject("tbCut.Image")));
            this.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new System.Drawing.Size(29, 24);
            this.tbCut.Text = "Cut";
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tbCopy.Image")));
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(29, 24);
            this.tbCopy.Text = "Copy";
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tbPaste.Image")));
            this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(29, 24);
            this.tbPaste.Text = "Paste";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tbNew");
            this.imageList1.Images.SetKeyName(1, "tbOpen");
            this.imageList1.Images.SetKeyName(2, "tbSave");
            this.imageList1.Images.SetKeyName(3, "tbCut");
            this.imageList1.Images.SetKeyName(4, "tbCopy");
            this.imageList1.Images.SetKeyName(5, "tbPaste");
            // 
            // findCWordsToolStripMenuItem
            // 
            this.findCWordsToolStripMenuItem.Name = "findCWordsToolStripMenuItem";
            this.findCWordsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findCWordsToolStripMenuItem.Text = "Find C words";
            this.findCWordsToolStripMenuItem.Click += new System.EventHandler(this.findCWordsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolBarMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBarMain.ResumeLayout(false);
            this.toolBarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private int openDocuments = 0;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untitled1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untitled2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untitled3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untitled4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untitled5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolBarMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton tbNew;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKRToolStripMenuItem;
        private ToolStripMenuItem pLToolStripMenuItem;
        private ToolStripMenuItem alignmentToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem centerToolStripMenuItem;
        private ToolStripMenuItem saveAsRTFToolStripMenuItem;
        private ToolStripMenuItem addImageToolStripMenuItem;
        private ToolStripMenuItem findCWordsToolStripMenuItem;
    }
}

