namespace CocoaBikiny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Ingresar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(244, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de venta";
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(283, 366);
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(216, 20);
            this.contra.TabIndex = 3;
            this.contra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(280, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(280, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(283, 290);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(216, 20);
            this.User.TabIndex = 7;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Ingresar_btn
            // 
            this.Ingresar_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Ingresar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresar_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Ingresar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ingresar_btn.ForeColor = System.Drawing.Color.Snow;
            this.Ingresar_btn.Location = new System.Drawing.Point(283, 413);
            this.Ingresar_btn.Name = "Ingresar_btn";
            this.Ingresar_btn.Size = new System.Drawing.Size(75, 23);
            this.Ingresar_btn.TabIndex = 8;
            this.Ingresar_btn.Text = "Ingresar";
            this.Ingresar_btn.UseVisualStyleBackColor = false;
            this.Ingresar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.Crimson;
            this.cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_btn.ForeColor = System.Drawing.Color.Snow;
            this.cancelar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar_btn.Location = new System.Drawing.Point(424, 413);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 9;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = false;
            this.cancelar_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(237, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 179);
            this.label1.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(793, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.Ingresar_btn);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Button Ingresar_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Label label1;
    }
}