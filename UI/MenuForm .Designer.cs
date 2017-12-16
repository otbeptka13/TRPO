namespace dbPankovES.UI
{
    partial class MenuForm
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
            this.labelTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSeller = new System.Windows.Forms.Button();
            this.btShowOrdes = new System.Windows.Forms.Button();
            this.btNewGoods = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTop.Location = new System.Drawing.Point(20, 9);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(522, 24);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "ПРОГРАММНЫЙ КОМПЛЕКС «РОЗНИЧНАЯ ТОРГОВЛЯ»";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строительный магазин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btSeller
            // 
            this.btSeller.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSeller.Location = new System.Drawing.Point(24, 137);
            this.btSeller.Name = "btSeller";
            this.btSeller.Size = new System.Drawing.Size(160, 65);
            this.btSeller.TabIndex = 7;
            this.btSeller.Text = "Оформление заказов";
            this.btSeller.UseVisualStyleBackColor = false;
            this.btSeller.Click += new System.EventHandler(this.btSeller_Click);
            // 
            // btShowOrdes
            // 
            this.btShowOrdes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btShowOrdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShowOrdes.Location = new System.Drawing.Point(24, 224);
            this.btShowOrdes.Name = "btShowOrdes";
            this.btShowOrdes.Size = new System.Drawing.Size(160, 65);
            this.btShowOrdes.TabIndex = 8;
            this.btShowOrdes.Text = "Просмотр заказов";
            this.btShowOrdes.UseVisualStyleBackColor = false;
            this.btShowOrdes.Click += new System.EventHandler(this.btShowOrdes_Click);
            // 
            // btNewGoods
            // 
            this.btNewGoods.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNewGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNewGoods.Location = new System.Drawing.Point(190, 137);
            this.btNewGoods.Name = "btNewGoods";
            this.btNewGoods.Size = new System.Drawing.Size(160, 65);
            this.btNewGoods.TabIndex = 9;
            this.btNewGoods.Text = "Учет товара";
            this.btNewGoods.UseVisualStyleBackColor = false;
            this.btNewGoods.Click += new System.EventHandler(this.btNewGoods_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(190, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 65);
            this.button1.TabIndex = 10;
            this.button1.Text = "Загрузить транспортный файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(356, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 65);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отчеты и статистика";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(356, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 65);
            this.button3.TabIndex = 12;
            this.button3.Text = "Администрирование";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(554, 311);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNewGoods);
            this.Controls.Add(this.btShowOrdes);
            this.Controls.Add(this.btSeller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПРОГРАММНЫЙ КОМПЛЕКС «РОЗНИЧНАЯ ТОРГОВЛЯ»";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSeller;
        private System.Windows.Forms.Button btShowOrdes;
        private System.Windows.Forms.Button btNewGoods;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}