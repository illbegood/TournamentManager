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
    public partial class MatchCategories : Form
    {
        public MatchCategories()
        {
            InitializeComponent();
        }

        private void matchCategoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matchCategoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void MatchCategories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.MatchCategories". При необходимости она может быть перемещена или удалена.
            this.matchCategoriesTableAdapter.Fill(this.databaseDataSet.MatchCategories);

        }
    }
}
