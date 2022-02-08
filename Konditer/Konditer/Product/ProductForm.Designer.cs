
namespace Konditer
{
    partial class ProductForm
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
            this.PanelProduct = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnComposition = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBut = new Guna.UI2.WinForms.Guna2Button();
            this.CreateButton = new Guna.UI2.WinForms.Guna2Button();
            this.LableProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TableProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BackBut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Line = new Guna.UI2.WinForms.Guna2Separator();
            this.PanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelProduct
            // 
            this.PanelProduct.Controls.Add(this.BtnComposition);
            this.PanelProduct.Controls.Add(this.DeleteBtn);
            this.PanelProduct.Controls.Add(this.UpdateBut);
            this.PanelProduct.Controls.Add(this.CreateButton);
            this.PanelProduct.Controls.Add(this.LableProduct);
            this.PanelProduct.Controls.Add(this.TableProduct);
            this.PanelProduct.Controls.Add(this.BackBut);
            this.PanelProduct.Controls.Add(this.Line);
            this.PanelProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PanelProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(197)))), ((int)(((byte)(242)))));
            this.PanelProduct.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.PanelProduct.Location = new System.Drawing.Point(0, 0);
            this.PanelProduct.Name = "PanelProduct";
            this.PanelProduct.ShadowDecoration.Parent = this.PanelProduct;
            this.PanelProduct.Size = new System.Drawing.Size(576, 420);
            this.PanelProduct.TabIndex = 3;
            this.PanelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProduct_Paint);
            // 
            // BtnComposition
            // 
            this.BtnComposition.BackColor = System.Drawing.Color.Transparent;
            this.BtnComposition.BorderColor = System.Drawing.Color.White;
            this.BtnComposition.BorderRadius = 5;
            this.BtnComposition.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BtnComposition.BorderThickness = 3;
            this.BtnComposition.CheckedState.Parent = this.BtnComposition;
            this.BtnComposition.CustomImages.Parent = this.BtnComposition;
            this.BtnComposition.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnComposition.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnComposition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnComposition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnComposition.DisabledState.Parent = this.BtnComposition;
            this.BtnComposition.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BtnComposition.ForeColor = System.Drawing.Color.White;
            this.BtnComposition.HoverState.Parent = this.BtnComposition;
            this.BtnComposition.Location = new System.Drawing.Point(199, 258);
            this.BtnComposition.Name = "BtnComposition";
            this.BtnComposition.ShadowDecoration.Parent = this.BtnComposition;
            this.BtnComposition.Size = new System.Drawing.Size(173, 45);
            this.BtnComposition.TabIndex = 7;
            this.BtnComposition.Text = "Состав продукта";
            this.BtnComposition.Click += new System.EventHandler(this.BtnComposition_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(378, 313);
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
            this.UpdateBut.Location = new System.Drawing.Point(200, 362);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.ShadowDecoration.Parent = this.UpdateBut;
            this.UpdateBut.Size = new System.Drawing.Size(173, 45);
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
            this.CreateButton.Location = new System.Drawing.Point(68, 313);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.ShadowDecoration.Parent = this.CreateButton;
            this.CreateButton.Size = new System.Drawing.Size(118, 45);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Создать";
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LableProduct
            // 
            this.LableProduct.BackColor = System.Drawing.Color.Transparent;
            this.LableProduct.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.LableProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LableProduct.Location = new System.Drawing.Point(254, 26);
            this.LableProduct.Name = "LableProduct";
            this.LableProduct.Size = new System.Drawing.Size(92, 25);
            this.LableProduct.TabIndex = 3;
            this.LableProduct.Text = "Продукты";
            // 
            // TableProduct
            // 
            this.TableProduct.AllowUserToAddRows = false;
            this.TableProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TableProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableProduct.BackgroundColor = System.Drawing.Color.White;
            this.TableProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableProduct.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableProduct.EnableHeadersVisualStyles = false;
            this.TableProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableProduct.Location = new System.Drawing.Point(68, 75);
            this.TableProduct.Name = "TableProduct";
            this.TableProduct.ReadOnly = true;
            this.TableProduct.RowHeadersVisible = false;
            this.TableProduct.RowHeadersWidth = 50;
            this.TableProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableProduct.Size = new System.Drawing.Size(428, 161);
            this.TableProduct.TabIndex = 2;
            this.TableProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TableProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TableProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TableProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TableProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TableProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TableProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TableProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TableProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TableProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TableProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TableProduct.ThemeStyle.HeaderStyle.Height = 30;
            this.TableProduct.ThemeStyle.ReadOnly = true;
            this.TableProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TableProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TableProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TableProduct.ThemeStyle.RowsStyle.Height = 22;
            this.TableProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TableProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TableProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableProduct_CellClick);
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
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 421);
            this.Controls.Add(this.PanelProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.PanelProduct.ResumeLayout(false);
            this.PanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel PanelProduct;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBut;
        private Guna.UI2.WinForms.Guna2Button CreateButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel LableProduct;
        private Guna.UI2.WinForms.Guna2DataGridView TableProduct;
        private Guna.UI2.WinForms.Guna2ImageButton BackBut;
        private Guna.UI2.WinForms.Guna2Separator Line;
        private Guna.UI2.WinForms.Guna2Button BtnComposition;
    }
}