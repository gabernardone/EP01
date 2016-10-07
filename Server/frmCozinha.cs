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

namespace Server
{
    public partial class frmCozinha : Form
    {
        private Dictionary<int, string> Cardapio;
        private UDPSocket socket;
        private frmBalcao balcao;

        public frmCozinha()
        {
            InitializeComponent();
            Cardapio = new Dictionary<int, string>();

            socket = new UDPSocket(PedidoRecebido, 6200);
            balcao = new frmBalcao();

            balcao.Show();

        }

        private void frmCozinha_Load(object sender, EventArgs e)
        {
            AdicionarItems();
        }


        private void PedidoRecebido(byte[] buffer, int size, string ip, int port)
        {
            // Converte o array de bytes para uma string, utilizando
            // a codificação UTF-8

            int numeroMesa = buffer[0];
            int qtdItems = buffer[1];

   

            for (int i = 2; i < size; i++)
            {
                if(Cardapio.ContainsKey(buffer[i]))
                {
                    listBox1.Items.Add(string.Format("Nº Mesa: {0}. Qntd de items do pedido:{1}. ITEM: {2}", numeroMesa.ToString(), qtdItems.ToString(), Cardapio[buffer[i]]));
                }
                else
                {
                    listBox1.Items.Add("Item não encontrado no cardápio da cozinha");
                }
                
            }

            listBox1.Items.Add(string.Format("--------------------------------------------------------------------"));
            listBox1.Items.Add(string.Format(""));

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

        }

        private void brnEnviarBalcao_Click(object sender, EventArgs e)
        {
            balcao.ltbBalcao.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);    
        }
    }
}
