using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KohtunikuPult
{
    using System.IO.Ports;
    using System.Windows.Forms.VisualStyles;

    public partial class Form1 : Form
    {

        private SerialPort dongle;

        private List<KeyValuePair<string, string>> comPair;

        private int counter;

        private class Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                this.Name = name;
                this.Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return this.Name;
            }
        }

        public Form1()
        {
            this.comPair = new List<KeyValuePair<string, string>>();
            string[] serialList = SerialPort.GetPortNames();
            this.InitializeComponent();
            var comports = COMPortInfo.GetCOMPortsInfo();
            counter = 1;

            for (int i = 0; i < serialList.Length; i++)
            {
                comPort.Items.Add(new Item(serialList[i], i));
            }

            string[] fields = { "A", "B", "X" };
            string[] robots = { "All", "A", "B", "C", "D" };
            string[] teams = { "A", "B" };

            for (int i = 0; i < fields.Length; i++)
            {
                fieldComboBox.Items.Add(new Item(fields[i], i));
            }

            for (int i = 0; i < robots.Length; i++)
            {
                teamComboBox.Items.Add(new Item(robots[i], i));
            }

            setAckRed();
        }

        private void comPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dongle.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Item port = (Item)comPort.SelectedItem;
            dongle = new SerialPort(port.Name);

            try
            {
                dongle.Open();
                dongle.DataReceived += new SerialDataReceivedEventHandler(this.DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string data = dataTextBox.Text;
            dongle.Write(data);
            setAckRed();
        }

        void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int dataLength = dongle.BytesToRead;
            byte[] data = new byte[dataLength];
            int nbrDataRead = dongle.Read(data, 0, dataLength);
            if (nbrDataRead == 0)
                return;
            string dataReceived = System.Text.Encoding.Default.GetString(data);
            AppendTextBox(dataReceived);

            Item field = (Item)this.fieldComboBox.SelectedItem;
            if (dataReceived[0] == 'a' && dataReceived[1] == field.Name[0] && dataReceived.Substring(3,3).CompareTo("ACK") == 0)
            {
                switch (dataReceived[2])
                {
                    case 'A':
                        robotA.BackColor = Color.DarkSeaGreen;
                        break;
                    case 'B':
                        robotB.BackColor = Color.DarkSeaGreen;
                        break;
                    case 'C':
                        robotC.BackColor = Color.DarkSeaGreen;
                        break;
                    case 'D':
                        robotD.BackColor = Color.DarkSeaGreen;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item field = (Item)this.fieldComboBox.SelectedItem;
            Item robot = (Item)this.teamComboBox.SelectedItem;

            try
            {
                string f = field.Name;
                string r = robot.Name == "All" ? "X" : robot.Name;
                string data = "a" + f + r + "START----";

                //start button click
                //string data = "aAXSTART----";
                dongle.Write(data);
                setAckRed();
            }
            catch (Exception)
            {
                MessageBox.Show("You must select a valid COM port, field and robot");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item field = (Item)this.fieldComboBox.SelectedItem;
            Item robot = (Item)this.teamComboBox.SelectedItem;

            try
            {
                string f = field.Name;
                string r = robot.Name == "All" ? "X" : robot.Name;
                string data = "a" + f + r + "STOP-----";

                //stop button click
                //string data = "aAXSTOP-----";
                dongle.Write(data);
                setAckRed();
            }
            catch (Exception)
            {
                MessageBox.Show("You must select a valid COM port, field and robot");
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }

            dataTextBox.AppendText(counter + ": " + value);
            dataTextBox.Text += "\n";
            dataTextBox.SelectionStart = dataTextBox.TextLength;
            dataTextBox.ScrollToCaret();
            counter++;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            counter = 1;
            setAckRed();
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            Item field = (Item)this.fieldComboBox.SelectedItem;
            //Item robot = (Item)this.teamComboBox.SelectedItem;

            try
            {
                string[] robots =
                {
                    "A",
                    "B",
                    "C",
                    "D"
                };

                foreach (var robot in robots)
                {
                    string f = field.Name;
                    string data = "a" + f + robot + "PING-----";
                    dongle.Write(data);
                    setAckRed();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must select a valid COM port, field and robot");
            }
        }

        private void setAckRed()
        {
            robotA.BackColor = Color.Salmon;
            robotB.BackColor = Color.Salmon;
            robotC.BackColor = Color.Salmon;
            robotD.BackColor = Color.Salmon;
        }
    }
}
