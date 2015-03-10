using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Core.Extensions;
using PcapDotNet.Base;

namespace Protocolos
{
    public partial class F_protocolos : Form
    {

        IList<LivePacketDevice> interfaz = LivePacketDevice.AllLocalMachine;

        public F_protocolos()
        {
            InitializeComponent();
        }


        private void F_protocolos_Load(object sender, EventArgs e)
        {
            if (interfaz.Count == 0)
            {
                MessageBox.Show("No hay interfaces para mostrar");
                return;
            }

            for (int i = 0; i != interfaz.Count; i++)
            {
                LivePacketDevice inter = interfaz[i];
                CB_Interfaz.Items.Add(inter.Description);
            }

        }

        private void B_captar_Click(object sender, EventArgs e)
        {
            PacketDevice selectindex = interfaz[CB_Interfaz.SelectedIndex];
            using (PacketCommunicator comunicador = selectindex.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000)) 
            {
                Console.WriteLine("Capturando de: "+ selectindex.Description);

                comunicador.ReceivePackets(0, PacketHandler);
            }
            
        }

        private static void PacketHandler(Packet packet)
        {
           // Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " length:" + packet.Length);
            IpV4Datagram ip = packet.Ethernet.IpV4;
            UdpDatagram udp = ip.Udp;
            Console.WriteLine("Numero de Paquetes: "+packet.Count+" Protocolos: "+ip.Protocol);
            
        }
    }
}
