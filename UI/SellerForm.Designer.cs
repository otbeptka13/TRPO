using System.Windows.Forms;

namespace dbPankovES.UI
{
    partial class SellerForm
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
            this.btOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btClear = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.lbTexItog = new System.Windows.Forms.Label();
            this.lbItog = new System.Windows.Forms.Label();
            this.lbWorker = new System.Windows.Forms.Label();
            this.btAddGood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOrder.Location = new System.Drawing.Point(178, 554);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(160, 65);
            this.btOrder.TabIndex = 6;
            this.btOrder.Text = "Завершить заказ";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(-1, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1201, 366);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "goodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "Идентификатор товара";
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            this.goodIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "goodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodTypeNameDataGridViewTextBoxColumn
            // 
            this.goodTypeNameDataGridViewTextBoxColumn.DataPropertyName = "goodTypeName";
            this.goodTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип товара";
            this.goodTypeNameDataGridViewTextBoxColumn.Name = "goodTypeNameDataGridViewTextBoxColumn";
            this.goodTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество единиц товара";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceOneDataGridViewTextBoxColumn
            // 
            this.priceOneDataGridViewTextBoxColumn.DataPropertyName = "priceOne";
            this.priceOneDataGridViewTextBoxColumn.HeaderText = "Цена за единицу";
            this.priceOneDataGridViewTextBoxColumn.Name = "priceOneDataGridViewTextBoxColumn";
            this.priceOneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oneTypeDataGridViewTextBoxColumn
            // 
            this.oneTypeDataGridViewTextBoxColumn.DataPropertyName = "oneType";
            this.oneTypeDataGridViewTextBoxColumn.HeaderText = "Ед.изм.";
            this.oneTypeDataGridViewTextBoxColumn.Name = "oneTypeDataGridViewTextBoxColumn";
            this.oneTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            this.summDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this.basketBindingSource;
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.Basket);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClear.Location = new System.Drawing.Point(344, 554);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(160, 65);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Очистить заказ";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
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
            this.lbTexItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTexItog.Location = new System.Drawing.Point(788, 437);
            this.lbTexItog.Name = "lbTexItog";
            this.lbTexItog.Size = new System.Drawing.Size(146, 46);
            this.lbTexItog.TabIndex = 22;
            this.lbTexItog.Text = "ИТОГ: ";
            this.lbTexItog.Visible = false;
            // 
            // lbItog
            // 
            this.lbItog.AutoSize = true;
            this.lbItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbItog.Location = new System.Drawing.Point(919, 425);
            this.lbItog.Name = "lbItog";
            this.lbItog.Size = new System.Drawing.Size(120, 63);
            this.lbItog.TabIndex = 23;
            this.lbItog.Text = "100";
            this.lbItog.Visible = false;
            // 
            // lbWorker
            // 
            this.lbWorker.AutoSize = true;
            this.lbWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWorker.Location = new System.Drawing.Point(6, 9);
            this.lbWorker.Name = "lbWorker";
            this.lbWorker.Size = new System.Drawing.Size(0, 20);
            this.lbWorker.TabIndex = 24;
            this.lbWorker.Visible = false;
            // 
            // btAddGood
            // 
            this.btAddGood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddGood.Location = new System.Drawing.Point(12, 554);
            this.btAddGood.Name = "btAddGood";
            this.btAddGood.Size = new System.Drawing.Size(160, 65);
            this.btAddGood.TabIndex = 9;
            this.btAddGood.Text = "Добавить товар";
            this.btAddGood.UseVisualStyleBackColor = false;
            this.btAddGood.Click += new System.EventHandler(this.btAddGood_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1202, 631);
            this.Controls.Add(this.lbWorker);
            this.Controls.Add(this.lbItog);
            this.Controls.Add(this.lbTexItog);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btAddGood);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование заказов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private Button btClear;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceOneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oneTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private Label lbError;
        private Label lbTexItog;
        private Label lbItog;
        private Label lbWorker;
        private Button btAddGood;
    }
}