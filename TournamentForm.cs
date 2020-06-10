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
    public partial class TournamentForm : Form
    {
        public TournamentForm()
        {
            InitializeComponent();
        }

        private void tournamentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tournamentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Tournaments". При необходимости она может быть перемещена или удалена.
            this.tournamentsTableAdapter.Fill(this.databaseDataSet.Tournaments);

        }
    }
}
