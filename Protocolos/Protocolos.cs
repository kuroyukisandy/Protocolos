﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Net.NetworkInformation;
using System.Data;


namespace Protocolos
{
    public partial class F_protocolos : Form
    {

        IList<LivePacketDevice> interfaz = LivePacketDevice.AllLocalMachine;
        IList<NetworkInterface> nint = NetworkInterface.GetAllNetworkInterfaces();
        Hashtable htProtocolos = new Hashtable();
        DataTable dtIps = new DataTable();
        DataColumn idFuente;
        DataColumn idDestino;
        DataRow filaIp;
        private PacketDevice selectindex;
        private NetworkInterface index;
        Series protocolo = new Series();
        private Thread hilo;
        int x = 0;
        public F_protocolos()
        {
            InitializeComponent();
            protocolo.ChartType = SeriesChartType.Doughnut;
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

            idFuente = new DataColumn();
            idDestino = new DataColumn();
            idFuente.ColumnName = "Id Origen";
            idDestino.ColumnName = "Id Destino";
            dtIps.Columns.Add(idFuente);
            dtIps.Columns.Add(idDestino);

        }

        private void B_captar_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(NetworkInterface.GetAllNetworkInterfaces());
            if (CB_Interfaz.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una interfaz");
            }
            else
            {
                hilo = new Thread(HiloPrincipal);
                hilo.Start();
            }
            
        }

        private void PacketHandler(Packet packet)
        {
                IpV4Datagram ip = packet.Ethernet.IpV4;
                UdpDatagram udp = ip.Udp;
                GrafIO(packet.Count);
                //Console.WriteLine("Numero de Paquetes: "+packet.Count+" Protocolos: "+ip.Protocol);
            if(IpV4Protocol.ServiceSpecificConnectionOrientedProtocolInAMultilinkAndConnectionlessEnvironment!= ip.Protocol){
                TB_datos.AppendText("Numero de Paquetes: " + packet.Count + " Protocolos: " + ip.Protocol + " Ip Origen: " + ip.Source + " Ip Destino: " + ip.Destination +" Velocidad: " +index.Speed/1000000 +"Mbs" + "\n");
                if (!htProtocolos.ContainsKey(ip.Protocol))
                {
                    htProtocolos.Add(ip.Protocol, 1);
                }
                else
                {
                    htProtocolos[ip.Protocol] = int.Parse(htProtocolos[ip.Protocol].ToString()) + 1;
                    //Console.WriteLine(ip.Protocol+"_-_"+htProtocolos[ip.Protocol]);
                    //Console.WriteLine(htProtocolos.Keys.ToString());
                }
                   Grafprot();

                   filaIp = dtIps.NewRow();
                   filaIp["Id Origen"] = ip.Source;
                   filaIp["Id Destino"] = ip.Destination;

                   dtIps.Rows.Add(filaIp);

                   LB_flow.Items.Add(ip.Source+"------>"+ip.Destination);
            }


            //protocolo.

        }

        //delegate void PacketHandlerDelegado(Packet packet);

        private void HiloPrincipal() {
            selectindex = interfaz[CB_Interfaz.SelectedIndex];
            index=nint[CB_Interfaz.SelectedIndex];
            //PB_tiempo.Style = ProgressBarStyle.Marquee;
            Thread.Sleep(1000);
            Grafprot();
            using (PacketCommunicator comunicador = selectindex.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                Console.WriteLine("Capturando de: " + selectindex.Description);
                Console.WriteLine("Capturando de: " + index.Speed/1000000);
                comunicador.ReceivePackets(0, PacketHandler);

            }
        }

        private void GrafIO(int bytes)
        {
            if (CH_io.Series[0].Points.Count > 30)
            {
                CH_io.Series[0].Points.RemoveAt(0);
                CH_io.Update();
            }

            CH_io.Series[0].Points.AddXY(x++,bytes);
            
        }


        private void Grafprot() 
        {
           CH_protocolos.Series[0].Points.Clear();
           foreach(DictionaryEntry ht in htProtocolos)
           {
               CH_protocolos.Series[0].Points.AddXY(ht.Key.ToString(), ht.Value);
           }
        }

        private void Grafflow()
        {
            
            //agregar una label con una ip nueva
            //agregar una linea con starcap roundanchor endcap arrowanchor
        }

        private void F_protocolos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                hilo.Abort();
            }
            catch { }
            
            DialogResult salir = MessageBox.Show("Salir","Seguro desea salir",MessageBoxButtons.YesNo);
        }

 

    }
}
