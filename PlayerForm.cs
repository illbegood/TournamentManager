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
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.databaseDataSet.Players);

        }

        private void PlayerForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.databaseDataSet.Players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.databaseDataSet.Players);

        }

        private void playersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}
