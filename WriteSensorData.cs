using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace OPCUAWriteData
{
    public class WriteSensorData
    {
        public void WriteTags_S1(OpcClient client, ref string strS1Name, ref string strS1Status, ref string strS1Val)
        {
            string strTagName = "ns=3;s=Sensor1/Name";
            string strName = strS1Name;
            client.WriteNode(strTagName, strName);

            strTagName = "ns=3;s=Sensor1/Status";
            bool bStt = Convert.ToBoolean(strS1Status);
            client.WriteNode(strTagName, bStt);

            strTagName = "ns=3;s=Sensor1/MeasValue";
            double dVal = Convert.ToDouble(strS1Val);
            client.WriteNode(strTagName, dVal);
        }

        public void WriteTags_S2(OpcClient client, ref string strS2Name, ref string strS2Status, ref string strS2Val)
        {
            string strTagName = "ns=3;s=Sensor2/Name";
            string strName = strS2Name;
            client.WriteNode(strTagName, strName);

            strTagName = "ns=3;s=Sensor2/Status";
            bool bStt = Convert.ToBoolean(strS2Status);
            client.WriteNode(strTagName, bStt);

            strTagName = "ns=3;s=Sensor2/MeasValue";
            double dVal = Convert.ToDouble(strS2Val);
            client.WriteNode(strTagName, dVal);
        }
    }
}
