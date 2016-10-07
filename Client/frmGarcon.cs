using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUDP;
using System.Reflection;

namespace Client
{
	public partial class frmGarcon : Form
	{
		private Dictionary<int, string> Cardapio;
        private UDPSocket socket;
        private frmConf configuracao;
        private string Ip;

        public frmGarcon()
		{
			InitializeComponent();
			Cardapio = new Dictionary<int, string>();
            socket = new UDPSocket();
            configuracao = new frmConf();
        }

		private void frmGarcon_Load(object sender, EventArgs e)
		{

            AdicionarItems();

        }

		private void btnAdicionar_Click(object sender, EventArgs e)
		{

			ltbPedido.Items.Add(ltbProdutos.SelectedItem);
            		
		}

		private void btnRemover_Click(object sender, EventArgs e)
		{
			ltbPedido.Items.Remove(ltbPedido.SelectedItem);

		}

        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {

            if (ConfigurarIp())
            {
                int qtdItens = ltbPedido.Items.Count;
                int numeroMesa = int.Parse(txtNumeroMesa.Text);


                byte[] pedido = new byte[2 + qtdItens];
                pedido[0] = (byte)numeroMesa;
                pedido[1] = (byte)qtdItens;

                int count = 2;
                foreach (KeyValuePair<int, string> item in ltbPedido.Items)
                {
                    pedido[count] = (byte)item.Key;
                    count++;
                }



                socket.Send(pedido, Ip, 6200);

                ltbPedido.Items.Clear();
                txtNumeroMesa.Text = string.Empty;
            }

        }


        public void AdicionarItems()
        {

            Cardapio.Add(66, "Coca-Cola");
            Cardapio.Add(37, "Bavaria");
            Cardapio.Add(12, "Arroz");
            Cardapio.Add(18, "Feijao");
            Cardapio.Add(24, "Salmão c/ Maracujá");
            Cardapio.Add(40, "Água");
            Cardapio.Add(38, "Temaki");
            Cardapio.Add(50, "Fritas");
            Cardapio.Add(125, "Feijoada");
            Cardapio.Add(255, "Tábua de Frios");
            Cardapio.Add(205, "Nacho");
            Cardapio.Add(110, "Carpaccio");
            Cardapio.Add(135, "Mousse de Maracujá");
            Cardapio.Add(92, "Bacalhau");
            Cardapio.Add(13, "Lentilha");
            Cardapio.Add(10, "Pastel");
            Cardapio.Add(63, "Onio Rings");
            Cardapio.Add(115, "Caviar");
            Cardapio.Add(32, "Macarrão ao Sugo");
            Cardapio.Add(1, "Bolo de Whey");
            Cardapio.Add(80, "Frango à tartaruga");
            Cardapio.Add(97, "Cobra");
            Cardapio.Add(17, "Rã");
            Cardapio.Add(70, "Codorna");

            ltbProdutos.Items.Add(Cardapio);
            ltbProdutos.DataSource = new BindingSource(Cardapio, null);
            ltbProdutos.DisplayMember = "Value";
            ltbProdutos.ValueMember = "Key";
        }

        private bool ConfigurarIp()
        {
            if (string.IsNullOrEmpty(configuracao.Ip))
            {
                MessageBox.Show("Configure um Ip para o servidor");

                return false;
            }
            else
            {
                Ip = configuracao.Ip;

                return true;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Termina o servidor quando fechar a janela
            socket.Close();
            socket.Dispose();
        }

        private void tsiConfiguararIPDoServidor_Click(object sender, EventArgs e)
        {
            configuracao = new frmConf();
            configuracao.Show();
          
        }
    }
}
