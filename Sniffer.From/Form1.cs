using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Sniffer.From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Multiline = false;
        private RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline;

        private void btn_Regex_Click(object sender, EventArgs e)
        {
            ItemRegex item = new ItemRegex();
            item.Start = txt_Start.Text;
            item.End = txt_End.Text;
            item.ConcatStart = !chk_Start.Checked;
            item.ConcatEnd = !chk_End.Checked;
            panel1.Controls.Clear();
            if (Multiline)
            {
                item.MultilinePattern = txt_Regex.Text;
                item.Convert(txt_Source.Text);
                
                DataGrid gv = new DataGrid();
                gv.Dock = DockStyle.Fill;
                gv.DataSource = item.Value as DataTable;
                panel1.Controls.Add(gv);
            }
            else
            {
                RichTextBox txt = new RichTextBox();
                txt.Dock = DockStyle.Fill;
                item.Convert(txt_Source.Text);
                txt.Text = item.Value.ToString();
                panel1.Controls.Add(txt);
            }
        }        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tb = sender as TabControl;
            if (tb.SelectedIndex == 0)
                Multiline = false;
            else if (tb.SelectedIndex == 1)
                Multiline = true;
        }

        private void btn_Ress_Click(object sender, EventArgs e)
        {
            string url = txt_Url.Text.Trim();
            txt_Source.Text = HttpHelper.GetPageText(url,Encoding.GetEncoding(cb_Encoding.SelectedItem.ToString()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cb_Encoding.Items.Count > 0)
                cb_Encoding.SelectedIndex = 0;

            Type TypeEnum = typeof(RegexOptions);
            FieldInfo[] InfoStyle = TypeEnum.GetFields();
            for (int i = 1; i < InfoStyle.Length; i++)
			{
                cbl_RegexOptions.Items.Add(InfoStyle[i].Name);
			}
            for (int i = 0; i < cbl_RegexOptions.Items.Count; i++)
            {
                if (cbl_RegexOptions.Items[i].ToString() == "IgnoreCase" || cbl_RegexOptions.Items[i].ToString() == "Singleline")
                {
                    cbl_RegexOptions.SetItemChecked(i, true);
                }
            }
        }

        private void cbl_RegexOptions_SelectedValueChanged(object sender, EventArgs e)
        {
            options = new RegexOptions();
            foreach (var item in cbl_RegexOptions.CheckedItems)
            {
                RegexOptions rOptions = (RegexOptions)Enum.Parse(typeof(RegexOptions), item.ToString());
                options |= rOptions;
            }
        }
    }
}
