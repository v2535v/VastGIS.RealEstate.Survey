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

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmQuickInput : Form
    {
        public frmQuickInput(string content)
        {
            InitializeComponent();
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
            IDictionary<string, string> templateDictionary = new Dictionary<string, string>();
            templateDictionary.Add("权利人且面积均无变化", "权利人{QLR}，已进行土地登记，发证宗地面积{X}平方米，证号{X}集{X}（{X}）字第{X}号。经调查，该宗地权利人、界址、坐落未发生变化，四至清楚。现状宗地面积{X}平方米，房产建筑面积{X}平方米。");
            templateDictionary.Add("权利人变化1", "权利人已故，现使用人{QLR}。");
            templateDictionary.Add("权利人变化2", "经调查，因（分家析产，房屋买卖、交换、抵押、权利人名字登记错误），现房屋使用人{QLR}。");
            templateDictionary.Add("权利人变化3", "权利人赠与{QLR}。");
            templateDictionary.Add("权利人变化", "权利人{QLR}，宗地面积{X}平方米，已进行土地登记，发证宗地面积{X}平方米，证号{X}集{X}（{X}）字第{X}号。经调查，因（分家析产，房屋买卖、交换、抵押、权利人名字登记错误、权利人已故...），现房屋使用人{QLR}，该宗地界址、坐落未发生变化,四至清楚。现状宗地面积{X}平方米，房产建筑面积{X}平方米。");
            templateDictionary.Add("界线变化", "权利人{QLR}，发证宗地面积{X}平方米，证号{X}集{X}（{X}）字第{X}号。经调查，该宗地权利人、坐落未发生变化，界址发生变化，四至清楚。现状宗地面积{X}平方米，比原登记减少(增加){X}平方米。");
            templateDictionary.Add("宗地、房屋变化：精度误差说明", "权利人{QLR}，已进行土地登记，发证宗地面积{X}平方米，证号{X}集{X}（{X}）字第{X}号。经调查，该宗地权利人、界址、坐落未发生变化，四至清楚。因精度误差，现状宗地面积{X}平方米，比原登记减少（增加）{X}平方米。房产建筑面积{X}平方米。");
            templateDictionary.Add("宗地、房屋变化：勘丈错误说明", "权利人{QLR}，已进行土地登记，发证宗地面积{X}平方米，证号{X}集{X}（{X}）字第{X}号。经调查：该宗地权利人、界址、坐落未发生变化，四至清楚。因丈量错误（面积登记错误），界址线{X}原登记边长为{X}米，本次实测为{X}米，现状宗地面积为{X}平方米，比原登记增加（减少）{X}平方米。（有可能存在角度误差导致的错误）。房产建筑面积{X}平方米。");
            templateDictionary.Add("宗地、房屋变化：未审批翻改扩建说明", "权利人{QLR}，已进行土地登记，发证宗地面积{X}平方米，证号{X}集{X}（{X}）字第{X}号。经调查，该宗地权利人未发生变化。该宗地房屋已进行翻（改、扩）建，房屋翻（改、扩）建时间{X}年，现状宗地面积为{X}平方米，比原登记增加{X}平方米。房产建筑面积{X}平方米。");
            templateDictionary.Add("宗地、房屋变化：已审批翻改扩建说明", "权利人{QLR}，已进行土地登记，发证宗地面积{X}平方米，证号{X}号；经调查，该宗地权利人未发生变化，四至清楚。该宗地进行翻（改、扩）建，房屋翻（改、扩）建时间{X}年，已办理了翻（改、扩）建手续，（如果已发改建后的土地证，填上改建后的土地证号，如果有规划的批准文件，填规划批准文号）现状宗地面积为{X}平方米，比原登记增加{X}平方米。房产建筑面积{X}平方米。");
            templateDictionary.Add("未登记宗地有部分权源的", "经调查：该宗地使用人{QLR}，使用人提供了（《建设用地批准书》、宅基地使用证、清查证、建筑许可执照、土地所有权证、）但未办理登记手续。现状宗地面积{X}平方米，四至界址清楚。");
            templateDictionary.Add("未登记宗地无权源的", "经调查：该宗地使用人{QLR}，使用人未提供权源资料，未办理登记手续。现状宗地面积{X}平方米，四至界址清楚。");
            //return templateDictionary;

            foreach (KeyValuePair<string, string> template in templateDictionary)
            {
                ucTempMapping templateControl = new ucTempMapping(template.Key, template.Value);
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
            string str = source.Substring(sIdx, eIdx-sIdx);
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
