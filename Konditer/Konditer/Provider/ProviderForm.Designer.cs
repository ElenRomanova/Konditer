
namespace Konditer
{
    partial class ProviderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Line = new Guna.UI2.WinForms.Guna2Separator();
            this.BackBut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBut = new Guna.UI2.WinForms.Guna2Button();
            this.CreateButton = new Guna.UI2.WinForms.Guna2Button();
            this.LableNProvider = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TableProvider = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Transparent;
            this.Line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Line.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Line.FillThickness = 2;
            this.Line.Location = new System.Drawing.Point(234, 47);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(139, 10);
            this.Line.TabIndex = 0;
            // 
            // BackBut
            // 
            this.BackBut.BackColor = System.Drawing.Color.Transparent;
            this.BackBut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBut.CheckedState.Parent = this.BackBut;
            this.BackBut.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBut.HoverState.Parent = this.BackBut;
            this.BackBut.Image = global::Konditer.Properties.Resources.icons8_длинная_стрелка_влево_80;
            this.BackBut.ImageOffset = new System.Drawing.Point(0, 0);
            this.BackBut.ImageRotate = 0F;
            this.BackBut.Location = new System.Drawing.Point(41, 13);
            this.BackBut.Name = "BackBut";
            this.BackBut.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBut.PressedState.Parent = this.BackBut;
            this.BackBut.ShadowDecoration.Parent = this.BackBut;
            this.BackBut.Size = new System.Drawing.Size(67, 44);
            this.BackBut.TabIndex = 1;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.DeleteBtn);
            this.guna2GradientPanel1.Controls.Add(this.UpdateBut);
            this.guna2GradientPanel1.Controls.Add(this.CreateButton);
            this.guna2GradientPanel1.Controls.Add(this.LableNProvider);
            this.guna2GradientPanel1.Controls.Add(this.TableProvider);
            this.guna2GradientPanel1.Controls.Add(this.BackBut);
            this.guna2GradientPanel1.Controls.Add(this.Line);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(197)))), ((int)(((byte)(242)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(576, 330);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BorderColor = System.Drawing.Color.White;
            this.DeleteBtn.BorderRadius = 5;
            this.DeleteBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.DeleteBtn.BorderThickness = 3;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.DisabledState.Parent = this.DeleteBtn;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
            this.DeleteBtn.Location = new System.Drawing.Point(418, 257);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(118, 45);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBut.BorderColor = System.Drawing.Color.White;
            this.UpdateBut.BorderRadius = 5;
            this.UpdateBut.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.UpdateBut.BorderThickness = 3;
            this.UpdateBut.CheckedState.Parent = this.UpdateBut;
            this.UpdateBut.CustomImages.Parent = this.UpdateBut;
            this.UpdateBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBut.DisabledState.Parent = this.UpdateBut;
            this.UpdateBut.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.UpdateBut.ForeColor = System.Drawing.Color.White;
            this.UpdateBut.HoverState.Parent = this.UpdateBut;
            this.UpdateBut.Location = new System.Drawing.Point(234, 257);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.ShadowDecoration.Parent = this.UpdateBut;
            this.UpdateBut.Size = new System.Drawing.Size(118, 45);
            this.UpdateBut.TabIndex = 5;
            this.UpdateBut.Text = "Изменить";
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.BorderColor = System.Drawing.Color.White;
            this.CreateButton.BorderRadius = 5;
            this.CreateButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CreateButton.BorderThickness = 3;
            this.CreateButton.CheckedState.Parent = this.CreateButton;
            this.CreateButton.CustomImages.Parent = this.CreateButton;
            this.CreateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateButton.DisabledState.Parent = this.CreateButton;
            this.CreateButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.HoverState.Parent = this.CreateButton;
            this.CreateButton.Location = new System.Drawing.Point(41, 257);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.ShadowDecoration.Parent = this.CreateButton;
            this.CreateButton.Size = new System.Drawing.Size(118, 45);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Создать";
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LableNProvider
            // 
            this.LableNProvider.BackColor = System.Drawing.Color.Transparent;
            this.LableNProvider.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.LableNProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LableNProvider.Location = new System.Drawing.Point(246, 26);
            this.LableNProvider.Name = "LableNProvider";
            this.LableNProvider.Size = new System.Drawing.Size(114, 25);
            this.LableNProvider.TabIndex = 3;
            this.LableNProvider.Text = "Поставщики";
            // 
            // TableProvider
            // 
            this.TableProvider.AllowUserToAddRows = false;
            this.TableProvider.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TableProvider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableProvider.BackgroundColor = System.Drawing.Color.White;
            this.TableProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableProvider.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableProvider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableProvider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableProvider.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableProvider.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableProvider.EnableHeadersVisualStyles = false;
            this.TableProvider.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableProvider.Location = new System.Drawing.Point(68, 75);
            this.TableProvider.Name = "TableProvider";
            this.TableProvider.ReadOnly = true;
            this.TableProvider.RowHeadersVisible = false;
            this.TableProvider.RowHeadersWidth = 50;
            this.TableProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableProvider.Size = new System.Drawing.Size(428, 161);
            this.TableProvider.TabIndex = 2;
            this.TableProvider.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TableProvider.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TableProvider.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TableProvider.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TableProvider.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TableProvider.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TableProvider.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableProvider.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TableProvider.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TableProvider.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TableProvider.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TableProvider.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TableProvider.ThemeStyle.HeaderStyle.Height = 30;
            this.TableProvider.ThemeStyle.ReadOnly = true;
            this.TableProvider.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TableProvider.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableProvider.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TableProvider.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TableProvider.ThemeStyle.RowsStyle.Height = 22;
            this.TableProvider.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableProvider.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TableProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableProvider_CellClick);
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 327);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProviderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderForm";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator Line;
        private Guna.UI2.WinForms.Guna2ImageButton BackBut;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LableNProvider;
        private Guna.UI2.WinForms.Guna2DataGridView TableProvider;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBut;
        private Guna.UI2.WinForms.Guna2Button CreateButton;
    }
}