using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caculator
{
    
    public partial class Form1 : Form
    {
        double number1, number2;
        int dau = 0;
        bool haveM = false;
        double M;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void phim1_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "1";
            else ketqua.Text += "1";
        }

        private void phim2_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "2";
            else ketqua.Text += "2";
        }

        private void phim0_Click(object sender, EventArgs e)
        {
            if (ketqua.Text != "0") ketqua.Text += "0";
        }

        private void phim3_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "3";
            else ketqua.Text += "3";
        }

        private void phim4_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "4";
            else ketqua.Text += "4";
        }

        private void phim5_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "5";
            else ketqua.Text += "5";
        }

        private void phim6_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "6";
            else ketqua.Text += "6";
        }

        private void phim7_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "7";
            else ketqua.Text += "7";
        }

        private void phim8_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "8";
            else ketqua.Text += "8";
        }

        private void phim9_Click(object sender, EventArgs e)
        {
            if (ketqua.Text == "0")
                ketqua.Text = "9";
            else ketqua.Text += "9";
        }

        private void dauBang_Click(object sender, EventArgs e)
        {
            string tmp = "";
            bool flag = false;
            for (int i = 0; i < ketqua.Text.Length; i++)
            {
                if (ketqua.Text[i] == '+' || (ketqua.Text[i] == '-' && dau == 2) || ketqua.Text[i] == 'x' || ketqua.Text[i] == '/') flag = true;
                if (ketqua.Text[i] != '+' && ketqua.Text[i] != '-' && ketqua.Text[i] != 'x' && ketqua.Text[i] != '/' && flag) tmp += ketqua.Text[i];
            }
            if (tmp != "") number2 = Convert.ToDouble(tmp);
            else number2 = 0;
            switch (dau)
            {
                case 0:
                    break;
                case 1:
                    ketqua.Text = Convert.ToString(number1 + number2);
                    number1 = number1 + number2;
                    dau = 0;
                    break;
                case 2:
                    ketqua.Text = Convert.ToString(number1 - number2);
                    number1 = number1 - number2;
                    dau = 0;
                    break;
                case 3:
                    ketqua.Text = Convert.ToString(number1 * number2);
                    number1 = number1 * number2;
                    dau = 0;
                    break;
                case 4:
                    if (number2 != 0)
                    {
                        ketqua.Text = Convert.ToString(number1 / number2);
                        number1 = number1 / number2;
                    }
                    else MessageBox.Show("Không thể chia cho 0");
                    dau = 0;
                    break;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ketqua.Text != "0")
            {
                if (ketqua.Text.Length != 1)
                    ketqua.Text = ketqua.Text.Remove(ketqua.Text.Length - 1);
                else ketqua.Text = "0";
            }
        }

        private void phimCE_Click(object sender, EventArgs e)
        {
            int i;
            for (i = ketqua.Text.Length - 1; i >= 0; i--)
            {
                if (ketqua.Text[i] == '+' || ketqua.Text[i] == '-' || ketqua.Text[i] == 'x' || ketqua.Text[i] == '/')
                {
                    if (i != ketqua.Text.Length) ketqua.Text = ketqua.Text.Remove(i + 1);
                    if (ketqua.Text == "-") ketqua.Text = "0";
                    break;
                }
            }
            if (i == -1) ketqua.Text = "0";
        }

        private void phimC_Click(object sender, EventArgs e)
        {
            if (ketqua.Text != "0") ketqua.Text = "0";
            dau = 0;
            number1 = 0;
            number2 = 0;
        }

        private void dauTru_Click(object sender, EventArgs e)
        {
            if (ketqua.Text[ketqua.Text.Length - 1] == '+' || ketqua.Text[ketqua.Text.Length - 1] == '-' ||
                ketqua.Text[ketqua.Text.Length - 1] == 'x' || ketqua.Text[ketqua.Text.Length - 1] == '/')
            {
                string tmp = ketqua.Text;
                tmp = tmp.Remove(tmp.Length - 1);
                ketqua.Text = tmp;
            }
            if (dau != 0) dauBang_Click(sender, e);
            dau = 2;
            if (ketqua.Text == "") number1 = 0;
            else number1 = Convert.ToDouble(ketqua.Text);
            ketqua.Text += "-";
        }

        private void dauNhan_Click(object sender, EventArgs e)
        {
            if (ketqua.Text[ketqua.Text.Length - 1] == '+' || ketqua.Text[ketqua.Text.Length - 1] == '-' ||
                ketqua.Text[ketqua.Text.Length - 1] == 'x' || ketqua.Text[ketqua.Text.Length - 1] == '/')
            {
                string tmp = ketqua.Text;
                tmp = tmp.Remove(tmp.Length - 1);
                ketqua.Text = tmp;
            }
            if (dau != 0) dauBang_Click(sender, e);
            dau = 3;
            if (ketqua.Text == "") number1 = 0;
            else number1 = Convert.ToDouble(ketqua.Text);
            ketqua.Text += "x";
        }

        private void dauCan_Click(object sender, EventArgs e)
        {
            if (dau != 0) dauBang_Click(sender, e);
            ketqua.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(ketqua.Text)));
        }

        private void dauPhanTram_Click(object sender, EventArgs e)
        {
            if (dau != 0) dauBang_Click(sender, e);
            ketqua.Text = Convert.ToString((Convert.ToDouble(ketqua.Text)) / 100);
        }

        private void dauPhanSo_Click(object sender, EventArgs e)
        {
            if (dau != 0) dauBang_Click(sender, e);
            if (ketqua.Text != "0") ketqua.Text = Convert.ToString(1 / (Convert.ToDouble(ketqua.Text)));
        }

        private void dauCham_Click(object sender, EventArgs e)
        {
            if (dau != 0) dauBang_Click(sender, e);
            if (!ketqua.Text.Contains(",")) ketqua.Text += ',';
        }

        private void phimAm_Click(object sender, EventArgs e)
        {
            if (dau != 0) dauBang_Click(sender, e);
            if (ketqua.Text != "0") ketqua.Text = Convert.ToString(-(Convert.ToDouble(ketqua.Text)));
        }

        private void phimMC_Click(object sender, EventArgs e)
        {
            M = 0;
            haveM = false;
        }

        private void phimMR_Click(object sender, EventArgs e)
        {
            if (haveM) ketqua.Text = Convert.ToString(M);
        }

        private void phimMS_Click(object sender, EventArgs e)
        {
            M = Convert.ToDouble(ketqua.Text);
            haveM = true;
        }

        private void phimMPlus_Click(object sender, EventArgs e)
        {
            M += Convert.ToDouble(ketqua.Text);
            haveM = true;
        }

        private void dauChia_Click(object sender, EventArgs e)
        {
            if (ketqua.Text[ketqua.Text.Length - 1] == '+' || ketqua.Text[ketqua.Text.Length - 1] == '-' ||
                ketqua.Text[ketqua.Text.Length - 1] == 'x' || ketqua.Text[ketqua.Text.Length - 1] == '/')
            {
                string tmp = ketqua.Text;
                tmp = tmp.Remove(tmp.Length - 1);
                ketqua.Text = tmp;
            }
            if (dau != 0) dauBang_Click(sender, e);
            dau = 4;
            if (ketqua.Text == "") number1 = 0;
            else number1 = Convert.ToDouble(ketqua.Text);
            ketqua.Text += "/";
        }

        private void dauCong_Click(object sender, EventArgs e)
        {
            if (ketqua.Text[ketqua.Text.Length - 1] == '+' || ketqua.Text[ketqua.Text.Length - 1] == '-' ||
                ketqua.Text[ketqua.Text.Length - 1] == 'x' || ketqua.Text[ketqua.Text.Length - 1] == '/')
            {
                string tmp = ketqua.Text;
                tmp = tmp.Remove(tmp.Length - 1);
                ketqua.Text = tmp;
            }
            if (dau != 0) dauBang_Click(sender, e);
            dau = 1;
            if (ketqua.Text == "") number1 = 0;
            else number1 = Convert.ToDouble(ketqua.Text);
            ketqua.Text += "+";
        }

        
    }
}
