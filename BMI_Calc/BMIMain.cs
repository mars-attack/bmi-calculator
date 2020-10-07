using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Web.Script.Serialization;
using System.IO;

namespace BMI_Calc
{
    public partial class BMIMain : Form
    {
        public List<Person> persons = new List<Person>();
        DataTable dt = new DataTable();

        public BMIMain()  
        {

            // threading used for handling the slashscreen form
            Thread t = new Thread(new ThreadStart(StartSplashScreen));
            t.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            t.Abort();

            // to bring form to the front
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            // clear tabs contents when switch tab
            Tabs.SelectedIndexChanged += new EventHandler(ClearTabData);


            // To load DataGrid on startup
            UpdateDataGrid();
        }


        // Clears and re-renders the table
        public void UpdateDataGrid()
        {
            GenericTuple<string, string,string> headings = new GenericTuple<string, string, string>("Name","Gender", "BMI");

            dt = new DataTable();
            dt.Columns.Add(headings.Item1);
            dt.Columns.Add(headings.Item2);
            dt.Columns.Add(headings.Item3);
            foreach (Person p in persons)
            {
                dt.Rows.Add(p.Name, p.Gender, p.BMI);
            }
            dataGridView1.DataSource = dt;
        }

        // Runs the SplashScreen
        public void StartSplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Exception handling for empty and zero values
            try
            {
                categoryBox1.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // color for sucess
                string name = NameBox.Text;
                int feet = Convert.ToInt32(feetBox.Text);
                int inchesHeight = feet * 12 + Convert.ToInt32(inchBox.Text);
                double weight = Convert.ToInt32(lbsBox.Text);

                if (feet != 0 && inchesHeight != 0 && weight != 0 && name != "")
                {
                    double results = weight / Math.Pow(inchesHeight, 2) * 703;
                    GenerateCategory(results);
                    impResults.Text = $"{results:f2}";
                }
                else
                {
                    throw new Exception();
                }
            }
            
            catch
            {
                categoryBox1.Text = "Please fill in all details.";
                categoryBox1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // color for error
            }
        }

        private void CalcMetricBMI_Click(object sender, EventArgs e)
        {
            // Exception handling for empty and zero values
            try
            {
                categoryBox2.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte) (0))))); // colour for sucess
                string name = NameBox2.Text;
                int cm = Convert.ToInt32(cmBox.Text);
                double weight = Convert.ToInt32(kgsBox.Text);
                if (cm != 0 && weight != 0 && name != "")
                {
                    double results = weight / Math.Pow(cm, 2) * 10_000;
                    GenerateCategory(results);
                    metricResults.Text = $"{results:f2}";
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                categoryBox2.Text = "Please fill in all details.";
                categoryBox2.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // colour for error
            };
        }


        private void GenerateCategory(double results)
        {

            // Dictionary for weight categories
            Dictionary<string, string> weightCategories = new Dictionary<string, string>
            {
                { "Underweight", "Try to gain weight." },
                { "Normal Weight", "You are at a healthy weight." },
                { "Overweight", "Try to lose weight." },
                { "Obese", "Try to lose weight." }
            };

            // using generic tuple again for weight categories and their upper limits
            GenericTuple<string, double> underweight = new GenericTuple<string, double>("Underweight", 18.5);
            GenericTuple<string, double> normalweight = new GenericTuple<string, double>("Normal Weight", 24.9);
            GenericTuple<string, double> overweight = new GenericTuple<string, double>("Overeight", 29.9);

            string categoryKey;

            categoryKey = results <= underweight.Item2 ? underweight.Item1 : results <= normalweight.Item2 ? normalweight.Item1 : results <= overweight.Item2 ? overweight.Item1 : "Obese";

            weightCategories.TryGetValue(categoryKey, out string catValue); // Gets the key's value and assigns it to a variable 

            string categoryResults = categoryKey + ".\n" + catValue;

            categoryBox1.Text = categoryResults;
            categoryBox2.Text = categoryResults;
        }

        // event handler for clearing form
        private void ClearTabData(object sender, EventArgs e)
        {
            // clear tab1
            NameBox.Text = "";
            feetBox.Text = "";
            inchBox.Text = "";
            lbsBox.Text = "";
            impResults.Text = "";
            categoryBox1.Text = "";
            GenderBox1.Text = "";
            // clear tab 2
            NameBox2.Text = "";
            cmBox.Text = "";
            kgsBox.Text = "";
            metricResults.Text = "";
            categoryBox2.Text = "";
            GenderBox2.Text = "";
        }

        // Add button handler
        private void AddBTN_Click(object sender, EventArgs e)
        {
            // Checks if imperial or metric before assigning
            string name = (NameBox.Text != "") ? NameBox.Text : NameBox2.Text;
            string bmi = (impResults.Text != "")? impResults.Text: metricResults.Text;
            string gender = (GenderBox1.Text != "") ? GenderBox1.Text : GenderBox2.Text;
            persons.Add(new Person(name, gender, bmi));
            UpdateDataGrid();
        }

        // Saves list as json file
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            TextWriter writer = new StreamWriter("myfile.json");
            writer.WriteLine(serializer.Serialize(persons));
            writer.Close();

            var myForm = new Form2();
            myForm.Show();
        }

        // Deletes person object in the list if there is a match
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // Must have a try catch, or else code won't run
            try
            {
                foreach (Person p in persons)
                {
                    if (NameBox.Text == p.Name)
                    {
                        persons.Remove(p);
                    }
                    else if (NameBox2.Text == p.Name)
                    {
                        persons.Remove(p);
                    }
                }
            }
            catch
            {

            }
            UpdateDataGrid();
        }

        // Updates person object in the list if there is a match
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            foreach (Person p in persons)
            {
                if (NameBox.Text == p.Name)
                {
                    p.Name = NameBox.Text;
                    p.Gender = GenderBox1.Text;
                    p.BMI = impResults.Text;
                }
                else if (NameBox2.Text == p.Name)
                {
                    p.Name = NameBox2.Text;
                    p.Gender = GenderBox2.Text;
                    p.BMI = metricResults.Text;
                }
            }
            UpdateDataGrid();
        }
    }
}
