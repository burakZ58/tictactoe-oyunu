using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<int> aktifBtnX = new List<int>();
        List<int> aktifBtnO = new List<int>();
        bool oxoBtn = true;
        int sayi;
        int a = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Oyuna X kişisi başlar sonra O kişisi devam eder bu sıra böyle devam eder");
        }

        // yapay zeka ekleyecegiz ve egerki xoxBtn(2) aktif ise 3 ve 4. butonlara basıp bozmaya calısacak xoxBtn(3,4) aktif ise 4 5. butonlara basıp bozmaya calısacak

        private void Kontrol()
        {
            if (aktifBtnX.Contains(1) && aktifBtnX.Contains(2) && aktifBtnX.Contains(3) ||
            aktifBtnX.Contains(4) && aktifBtnX.Contains(5) && aktifBtnX.Contains(6) ||
            aktifBtnX.Contains(7) && aktifBtnX.Contains(8) && aktifBtnX.Contains(9) ||
            aktifBtnX.Contains(1) && aktifBtnX.Contains(4) && aktifBtnX.Contains(7) ||
            aktifBtnX.Contains(2) && aktifBtnX.Contains(5) && aktifBtnX.Contains(8) ||
            aktifBtnX.Contains(3) && aktifBtnX.Contains(6) && aktifBtnX.Contains(9) ||
            aktifBtnX.Contains(1) && aktifBtnX.Contains(5) && aktifBtnX.Contains(9) ||
            aktifBtnX.Contains(3) && aktifBtnX.Contains(5) && aktifBtnX.Contains(7))
            {
                aktifBtnX.Clear(); aktifBtnO.Clear();
                MessageBox.Show("X kişisi kazandı");
                while (a < 9) 
                {
                    a++;
                    this.Controls[$"button{a}"].Text = ""; 
                }
                a = 0;
            }
            else if (aktifBtnO.Contains(1) && aktifBtnO.Contains(2) && aktifBtnO.Contains(3) ||
                aktifBtnO.Contains(4) && aktifBtnO.Contains(5) && aktifBtnO.Contains(6) ||
                aktifBtnO.Contains(7) && aktifBtnO.Contains(8) && aktifBtnO.Contains(9) ||
                aktifBtnO.Contains(1) && aktifBtnO.Contains(4) && aktifBtnO.Contains(7) ||
                aktifBtnO.Contains(2) && aktifBtnO.Contains(5) && aktifBtnO.Contains(8) ||
                aktifBtnO.Contains(3) && aktifBtnO.Contains(6) && aktifBtnO.Contains(9) ||
                aktifBtnO.Contains(1) && aktifBtnO.Contains(5) && aktifBtnO.Contains(9) ||
                aktifBtnO.Contains(3) && aktifBtnO.Contains(5) && aktifBtnO.Contains(7))
            {
                aktifBtnX.Clear(); aktifBtnO.Clear();
                MessageBox.Show("O kişisi kazandı");
                while (a < 9)
                {
                    a++;
                    this.Controls[$"button{a}"].Text = "";
                }
                a = 0;
            }
            else if (aktifBtnX.Count + aktifBtnO.Count == 9)
            {
                aktifBtnX.Clear(); aktifBtnO.Clear();
                MessageBox.Show("Kazanan çıkmadı oyun baştan başlatılıyor");
                while (a < 9)
                {
                    a++;
                    this.Controls[$"button{a}"].Text = "";
                }
                a = 0;
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = 1;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else 
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = 2;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi = 3;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi = 4;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi = 5;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayi = 6;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayi = 7;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi = 8;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayi = 9;
            if (aktifBtnX.Contains(sayi) || aktifBtnO.Contains(sayi)) { }
            else
            {
                if (oxoBtn) { this.Controls[$"button{sayi}"].Text = "X"; aktifBtnX.Add(sayi); oxoBtn = false; }
                else { this.Controls[$"button{sayi}"].Text = "O"; aktifBtnO.Add(sayi); oxoBtn = true; }
                Kontrol();
            }
        }


    }
}
