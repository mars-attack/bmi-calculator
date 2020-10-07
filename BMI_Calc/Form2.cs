using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BMI_Calc
{
    // GROUP - 8
    // Marianne Palmer - 301122149
    // Shota Ito - 301103095
    // Xu-Tung Jin - 301111889
    // Kris Waithe - 300637474

    public partial class Form2 : Form
    {
        readonly DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            TextReader reader = new StreamReader("myfile.json");
            List<Person> persons = serializer.Deserialize<List<Person>>(reader.ReadToEnd());

            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("BMI");

            foreach (Person p in persons)
            {
                dt.Rows.Add(p.Name, p.Gender, p.BMI);
            }

            dataGridView.DataSource = dt;

            reader.Close();
        }
    }
}
