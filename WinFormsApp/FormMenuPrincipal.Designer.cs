
namespace WinFormsApp
{
    partial class FormMenuPrincipal
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
            this.panelMenuIzquierda = new System.Windows.Forms.Panel();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.MenuLabelPrincipal = new System.Windows.Forms.Label();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.MenuMarcaVehiculo = new FontAwesome.Sharp.IconButton();
            this.panelMenuIzquierda.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            this.panelMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuIzquierda
            // 
            this.panelMenuIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelMenuIzquierda.Controls.Add(this.MenuMarcaVehiculo);
            this.panelMenuIzquierda.Controls.Add(this.panelMenuLogo);
            this.panelMenuIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzquierda.Name = "panelMenuIzquierda";
            this.panelMenuIzquierda.Size = new System.Drawing.Size(220, 766);
            this.panelMenuIzquierda.TabIndex = 0;
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Controls.Add(this.iconButton1);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(220, 92);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconButton1.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(220, 87);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Agencia";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelMenuTop.Controls.Add(this.MenuLabelPrincipal);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(220, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(1179, 92);
            this.panelMenuTop.TabIndex = 1;
            // 
            // MenuLabelPrincipal
            // 
            this.MenuLabelPrincipal.AutoSize = true;
            this.MenuLabelPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLabelPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuLabelPrincipal.Location = new System.Drawing.Point(29, 23);
            this.MenuLabelPrincipal.Name = "MenuLabelPrincipal";
            this.MenuLabelPrincipal.Size = new System.Drawing.Size(65, 28);
            this.MenuLabelPrincipal.TabIndex = 0;
            this.MenuLabelPrincipal.Text = "Home";
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(220, 92);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(1179, 674);
            this.panelMenuPrincipal.TabIndex = 2;
            // 
            // MenuMarcaVehiculo
            // 
            this.MenuMarcaVehiculo.FlatAppearance.BorderSize = 0;
            this.MenuMarcaVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuMarcaVehiculo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuMarcaVehiculo.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MenuMarcaVehiculo.IconColor = System.Drawing.Color.LightBlue;
            this.MenuMarcaVehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMarcaVehiculo.Location = new System.Drawing.Point(12, 116);
            this.MenuMarcaVehiculo.Name = "MenuMarcaVehiculo";
            this.MenuMarcaVehiculo.Size = new System.Drawing.Size(184, 58);
            this.MenuMarcaVehiculo.TabIndex = 1;
            this.MenuMarcaVehiculo.Text = "Marca Vehiculo";
            this.MenuMarcaVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuMarcaVehiculo.UseVisualStyleBackColor = true;
            this.MenuMarcaVehiculo.Click += new System.EventHandler(this.MenuMarcaVehiculo_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 766);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.panelMenuIzquierda);
            this.Name = "FormMenuPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Menú";
            this.panelMenuIzquierda.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzquierda;
        private System.Windows.Forms.Panel panelMenuLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label MenuLabelPrincipal;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private FontAwesome.Sharp.IconButton MenuMarcaVehiculo;
    }
}