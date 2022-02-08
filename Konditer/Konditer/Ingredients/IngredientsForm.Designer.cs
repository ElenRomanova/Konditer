
namespace Konditer
{
    partial class IngredientsForm
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
            this.Panelngred = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBut = new Guna.UI2.WinForms.Guna2Button();
            this.CreateButton = new Guna.UI2.WinForms.Guna2Button();
            this.LableIngred = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TableIngred = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Line = new Guna.UI2.WinForms.Guna2Separator();
            this.BackBut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Panelngred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIngred)).BeginInit();
            this.SuspendLayout();
            // 
            // Panelngred
            // 
            this.Panelngred.Controls.Add(this.DeleteBtn);
            this.Panelngred.Controls.Add(this.UpdateBut);
            this.Panelngred.Controls.Add(this.CreateButton);
            this.Panelngred.Controls.Add(this.LableIngred);
            this.Panelngred.Controls.Add(this.TableIngred);
            this.Panelngred.Controls.Add(this.BackBut);
            this.Panelngred.Controls.Add(this.Line);
            this.Panelngred.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Panelngred.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(197)))), ((int)(((byte)(242)))));
            this.Panelngred.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Panelngred.Location = new System.Drawing.Point(0, -2);
            this.Panelngred.Name = "Panelngred";
            this.Panelngred.ShadowDecoration.Parent = this.Panelngred;
            this.Panelngred.Size = new System.Drawing.Size(580, 333);
            this.Panelngred.TabIndex = 4;
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
            // LableIngred
            // 
            this.LableIngred.BackColor = System.Drawing.Color.Transparent;
            this.LableIngred.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.LableIngred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LableIngred.Location = new System.Drawing.Point(254, 26);
            this.LableIngred.Name = "LableIngred";
            this.LableIngred.Size = new System.Drawing.Size(122, 25);
            this.LableIngred.TabIndex = 3;
            this.LableIngred.Text = "Ингредиенты";
            // 
            // TableIngred
            // 
            this.TableIngred.AllowUserToAddRows = false;
            this.TableIngred.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TableIngred.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableIngred.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableIngred.BackgroundColor = System.Drawing.Color.White;
            this.TableIngred.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableIngred.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableIngred.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableIngred.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableIngred.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableIngred.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableIngred.EnableHeadersVisualStyles = false;
            this.TableIngred.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableIngred.Location = new System.Drawing.Point(82, 74);
            this.TableIngred.Name = "TableIngred";
            this.TableIngred.ReadOnly = true;
            this.TableIngred.RowHeadersVisible = false;
            this.TableIngred.RowHeadersWidth = 50;
            this.TableIngred.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableIngred.Size = new System.Drawing.Size(428, 161);
            this.TableIngred.TabIndex = 2;
            this.TableIngred.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TableIngred.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TableIngred.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TableIngred.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TableIngred.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TableIngred.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TableIngred.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableIngred.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TableIngred.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TableIngred.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TableIngred.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TableIngred.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TableIngred.ThemeStyle.HeaderStyle.Height = 30;
            this.TableIngred.ThemeStyle.ReadOnly = true;
            this.TableIngred.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TableIngred.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableIngred.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TableIngred.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TableIngred.ThemeStyle.RowsStyle.Height = 22;
            this.TableIngred.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableIngred.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TableIngred.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableIngred_CellClick);
            this.TableIngred.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableIngred_CellContentClick);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Transparent;
            this.Line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Line.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Line.FillThickness = 2;
            this.Line.Location = new System.Drawing.Point(234, 47);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(161, 10);
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
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 331);
            this.Controls.Add(this.Panelngred);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngredientsForm";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            this.Panelngred.ResumeLayout(false);
            this.Panelngred.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIngred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Panelngred;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBut;
        private Guna.UI2.WinForms.Guna2Button CreateButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel LableIngred;
        private Guna.UI2.WinForms.Guna2DataGridView TableIngred;
        private Guna.UI2.WinForms.Guna2ImageButton BackBut;
        private Guna.UI2.WinForms.Guna2Separator Line;
    }
}