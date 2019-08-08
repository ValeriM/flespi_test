using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace flespi_test
{
    public partial class Form1 : Form
    {
        MqttClient client;
        string clientId;
        static readonly string token = "Vo6wSNjDEM19qzUdq9qbwZugZPmPl3N4hHq0lAtPalMqIwuYuKZQxiUnX7060B17";

        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "test.mosquitto.org";
            BrokerAddress = "mqtt.flespi.io";
            client = new MqttClient(BrokerAddress);

            // register a callback-function (we have to implement, see below) which is called by the library when a message was received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            // use a unique id as client id, each time we start the application
            clientId = Guid.NewGuid().ToString();

            client.Connect(clientId, token, "");

            Text = client.IsConnected ? "Connected" : "Хуй там";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.IsConnected)
                client.Disconnect();

            base.OnClosed(e);
            //App.Current.Shutdown();
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtTopicSubscribe.Text != "")
            {
                // whole topic
                string Topic = txtTopicSubscribe.Text;

                // subscribe to the topic with QoS 2
                ushort code = client.Subscribe(new string[] { Topic }, new byte[] { 2 });   // we need arrays as parameters because we can subscribe to different topics with one call
                txtReceived.Text = code.ToString();
            }
            else
            {
                MessageBox.Show("You have to enter a topic to subscribe!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtTopicPublish.Text != "")
            {
                // whole topic
                string Topic = txtTopicPublish.Text;

                // publish a message with QoS 2
                ushort code = client.Publish(Topic, Encoding.UTF8.GetBytes(txtTopicPublish.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                txtReceived.Text = code.ToString();
            }
            else
            {
                MessageBox.Show("You have to enter a topic to publish!");
            }
        }
        // this code runs when a message was received
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            MessageBox.Show(ReceivedMessage);

            //Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
            //    txtReceived.Text = ReceivedMessage;
            //});
        }
    }
}
