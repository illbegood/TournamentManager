using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager
{
    public partial class MatchFormatsForm : Form
    {
        public MatchFormatsForm()
        {
            InitializeComponent();
        }

        private void matchFormatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matchFormatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void MatchFormatsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.MatchFormats". При необходимости она может быть перемещена или удалена.
            this.matchFormatsTableAdapter.Fill(this.databaseDataSet.MatchFormats);

        }
    }
}
