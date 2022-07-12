using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace OPCUAWriteData
{
    public class WriteMotorData
    {
        public void WriteTags_M1(OpcClient client, ref string strM1Name, ref string strM1Position, ref string strM1Mode, ref string strM1Status, ref string strM1Temp)
        {
            //Motor1
            string strTagName = "ns=2;s=Motor1/Name";
            string strName = strM1Name;
            client.WriteNode(strTagName, strName);

            strTagName = "ns=2;s=Motor1/Position";
            double dPos = Convert.ToDouble(strM1Position);
            client.WriteNode(strTagName, dPos);

            strTagName = "ns=2;s=Motor1/Status";
            bool bStt = Convert.ToBoolean(strM1Status);
            client.WriteNode(strTagName, bStt);

            strTagName = "ns=2;s=Motor1/Mode";
            int nMode = Convert.ToInt32(strM1Mode);
            client.WriteNode(strTagName, nMode);

            strTagName = "ns=2;s=Motor1/Temperature";
            double dTemp = Convert.ToDouble(strM1Temp);
            client.WriteNode(strTagName, dTemp);

        }

        public void WriteTags_M2(OpcClient client, ref string strM2Name, ref string strM2Position, ref string strM2Mode, ref string strM2Status, ref string strM2Temp)
        {
            //Motor2
            string strTagName = "ns=2;s=Motor2/Name";
            string strName = strM2Name;
            client.WriteNode(strTagName, strName);

            strTagName = "ns=2;s=Motor2/Position";
            double dPos = Convert.ToDouble(strM2Position);
            client.WriteNode(strTagName, dPos);

            strTagName = "ns=2;s=Motor2/Status";
            bool bStt = Convert.ToBoolean(strM2Status);
            client.WriteNode(strTagName, bStt);

            strTagName = "ns=2;s=Motor2/Mode";
            int nMode = Convert.ToInt32(strM2Mode);
            client.WriteNode(strTagName, nMode);

            strTagName = "ns=2;s=Motor2/Temperature";
            double dTemp = Convert.ToDouble(strM2Temp);
            client.WriteNode(strTagName, dTemp);

        }
    }
}
