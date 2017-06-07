using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_2

{

    public partial class Form1 : Form
    {
        int J_voto = 0, C_voto = 0, M_voto = 0, F_voto = 0, nb_voto = 0;
        int min = 0, hora = 0, seg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voto Computado");

            nb_voto += 1;

            bnresult.Text = Convert.ToString(nb_voto);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void Cresult_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
              if (textBox1.Text == "45")
            {

                pictureBox2.Image = Properties.Resources.joaodoria;
                textBox2.Text = "45";
                lblNcandidato.Text = "João Doria";
                label9.Visible = true;
                label8.Visible = true;
                textBox2.Visible = true;
                lblpartido.Visible = true;
                lblNcandidato.Visible = true;
                lblpartido.Visible = true;
                label10.Visible = true;
                lblpartido.Text = "PSDB";
            }

            else if (textBox1.Text == "13")
            {
                pictureBox2.Image = Properties.Resources.haddad_entrevista_epoca;
                textBox2.Text = "13";
                textBox2.Visible = true;
                lblNcandidato.Visible = true;
                label8.Visible = true;
                lblpartido.Visible = true;
                lblpartido.Visible = true;
                label10.Visible = true;
                lblNcandidato.Text = "Fernando Haddad";
                label9.Visible = true;
                lblpartido.Text = "PT";

            }

            else if (textBox1.Text == "10")
            {
                lblNcandidato.Text = "Celso Russomano";
                label9.Visible = true;
                textBox2.Visible = true;
                lblNcandidato.Visible = true;
                label8.Visible = true;
                lblpartido.Visible = true;
                lblpartido.Visible = true;
                label10.Visible = true;
                pictureBox2.Image = Properties.Resources.photo;
                textBox2.Text = "10";
                lblpartido.Text = "PRB";
            }
            else if (textBox1.Text == "15")
            {
                lblNcandidato.Text = "Marta Suplicy";
                label9.Visible = true;
                textBox2.Visible = true;
                lblNcandidato.Visible = true;
                label8.Visible = true;
                lblpartido.Visible = true;
                lblpartido.Visible = true;
                label10.Visible = true;
                textBox2.Text = "15";
                lblpartido.Text = "PMDB";
                pictureBox2.Image = Properties.Resources.marta_suplicy_FELIPE_RAU_ESTADaO;

            }

        


        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.images;
            MessageBox.Show("Digite corretamente os números do Candidato");
            lblNcandidato.Text = "";
            lblpartido.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "45")
            {
                J_voto += 1;

                Jresult.Text = Convert.ToString(J_voto);

            }

            else if (textBox1.Text == "10")

            {
                C_voto += 1;
                Cresult.Text = Convert.ToString(C_voto);

            }

            else if (textBox1.Text == "13")
            {
                F_voto += 1;
                Fresult.Text = Convert.ToString(F_voto);


            }

            else if (textBox1.Text == "15")
            {
                M_voto += 1;
                Mresult.Text = Convert.ToString(M_voto);

            }

            else if (textBox1.Text != "45" || textBox1.Text != "10" || textBox1.Text != "13" || textBox1.Text != "15")
                {
           

                nb_voto += 1;

                bnresult.Text = Convert.ToString(nb_voto);


                }


            string caminhoaudio = @"C:\Users\Felipe\Desktop\exercicio 2 - v2\Urna.wav";
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(caminhoaudio);
            s.PlaySync();
            s.Stop();
            //MessageBox.Show("Voto Computado");
            textBox2.Clear();
            textBox1.Clear();
            pictureBox2.Image = Properties.Resources.images;
            lblpartido.Text = "";
            lblNcandidato.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }

            else if (min == 60)
            {
                hora++;
                min = 0;
            }

            lbltempo.Text = hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');

            if (lbltempo.Text == "00:00:20")
            {
                groupBox1.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Votação Encerrada");
                lbltempo.Text = "00:00:00";
                button22.Enabled = false;
                //Application.Restart();
                
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void lbltempo_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }
    }
}
