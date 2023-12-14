namespace ShoppingCar.Views
{
    partial class RegistrationVehicle
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
            ListCardataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            Chassis = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            ManufacturingYear = new DataGridViewTextBoxColumn();
            ModelYear = new DataGridViewTextBoxColumn();
            FipeValue = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            UpdateButton = new Button();
            DeleteButton = new Button();
            RefreshCarbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)ListCardataGridView).BeginInit();
            SuspendLayout();
            // 
            // ListCardataGridView
            // 
            ListCardataGridView.AllowUserToAddRows = false;
            ListCardataGridView.AllowUserToDeleteRows = false;
            ListCardataGridView.AllowUserToResizeColumns = false;
            ListCardataGridView.AllowUserToResizeRows = false;
            ListCardataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListCardataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListCardataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, LicensePlate, Chassis, Brand, Model, ManufacturingYear, ModelYear, FipeValue, SellingPrice, Notes });
            ListCardataGridView.Location = new Point(34, 72);
            ListCardataGridView.MultiSelect = false;
            ListCardataGridView.Name = "ListCardataGridView";
            ListCardataGridView.ReadOnly = true;
            ListCardataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListCardataGridView.Size = new Size(950, 414);
            ListCardataGridView.TabIndex = 5;
            ListCardataGridView.SelectionChanged += ListCardataGridView_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // LicensePlate
            // 
            LicensePlate.FillWeight = 80F;
            LicensePlate.HeaderText = "Placa";
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            // 
            // Chassis
            // 
            Chassis.FillWeight = 85F;
            Chassis.HeaderText = "Chassi";
            Chassis.Name = "Chassis";
            Chassis.ReadOnly = true;
            // 
            // Brand
            // 
            Brand.HeaderText = "Marca";
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // Model
            // 
            Model.HeaderText = "Modelo";
            Model.Name = "Model";
            Model.ReadOnly = true;
            // 
            // ManufacturingYear
            // 
            ManufacturingYear.HeaderText = "Ano Fabricação";
            ManufacturingYear.Name = "ManufacturingYear";
            ManufacturingYear.ReadOnly = true;
            // 
            // ModelYear
            // 
            ModelYear.HeaderText = "Ano Modelo";
            ModelYear.Name = "ModelYear";
            ModelYear.ReadOnly = true;
            // 
            // FipeValue
            // 
            FipeValue.HeaderText = "Valor da Tabela FIPE";
            FipeValue.Name = "FipeValue";
            FipeValue.ReadOnly = true;
            // 
            // SellingPrice
            // 
            SellingPrice.HeaderText = "Valor de venda";
            SellingPrice.Name = "SellingPrice";
            SellingPrice.ReadOnly = true;
            // 
            // Notes
            // 
            Notes.HeaderText = "Observações";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(368, 517);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(118, 23);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Atualizar";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(529, 517);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(118, 23);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Deletar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RefreshCarbutton
            // 
            RefreshCarbutton.Location = new Point(34, 33);
            RefreshCarbutton.Name = "RefreshCarbutton";
            RefreshCarbutton.Size = new Size(77, 22);
            RefreshCarbutton.TabIndex = 7;
            RefreshCarbutton.Text = "Refresh";
            RefreshCarbutton.UseVisualStyleBackColor = true;
            RefreshCarbutton.Click += RefreshCarbutton_Click;
            // 
            // RegistrationVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 569);
            Controls.Add(RefreshCarbutton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ListCardataGridView);
            Name = "RegistrationVehicle";
            ShowIcon = false;
            Load += RegistrationVehicle_Load;
            ((System.ComponentModel.ISupportInitialize)ListCardataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn Chassis;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn ManufacturingYear;
        private DataGridViewTextBoxColumn ModelYear;
        private DataGridViewTextBoxColumn FipeValue;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn Notes;
        private Button RefreshButton;
        private Button RefreshCarbutton;
        public DataGridView ListCardataGridView;
    }
}