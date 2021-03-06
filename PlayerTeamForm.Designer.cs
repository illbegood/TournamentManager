﻿namespace TournamentManager
{
    partial class PlayerTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerTeamForm));
            this.databaseDataSet = new TournamentManager.databaseDataSet();
            this.playersTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTeamsTableAdapter = new TournamentManager.databaseDataSetTableAdapters.PlayersTeamsTableAdapter();
            this.tableAdapterManager = new TournamentManager.databaseDataSetTableAdapters.TableAdapterManager();
            this.playersTeamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.playersTeamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playersTeamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersTeamsBindingNavigator)).BeginInit();
            this.playersTeamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersTeamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTeamsBindingSource
            // 
            this.playersTeamsBindingSource.DataMember = "PlayersTeams";
            this.playersTeamsBindingSource.DataSource = this.databaseDataSet;
            // 
            // playersTeamsTableAdapter
            // 
            this.playersTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.MatchCategoriesTableAdapter = null;
            this.tableAdapterManager.MatchesTableAdapter = null;
            this.tableAdapterManager.MatchFormatsTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.PlayersTeamsTableAdapter = this.playersTeamsTableAdapter;
            this.tableAdapterManager.PrizedistributionsTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TournamentsTableAdapter = null;
            this.tableAdapterManager.TournamentsTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TournamentManager.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersTeamsBindingNavigator
            // 
            this.playersTeamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playersTeamsBindingNavigator.BindingSource = this.playersTeamsBindingSource;
            this.playersTeamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playersTeamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playersTeamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.playersTeamsBindingNavigatorSaveItem});
            this.playersTeamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playersTeamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playersTeamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playersTeamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playersTeamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playersTeamsBindingNavigator.Name = "playersTeamsBindingNavigator";
            this.playersTeamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playersTeamsBindingNavigator.Size = new System.Drawing.Size(310, 25);
            this.playersTeamsBindingNavigator.TabIndex = 0;
            this.playersTeamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // playersTeamsBindingNavigatorSaveItem
            // 
            this.playersTeamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersTeamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playersTeamsBindingNavigatorSaveItem.Image")));
            this.playersTeamsBindingNavigatorSaveItem.Name = "playersTeamsBindingNavigatorSaveItem";
            this.playersTeamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.playersTeamsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.playersTeamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.playersTeamsBindingNavigatorSaveItem_Click);
            // 
            // playersTeamsDataGridView
            // 
            this.playersTeamsDataGridView.AutoGenerateColumns = false;
            this.playersTeamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersTeamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.playersTeamsDataGridView.DataSource = this.playersTeamsBindingSource;
            this.playersTeamsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.playersTeamsDataGridView.Name = "playersTeamsDataGridView";
            this.playersTeamsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.playersTeamsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "player_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "player_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "team_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "team_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // PlayerTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 244);
            this.Controls.Add(this.playersTeamsDataGridView);
            this.Controls.Add(this.playersTeamsBindingNavigator);
            this.Name = "PlayerTeamForm";
            this.Text = "PlayerTeamForm";
            this.Load += new System.EventHandler(this.PlayerTeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersTeamsBindingNavigator)).EndInit();
            this.playersTeamsBindingNavigator.ResumeLayout(false);
            this.playersTeamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersTeamsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource playersTeamsBindingSource;
        private databaseDataSetTableAdapters.PlayersTeamsTableAdapter playersTeamsTableAdapter;
        private databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator playersTeamsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton playersTeamsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView playersTeamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}