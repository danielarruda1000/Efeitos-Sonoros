using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efeitos_Sonos_Teatro_MDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound =new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Porta\Campainha.wav");
            simpleSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Audios\Vazio.wav");
            simpleSound.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\Tiro1.wav");
            simpleSound.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\Policia.wav");
            simpleSound.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Celular\Mensagem.wav");
            simpleSound.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Celular\ToqueIphone.wav");
            simpleSound.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\PuxandoTrava.wav");
            simpleSound.Play();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\TiroFalho.wav");
            simpleSound.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Porta\CampainhaPorta.wav");
            simpleSound.Play();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Porta\BatendoFraco.wav");
            simpleSound.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\Ventania.wav");
            simpleSound.Play();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\carroLigando.wav");
            simpleSound.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\Pronto\Desktop\diversos\teatro\Efeitos Sonoros MDV\WindowsFormsApp1\BancoDeDados\Audios\Diversos\buzina.wav");
            simpleSound.Play();
        }
    }
}
