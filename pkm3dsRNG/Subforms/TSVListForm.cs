using System.Collections.Generic;
using System.Windows.Forms;

namespace pkm3dsRNG
{
    public partial class TSVListForm : Form
    {
        public List<int> other_tsv = new List<int>();
        public TSVListForm(string tsvstr)
        {
            InitializeComponent();
            try
            {
                RTB_TSV.Lines = tsvstr.Split(',');
            }
            catch { }
        }

        private void B_Save_Click(object sender, System.EventArgs e)
        {
            getTSV();
            Close();
        }

        private void getTSV()
        {
            string[] lines = RTB_TSV.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                int val;
                if (!int.TryParse(lines[i], out val))
                    continue;

                if (0 > val || val > 4095)
                    continue;

                other_tsv.Add(val);
            }
        }
    }
}
