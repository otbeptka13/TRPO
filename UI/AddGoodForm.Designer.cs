using System.Windows.Forms;

namespace dbPankovES.UI
{
    partial class AddGoodForm
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
            this.btAddGood = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGoodType = new System.Windows.Forms.ComboBox();
            this.goodTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbGood = new System.Windows.Forms.ComboBox();
            this.goodsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.userTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbVailable = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddGood
            // 
            this.btAddGood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddGood.Location = new System.Drawing.Point(23, 321);
            this.btAddGood.Name = "btAddGood";
            this.btAddGood.Size = new System.Drawing.Size(118, 36);
            this.btAddGood.TabIndex = 10;
            this.btAddGood.Text = "Добавить товар";
            this.btAddGood.UseVisualStyleBackColor = false;
            this.btAddGood.Click += new System.EventHandler(this.btAddGood_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(169, 321);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(118, 36);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Отмена";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(23, 228);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(156, 20);
            this.tbCount.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество единиц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тип товара";
            // 
            // cbGoodType
            // 
            this.cbGoodType.DataSource = this.goodTypesBindingSource;
            this.cbGoodType.DisplayMember = "name";
            this.cbGoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoodType.FormattingEnabled = true;
            this.cbGoodType.Location = new System.Drawing.Point(205, 39);
            this.cbGoodType.Name = "cbGoodType";
            this.cbGoodType.Size = new System.Drawing.Size(219, 21);
            this.cbGoodType.TabIndex = 15;
            this.cbGoodType.ValueMember = "id";
            this.cbGoodType.SelectedIndexChanged += new System.EventHandler(this.cbGoodType_SelectedIndexChanged);
            // 
            // goodTypesBindingSource
            // 
            this.goodTypesBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.GoodTypes);
            // 
            // cbGood
            // 
            this.cbGood.DataSource = this.goodsViewBindingSource;
            this.cbGood.DisplayMember = "name";
            this.cbGood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGood.FormattingEnabled = true;
            this.cbGood.Location = new System.Drawing.Point(205, 83);
            this.cbGood.Name = "cbGood";
            this.cbGood.Size = new System.Drawing.Size(219, 21);
            this.cbGood.TabIndex = 17;
            this.cbGood.ValueMember = "id";
            this.cbGood.SelectedIndexChanged += new System.EventHandler(this.cbGood_SelectedIndexChanged);
            // 
            // goodsViewBindingSource
            // 
            this.goodsViewBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.GoodsView);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Наименование товара";
            // 
            // userTypesBindingSource
            // 
            this.userTypesBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.UserTypes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(206, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Доступно";
            // 
            // tbVailable
            // 
            this.tbVailable.Location = new System.Drawing.Point(205, 228);
            this.tbVailable.Name = "tbVailable";
            this.tbVailable.ReadOnly = true;
            this.tbVailable.Size = new System.Drawing.Size(77, 20);
            this.tbVailable.TabIndex = 19;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(19, 284);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 20);
            this.lbError.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Цена за ед. товара";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(205, 121);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(219, 20);
            this.tbPrice.TabIndex = 22;
            // 
            // AddGoodForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(446, 369);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.tbVailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGoodType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAddGood);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            ((System.ComponentModel.ISupportInitialize)(this.goodTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btAddGood;
        private Button btExit;
        #endregion

        private TextBox tbCount;
        private Label label2;
        private Label label1;
        private ComboBox cbGoodType;
        private BindingSource goodTypesBindingSource;
        private ComboBox cbGood;
        private Label label3;
        private BindingSource userTypesBindingSource;
        private BindingSource goodsViewBindingSource;
        private Label label4;
        private TextBox tbVailable;
        private Label lbError;
        private Label label5;
        private TextBox tbPrice;
    }
}