﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Hero : Character
    {
        List<string> itemList = new List<string>();
        int exp, lv;
        public Hero(int level)
        {
            lv = level;
            Random r = new Random(50);
            this.setMaxHp(level * 200);
            this.setmaxMp(level * 10);
        }
        public List<string> getList()
        {
            return itemList;
        }
        public void setList(List<string> s)
        {
            itemList = s;
        }
        public void addItem(string item)
        {
            itemList.Add(item);
        }
        public void removeItem(string item)
        {
            itemList.Remove(item);
        }
        public int getExp()
        {
            return exp;
        }
        public void setExp(int e)
        {
            exp = e;
            if (exp > 1000)
            {
                lv++;
            }
        }
        public int getLevel()
        {
            return lv;
        }
        public void setLevel(int lev)
        {
            lv = lev;
        }
    }
}
