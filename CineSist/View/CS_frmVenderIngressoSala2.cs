using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineSist
{
    public partial class CS_frmVenderIngressoSala2 : Form
    {

        //criação de instância para usar o formulário CS_frmVendaIngresso
        private static CS_frmVenderIngressoSala2 frmVendaIngresso2 = null;
        public CS_frmVenderIngresso frmVenda;
        int poltrona = 0;
        public CS_frmVenderIngressoSala2(CS_frmVenderIngresso frmV)
        {
            InitializeComponent();
            frmVenda = frmV;
            lblTipoIngresso.Text = frmVenda.txtIdSessao.Text;
        }

        public void recebeValor()
        {
            CS_frmVenderIngresso frmVenderIngresso = new CS_frmVenderIngresso();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
       /* public static CS_frmVenderIngressoSala2 getInstance()
        {
            if (frmVendaIngresso2 == null)
            {
                frmVendaIngresso2 = new CS_frmVenderIngressoSala2();
            }
            return (frmVendaIngresso2);
        }*/

        private void pbxPoltrona01_Click(object sender, EventArgs e)
        {
            pbxPoltrona01.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona01_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona01.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 1;
        }

        private void pbxPoltrona02_Click(object sender, EventArgs e)
        {
            pbxPoltrona02.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona02_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona02.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 2;
        }

        private void pbxPoltrona03_Click(object sender, EventArgs e)
        {
            pbxPoltrona03.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona03_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona03.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 3;
        }

        private void pbxPoltrona04_Click(object sender, EventArgs e)
        {
            pbxPoltrona04.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona04_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona04.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 4;
        }

        private void pbxPoltrona05_Click(object sender, EventArgs e)
        {
            pbxPoltrona05.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona05_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona05.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 5;
        }

        private void pbxPoltrona06_Click(object sender, EventArgs e)
        {
            pbxPoltrona06.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona06_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona06.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 6;
        }

        private void pbxPoltrona07_Click(object sender, EventArgs e)
        {
            pbxPoltrona07.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona07_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona07.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 7;
        }

        private void pbxPoltrona08_Click(object sender, EventArgs e)
        {
            pbxPoltrona08.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona08_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona08.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 8;
        }

        private void pbxPoltrona09_Click(object sender, EventArgs e)
        {
            pbxPoltrona09.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona09_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona09.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 9;
        }

        private void pbxPoltrona10_Click(object sender, EventArgs e)
        {
            pbxPoltrona10.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona10_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona10.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 10;
        }

        private void pbxPoltrona11_Click(object sender, EventArgs e)
        {
            pbxPoltrona11.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona11_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona11.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 11;
        }

        private void pbxPoltrona12_Click(object sender, EventArgs e)
        {
            pbxPoltrona12.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona12_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona12.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 12;
        }

        private void pbxPoltrona13_Click(object sender, EventArgs e)
        {
            pbxPoltrona13.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona13_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona13.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 13;
        }

        private void pbxPoltrona14_Click(object sender, EventArgs e)
        {
            pbxPoltrona14.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona14_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona14.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 14;
        }

        private void pbxPoltrona15_Click(object sender, EventArgs e)
        {
            pbxPoltrona15.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona15_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona15.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 15;
        }

        private void pbxPoltrona16_Click(object sender, EventArgs e)
        {
            pbxPoltrona16.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona16_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona16.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 16;
        }

        private void pbxPoltrona17_Click(object sender, EventArgs e)
        {
            pbxPoltrona17.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona17_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona17.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 17;
        }

        private void pbxPoltrona18_Click(object sender, EventArgs e)
        {
            pbxPoltrona18.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona18_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona18.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 18;
        }

        private void pbxPoltrona19_Click(object sender, EventArgs e)
        {
            pbxPoltrona19.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona19_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona19.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 19;
        }

        private void pbxPoltrona20_Click(object sender, EventArgs e)
        {
            pbxPoltrona20.Image = Image.FromFile("../../Imagens/p1.png");
        }

        private void pbxPoltrona20_DoubleClick(object sender, EventArgs e)
        {
            pbxPoltrona20.Image = Image.FromFile("../../Imagens/p2.png");
            poltrona = 20;
        }

        private void fechandoForm(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            frmVendaIngresso2 = null;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            

        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {

            try
            {
                CS_clsIngresso mObjIngresso = new CS_clsIngresso();

                mObjIngresso = mObjIngresso.exibirDados(poltrona);

                if(mObjIngresso != null)
                {
                    MessageBox.Show("Esse ingresso ja esta reservado");
                }

                else
                {
                    CS_clsIngresso mObjIngresso2 = new CS_clsIngresso();
                    mObjIngresso2.Id_Ingresso = mObjIngresso2.autoIncremento();
                    mObjIngresso2.NM_Tipo = cmbTipo.Text;
                    mObjIngresso2.Id_Poltrona = poltrona;
                    mObjIngresso2.Id_Sessao = Convert.ToInt32(lblTipoIngresso.Text);

                    float preco = 0;
                    if (cmbTipo.Text == "INTEIRA")
                    {
                        preco = mObjIngresso2.pegaPrecoInteira(Convert.ToInt32(lblTipoIngresso.Text));
                    }
                    else if (cmbTipo.Text == "MEIA")
                    {
                        preco = mObjIngresso2.pegaPrecoMeia(Convert.ToInt32(lblTipoIngresso.Text));
                    }



                     string mErro = mObjIngresso2.inserirIngresso();

                     if (mErro == null)
                         {
                              MessageBox.Show("Valor do ingresso RS"+preco);
                              CS_frmSplashVender frmSplashVender = new CS_frmSplashVender();
                              frmSplashVender.Show();
                         }
                    else
                        {
                            MessageBox.Show(mErro);
                        }
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro catastrofico 11 " + ex.Message);
            }
            finally
            {
                CS_frmVenderIngresso venderIngresso = CS_frmVenderIngresso.getInstance();
                venderIngresso.Show();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
