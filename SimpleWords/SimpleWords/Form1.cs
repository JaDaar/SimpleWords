using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWords
{
    public partial class Form1 : Form
    {
        public List<string> VerticalWordList;
        public List<string> VerticalClueList;

        public List<string> HorizontallWordList;
        public List<string> HorizontalClueList;
        private TextBox[] arr = new TextBox[101];

        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            VerticalWordList = new List<string>();
            VerticalClueList = new List<string>();
            HorizontallWordList = new List<string>();
            HorizontalClueList = new List<string>();
            AddVerticalWords();
            AddHorizontalWords();
            CreateTextboxArray();
        }

        private void CreateTextboxArray()
        {
            

            for (var i = 0; i < 101; i++)
            {
                var tbox = new TextBox();
                tbox.TextAlign = HorizontalAlignment.Center;
                tbox.Anchor = AnchorStyles.None;
                tbox.Dock = DockStyle.Fill;
                this.Controls.Add(tbox);
                arr[i] = tbox;
                tblyCC.Controls.Add(arr[i]);
            }
        }

        private void AddVerticalWords()
        {
            VerticalWordList.Add("distend");
            AddToDownList("extend");

            VerticalWordList.Add("brainiac");
            AddToDownList("very intelligent person");

            VerticalWordList.Add("tyro");
            AddToDownList("a beginner in learning");

            VerticalWordList.Add("equity");
            AddToDownList("justice according to natural law");

            VerticalWordList.Add("ambient");
            AddToDownList("encompassing");

            VerticalWordList.Add("hinterland");
            AddToDownList("area lying beyond what is visible");

            VerticalWordList.Add("capitulate");
            AddToDownList("surrender");

            VerticalWordList.Add("pot");
            AddToDownList("___ roast");

            VerticalWordList.Add("television");
            AddToDownList("idiot-box");

            VerticalWordList.Add("JJ");
            AddToDownList("Producer __ Abrams");

            VerticalWordList.Add("yen");
            AddToDownList("Japanese currency");
        }

        private void AddToDownList(string item)
        {
            if (item!=null && item.Length > 0)
            {
                VerticalClueList.Add(item.Substring(0, 1).ToUpper() + item.Substring(1));
                lstDown.Items.Add(item.Substring(0, 1).ToUpper() + item.Substring(1));
            }
        }

        private void AddHorizontalWords()
        {
            HorizontallWordList.Add("car");
            AddToAcrossList("horseless carriage");

            HorizontallWordList.Add("jobs");
            AddToAcrossList("apple co-founder");

            HorizontallWordList.Add("romaine");
            AddToAcrossList("hail caesar");

            HorizontallWordList.Add("sofa");
            AddToAcrossList("furniture");

            HorizontallWordList.Add("surfboard");
            AddToAcrossList("ocean fun");

            HorizontallWordList.Add("shutterbug");
            AddToAcrossList("photographer");

            HorizontallWordList.Add("boeing");
            AddToAcrossList("airplane maker");

            HorizontallWordList.Add("blackjack");
            AddToAcrossList("game of chance");

            HorizontallWordList.Add("edison");
            AddToAcrossList("inventor of the lightbulb");

            HorizontallWordList.Add("longhand");
            AddToAcrossList("calligraphy");

        }

        private void AddToAcrossList(string item)
        {
            if (item !=null && item.Length > 0)
            {
                HorizontalClueList.Add(item.Substring(0, 1).ToUpper() + item.Substring(1));
                lstAcross.Items.Add(item.Substring(0, 1).ToUpper() + item.Substring(1));
            }
        }

        private void GetAcrossWord(string v, int start)
        {
            if (start == 0)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 1)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 2)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 3)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 4)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 5)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s- offSet, 1).ToUpper();
                }
            }
            else if (start == 6)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 7)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 8)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 9)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
            else if (start == 10)
            {
                var offSet = start * 10;
                for (var s = offSet; s < v.Length + offSet; s++)
                {
                    arr[s].Text = v.Substring(s - offSet, 1).ToUpper();
                }
            }
        }

        private void lstAcross_Click(object sender, EventArgs e)
        {
            GetAcrossWord(HorizontallWordList[lstAcross.SelectedIndex].ToString(), lstAcross.SelectedIndex);
        }
    }
}
