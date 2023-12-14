namespace ShoppingCar.Views
{
    partial class Car
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
            CreateCarButton = new Button();
            ListCardataGridView = new DataGridView();
            Modelo = new DataGridViewTextBoxColumn();
            ano = new DataGridViewTextBoxColumn();
            SearchMarcacomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ListCardataGridView).BeginInit();
            SuspendLayout();
            // 
            // CreateCarButton
            // 
            CreateCarButton.Location = new Point(416, 468);
            CreateCarButton.Name = "CreateCarButton";
            CreateCarButton.Size = new Size(117, 23);
            CreateCarButton.TabIndex = 7;
            CreateCarButton.Text = "Cadastrar Veiculo";
            CreateCarButton.UseVisualStyleBackColor = true;
            CreateCarButton.Click += CreateCarButton_Click;
            // 
            // ListCardataGridView
            // 
            ListCardataGridView.AllowUserToAddRows = false;
            ListCardataGridView.AllowUserToDeleteRows = false;
            ListCardataGridView.AllowUserToResizeColumns = false;
            ListCardataGridView.AllowUserToResizeRows = false;
            ListCardataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListCardataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListCardataGridView.Columns.AddRange(new DataGridViewColumn[] { Modelo, ano });
            ListCardataGridView.Location = new Point(124, 85);
            ListCardataGridView.MultiSelect = false;
            ListCardataGridView.Name = "ListCardataGridView";
            ListCardataGridView.ReadOnly = true;
            ListCardataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListCardataGridView.Size = new Size(707, 354);
            ListCardataGridView.TabIndex = 6;
            ListCardataGridView.SelectionChanged += ListCardataGridView_SelectionChanged;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // ano
            // 
            ano.HeaderText = "Ano";
            ano.Name = "ano";
            ano.ReadOnly = true;
            // 
            // SearchMarcacomboBox
            // 
            SearchMarcacomboBox.FormattingEnabled = true;
            SearchMarcacomboBox.Location = new Point(124, 41);
            SearchMarcacomboBox.Name = "SearchMarcacomboBox";
            SearchMarcacomboBox.Size = new Size(184, 23);
            SearchMarcacomboBox.TabIndex = 5;
            SearchMarcacomboBox.SelectedIndexChanged += SearchMarcacomboBox_SelectedIndexChanged;
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 562);
            Controls.Add(CreateCarButton);
            Controls.Add(ListCardataGridView);
            Controls.Add(SearchMarcacomboBox);
            Name = "Car";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Car_Load;
            ((System.ComponentModel.ISupportInitialize)ListCardataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateCarButton;
        private DataGridView ListCardataGridView;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn ano;
        private ComboBox SearchMarcacomboBox;
    }
}