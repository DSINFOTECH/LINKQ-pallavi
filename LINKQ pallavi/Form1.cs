using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LINKQ_pallavi.DataLayer;
using System.Data.Linq; 
namespace LINKQ_pallavi
{
    public partial class Form1 : Form
    {
        DataLINKQDataContext _dLinq;
        List<Company> _list;
        public Form1()
        {
             _dLinq = new DataLINKQDataContext(); 
            InitializeComponent();
        }

        private void loaddata()
        {
            _list = new List<Company>();
            _dLinq = new DataLINKQDataContext();
            
            
            dataGridView1.DataSource = _list;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata(); 

           // _list = new List<Company>();
           // _list = _dLinq.Companies.ToList();
           // var query = from r in _dLinq.Companies select r;
           // dataGridView1.DataSource = _list; 
           //// dataGridView1.DataSource = query;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        

        }
      
    }
}
