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
    public partial class MatchForm : Form
    {
        public MatchForm()
        {
            InitializeComponent();
        }

        private void matchesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matchesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void MatchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Matches". При необходимости она может быть перемещена или удалена.
            this.matchesTableAdapter.Fill(this.databaseDataSet.Matches);

        }
    }
}
