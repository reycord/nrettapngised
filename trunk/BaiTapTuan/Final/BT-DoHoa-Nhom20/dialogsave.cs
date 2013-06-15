using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT_DoHoa_Nhom20
{
    public partial class dialogsave : Form
    {
        private String _nameOfFile;
        public String NameOfFile
        {
            get { return _nameOfFile; }
            set { _nameOfFile = value; }
        }
        private String _typeOfFile;
        public String TypeOfFile
        {
            get { return _typeOfFile; }
            set { _typeOfFile = value; }
        }

        public dialogsave()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            _nameOfFile = textBox1.Text;
            _typeOfFile = comboBox1.SelectedItem.ToString();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dialogsave_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
