using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FiatShamir
{
    public partial class Form1 : Form
    {
        ShamirAndFiat newCode = new ShamirAndFiat();

        public Form1()
        {
            InitializeComponent();
            textBoxN.Text = newCode.GetNKey().ToString();
            textBoxS.Text = newCode.GetSKey().ToString();
            textBoxV.Text = Convert.ToString(newCode.GetVKey());
        }

        private void btnNewGen_Click(object sender, EventArgs e)
        {
            newCode = new ShamirAndFiat();
            textBoxN.Text = newCode.GetNKey().ToString();
            textBoxS.Text = newCode.GetSKey().ToString();
            textBoxV.Text = newCode.GetVKey().ToString();
        }

        private void btnNewGenS_Click(object sender, EventArgs e)
        {
            if (newCode.GetP() != 0)
            {
                newCode.NewSGen();
                textBoxS.Text = newCode.GetSKey().ToString();
                textBoxV.Text = newCode.GetVKey().ToString();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            resultListView.Items.Clear();
            var check = true;

            for (int i = 0; i < int.Parse(textBoxCheckNum.Text) && check; i++)
            {
                var tmp1 = 0;
                var tmp2 = 0;
                check = newCode.Check(int.Parse(textBoxN.Text), int.Parse(textBoxV.Text), int.Parse(textBoxS.Text), ref tmp1, ref tmp2);
                label5.Text = Convert.ToString(i + 1);

                resultListView.Items.Add(tmp1.ToString());
                resultListView.Items[i].SubItems.Add(tmp2.ToString());
                if (check)
                    resultListView.Items[i].SubItems.Add("true");
                else resultListView.Items[i].SubItems.Add("false");
            }

            if (check)
                label5.Text = "Идентификация успешна";
            else label5.Text = "Ошибка идентификации";
        }
            
        
    }
}
