using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace JogoCassino
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Numerador.Visible = false;
            btnComprar.Visible = false;
            int giros = 0;
            btn_totalGiros.Text = giros.ToString();
            IniciarImage();
        }

        public void IniciarImage()
        {

            try
            {
                string img_one = Environment.CurrentDirectory + @"\Img\Diamante.png";
                string img_two = Environment.CurrentDirectory + @"\Img\Coroa.png";
                string img_tree = Environment.CurrentDirectory + @"\Img\Money.png";

                imgOne.Image = Image.FromFile(img_one);
                ImgTwo.Image = Image.FromFile(img_two);
                ImgTree.Image = Image.FromFile(img_tree);

            }
            catch (Exception ex)
            {
                MsgInfo.Show("Erro ao carregar as imagens principal, verifique!", "Aviso\n" + ex.Message);
            }
        }

        public void Jogar()
        {
            SorteaImagens();
        }

        public void SorteaImagens()
        {
            string[] img = new string[]
            {
                Environment.CurrentDirectory + @"\Img\Bar.png",
                Environment.CurrentDirectory + @"\Img\Money.png",
                Environment.CurrentDirectory + @"\Img\Diamante.png",
                Environment.CurrentDirectory + @"\Img\Coroa.png",
                Environment.CurrentDirectory + @"\Img\Coin.png",
                Environment.CurrentDirectory + @"\Img\Uva.png",
                Environment.CurrentDirectory + @"\Img\trevo.png",
                Environment.CurrentDirectory + @"\Img\Sete.png"
            };

            //Realizando os sorteios dos numeros para carregar as imagens
            //-----------------------------------------------------------
            //1° Sorteio
            string sorteioO = img[new Random().Next(8)];
            imgOne.Image = Image.FromFile(sorteioO);

            Thread.Sleep(400);

            //2° Sorteio
            string sorteioU = img[new Random().Next(8)];
            ImgTwo.Image = Image.FromFile(sorteioU);

            Thread.Sleep(400);

            //3° Sorteio
            string sorteioTr = img[new Random().Next(8)];
            ImgTree.Image = Image.FromFile(sorteioTr);

            /* Verificar o numero de processadores que contem na maquina
             *   int cpu = Environment.ProcessorCount;
             *   MessageBox.Show($"Você tem {cpu} cpu em sua maquina...");
            */
        }


        public void ComprarGiros()
        {
            MessageBox.Show("Selecione a quantidade de Giros que deseja comprar , 50 no Máximo.");
            Numerador.Visible = true;
            btnComprar.Visible = true;
            guna2Button1.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //verificando se existe rodadas disponivél
            int newValue;
            int totalGiros = Convert.ToInt16(btn_totalGiros.Text);
            if (totalGiros <= 0)
            {
                MessageBox.Show("Não existe giros disponivel...");
                return;
            }
            else
            {
                Jogar();
                newValue = totalGiros - 1;
                btn_totalGiros.Text = newValue.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ComprarGiros();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int newGiros = Convert.ToInt16(btn_totalGiros.Text);
            int totalGiros = (int)Numerador.Value;

            if (totalGiros > 0)
            {
                newGiros += totalGiros;
                btn_totalGiros.Text = newGiros.ToString();
                guna2Button1.Enabled = true;
                Numerador.Visible = false;
                btnComprar.Visible = false;
            }
            else
            {
                MessageBox.Show("Você não comprou Giros");
            }
        }
    }
}
