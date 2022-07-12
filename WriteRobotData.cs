using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace OPCUAWriteData
{
    public class WriteRobotData
    {
        public void WriteTags_R1(OpcClient client, ref string strR1Name, ref string strR1Position, ref string strR1Mode, ref string strR1Status, ref string strR1Temp)
        {
            //Motor1
            string strTagName = "ns=4;s=Robot1/Name";
            string strName = strR1Name;
            client.WriteNode(strTagName, strName);

            strTagName = "ns=4;s=Robot1/Position";
            double dPos = Convert.ToDouble(strR1Position);
            client.WriteNode(strTagName, dPos);

            strTagName = "ns=4;s=Robot1/Status";
            bool bStt = Convert.ToBoolean(strR1Status);
            client.WriteNode(strTagName, bStt);

            strTagName = "ns=4;s=Robot1/Mode";
            int nMode = Convert.ToInt32(strR1Mode);
            client.WriteNode(strTagName, nMode);

            strTagName = "ns=4;s=Robot1/Temperature";
            double dTemp = Convert.ToDouble(strR1Temp);
            client.WriteNode(strTagName, dTemp);

        }

        public void WriteTags_R2(OpcClient client, ref string strR2Name, ref string strR2Position, ref string strR2Mode, ref string strR2Status, ref string strR2Temp)
        {
            //Motor2
            string strTagName = "ns=4;s=Robot2/Name";
            string strName = strR2Name;
            client.WriteNode(strTagName, strName);

            strTagName = "ns=4;s=Robot2/Position";
            double dPos = Convert.ToDouble(strR2Position);
            client.WriteNode(strTagName, dPos);

            strTagName = "ns=4;s=Robot2/Status";
            bool bStt = Convert.ToBoolean(strR2Status);
            client.WriteNode(strTagName, bStt);

            strTagName = "ns=4;s=Robot2/Mode";
            int nMode = Convert.ToInt32(strR2Mode);
            client.WriteNode(strTagName, nMode);

            strTagName = "ns=4;s=Robot2/Temperature";
            double dTemp = Convert.ToDouble(strR2Temp);
            client.WriteNode(strTagName, dTemp);

        }
    }
}
