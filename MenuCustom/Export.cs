using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace MenuCustom
{
    internal partial class Export : Form
    {
        MainMenu parent;
        List<Window_Class> windows;
        Option options;

        bool import;
        public Export(MainMenu p, List<Window_Class> w, Option o, bool imp)
        {
            InitializeComponent();
            parent = p;
            windows = w;
            options = o;

            import = imp;

            if (import)
            {
                button1.Text = "Import";
                this.Text = "Import";
            }
            else
            {

                string contents = "@raw 9998, \"" + options.showMap;
                if (options.background != "")
                    contents += ",'" + options.background + "'";

                foreach (Window_Class window in windows)
                {
                    contents += "\n";
                    string b = window.getHide().ToString();
                    contents += window.getName() + ":" + window.getX() + "," + window.getY() + "," + (window.getW() + 8) + "," + (window.getH() - 8) + "," + window.getColumn() + "," + b + "," + window.getOpacity();
                    if (window.getCustom())
                        foreach (Page page in window.GetPageList())
                        {
                            int i = -1;
                            if (page.Condition)
                                i = page.Condition_index;
                            contents += ",{" + i + "}{" + page.Align + "}{'" + page.Text + "'}";
                        }

                }
                contents += "\"";
                textContents.Text = contents;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent != null)
            {
                parent.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (import)
            {
                parseImport();
                parent.refreshImport();
            }

            this.Close();
        }

        private void parseImport()
        {
            parent.GetListWindows().Nodes.Clear();
            parent.windows.Clear();

            int maxWin = 1;

            string import = textContents.Text;
            int index_found = import.IndexOf('"') + 1;
            import = import.Substring(index_found, import.Length - index_found);

            char delim = '\n';

            string[] lines = import.Split(delim);

            int nline = 0;
            foreach (string line in lines)
            {
                if (nline == 0)
                {
                    delim = ',';

                    string[] tokens = line.Split(delim);
                    tokens[0] = tokens[0].Replace(" ", "");
                    options.showMap = tokens[0].ToLower() == "true";

                    if (tokens.Length > 1)
                    {
                        index_found = tokens[1].IndexOf('\'') + 1;
                        int last_index_found = tokens[1].LastIndexOf('\'');
                        tokens[1] = tokens[1].Substring(index_found, last_index_found - index_found);
                        options.background = tokens[1];
                    }
                }
                else
                {
                    string win_name;

                    delim = ':';

                    string[] tokens = line.Split(delim);
                    win_name = tokens[0];

                    index_found = line.IndexOf(':') + 1;
                    string param = line.Substring(index_found, line.Length - index_found);

                    //label1.Text += param + "\n";

                    // Expression régulière pour ignorer les virgules entre guillemets simples
                    string pattern = @",(?=(?:[^']*'[^']*')*[^']*$)";

                    // Découper la chaîne en utilisant la regex
                    string[] result = Regex.Split(param, pattern);



                    Window_Class win = null;
                    if (win_name == "Commands")
                    {
                        // win = new Window_Class("Commands", false);
                        // parent.WindowCommand = win;
                        win = parent.WindowCommand;
                        parent.GetListWindows().Nodes.Add(win.getName());
                    }
                    else if (win_name == "Gold")
                    {
                        // win = new Window_Class("Gold", false);
                        // parent.WindowGold = win;
                        win = parent.WindowGold;
                        parent.GetListWindows().Nodes.Add(win.getName());
                    }
                    else if (win_name == "Status")
                    {
                        // win = new Window_Class("Status", false);
                        // parent.WindowStatus = win;
                        win = parent.WindowStatus;
                        parent.GetListWindows().Nodes.Add(win.getName());
                    }
                    else
                    {
                        win = new Window_Class("CWin" + maxWin, true, maxWin);
                        maxWin++;
                        win.GetPageList().Clear();

                        parent.windows.Add(win);
                        parent.GetListWindows().Nodes.Add(win.getName());
                    }

                    if (win != null)
                    {

                        win.setX(Int32.Parse(result[0]));
                        win.setY(Int32.Parse(result[1]));
                        win.setW(Int32.Parse(result[2]));
                        win.setH(Int32.Parse(result[3]));

                        win.setColumn(Int32.Parse(result[4]));
                        win.setOpacity(Int32.Parse(result[5]));

                        result[6] = result[6].Replace(" ", "");
                        win.setHide(result[6].ToLower() == "true");


                        // Text
                        if (result.Length > 7)
                        {
                            pattern = @"\{(.*?)\}";
                            win.GetPageList().Clear();

                            for (int i = 7; i < result.Length; i++)
                            {
                                string text = result[i];
                                // Découper la chaîne en utilisant la regex

                                // Utilisation de Regex.Match pour trouver les correspondances
                                MatchCollection matches = Regex.Matches(text, pattern);

                                //foreach (string t in matches)
                                //{
                                //    label1.Text += t +"!";
                                //}
                                //label1.Text += "\n";


                                //label1.Text += text + "\n";

                                Page p = new Page();
                                string s = matches[0].Value;
                                s = s.Substring(1, s.Length - 2);
                                int c = Int32.Parse(s);
                                p.Condition = c >= 0;
                                if (c < 0)
                                    c = 0;
                                p.Condition_index = c;

                                s = matches[1].Value;
                                s = s.Substring(1, s.Length - 2);
                                p.Align = s;

                                s = matches[2].Value;
                                s = s.Substring(2, s.Length - 4);
                                p.Text = s;

                                win.GetPageList().Add(p);
                            }
                        }
                    }

                }

                nline++;
            }
        }

    }
}
