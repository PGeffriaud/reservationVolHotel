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
using booking.commonTypes;
using booking.libReservation;
using System.Data.SqlClient;

namespace MSMQtool
{
    public partial class MainWindow : Form
    {
        private libReservation libReservation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.libReservation = new libReservation();
            getAllMessagesFromQueue();
        }

        private void getAllMessagesFromQueue()
        {
            MessageQueue mq = getMessageQueue();
            System.Messaging.Message[] allMess = mq.GetAllMessages();
            List<string> listeResa = new List<string>();
            foreach (System.Messaging.Message item in allMess)
            {
                Reservation tmp = (Reservation)item.Body;
                listeResa.Add(genLineReservation(tmp));
            }
            itemsList.DataSource = listeResa;
            mq.Close();
        }

        private static MessageQueue getMessageQueue()
        {
            MessageQueue mq = new MessageQueue(@".\private$\bookingemn");
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(Reservation) });
            return mq;
        }

        private static string genLineReservation(Reservation tmp)
        {
            return "client : " + tmp.idClient + ", flight :" + tmp.idFlight + ", hotel :" + tmp.idHotel + ", dateFrom :" + tmp.hotelDateFrom + ", dateTo :" + tmp.hotelDateTo;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            clearAllMessagesFromQueue();
        }

        private void clearAllMessagesFromQueue()
        {
            MessageQueue mq = getMessageQueue();
            System.Messaging.Message[] allMess = mq.GetAllMessages();
            foreach (var item in allMess)
            {
                mq.ReceiveById(item.Id);
            }
            mq.Close();
            getAllMessagesFromQueue();
        }

        private void buttonReceiveAll_Click(object sender, EventArgs e)
        {
            MessageQueue mq = getMessageQueue();
            System.Messaging.Message[] allMess = mq.GetAllMessages();

            foreach (var item in allMess)
            {
                Reservation res = (Reservation)item.Body;

                try {
                    libReservation.reservation(res.idClient, res.idFlight, res.idHotel, res.hotelDateFrom, res.hotelDateTo);
                    labelInfo.Text = "Reception OK";
                    mq.ReceiveById(item.Id);
                } catch (SqlException exc) {
                    labelInfo.Text = exc.Message;
                    Console.WriteLine("Erreur SQL : " + exc.Message);
                }
            }
            mq.Close();
            getAllMessagesFromQueue();
        }

        private void buttonReceiveOne_Click(object sender, EventArgs e)
        {
            MessageQueue mq = getMessageQueue();

            System.Messaging.Message mess = mq.Peek();
            Reservation res = (Reservation)mess.Body;

            try {
                libReservation.reservation(res.idClient, res.idFlight, res.idHotel, res.hotelDateFrom, res.hotelDateTo);
                labelInfo.Text = "Reception OK";
                mq.Receive();
            } catch (SqlException exc) {
                labelInfo.Text = exc.Message;
                Console.WriteLine("Erreur SQL : " + exc.Message);
            }

            mq.Close();
            getAllMessagesFromQueue();
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            getAllMessagesFromQueue();
        }
    }
}
