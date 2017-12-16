using System.Windows.Forms;

namespace dbPankovES.UI
{
    partial class StatsForm
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
            this.lbError = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbWorker = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.lbTexItog = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbOrderSum = new System.Windows.Forms.Label();
            this.lbSupplySum = new System.Windows.Forms.Label();
            this.lbCapital = new System.Windows.Forms.Label();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(652, 57);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(120, 63);
            this.lbCount.TabIndex = 23;
            this.lbCount.Text = "100";
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
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDate.Location = new System.Drawing.Point(106, 9);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 29);
            this.fromDate.TabIndex = 25;
            this.fromDate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Период с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "по";
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDate.Location = new System.Drawing.Point(422, 9);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 29);
            this.toDate.TabIndex = 27;
            this.toDate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lbTexItog
            // 
            this.lbTexItog.AutoSize = true;
            this.lbTexItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTexItog.Location = new System.Drawing.Point(26, 69);
            this.lbTexItog.Name = "lbTexItog";
            this.lbTexItog.Size = new System.Drawing.Size(534, 46);
            this.lbTexItog.TabIndex = 22;
            this.lbTexItog.Text = "Общее количество заказов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 46);
            this.label3.TabIndex = 29;
            this.label3.Text = "Общая сумма заказов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 46);
            this.label4.TabIndex = 30;
            this.label4.Text = "Расходы на закупку товаров";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 46);
            this.label7.TabIndex = 31;
            this.label7.Text = "Капитализация";
            // 
            // lbOrderSum
            // 
            this.lbOrderSum.AutoSize = true;
            this.lbOrderSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderSum.Location = new System.Drawing.Point(652, 113);
            this.lbOrderSum.Name = "lbOrderSum";
            this.lbOrderSum.Size = new System.Drawing.Size(120, 63);
            this.lbOrderSum.TabIndex = 32;
            this.lbOrderSum.Text = "100";
            // 
            // lbSupplySum
            // 
            this.lbSupplySum.AutoSize = true;
            this.lbSupplySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSupplySum.Location = new System.Drawing.Point(652, 171);
            this.lbSupplySum.Name = "lbSupplySum";
            this.lbSupplySum.Size = new System.Drawing.Size(120, 63);
            this.lbSupplySum.TabIndex = 33;
            this.lbSupplySum.Text = "100";
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCapital.Location = new System.Drawing.Point(652, 228);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(120, 63);
            this.lbCapital.TabIndex = 34;
            this.lbCapital.Text = "100";
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.OrdersView);
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataSource = typeof(dbPankovES.DomainObject.Models.Basket);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1078, 300);
            this.Controls.Add(this.lbCapital);
            this.Controls.Add(this.lbSupplySum);
            this.Controls.Add(this.lbOrderSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.lbWorker);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbTexItog);
            this.Controls.Add(this.lbError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbError;
        private Label lbCount;
        private Label lbWorker;
        private DateTimePicker fromDate;
        private Label label1;
        private Label label2;
        private DateTimePicker toDate;
        private BindingSource basketBindingSource;
        private BindingSource ordersViewBindingSource;
        private Label lbTexItog;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label lbOrderSum;
        private Label lbSupplySum;
        private Label lbCapital;
    }
}