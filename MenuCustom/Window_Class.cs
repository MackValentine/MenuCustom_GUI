using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MenuCustom
{
    public class Window_Class
    {
        int x;
        int y;
        int w = 80;
        int h = 80;

        int column = 1;

        public int index;

        bool isHided;

        bool custom;

        string name = "";

        int opacity;

        string customText = "";
        List<Page> pageList = new List<Page>(); 

        public Window_Class(String n, bool b, int i)
        {

            index = i;
            name = n;
            custom = b;
            Page p = new Page();
            pageList.Add(p);
        }

        public String getName()
        {
            return name;
        }


        public int getX()
        {
             return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int i)
        {
            x = i;
        }

        public void setY(int i)
        {
            y = i;
        }

        public int getW()
        {
            return w;
        }

        public int getH()
        {
            return h;
        }

        public void setW(int i)
        {
            w = i - 8;
        }

        public void setH(int i)
        {
            h = i + 8;
        }

        public bool getHide()
        {
            return isHided;
        }

        public void setHide(bool b)
        {
            isHided = b;
        }

        public bool getCustom()
        {
            return custom;
        }

        public void setCustom(bool b)
        {
            custom = b;
        }

        public String getText()
        {
            return customText;
        }
        public void setText(String s)
        {
            customText = s;
        }

        public int getColumn()
        {
            return column;
        }

        public void setColumn(int i)
        {
            column = i;
        }

        public int getOpacity()
        {
            return opacity;
        }

        public void setOpacity(int i)
        {
            opacity = i;
        }

        public List<Page> GetPageList()
        {
            return pageList;
        }
    }
}
