using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;

namespace MQTT_Samuel_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.txtEventos.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
                txtEventos.AppendText(text + "\r\n");
        }

        string mensagem;
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            byte[] dado = e.Message;

            mensagem = "";

            for (int i = 0; i < dado.Length; i++)
            {
                mensagem += Convert.ToChar(dado[i]).ToString();
            }

            SetText(e.Topic + ":" + mensagem);

        }


        MqttClient cliente = null;
     

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new MqttClient("broker.hivemq.com", 1883, false, MqttSslProtocols.None, null, null);

                string clientId = Guid.NewGuid().ToString();

                cliente.Connect(clientId);

                cliente.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                // Subscribe messages
                cliente.Subscribe(new string[] { "SENAI/TOPICO_TESTE" },
                    new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                MessageBox.Show("Conectado com sucesso!", "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            cliente.Disconnect();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cliente.Publish("SENAI/TESTE", ASCIIEncoding.UTF8.GetBytes(txtenviar.Text));
        }
    }
}

    