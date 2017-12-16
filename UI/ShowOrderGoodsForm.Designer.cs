using System.Windows.Forms;

namespace dbPankovES.UI
{
    partial class ShowOrderGoodsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbError = new System.Windows.Forms.Label();
            this.lbTexItog = new System.Windows.Forms.Label();
            this.lbItog = new System.Windows.Forms.Label();
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.goodIdDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.goodTypeNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceOneDataGridViewTextBoxColumn,
            this.oneTypeDataGridViewTextBoxColumn,
            this.summDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(717, 255);
            this.dataGridView1.TabIndex = 7;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this.basketBindingSource;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(23, 522);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 20);
            this.lbError.TabIndex = 21;
            // 
            // lbTexItog
            // 
            this.lbTexItog.AutoSize = true;
            this.lbTexItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTexItog.Location = new System.Drawing.Point(517, 258);
            this.lbTexItog.Name = "lbTexItog";
            this.lbTexItog.Size = new System.Drawing.Size(102, 31);
            this.lbTexItog.TabIndex = 22;
            this.lbTexItog.Text = "ИТОГ: ";
            this.lbTexItog.Visible = false;
            // 
            // lbItog
            // 
            this.lbItog.AutoSize = true;
            this.lbItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbItog.Location = new System.Drawing.Point(608, 258);
            this.lbItog.Name = "lbItog";
            this.lbItog.Size = new System.Drawing.Size(62, 31);
            this.lbItog.TabIndex = 23;
            this.lbItog.Text = "100";
            this.lbItog.Visible = false;
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.Basket);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "goodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "ИД товара";
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            this.goodIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "goodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // goodTypeNameDataGridViewTextBoxColumn
            // 
            this.goodTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.goodTypeNameDataGridViewTextBoxColumn.DataPropertyName = "goodTypeName";
            this.goodTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип товара";
            this.goodTypeNameDataGridViewTextBoxColumn.Name = "goodTypeNameDataGridViewTextBoxColumn";
            this.goodTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodTypeNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во ед-ц";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceOneDataGridViewTextBoxColumn
            // 
            this.priceOneDataGridViewTextBoxColumn.DataPropertyName = "priceOne";
            this.priceOneDataGridViewTextBoxColumn.HeaderText = "Цена за единицу";
            this.priceOneDataGridViewTextBoxColumn.Name = "priceOneDataGridViewTextBoxColumn";
            this.priceOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceOneDataGridViewTextBoxColumn.Width = 107;
            // 
            // oneTypeDataGridViewTextBoxColumn
            // 
            this.oneTypeDataGridViewTextBoxColumn.DataPropertyName = "oneType";
            this.oneTypeDataGridViewTextBoxColumn.HeaderText = "Ед.изм.";
            this.oneTypeDataGridViewTextBoxColumn.Name = "oneTypeDataGridViewTextBoxColumn";
            this.oneTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.oneTypeDataGridViewTextBoxColumn.Width = 71;
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            this.summDataGridViewTextBoxColumn.ReadOnly = true;
            this.summDataGridViewTextBoxColumn.Width = 66;
            // 
            // ShowOrderGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(714, 290);
            this.Controls.Add(this.lbItog);
            this.Controls.Add(this.lbTexItog);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShowOrderGoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав заказа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private Label lbError;
        private Label lbTexItog;
        private Label lbItog;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceOneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oneTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
    }
}