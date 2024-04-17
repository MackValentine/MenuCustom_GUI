using Microsoft.VisualBasic.Devices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuCustom
{

    public partial class MainMenu : Form
    {

        Option options;

        FontFamily fontFamily;
        Font font;
        SolidBrush solidBrush;

        int width8 = 8;
        int height8 = 8;

        Image[] spriteSheet = new Image[16];
        Image[] spriteSheetSelect = new Image[16];

        int maxWin = 0;

        public List<Window_Class> windows;
        Window_Class selectedWindow;


        Window_Class windowCommand = new Window_Class("Commands", false, 0);

        Window_Class windowGold = new Window_Class("Gold", false, 0);

        Window_Class windowStatus = new Window_Class("Status", false, 0);

        public Window_Class WindowCommand { get => windowCommand; set => windowCommand = value; }
        public Window_Class WindowGold { get => windowGold; set => windowGold = value; }
        public Window_Class WindowStatus { get => windowStatus; set => windowStatus = value; }

        public MainMenu()
        {
            InitializeComponent();

            options = new Option();

            fontFamily = new FontFamily("MS UI Gothic");
            font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            solidBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

            windows = new List<Window_Class>();
            windows.Add(windowCommand);
            windows.Add(windowGold);
            windows.Add(windowStatus);

            foreach (Window_Class w in windows)
            {
                listWindows.Nodes.Add(w.getName());
            }

            isHided.Enabled = false;
            numericX.Enabled = false;
            numericY.Enabled = false;
            numericW.Enabled = false;
            numericH.Enabled = false;
            numericColumn.Enabled = false;
            numericOpacity.Enabled = false;
            textBox.Enabled = false;
            comboBoxAlign.Enabled = false;


            windowCommand.setX(0);
            windowCommand.setY(0);
            windowCommand.setW(88);
            windowCommand.setH(9 * 16 + 16);

            windowGold.setX(0);
            windowGold.setY(240 - 32);
            windowGold.setW(88);
            windowGold.setH(32);

            windowStatus.setX(88);
            windowStatus.setY(0);
            windowStatus.setW(232);
            windowStatus.setH(240);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            var img = Properties.Resources.skin;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    spriteSheet[index] = new Bitmap(width8, height8);
                    var graphics = Graphics.FromImage(spriteSheet[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, width8, height8), new Rectangle(i * width8, j * height8, width8, height8), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            img = Properties.Resources.skinSelect;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    spriteSheetSelect[index] = new Bitmap(width8, height8);
                    var graphics = Graphics.FromImage(spriteSheetSelect[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, width8, height8), new Rectangle(i * width8, j * height8, width8, height8), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

        }
        private void drawWindow(Window_Class window, Graphics g, Image[] sprite)
        {

            int max = (((window.getW() / width8)) - 1) * (((window.getH() - 16) / height8));

            for (int f1 = 0; f1 < max; f1++)
            {


                int x = f1 % ((window.getW() / width8) - 1);
                int y = f1 / ((window.getW() / width8) - 1);

                int id = 0;
                if (y % 2 == 1)
                {
                    if (f1 % 2 == 0)
                        id = 10;
                    else if (f1 % 2 == 1)
                        id = 6;
                }
                else
                {
                    if (f1 % 2 == 0)
                        id = 5;
                    else if (f1 % 2 == 1)
                        id = 9;
                }

                g.DrawImage(sprite[id], new RectangleF(window.getX() + width8 + x * width8, window.getY() + height8 + y * height8, width8, height8));

            }

            g.DrawImage(sprite[0], new RectangleF(window.getX(), window.getY(), width8, height8));
            g.DrawImage(sprite[12], new RectangleF(window.getX() + window.getW(), window.getY(), width8, height8));
            g.DrawImage(sprite[3], new RectangleF(window.getX(), window.getY() + window.getH() - height8 * 2, width8, height8));
            g.DrawImage(sprite[15], new RectangleF(window.getX() + window.getW(), window.getY() + window.getH() - height8 * 2, width8, height8));


            for (int w1 = 0; w1 < ((window.getW() - 8) / width8); w1++)
            {
                if (w1 % 2 == 0)
                    g.DrawImage(sprite[4], new RectangleF(window.getX() + w1 * width8 + width8, window.getY(), width8, height8));
                else
                    g.DrawImage(sprite[8], new RectangleF(window.getX() + w1 * width8 + width8, window.getY(), width8, height8));

                if (w1 % 2 == 0)
                    g.DrawImage(sprite[7], new RectangleF(window.getX() + w1 * width8 + width8, window.getY() + window.getH() - height8 * 2, width8, height8));
                else
                    g.DrawImage(sprite[11], new RectangleF(window.getX() + w1 * width8 + width8, window.getY() + window.getH() - height8 * 2, width8, height8));
            }

            for (int h1 = 0; h1 < ((window.getH() - 24) / height8); h1++)
            {
                int id = 1;
                if (h1 % 2 == 0)
                    id = 2;
                g.DrawImage(sprite[id], new RectangleF(window.getX(), window.getY() + h1 * height8 + height8, width8, height8));

                id = 13;
                if (h1 % 2 == 0)
                    id = 14;
                g.DrawImage(sprite[id], new RectangleF(window.getX() + window.getW(), window.getY() + h1 * height8 + height8, width8, height8));
            }

        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refreshMenu(Window_Class window)
        {

            // label2.Text = "" + window.GetPageList()[0].Condition_index;
            if (window != null)
            {
                isHided.Checked = window.getHide();
                numericX.Value = window.getX();
                numericY.Value = window.getY();
                numericW.Value = window.getW() + 8;
                numericH.Value = window.getH() - 8;
                textBox.Text = window.GetPageList()[0].Text;
                checkBoxCondition.Checked = window.GetPageList()[0].Condition;
                numericCondition.Value = window.GetPageList()[0].Condition_index;
                comboBoxAlign.Text = window.GetPageList()[0].Align;
                numericCondition.Enabled = !checkBoxCondition.Checked;

                //  label1.Text = "" + window.GetPageList()[0].Condition_index;

                if (!window.getCustom())
                    while (tabControl.TabPages.Count > 1)
                        tabControl.TabPages.RemoveAt(1);

                if (window.GetPageList().Count > 1)
                {
                    while (tabControl.TabPages.Count > 1)
                        tabControl.TabPages.RemoveAt(1);

                    for (int i = 1; i < window.GetPageList().Count; i++)
                    {

                        string title = "Page " + (tabControl.TabCount + 1).ToString();
                        TabPage myTabPage = new TabPage(title);
                        myTabPage.BackColor = tabControl.TabPages[0].BackColor;

                        foreach (Control c in tabControl.TabPages[0].Controls)
                        {
                            Control c2 = new Control();
                            if (c.GetType() == typeof(System.Windows.Forms.TextBox))
                                c2 = new System.Windows.Forms.TextBox();
                            else if (c.GetType() == typeof(Label))
                            {
                                c2 = new Label();
                                c2.Text = c.Text;
                            }
                            else if (c.GetType() == typeof(CheckBox))
                            {
                                c2 = new CheckBox();
                                c2.Text = c.Text;
                                if (c.Name == "checkBoxCondition")
                                {
                                    ((System.Windows.Forms.CheckBox)c2).Checked = window.GetPageList()[i].Condition;
                                    ((System.Windows.Forms.CheckBox)c2).CheckedChanged += checkBoxCondition_CheckedChanged;
                                }
                            }
                            else if (c.GetType() == typeof(DataGridView))
                                c2 = new DataGridView();
                            else if (c.GetType() == typeof(System.Windows.Forms.Button))
                            {
                                c2 = new System.Windows.Forms.Button();
                                c2.Click += buttonNewPage_Click;
                                c2.Text = c.Text;
                            }
                            else if (c.GetType() == typeof(RichTextBox))
                            {
                                c2 = new RichTextBox();
                                c2.TextChanged += textBox_TextChanged;
                                c2.Text = window.GetPageList()[i].Text;
                            }
                            else if (c.GetType() == typeof(System.Windows.Forms.ComboBox))
                            {
                                c2 = new System.Windows.Forms.ComboBox();
                                c2.Text = window.GetPageList()[i].Align;
                                ((System.Windows.Forms.ComboBox)c2).Items.AddRange(((System.Windows.Forms.ComboBox)c).Items.Cast<Object>().ToArray());
                                ((System.Windows.Forms.ComboBox)c2).SelectedIndexChanged += comboBoxAlign_SelectedIndexChanged;
                            }
                            else if (c.GetType() == typeof(NumericUpDown))
                            {
                                c2 = new NumericUpDown();
                                if (c.Name == "numericCondition")
                                {
                                    ((System.Windows.Forms.NumericUpDown)c2).Value = window.GetPageList()[i].Condition_index;
                                    c2.Enabled = window.GetPageList()[i].Condition;
                                    ((System.Windows.Forms.NumericUpDown)c2).ValueChanged += numericCondition_ValueChanged;
                                }
                            }
                            c2.Location = c.Location;
                            c2.Size = c.Size;

                            c2.Name = c.Name;

                            c2.Enabled = c.Enabled;
                            c2.BackColor = c.BackColor;
                            c2.ForeColor = c.ForeColor;

                            myTabPage.Controls.Add(c2);

                        }

                        tabControl.TabPages.Add(myTabPage);
                    }
                }
            }
            else
            {
                isHided.Checked = false;
                numericX.Value = 0;
                numericY.Value = 0;
                numericW.Value = 0;
                numericH.Value = 0;
                textBox.Text = "";
                checkBoxCondition.Checked = false;
                numericCondition.Value = 0;
                numericCondition.Enabled = false;

                while (tabControl.TabPages.Count > 1)
                    tabControl.TabPages.RemoveAt(1);
            }
        }
        private void refresh()
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.Transparent);

                Image image = Properties.Resources.skin;

                Image[] sp;

                // Commands
                if (!windowCommand.getHide())
                {
                    sp = spriteSheet;
                    if (selectedWindow == windowCommand)
                        sp = spriteSheetSelect;

                    drawWindow(windowCommand, g, sp);

                    drawText(g, "Items\nSkills\nEquipment\nSave\nStatus\nRow\nFormation\nWait\nTo Title", windowCommand.getX() + 6, windowCommand.getY() + 6 + 4,
                        windowCommand.getW(), windowCommand.getH(), windowCommand.getColumn(), TextFormatFlags.Left);

                }

                // Golds
                if (!windowGold.getHide())
                {
                    sp = spriteSheet;
                    if (selectedWindow == windowGold)
                        sp = spriteSheetSelect;

                    drawWindow(windowGold, g, sp);

                    drawText(g, "0G", windowGold.getX(), windowGold.getY() + 10, windowGold.getW(), windowGold.getH(), TextFormatFlags.Right);
                }

                // Status
                if (!windowStatus.getHide())
                {

                    sp = spriteSheet;
                    if (selectedWindow == windowStatus)
                        sp = spriteSheetSelect;

                    drawWindow(windowStatus, g, sp);

                    drawText(g, "Zack             None\nL   1      Normal     HP 9999/9999\n            0/9999   MP999/999", windowStatus.getX() + 56, windowStatus.getY() + 11,
                        windowStatus.getW(), windowStatus.getH(), TextFormatFlags.Left);

                    drawText(g, "Zack             None\nL   1      Normal     HP 9999/9999\n            0/9999   MP999/999", windowStatus.getX() + 56, windowStatus.getY() + 69,
                        windowStatus.getW(), windowStatus.getH(), TextFormatFlags.Left);

                    drawText(g, "Zack             None\nL   1      Normal     HP 9999/9999\n            0/9999   MP999/999", windowStatus.getX() + 56, windowStatus.getY() + 127,
                        windowStatus.getW(), windowStatus.getH(), TextFormatFlags.Left);

                    drawText(g, "Zack             None\nL   1      Normal     HP 9999/9999\n            0/9999   MP999/999", windowStatus.getX() + 56, windowStatus.getY() + 185,
                        windowStatus.getW(), windowStatus.getH(), TextFormatFlags.Left);

                    var img = Properties.Resources.Actor1;
                    g.DrawImage(img, new RectangleF(windowStatus.getX() + 4, windowStatus.getY() + 8, 48, 48));
                    g.DrawImage(img, new RectangleF(windowStatus.getX() + 4, windowStatus.getY() + 64, 48, 48));
                    g.DrawImage(img, new RectangleF(windowStatus.getX() + 4, windowStatus.getY() + 124, 48, 48));
                    g.DrawImage(img, new RectangleF(windowStatus.getX() + 4, windowStatus.getY() + 182, 48, 48));

                }

                foreach (Window_Class w in windows)
                {
                    if (w != windowStatus && w != windowGold && w != windowCommand)
                    {
                        sp = spriteSheet;
                        if (selectedWindow == w)
                            sp = spriteSheetSelect;

                        drawWindow(w, g, sp);
                        drawText(g, w.GetPageList()[0].Text, w.getX() + 8, w.getY() + 8,
                        w.getW(), w.getH(), w.getColumn(), TextFormatFlags.Left);
                    }
                }

            }

            if (selectedWindow != null)
            {
                isHided.Enabled = true;
                numericX.Enabled = true;
                numericY.Enabled = true;
                numericW.Enabled = true;
                numericH.Enabled = true;
                numericOpacity.Enabled = true;
                numericColumn.Enabled = true;
                textBox.Enabled = false;
                foreach (TabPage t in tabControl.TabPages)
                    foreach (Control c in t.Controls)
                    {
                        if (c.Name == "numericCondition" && selectedWindow.getCustom())
                        {
                            int i = tabControl.TabPages.IndexOf(t);
                            if (i< selectedWindow.GetPageList().Count())
                                c.Enabled = selectedWindow.GetPageList()[i].Condition;
                        }
                        else
                            c.Enabled = false;
                    }
                if (selectedWindow.getCustom())
                {
                    textBox.Enabled = true;
                    foreach (TabPage t in tabControl.TabPages)
                        foreach (Control c in t.Controls)
                        {
                            if (c.Name == "numericCondition" && selectedWindow.getCustom())
                            {
                                int i = tabControl.TabPages.IndexOf(t);
                                if (i < selectedWindow.GetPageList().Count())
                                    c.Enabled = selectedWindow.GetPageList()[i].Condition;
                            }
                            else
                                c.Enabled = true;
                        }
                }
            }
            else
            {
                isHided.Enabled = false;
                numericX.Enabled = false;
                numericY.Enabled = false;
                numericW.Enabled = false;
                numericH.Enabled = false;
                numericOpacity.Enabled = false;
                textBox.Enabled = false;
                numericColumn.Enabled = false;
                numericCondition.Enabled = false;
                foreach (TabPage t in tabControl.TabPages)
                    foreach (Control c in t.Controls)
                    {

                        c.Enabled = false;
                    }
            }
        }

        private void drawText(Graphics g, String s, int x, int y, int w, int h, int c, TextFormatFlags textFormat)
        {
            if (s != null)
            {
                string[] subs = s.Split('\n');

                int i = 0;
                foreach (String ss in subs)
                {
                    if (c == 0)
                        c = 1;
                    int ix = x + (i % c) * w / c;
                    int iy = y + (i / c) * 16;
                    TextRenderer.DrawText(g, ss, font,
                      new Rectangle(ix, iy, w, h), Color.White, Color.Transparent, textFormat);

                    //y += 16;
                    i++;
                }
            }
        }
        private void drawText(Graphics g, String s, int x, int y, int w, int h, TextFormatFlags textFormat)
        {
            if (s != null)
            {
                string[] subs = s.Split('\n');

                foreach (String ss in subs)
                {
                    TextRenderer.DrawText(g, ss, font,
                      new Rectangle(x, y, w, h), Color.White, Color.Transparent, textFormat);

                    y += 16;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            Point mouseP = me.Location;

            // selectedWindow = null;

            foreach (Window_Class w in windows)
            {
                if (mouseP.X > w.getX() && mouseP.X < w.getX() + w.getW())
                {
                    if (mouseP.Y > w.getY() && mouseP.Y < w.getY() + w.getH() - 8)
                    {
                        selectedWindow = w;
                        foreach (TreeNode n in listWindows.Nodes)
                        {
                            if (n.Text == w.getName())
                                listWindows.SelectedNode = n;
                        }
                        label1.Text = "" + w.GetPageList()[0].Condition_index;
                        refreshMenu(w);
                        break;
                    }
                }
            }
            //if (selectedWindow == null)
            //{
            //    listWindows.SelectedNode = null;
            //    while (tabControl.TabPages.Count > 1)
            //        tabControl.TabPages.RemoveAt(1);
            //}

            refresh();

        }

        private void isHided_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                bool b = ((CheckBox)sender).Checked;
                selectedWindow.setHide(b);
            }
        }

        private void listWindows_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String s = ((TreeNode)e.Node).Text;
            
            selectedWindow = null;
            refreshMenu(null);

            foreach (Window_Class w in windows)
            {
                if (w.getName() == s)
                {
                    selectedWindow = w;
                    refreshMenu(w);
                    break;
                }
            }
            refresh();

        }

        private void numericX_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int i = (int)((NumericUpDown)sender).Value;
                selectedWindow.setX(i);
            }
        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int i = (int)((NumericUpDown)sender).Value;
                selectedWindow.setY(i);
            }
        }

        private void numericW_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int i = (int)((NumericUpDown)sender).Value;
                selectedWindow.setW(i);
            }
        }

        private void numericH_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int i = (int)((NumericUpDown)sender).Value;
                selectedWindow.setH(i);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Export childForm = new Export(this, windows, options, false);
            childForm.StartPosition = FormStartPosition.CenterParent;
            this.Enabled = false;
            childForm.Show(this);
            //this.Enabled = true;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (maxWin == 0) { 
                foreach (Window_Class ww in windows)
                {
                    if (ww.index > maxWin)
                        maxWin = ww.index;
                }
            }

            maxWin++;

            Window_Class w = new Window_Class("CWin" + maxWin, true, maxWin);
            w.setX(0);
            w.setY(0);
            w.setW(80);
            w.setH(80);
            windows.Add(w);
            listWindows.Nodes.Add(w.getName());

            refresh();
        }

        public System.Windows.Forms.TreeView GetListWindows()
        {
            return listWindows;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                String s = ((RichTextBox)sender).Text;
                int i = tabControl.SelectedIndex;
                if (selectedWindow.GetPageList().Count > i)
                {
                    selectedWindow.GetPageList()[i].Text = s;
                }
            }
        }

        private void checkMap_CheckedChanged(object sender, EventArgs e)
        {
            options.showMap = ((CheckBox)sender).Checked;
        }

        private void textBoxBackground_TextChanged(object sender, EventArgs e)
        {
            options.background = ((System.Windows.Forms.TextBox)sender).Text;
        }

        private void numericColumn_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int i = (int)((NumericUpDown)sender).Value;
                selectedWindow.setColumn(i);
            }
        }

        private void numericOpacity_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int i = (int)((NumericUpDown)sender).Value;
                selectedWindow.setOpacity(i);
            }
        }

        private void buttonNewPage_Click(object sender, EventArgs e)
        {
            string title = "Page " + (tabControl.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.BackColor = tabControl.TabPages[0].BackColor;

            //foreach (Control control in tabControl.TabPages[0].Controls)
            //{
            //    myTabPage.Controls.Add(control);
            //}

            foreach (Control c in tabControl.TabPages[0].Controls)
            {

                bool b = c.Enabled;

                Control c2 = new Control();
                if (c.GetType() == typeof(System.Windows.Forms.TextBox))
                    c2 = new System.Windows.Forms.TextBox();
                else if (c.GetType() == typeof(Label))
                    c2 = new Label();
                else if (c.GetType() == typeof(CheckBox))
                {
                    c2 = new CheckBox();
                    if (c.Name == "checkBoxCondition")
                    {
                        ((System.Windows.Forms.CheckBox)c2).CheckedChanged += checkBoxCondition_CheckedChanged;
                    }
                }
                else if (c.GetType() == typeof(DataGridView))
                    c2 = new DataGridView();
                else if (c.GetType() == typeof(System.Windows.Forms.Button))
                {
                    c2 = new System.Windows.Forms.Button();
                    c2.Click += buttonNewPage_Click;
                }
                else if (c.GetType() == typeof(RichTextBox))
                {
                    c2 = new RichTextBox();
                    c2.TextChanged += textBox_TextChanged;
                }
                else if (c.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    c2 = new System.Windows.Forms.ComboBox();
                    c2.Text = "Left";
                    ((System.Windows.Forms.ComboBox)c2).Items.AddRange(((System.Windows.Forms.ComboBox)c).Items.Cast<Object>().ToArray());
                    ((System.Windows.Forms.ComboBox)c2).SelectedIndexChanged += comboBoxAlign_SelectedIndexChanged;
                }
                else if (c.GetType() == typeof(NumericUpDown))
                {
                    c2 = new NumericUpDown();
                    if (c.Name == "numericCondition")
                    {
                        ((System.Windows.Forms.NumericUpDown)c2).ValueChanged += numericCondition_ValueChanged;
                        b = false;
                    }
                }
                c2.Name = c.Name;
                c2.Location = c.Location;
                c2.Size = c.Size;
                c2.Text = c.Text;
                if (c.Name == "textBox")
                    c2.Text = "";
                c2.Enabled = b;
                c2.BackColor = c.BackColor;
                c2.ForeColor = c.ForeColor;

                myTabPage.Controls.Add(c2);

            }

            tabControl.TabPages.Add(myTabPage);

            Page p = new Page();
            p.ID = selectedWindow.GetPageList().Count;
            selectedWindow.GetPageList().Add(p);

            // label1.Text = "C : " + selectedWindow.GetPageList().Count;

        }

        private void comboBoxAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                String s = ((System.Windows.Forms.ComboBox)sender).Text;
                int i = tabControl.SelectedIndex;
                if (selectedWindow.GetPageList().Count > i)
                {
                    selectedWindow.GetPageList()[i].Align = s;
                }
            }

        }

        private void checkBoxCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                bool b = ((CheckBox)sender).Checked;
                int i = tabControl.SelectedIndex;
                if (selectedWindow.GetPageList().Count > i)
                {
                    selectedWindow.GetPageList()[i].Condition = b;
                    foreach (Control p in tabControl.TabPages[i].Controls)
                    {
                        if (p.Name == "numericCondition")
                        {
                            p.Enabled = b;
                        }
                    }
                }
            }
        }

        private void numericCondition_ValueChanged(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                int v = (int)((NumericUpDown)sender).Value;
                int i = tabControl.SelectedIndex;
                if (selectedWindow.GetPageList().Count > i)
                {
                    //label1.Text = i + " ";
                    selectedWindow.GetPageList()[i].Condition_index = v;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedWindow != null)
            {
                switch (selectedWindow.getName())
                {
                    case "Commands":
                    case "Gold":
                    case "Status":
                        break;
                    default:

                        windows.Remove(selectedWindow);

                        label1.Text = selectedWindow.getName() + "";
                        foreach (System.Windows.Forms.TreeNode n in listWindows.Nodes)
                        {
                            if (n != null)
                                if (n.Text == selectedWindow.getName())
                                {
                                    listWindows.Nodes.Remove(n);
                                }
                        }

                        selectedWindow = null;
                        listWindows.SelectedNode = null;
                        refresh();
                        break;
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            Export childForm = new Export(this, windows, options, true);
            childForm.StartPosition = FormStartPosition.CenterParent;
            this.Enabled = false;
            childForm.Show(this);

            
        }

        public void refreshImport()
        {
            textBoxBackground.Text = options.background;
            checkMap.Checked = options.showMap;

            tabControl.SelectedIndex = 0;

            refresh();
        }
    }
}