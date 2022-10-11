using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormKezdolap : Form
    {
        public FormKezdolap()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKezdolap_Load(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                StreamReader rd = new StreamReader("Regisztraltak.txt", Encoding.UTF8);
                while (!rd.EndOfStream)
                {
                    rd.ReadLine();
                    count++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült a termékek beolvasása a Regisztraltak.txt fájlból!");
                throw;
            }

            StreamReader term = new StreamReader("Termekek.txt", Encoding.UTF8);
            List<Sajat> beolvasottTerm = new List<Sajat>();
            while (!term.EndOfStream)
            {
                string[] split = term.ReadLine().Split(';');
                if (split.Length == 5)
                {
                    //sajat termek
                    Sajat t = new Sajat(split[0], split[1], Convert.ToInt32(split[2]), Convert.ToInt32(split[3]), split[4]);
                    beolvasottTerm.Add(t);

                }
                else
                {
                    //beszerzett termek
                    Beszerzett t = new Beszerzett(split[0], split[1], Convert.ToInt32(split[2]), Convert.ToInt32(split[3]), split[4], split[5]);
                    beolvasottTerm.Add(t);

                }
            }
            term.Close();

            //Series series = this.chartControl.Series.Add("Total Income");
            //series.ChartType = SeriesChartType.Spline;

            /*chart1.Series["Bevetel"].Points.AddXY(beolvasottTerm[0].Dátum, beolvasottTerm[0].Ár);
            chart1.Series["Bevetel"].Points.AddXY(beolvasottTerm[1].Dátum, beolvasottTerm[1].Ár);
            chart1.Series["Bevetel"].Points.AddXY(beolvasottTerm[2].Dátum, beolvasottTerm[2].Ár);
            chart1.Series["Bevetel"].Points.AddXY(beolvasottTerm[3].Dátum, beolvasottTerm[3].Ár);
            chart1.Series["Bevetel"].Points.AddXY(beolvasottTerm[4].Dátum, beolvasottTerm[4].Ár);*/
            chart1.ChartAreas[0].BackColor = Color.FromArgb(37, 42, 67);
            List<Tuple<DateTime, int>> list_bev = new List<Tuple<DateTime, int>>();
            var usersGroupedByCountry = beolvasottTerm.GroupBy(user => user.Dátum);
            foreach (var group in usersGroupedByCountry)
            {
                //Console.WriteLine("Dátum " + group.Key + ":");
                DateTime myDate = DateTime.ParseExact(group.Key, "yyyy. MM. dd.",
                                       System.Globalization.CultureInfo.InvariantCulture);
                int groupbyAr = 0;
                foreach (var user in group)
                    groupbyAr += user.Ár;
                list_bev.Add(new Tuple<DateTime, int>(myDate, groupbyAr));

                //Console.WriteLine("Bevételek: " + groupbyAr);
            }

            foreach (var i in list_bev)
            {
                Console.WriteLine(i.Item1.ToString("yyyy. MM. dd.") + "  " + i.Item2);

            }
            var listOrdered = list_bev.OrderBy(x => x.Item1).ToList();

            Console.WriteLine();
            foreach (var i in listOrdered)
            {

                chart1.Series["Bevetel"].Points.AddXY(i.Item1.ToString("yyyy. MM. dd."), i.Item2);
                Console.WriteLine(i.Item1.ToString("yyyy. MM. dd.") + "  " + i.Item2);

            }
            /*
            List<String> x_tengely = beolvasottTerm.Select(i => i.Dátum).Distinct().ToList<String>();
            x_tengely.ForEach(i => Console.WriteLine(i));
            List<Tuple<string, int>> list_bev = new List<Tuple<string,int>>();
            int count_x = 0;
            foreach (String i in x_tengely){
                foreach(Sajat j in beolvasottTerm){
                    if (i.Equals(j.Dátum))
                    {
                        int napi_bev = list_bev[count_x].Item2;
                        list_bev.Add(new Tuple<string, int>(i, list_bev.get));
                    }
                }
                chart1.Series["Bevetel"].Points.AddXY(list_bev[count_x].Item1, list_bev[count_x].Item2);
                count_x++;
            }
            */

            chart1.Titles.Add("Napi bevétel gráf");

            string s = count.ToString();
            lblOsszesVasarlo.Text = s;
        }
    }
}
