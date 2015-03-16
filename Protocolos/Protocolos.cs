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
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;


namespace Protocolos
{
    public partial class F_protocolos : Form
    {

        IList<LivePacketDevice> interfaz = LivePacketDevice.AllLocalMachine;
        IList<NetworkInterface> nint = NetworkInterface.GetAllNetworkInterfaces();
        private PacketDevice selectindex;
        Series protocolo = new Series();
        private Thread hilo;

        public F_protocolos()
        {
            InitializeComponent();
            protocolo.ChartType = SeriesChartType.Pie;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            ProgressBar.CheckForIllegalCrossThreadCalls = false;
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
            //Console.WriteLine(NetworkInterface.GetAllNetworkInterfaces());
            hilo = new Thread(HiloPrincipal);
            hilo.Start();
            
        }

        private void PacketHandler(Packet packet)
        {
                IpV4Datagram ip = packet.Ethernet.IpV4;
                UdpDatagram udp = ip.Udp;
                //Console.WriteLine("Numero de Paquetes: "+packet.Count+" Protocolos: "+ip.Protocol);
                if (!ip.Protocol.Equals("ServiceSpecificConnectionOrientedProtocolInAMultilinkAndConnectionlessEnvironment"))
                {
                    TB_datos.AppendText("Numero de Paquetes: " + packet.Count + " Protocolos: " + ip.Protocol + " Ip Origen: " + ip.Source + " Ip Destino: " + ip.Destination + "\n");
                }
        }

        //delegate void PacketHandlerDelegado(Packet packet);

        private void HiloPrincipal() {
            PB_tiempo.Style = ProgressBarStyle.Marquee;
            selectindex = interfaz[CB_Interfaz.SelectedIndex];
            using (PacketCommunicator comunicador = selectindex.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                Console.WriteLine("Capturando de: " + selectindex.Description);

                comunicador.ReceivePackets(0, PacketHandler);

            }
            
           // Protocolos.F_protocolos.
        }
    }
}
