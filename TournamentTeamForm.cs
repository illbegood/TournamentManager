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
    public partial class TournamentTeamForm : Form
    {
        public TournamentTeamForm()
        {
            InitializeComponent();
        }

        private void tournamentsTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tournamentsTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void TournamentTeamForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.TournamentsTeams". При необходимости она может быть перемещена или удалена.
            this.tournamentsTeamsTableAdapter.Fill(this.databaseDataSet.TournamentsTeams);

        }
    }
}
