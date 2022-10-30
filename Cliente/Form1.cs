using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mi.Service1Client oClient = new Mi.Service1Client();
            string res = oClient.GetData(5,3);
            MessageBox.Show(res);

            Mi.CompositeType oData = new Mi.CompositeType();
            oData.BoolValue = true;
            var res2= oClient.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);
        }
    }
}
