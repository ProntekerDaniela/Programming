using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._1DB
{
    public partial class Form1 : Form
    {
        List<Table> stud = new List<Table>();

        public Form1()
        {

            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

            using (UniversityContext st = new UniversityContext())
            {
                List<Table> stud = st.Table.ToList<Table>();
                dataGridView1.DataSource = stud;
            }

        }
      
        private void buttonSort_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (UniversityContext st = new UniversityContext())
            {
                stud = st.Table.ToList<Table>()
                    .Where((stud) => stud.course == numCourse.Value)
                    .ToList<Table>();  
            }
            dataGridView1.DataSource = stud;
        }
       
        private void Max_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (UniversityContext st = new UniversityContext())
            {
                stud = st.Table.ToList<Table>()
                    .Where((stud) => stud.name.ToLower().Contains(textFilterName.Text.ToLower()))
                    .ToList<Table>();
            }
            dataGridView1.DataSource = stud;
        }
       
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (UniversityContext st = new UniversityContext())
            {
                stud = st.Table.ToList<Table>().OrderBy(stud => stud.rate)
                .Skip(1)
                .ToList<Table>();
            }
            dataGridView1.DataSource = stud;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void MaxValueRate_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (UniversityContext st = new UniversityContext())
            {
                stud = st.Table.ToList<Table>().OrderByDescending(stud => stud.rate)
               .Take(1)
               .ToList<Table>();
            }
            dataGridView1.DataSource = stud;
        }
       
        private void count_Click(object sender, EventArgs e)
        {
            using (UniversityContext st = new UniversityContext())
            {
                MessageBox.Show($"All students: {un.Table.ToList<Table>().Count(stud => stud.course == numCourse.Value)}");
            }
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            using (UniversityContext st = new UniversityContext())
            {
                MessageBox.Show($"Student were rate>60: {un.Table.ToList<Table>().Count((stud) => stud.rate>60)}");
            }
        }
    }
}
