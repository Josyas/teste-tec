namespace ShoppingCar.Views
{
    partial class Login
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
            label2 = new Label();
            label1 = new Label();
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            AcessButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 177);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 112);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuário";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(281, 195);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(241, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(281, 130);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(241, 23);
            userTextBox.TabIndex = 8;
            // 
            // AcessButton
            // 
            AcessButton.Location = new Point(361, 245);
            AcessButton.Name = "AcessButton";
            AcessButton.Size = new Size(75, 23);
            AcessButton.TabIndex = 3;
            AcessButton.Text = "Acessar";
            AcessButton.UseVisualStyleBackColor = true;
            AcessButton.Click += AcessButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(AcessButton);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox passwordTextBox;
        private TextBox userTextBox;
        private Button AcessButton;
    }
}