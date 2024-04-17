using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCustom
{
    public class Page
    {
        private string text = "";
        private int id;
        private string align = "Left";
        private bool condition;
        private int condition_index;

        public string Text { get => text; set => text = value; }
        public int ID { get => id; set => id = value; }
        public string Align { get => align; set => align = value; }
        public int Condition_index { get => condition_index; set => condition_index = value; }
        public bool Condition { get => condition; set => condition = value; }
    }
}
