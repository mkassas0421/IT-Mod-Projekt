using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormTermekFelelos : Form
    
    {   
        string[] s = Enum.GetNames(typeof(Márka));
        static List<String> markaList = new List<String>();
        String selectedVal;

        public FormTermekFelelos()
        {
            InitializeComponent();
            List<String> allLinesText = File.ReadAllLines("marka.txt").ToList();
            //Ha nem üres a mentett lista, akkor abból olvassuk be a Márkákat
            //Egyébként az enumból
            if (allLinesText.Count != 0)
            {
                foreach (string name in allLinesText)
                {
                    comboBox1.Items.Add(name);
                    setMarka(name);

                }
            }
            else
            {
                foreach (string name in Enum.GetNames(typeof(Márka)))
                {
                    comboBox1.Items.Add(name);
                    setMarka(name);
                }
            }
            Console.WriteLine(markaList.Count);

        }
        public static List<String> GetMarka()
        {
            return markaList;
        }
        public void setMarka (String newMarka)
        {
            markaList.Add(newMarka);
        }

        private void refreshCb()
        {
            comboBox1.Items.Clear();
                for (int i = 0; i < markaList.Count; i++) {
                //Console.WriteLine(markaList[i]);
                    comboBox1.Items.Add(markaList[i]);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb1 = (ComboBox)sender;
            selectedVal = (String)cmb1.SelectedItem;
            Console.WriteLine(selectedVal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            markaList.Remove(selectedVal);
            comboBox1.Items.Remove(selectedVal);
            refreshCb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markaList.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
            refreshCb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            markaList.Remove(selectedVal);
            markaList.Add(comboBox1.Text);
            comboBox1.Items.Remove(selectedVal);
            comboBox1.Items.Add(textBox1.Text);
            refreshCb();

        }
        public void exportToFile()
        {
            System.IO.File.WriteAllLines("marka.txt", markaList);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            exportToFile();
            this.Close();
        }
    }
}
