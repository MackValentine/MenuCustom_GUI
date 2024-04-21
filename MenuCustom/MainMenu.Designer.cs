namespace MenuCustom
{
    partial class MainMenu
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonUpd = new Button();
            isHided = new CheckBox();
            listWindows = new TreeView();
            labelX = new Label();
            numericX = new NumericUpDown();
            numericY = new NumericUpDown();
            labelY = new Label();
            label1 = new Label();
            numericH = new NumericUpDown();
            labelH = new Label();
            numericW = new NumericUpDown();
            labelW = new Label();
            buttonOK = new Button();
            buttonNew = new Button();
            textBox = new RichTextBox();
            groupWindow = new GroupBox();
            tabControl = new TabControl();
            Page1 = new TabPage();
            numericCondition = new NumericUpDown();
            checkBoxCondition = new CheckBox();
            labelAlign = new Label();
            comboBoxAlign = new ComboBox();
            buttonNewPage = new Button();
            labelOpacity = new Label();
            numericOpacity = new NumericUpDown();
            labelColumn = new Label();
            numericColumn = new NumericUpDown();
            checkMap = new CheckBox();
            textBoxBackground = new TextBox();
            labelBackground = new Label();
            label2 = new Label();
            buttonDelete = new Button();
            buttonImport = new Button();
            numericSX = new NumericUpDown();
            numericSY = new NumericUpDown();
            labelSX = new Label();
            labelSY = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericW).BeginInit();
            groupWindow.SuspendLayout();
            tabControl.SuspendLayout();
            Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCondition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOpacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSY).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 258);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.test;
            pictureBox1.Location = new Point(5, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 240);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(5, 264);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(75, 23);
            buttonUpd.TabIndex = 2;
            buttonUpd.Text = "Update";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // isHided
            // 
            isHided.AutoSize = true;
            isHided.Location = new Point(18, 24);
            isHided.Name = "isHided";
            isHided.Size = new Size(59, 19);
            isHided.TabIndex = 3;
            isHided.Text = "Hide ?";
            isHided.UseVisualStyleBackColor = true;
            isHided.CheckedChanged += isHided_CheckedChanged;
            // 
            // listWindows
            // 
            listWindows.FullRowSelect = true;
            listWindows.HideSelection = false;
            listWindows.Location = new Point(86, 264);
            listWindows.Name = "listWindows";
            listWindows.Size = new Size(239, 220);
            listWindows.TabIndex = 5;
            listWindows.AfterSelect += listWindows_AfterSelect;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(18, 57);
            labelX.Name = "labelX";
            labelX.Size = new Size(20, 15);
            labelX.TabIndex = 6;
            labelX.Text = "X :";
            // 
            // numericX
            // 
            numericX.Location = new Point(18, 75);
            numericX.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericX.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericX.Name = "numericX";
            numericX.Size = new Size(120, 23);
            numericX.TabIndex = 7;
            numericX.ValueChanged += numericX_ValueChanged;
            // 
            // numericY
            // 
            numericY.Location = new Point(186, 75);
            numericY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericY.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericY.Name = "numericY";
            numericY.Size = new Size(120, 23);
            numericY.TabIndex = 9;
            numericY.ValueChanged += numericY_ValueChanged;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(186, 57);
            labelY.Name = "labelY";
            labelY.Size = new Size(20, 15);
            labelY.TabIndex = 8;
            labelY.Text = "Y :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(949, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // numericH
            // 
            numericH.Location = new Point(186, 123);
            numericH.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericH.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericH.Name = "numericH";
            numericH.Size = new Size(120, 23);
            numericH.TabIndex = 14;
            numericH.ValueChanged += numericH_ValueChanged;
            // 
            // labelH
            // 
            labelH.AutoSize = true;
            labelH.Location = new Point(186, 105);
            labelH.Name = "labelH";
            labelH.Size = new Size(49, 15);
            labelH.TabIndex = 13;
            labelH.Text = "Height :";
            // 
            // numericW
            // 
            numericW.Location = new Point(18, 123);
            numericW.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericW.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericW.Name = "numericW";
            numericW.Size = new Size(120, 23);
            numericW.TabIndex = 12;
            numericW.ValueChanged += numericW_ValueChanged;
            // 
            // labelW
            // 
            labelW.AutoSize = true;
            labelW.Location = new Point(18, 105);
            labelW.Name = "labelW";
            labelW.Size = new Size(45, 15);
            labelW.TabIndex = 11;
            labelW.Text = "Width :";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(912, 440);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 15;
            buttonOK.Text = "Export";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(5, 293);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 16;
            buttonNew.Text = "New window";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(6, 36);
            textBox.Name = "textBox";
            textBox.Size = new Size(317, 146);
            textBox.TabIndex = 17;
            textBox.Text = "";
            textBox.TextChanged += textBox_TextChanged;
            // 
            // groupWindow
            // 
            groupWindow.Controls.Add(tabControl);
            groupWindow.Controls.Add(labelOpacity);
            groupWindow.Controls.Add(numericOpacity);
            groupWindow.Controls.Add(labelColumn);
            groupWindow.Controls.Add(numericColumn);
            groupWindow.Controls.Add(isHided);
            groupWindow.Controls.Add(labelX);
            groupWindow.Controls.Add(numericX);
            groupWindow.Controls.Add(numericH);
            groupWindow.Controls.Add(labelY);
            groupWindow.Controls.Add(labelH);
            groupWindow.Controls.Add(numericY);
            groupWindow.Controls.Add(numericW);
            groupWindow.Controls.Add(labelW);
            groupWindow.Location = new Point(349, 15);
            groupWindow.Name = "groupWindow";
            groupWindow.Size = new Size(349, 469);
            groupWindow.TabIndex = 18;
            groupWindow.TabStop = false;
            groupWindow.Text = "Window";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(Page1);
            tabControl.Location = new Point(6, 218);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(337, 245);
            tabControl.TabIndex = 22;
            // 
            // Page1
            // 
            Page1.BackColor = Color.White;
            Page1.Controls.Add(numericCondition);
            Page1.Controls.Add(checkBoxCondition);
            Page1.Controls.Add(labelAlign);
            Page1.Controls.Add(comboBoxAlign);
            Page1.Controls.Add(buttonNewPage);
            Page1.Controls.Add(textBox);
            Page1.Location = new Point(4, 24);
            Page1.Name = "Page1";
            Page1.Padding = new Padding(3);
            Page1.Size = new Size(329, 217);
            Page1.TabIndex = 0;
            Page1.Text = "Page 1";
            // 
            // numericCondition
            // 
            numericCondition.Enabled = false;
            numericCondition.Location = new Point(243, 6);
            numericCondition.Name = "numericCondition";
            numericCondition.Size = new Size(80, 23);
            numericCondition.TabIndex = 22;
            numericCondition.ValueChanged += numericCondition_ValueChanged;
            // 
            // checkBoxCondition
            // 
            checkBoxCondition.AutoSize = true;
            checkBoxCondition.Enabled = false;
            checkBoxCondition.Location = new Point(116, 8);
            checkBoxCondition.Name = "checkBoxCondition";
            checkBoxCondition.Size = new Size(121, 19);
            checkBoxCondition.TabIndex = 21;
            checkBoxCondition.Text = "Command Index :";
            checkBoxCondition.UseVisualStyleBackColor = true;
            checkBoxCondition.CheckedChanged += checkBoxCondition_CheckedChanged;
            // 
            // labelAlign
            // 
            labelAlign.AutoSize = true;
            labelAlign.Location = new Point(158, 191);
            labelAlign.Name = "labelAlign";
            labelAlign.Size = new Size(41, 15);
            labelAlign.TabIndex = 20;
            labelAlign.Text = "Align :";
            // 
            // comboBoxAlign
            // 
            comboBoxAlign.FormattingEnabled = true;
            comboBoxAlign.Items.AddRange(new object[] { "Left", "Middle", "Right" });
            comboBoxAlign.Location = new Point(202, 188);
            comboBoxAlign.Name = "comboBoxAlign";
            comboBoxAlign.Size = new Size(121, 23);
            comboBoxAlign.TabIndex = 19;
            comboBoxAlign.Text = "Left";
            comboBoxAlign.SelectedIndexChanged += comboBoxAlign_SelectedIndexChanged;
            // 
            // buttonNewPage
            // 
            buttonNewPage.BackColor = Color.White;
            buttonNewPage.Enabled = false;
            buttonNewPage.Location = new Point(8, 6);
            buttonNewPage.Name = "buttonNewPage";
            buttonNewPage.Size = new Size(75, 23);
            buttonNewPage.TabIndex = 18;
            buttonNewPage.Text = "New Page";
            buttonNewPage.UseVisualStyleBackColor = false;
            buttonNewPage.Click += buttonNewPage_Click;
            // 
            // labelOpacity
            // 
            labelOpacity.AutoSize = true;
            labelOpacity.Location = new Point(186, 158);
            labelOpacity.Name = "labelOpacity";
            labelOpacity.Size = new Size(54, 15);
            labelOpacity.TabIndex = 20;
            labelOpacity.Text = "Opacity :";
            // 
            // numericOpacity
            // 
            numericOpacity.Location = new Point(186, 176);
            numericOpacity.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericOpacity.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericOpacity.Name = "numericOpacity";
            numericOpacity.Size = new Size(120, 23);
            numericOpacity.TabIndex = 21;
            numericOpacity.ValueChanged += numericOpacity_ValueChanged;
            // 
            // labelColumn
            // 
            labelColumn.AutoSize = true;
            labelColumn.Location = new Point(18, 158);
            labelColumn.Name = "labelColumn";
            labelColumn.Size = new Size(56, 15);
            labelColumn.TabIndex = 18;
            labelColumn.Text = "Column :";
            // 
            // numericColumn
            // 
            numericColumn.Location = new Point(18, 176);
            numericColumn.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericColumn.Name = "numericColumn";
            numericColumn.Size = new Size(120, 23);
            numericColumn.TabIndex = 19;
            numericColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericColumn.ValueChanged += numericColumn_ValueChanged;
            // 
            // checkMap
            // 
            checkMap.AutoSize = true;
            checkMap.Location = new Point(704, 56);
            checkMap.Name = "checkMap";
            checkMap.Size = new Size(82, 19);
            checkMap.TabIndex = 19;
            checkMap.Text = "Show Map";
            checkMap.UseVisualStyleBackColor = true;
            checkMap.CheckedChanged += checkMap_CheckedChanged;
            // 
            // textBoxBackground
            // 
            textBoxBackground.Location = new Point(784, 74);
            textBoxBackground.Name = "textBoxBackground";
            textBoxBackground.Size = new Size(100, 23);
            textBoxBackground.TabIndex = 20;
            textBoxBackground.TextChanged += textBoxBackground_TextChanged;
            // 
            // labelBackground
            // 
            labelBackground.AutoSize = true;
            labelBackground.Location = new Point(704, 78);
            labelBackground.Name = "labelBackground";
            labelBackground.Size = new Size(80, 15);
            labelBackground.TabIndex = 21;
            labelBackground.Text = "Background : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(870, 28);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 22;
            label2.Text = "label2";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(5, 322);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 23;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(912, 469);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(75, 23);
            buttonImport.TabIndex = 24;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // numericSX
            // 
            numericSX.Location = new Point(704, 120);
            numericSX.Name = "numericSX";
            numericSX.Size = new Size(120, 23);
            numericSX.TabIndex = 25;
            numericSX.ValueChanged += numericSX_ValueChanged;
            // 
            // numericSY
            // 
            numericSY.Location = new Point(835, 120);
            numericSY.Name = "numericSY";
            numericSY.Size = new Size(120, 23);
            numericSY.TabIndex = 26;
            numericSY.ValueChanged += numericSY_ValueChanged;
            // 
            // labelSX
            // 
            labelSX.AutoSize = true;
            labelSX.Location = new Point(704, 102);
            labelSX.Name = "labelSX";
            labelSX.Size = new Size(55, 15);
            labelSX.TabIndex = 27;
            labelSX.Text = "Speed X :";
            // 
            // labelSY
            // 
            labelSY.AutoSize = true;
            labelSY.Location = new Point(835, 102);
            labelSY.Name = "labelSY";
            labelSY.Size = new Size(55, 15);
            labelSY.TabIndex = 28;
            labelSY.Text = "Speed Y :";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 496);
            Controls.Add(labelSY);
            Controls.Add(labelSX);
            Controls.Add(numericSY);
            Controls.Add(numericSX);
            Controls.Add(buttonImport);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(labelBackground);
            Controls.Add(textBoxBackground);
            Controls.Add(checkMap);
            Controls.Add(groupWindow);
            Controls.Add(buttonNew);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            Controls.Add(listWindows);
            Controls.Add(buttonUpd);
            Controls.Add(groupBox1);
            Name = "MainMenu";
            Text = "Main menu";
            Shown += Form1_Shown;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericW).EndInit();
            groupWindow.ResumeLayout(false);
            groupWindow.PerformLayout();
            tabControl.ResumeLayout(false);
            Page1.ResumeLayout(false);
            Page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCondition).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOpacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonUpd;
        private CheckBox isHided;
        private TreeView listWindows;
        private Label labelX;
        private NumericUpDown numericX;
        private NumericUpDown numericY;
        private Label labelY;
        private Label label1;
        private NumericUpDown numericH;
        private Label labelH;
        private NumericUpDown numericW;
        private Label labelW;
        private Button buttonOK;
        private Button buttonNew;
        private RichTextBox textBox;
        private GroupBox groupWindow;
        private CheckBox checkMap;
        private TextBox textBoxBackground;
        private Label labelBackground;
        private Label labelColumn;
        private NumericUpDown numericColumn;
        private Label labelOpacity;
        private NumericUpDown numericOpacity;
        private TabControl tabControl;
        private TabPage Page1;
        private Button buttonNewPage;
        private Label labelAlign;
        private ComboBox comboBoxAlign;
        private NumericUpDown numericCondition;
        private CheckBox checkBoxCondition;
        private Label label2;
        private Button buttonDelete;
        private Button buttonImport;
        private NumericUpDown numericSX;
        private NumericUpDown numericSY;
        private Label labelSX;
        private Label labelSY;
    }
}