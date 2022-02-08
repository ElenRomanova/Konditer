
namespace Konditer
{
    partial class ChangeIngComp
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ComBoxProvider = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CreateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LableCreate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BackBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Line = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.ComBoxProvider);
            this.guna2GradientPanel1.Controls.Add(this.CreateBtn);
            this.guna2GradientPanel1.Controls.Add(this.LableCreate);
            this.guna2GradientPanel1.Controls.Add(this.BackBtn);
            this.guna2GradientPanel1.Controls.Add(this.Line);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(197)))), ((int)(((byte)(242)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(527, 215);
            this.guna2GradientPanel1.TabIndex = 7;
            // 
            // ComBoxProvider
            // 
            this.ComBoxProvider.BackColor = System.Drawing.Color.Transparent;
            this.ComBoxProvider.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxProvider.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBoxProvider.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBoxProvider.FocusedState.Parent = this.ComBoxProvider;
            this.ComBoxProvider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComBoxProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComBoxProvider.HoverState.Parent = this.ComBoxProvider;
            this.ComBoxProvider.ItemHeight = 30;
            this.ComBoxProvider.ItemsAppearance.Parent = this.ComBoxProvider;
            this.ComBoxProvider.Location = new System.Drawing.Point(173, 79);
            this.ComBoxProvider.Name = "ComBoxProvider";
            this.ComBoxProvider.ShadowDecoration.Parent = this.ComBoxProvider;
            this.ComBoxProvider.Size = new System.Drawing.Size(265, 36);
            this.ComBoxProvider.TabIndex = 9;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.BorderColor = System.Drawing.Color.White;
            this.CreateBtn.BorderRadius = 5;
            this.CreateBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CreateBtn.BorderThickness = 3;
            this.CreateBtn.CheckedState.Parent = this.CreateBtn;
            this.CreateBtn.CustomImages.Parent = this.CreateBtn;
            this.CreateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtn.DisabledState.Parent = this.CreateBtn;
            this.CreateBtn.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.HoverState.Parent = this.CreateBtn;
            this.CreateBtn.Location = new System.Drawing.Point(213, 144);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.ShadowDecoration.Parent = this.CreateBtn;
            this.CreateBtn.Size = new System.Drawing.Size(170, 45);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Изменить";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // LableCreate
            // 
            this.LableCreate.BackColor = System.Drawing.Color.Transparent;
            this.LableCreate.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.LableCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LableCreate.Location = new System.Drawing.Point(213, 24);
            this.LableCreate.Name = "LableCreate";
            this.LableCreate.Size = new System.Drawing.Size(195, 25);
            this.LableCreate.TabIndex = 3;
            this.LableCreate.Text = "Изменить ингредиент";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Image = global::Konditer.Properties.Resources.icons8_длинная_стрелка_влево_80;
            this.BackBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.BackBtn.ImageRotate = 0F;
            this.BackBtn.Location = new System.Drawing.Point(50, 24);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBtn.PressedState.Parent = this.BackBtn;
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(67, 44);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Transparent;
            this.Line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Line.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Line.FillThickness = 2;
            this.Line.Location = new System.Drawing.Point(173, 51);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(265, 10);
            this.Line.TabIndex = 0;
            // 
            // ChangeIngComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 213);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeIngComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeIngComp";
            this.Load += new System.EventHandler(this.ChangeIngComp_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComBoxProvider;
        private Guna.UI2.WinForms.Guna2Button CreateBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel LableCreate;
        private Guna.UI2.WinForms.Guna2ImageButton BackBtn;
        private Guna.UI2.WinForms.Guna2Separator Line;
    }
}