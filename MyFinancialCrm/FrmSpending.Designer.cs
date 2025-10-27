namespace MyFinancialCrm
{
    partial class FrmSpending
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvSpendings = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.chartTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpendings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrend)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpendings
            // 
            this.dgvSpendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpendings.Location = new System.Drawing.Point(325, 28);
            this.dgvSpendings.Name = "dgvSpendings";
            this.dgvSpendings.RowHeadersWidth = 51;
            this.dgvSpendings.RowTemplate.Height = 24;
            this.dgvSpendings.Size = new System.Drawing.Size(547, 305);
            this.dgvSpendings.TabIndex = 0;
            this.dgvSpendings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpendings_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.Location = new System.Drawing.Point(170, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(170, 115);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(170, 171);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(121, 22);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(170, 222);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 6;
            // 
            // chartTrend
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrend.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTrend.Legends.Add(legend1);
            this.chartTrend.Location = new System.Drawing.Point(354, 352);
            this.chartTrend.Name = "chartTrend";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTrend.Series.Add(series1);
            this.chartTrend.Size = new System.Drawing.Size(395, 258);
            this.chartTrend.TabIndex = 8;
            this.chartTrend.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Harcama Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Harcama Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Harcama Başlığı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Harcama Kategorisi";
            // 
            // FrmSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 622);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTrend);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvSpendings);
            this.Name = "FrmSpending";
            this.Text = "FrmSpending";
            this.Load += new System.EventHandler(this.FrmSpending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpendings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpendings;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}