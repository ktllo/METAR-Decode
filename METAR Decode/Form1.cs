using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace METAR_Decode
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }

        private void butDecode_Click(object sender, EventArgs e)
        {
            String message = txtCode.Text;
            try
            {
                METAR metar = Parser.parse(message);
                //TODO: Display the result
                lbType.Text = metar.messageType.ToString();
            }catch(ParserException pe)
            {
                MessageBox.Show(pe.Message);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Clear everythings
            lbType.Text = "";
        }
    }
}
