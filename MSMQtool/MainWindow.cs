using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;

namespace MSMQtool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ecriture dans la file
            MessageQueue mq = new MessageQueue(@".\private$\bookingemn");
            //mq.Formatter = new XMLMessageFormatter(new Type[] { typeof(Reservation) });
            itemsList.DataSource = mq.GetAllMessages();
            mq.Close();
        }
    }
}
