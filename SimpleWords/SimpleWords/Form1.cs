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
        public List<string> WordList;
        public List<string> DescriptionList;

        public Form1()
        {
            InitializeComponent();
            WordList = new List<string>();
            DescriptionList = new List<string>();
            //string[] puzzle = new string[5000];
            List<string> puzzles = new List<string>();
            string[] words = { "zebra", "house","predator","baseball","computer",
                                "China","dancing","carnival","barn","yoda"};

            string[] wordDescription = {"African equines",
                                        "a residential building",
                                        "one organism kills and eats another organism",
                                        "bat-and-ball game played between two opposing teams",
                                        "a machine that can be instructed to carry out sequences of arithmetic or logical operations automatically",
                                        "a country in East Asia",
                                        "performing art form consisting of purposefully selected sequences of human movement",
                                        "a traveling amusement show or circus.",
                                        "a large farm building used for storing grain, hay, or straw or for housing livestock",
                                        "a legendary Jedi Master"};

            WordList.AddRange(words);
            DescriptionList.AddRange(wordDescription);

            for(var index = 0; index < words.Length; index++)
            {
                for (var iter = 0; iter < words[index].Length; iter++)
                {
                    puzzles.Add(words[index].Substring(iter, 1).ToUpper());
                }
                
            }
        }


    }
}
