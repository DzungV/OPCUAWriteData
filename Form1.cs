using Opc.UaFx.Client;

namespace OPCUAWriteData
{
    public partial class Form1 : Form
    {
        OpcClient client = new OpcClient("opc.tcp://localhost:4840/"); // ip address depends on the address of the server 

        string strName;
        string strPosition;
        string strMode;
        string strStatus;
        string strTemperature;
        string strValue;
        WriteMotorData writeMotor = new WriteMotorData();
        WriteRobotData writeRobot = new WriteRobotData();
        WriteSensorData writeSensor = new WriteSensorData();

        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime sensorDateTime = DateTime.Now;
            txtTimeStamp.Text = sensorDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                UpdateTimer.Start();
                lbStatusMsg.Text = "Logging Started and Connected to OPC Server";
                txtServerAddr.Text = "opc.tcp://localhost:4840/";
            }
            catch (Exception ex)
            {
                lbStatusMsg.Text = "Server is not open!!!";
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            if (client != null)
            {
                client.Disconnect();
                lbStatusMsg.Text = "Logging Stopped and Disconnected from OPC Server";
            }
            else
                lbStatusMsg.Text = "Client hasn't connected to Server";
        }

        private void btnChangeM1_Click(object sender, EventArgs e)
        {
            try
            {
                OPCUAWriteMotor1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No input data enough!!!");
            }
        }

        private void btnChangeM2_Click(object sender, EventArgs e)
        {
            try
            {
                OPCUAWriteMotor2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No input data enough!!!");
            }
        }

        private void btnChangeS1_Click(object sender, EventArgs e)
        {
            try
            {
                OPCUAWriteSensor1();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No input data enough!!!");
            }
        }

        private void btnChangeS2_Click(object sender, EventArgs e)
        {
            try
            {
                OPCUAWriteSensor2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No input data enough!!!");
            }
        }

        private void btnChangeR1_Click(object sender, EventArgs e)
        {
            try
            {
                OPCUAWriteRobot1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No input data enough!!!");
            }
        }

        private void btnChangeR2_Click(object sender, EventArgs e)
        {
            try
            {
                OPCUAWriteRobot2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No input data enough!!!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
                client.Disconnect();
        }

        public void OPCUAWriteMotor1()
        {
            strName = txtM1Name.Text;
            strPosition = txtM1Position.Text;
            strMode = txtM1Mode.Text;
            strStatus = txtM1Status.Text;
            strTemperature = txtM1Temp.Text;
            writeMotor.WriteTags_M1(client, ref strName, ref strPosition, ref strMode, ref strStatus, ref strTemperature);
        }
        public void OPCUAWriteMotor2()
        {
            strName = txtM2Name.Text;
            strPosition = txtM2Position.Text;
            strMode = txtM2Mode.Text;
            strStatus = txtM2Status.Text;
            strTemperature = txtM2Temp.Text;
            writeMotor.WriteTags_M2(client, ref strName, ref strPosition, ref strMode, ref strStatus, ref strTemperature);
        }
        public void OPCUAWriteRobot1()
        {
            strName = txtRB1Name.Text;
            strPosition = txtRB1Position.Text;
            strMode = txtRB1Mode.Text;
            strStatus = txtRB1Status.Text;
            strTemperature = txtRB1Temp.Text;
            writeRobot.WriteTags_R1(client, ref strName, ref strPosition, ref strMode, ref strStatus, ref strTemperature);
        }
        public void OPCUAWriteRobot2()
        {
            strName = txtRB2Name.Text;
            strPosition = txtRB2Position.Text;
            strMode = txtRB2Mode.Text;
            strStatus = txtRB2Status.Text;
            strTemperature = txtRB2Temp.Text;
            writeRobot.WriteTags_R2(client, ref strName, ref strPosition, ref strMode, ref strStatus, ref strTemperature);
        }
        public void OPCUAWriteSensor1()
        {
            strName = txtS1Name.Text;
            strStatus = txtS1Status.Text;
            strValue = txtS1Value.Text;
            writeSensor.WriteTags_S1(client, ref strName, ref strStatus, ref strValue);
        }
        public void OPCUAWriteSensor2()
        {
            strName = txtS2Name.Text;
            strStatus = txtS2Status.Text;
            strValue = txtS2Value.Text;
            writeSensor.WriteTags_S2(client, ref strName, ref strStatus, ref strValue);
        }

       
    }
}