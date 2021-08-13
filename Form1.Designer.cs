namespace CountryApp
{
    partial class CountryAppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FindCountryButton = new System.Windows.Forms.Button();
            this.FindCountryComboBox = new System.Windows.Forms.ComboBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapitalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryTextBox = new System.Windows.Forms.RichTextBox();
            this.labelCountApp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FindCountryButton
            // 
            this.FindCountryButton.Location = new System.Drawing.Point(12, 86);
            this.FindCountryButton.Name = "FindCountryButton";
            this.FindCountryButton.Size = new System.Drawing.Size(100, 23);
            this.FindCountryButton.TabIndex = 1;
            this.FindCountryButton.Text = "Поиск страны";
            this.FindCountryButton.UseVisualStyleBackColor = true;
            this.FindCountryButton.Click += new System.EventHandler(this.FindCountryButton_ClickAsync);
            // 
            // FindCountryComboBox
            // 
            this.FindCountryComboBox.FormattingEnabled = true;
            this.FindCountryComboBox.Location = new System.Drawing.Point(12, 43);
            this.FindCountryComboBox.Name = "FindCountryComboBox";
            this.FindCountryComboBox.Size = new System.Drawing.Size(125, 21);
            this.FindCountryComboBox.TabIndex = 2;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(12, 119);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(126, 23);
            this.LoadDataButton.TabIndex = 4;
            this.LoadDataButton.Text = "Показать страны БД";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.codeColumn,
            this.CapitalColumn,
            this.areaColumn,
            this.populColumn,
            this.regionColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 148);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(561, 174);
            this.dataGridView.TabIndex = 5;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // codeColumn
            // 
            this.codeColumn.HeaderText = "Код";
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.ReadOnly = true;
            this.codeColumn.Width = 50;
            // 
            // CapitalColumn
            // 
            this.CapitalColumn.HeaderText = "Столица";
            this.CapitalColumn.Name = "CapitalColumn";
            this.CapitalColumn.ReadOnly = true;
            // 
            // areaColumn
            // 
            this.areaColumn.HeaderText = "Площадь";
            this.areaColumn.Name = "areaColumn";
            this.areaColumn.ReadOnly = true;
            // 
            // populColumn
            // 
            this.populColumn.HeaderText = "Население";
            this.populColumn.Name = "populColumn";
            this.populColumn.ReadOnly = true;
            // 
            // regionColumn
            // 
            this.regionColumn.HeaderText = "Регион";
            this.regionColumn.Name = "regionColumn";
            this.regionColumn.ReadOnly = true;
            this.regionColumn.Width = 68;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(213, 28);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.ReadOnly = true;
            this.CountryTextBox.Size = new System.Drawing.Size(314, 114);
            this.CountryTextBox.TabIndex = 6;
            this.CountryTextBox.Text = "";
            // 
            // labelCountApp
            // 
            this.labelCountApp.AutoSize = true;
            this.labelCountApp.Location = new System.Drawing.Point(9, 27);
            this.labelCountApp.Name = "labelCountApp";
            this.labelCountApp.Size = new System.Drawing.Size(86, 13);
            this.labelCountApp.TabIndex = 7;
            this.labelCountApp.Text = "Введите страну";
            // 
            // CountryAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 334);
            this.Controls.Add(this.labelCountApp);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.FindCountryComboBox);
            this.Controls.Add(this.FindCountryButton);
            this.Name = "CountryAppForm";
            this.Text = "CountryApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindCountryButton;
        private System.Windows.Forms.ComboBox FindCountryComboBox;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox CountryTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapitalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionColumn;
        private System.Windows.Forms.Label labelCountApp;
    }
}

