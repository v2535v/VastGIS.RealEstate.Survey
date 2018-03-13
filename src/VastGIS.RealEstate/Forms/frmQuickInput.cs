using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.RealEstate.CommonControls;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmQuickInput : Form
    {
        private IREDatabase _database;
        public frmQuickInput(IREDatabase database, string content)
        {
            InitializeComponent();
            _database = database;
            txtContent.Text = content;
            LoadQlrList();
            LoadTemplateList();
        }

        public string Content
        {
            get { return txtContent.Text; }
            set { txtContent.Text = value; }
        }

        private void LoadQlrList()
        {
            List<string> qlrs = new List<string>();
            qlrs.Add("李先生");
            qlrs.Add("张先生");

            foreach (string qlr in qlrs)
            {
                Button qlrButton = new Button();
                qlrButton.Dock = DockStyle.Left;
                qlrButton.Text = qlr;
                qlrButton.Click += QlrButton_Click;
                panelQlrs.Controls.Add(qlrButton);
            }
        }

        private void QlrButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
                return;
            string qlr = button.Text;
            txtContent.Text = Replace(txtContent.Text, "{QLR}", qlr);
        }

        private void LoadTemplateList()
        {
            List<VgDictionary> dictionaries = _database.DomainService.GetDictionaryByName("KSLRZD");

            foreach (VgDictionary template in dictionaries)
            {
                ucTempMapping templateControl = new ucTempMapping(template.Zdz, template.Zdsm);
                templateControl.SelectedComplateEvent += TemplateControl_SelectedComplateEvent;
                templateControl.Dock = DockStyle.Top;
                panelTemplates.Controls.Add(templateControl);
            }
        }

        private void TemplateControl_SelectedComplateEvent(string content)
        {
            txtContent.AppendText($"{content}\n");
        }

        public static string Replace(string source, string match, string replacement)
        {
            char[] sArr = source.ToCharArray();
            char[] mArr = match.ToCharArray();
            char[] rArr = replacement.ToCharArray();
            int idx = IndexOf(sArr, mArr);
            if (idx == -1)
            {
                return source;
            }
            else
            {
                return new string(sArr.Take(idx).Concat(rArr).Concat(sArr.Skip(idx + mArr.Length)).ToArray());
            }
        }

        private static int IndexOf(char[] source, char[] match)
        {
            int idx = -1;
            for (int i = 0; i <= source.Length - match.Length; i++)
            {
                if (source[i] == match[0])
                {
                    bool isMatch = true;
                    for (int j = 0; j < match.Length; j++)
                    {
                        if (source[i + j] != match[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    if (isMatch)
                    {
                        idx = i;
                        break;
                    }
                }
            }
            return idx;
        }

        private void txtContent_Click(object sender, EventArgs e)
        {
            int idx = txtContent.SelectionStart;
            int sIdx = SearchMatchStr(txtContent.Text, idx, "{X}");
            if (sIdx == -1)
                return;
            else
                txtContent.Select(sIdx, 3);
        }

        private int SearchMatchStr(string source, int idx, string match)
        {
            int sIdx = -1;
            int eIdx = source.Length;
            if (idx < match.Length) sIdx = 0;
            else sIdx = idx - match.Length;
            if (idx + 3 < source.Length + 1) eIdx = idx + 3;
            string str = source.Substring(sIdx, eIdx - sIdx);
            int i = IndexOf(str.ToCharArray(), match.ToCharArray());
            if (i < 0) return -1;
            else return sIdx + i;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
        }
    }
}
