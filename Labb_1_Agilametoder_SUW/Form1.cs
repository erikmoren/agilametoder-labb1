///Author: Erik Morén
///Version: 1
///Date: 2014-10-06

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_1_Agilametoder_SUW
{
    public partial class Form1 : Form
    {
        List<String> Stringlist = new List<String>();
        public Form1()
        {
            InitializeComponent();
            InitList(); 
        }

        /// <summary>
        /// Clears all input fields in the form.
        /// </summary>
        private void ClearAllInputFields()
        {
            textBox1.Clear(); 
            textBox2.Clear(); 
            textBox3.Clear();
        }

        /// <summary>
        /// Initializes our list with start values.
        /// </summary>
        private void InitList()
        {
            Stringlist.Add("Namn     Mejl     Nummer");
            Stringlist.Add("Bengt     benga55@gmail.com     0701234567");
            Stringlist.Add("Peter     ptr@hotspot.com     0701234576");
            Stringlist.Add("Lina     lina_w@gmail.com     0701239654");
            Stringlist.Add("Ahmed     ahmed_ahmed@gmail.com     0707654321");
            Stringlist.Add("Angelica     angelangelica@gmail.com     0701212125");
            Stringlist.Add("Olof     olof_olofsson5@gmail.com     0702223336");
            Stringlist.Add("Clara     stensson_c@gmail.com     0730456789");
            Stringlist.Add("Stina     stinastinastinastina@hotmail.com     0700554412");
            Stringlist.Add("Bertil     beritochbertil@telia.com     0700000258");
        }

        /// <summary>
        /// Click evet for addToList button. Adds an element to our list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToListButton_Click(object sender, EventArgs e)
        {
            Stringlist.Add(textBox1.Text + "     " + textBox2.Text + "     " + textBox3.Text);
            ClearAllInputFields();
        }

        /// <summary>
        /// Click event for showList button. Displays our list in our window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showListButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            foreach (String str in Stringlist)
            {
                listBox1.Items.Add(str);
            }

            ClearAllInputFields();
        }

        /// <summary>
        /// Click event for search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void searchListButton_Click(object sender, EventArgs e)
        {
            String searchStr = textBox4.Text.ToLower();
            List<String> resultList = SearchList(searchStr);

            listBox1.Items.Add("");
            
            if (resultList.Count > 0)
            {
                listBox1.Items.Add("Resultat av sökning:");
                foreach (String str in resultList)
                {
                    listBox1.Items.Add(str);
                }
            }
            else
            {
                listBox1.Items.Add("Sorry, hittade inget.");
            }
        }

        /// <summary>
        /// Searches through our list of strings for a match.
        /// </summary>
        /// <param name="searchStr">String with our search text</param>
        /// <returns>List of Strings</returns>
        private List<String> SearchList(String searchStr)
        {
            List<String> resultList = new List<String>();
            foreach (String str in Stringlist)
            {
                if (str.ToLower().Contains(searchStr))
                {
                    resultList.Add(str);
                }
            }

            return resultList;
        }
    }
}
