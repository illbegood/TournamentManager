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
    public partial class PlayerTeamForm : Form
    {
        public PlayerTeamForm()
        {
            InitializeComponent();
        }

        private void playersTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void PlayerTeamForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.PlayersTeams". При необходимости она может быть перемещена или удалена.
            this.playersTeamsTableAdapter.Fill(this.databaseDataSet.PlayersTeams);

        }
    }
}
