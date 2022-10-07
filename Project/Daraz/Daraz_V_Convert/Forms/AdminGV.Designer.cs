namespace Daraz_V_Convert.Forms
{
    partial class AdminGV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellerGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picNewSeller = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sellerGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 465);
            this.panel1.TabIndex = 2;
            // 
            // sellerGrid
            // 
            this.sellerGrid.AllowUserToAddRows = false;
            this.sellerGrid.AllowUserToDeleteRows = false;
            this.sellerGrid.AllowUserToResizeColumns = false;
            this.sellerGrid.AllowUserToResizeRows = false;
            this.sellerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellerGrid.Location = new System.Drawing.Point(0, 0);
            this.sellerGrid.Name = "sellerGrid";
            this.sellerGrid.ReadOnly = true;
            this.sellerGrid.RowHeadersVisible = false;
            this.sellerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellerGrid.Size = new System.Drawing.Size(841, 465);
            this.sellerGrid.TabIndex = 0;
            this.sellerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerGrid_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.26563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.73438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.picNewSeller, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.picEdit, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.picDelete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.picExit, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 403);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 62);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // picNewSeller
            // 
            this.picNewSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNewSeller.Image = global::Daraz_V_Convert.Properties.Resources.small_button_clip_art_clkerm_vector_clip_art_37334;
            this.picNewSeller.Location = new System.Drawing.Point(699, 3);
            this.picNewSeller.Name = "picNewSeller";
            this.picNewSeller.Size = new System.Drawing.Size(139, 56);
            this.picNewSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewSeller.TabIndex = 4;
            this.picNewSeller.TabStop = false;
            this.picNewSeller.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picEdit
            // 
            this.picEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEdit.Image = global::Daraz_V_Convert.Properties.Resources.small_button_clip_art_clkerm_vector_clip_art_37336;
            this.picEdit.Location = new System.Drawing.Point(564, 3);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(129, 56);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 5;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // picDelete
            // 
            this.picDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDelete.Image = global::Daraz_V_Convert.Properties.Resources.small_button_clip_art_clkerm_vector_clip_www3733;
            this.picDelete.Location = new System.Drawing.Point(430, 3);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(128, 56);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 6;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picExit
            // 
            this.picExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picExit.Image = global::Daraz_V_Convert.Properties.Resources._618316_arrow_exit_logout_sign_out_icon;
            this.picExit.Location = new System.Drawing.Point(3, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(59, 56);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 8;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // AdminGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminGV";
            this.Text = "AdminGV";
            this.Load += new System.EventHandler(this.AdminGV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellerGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNewSeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picNewSeller;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.DataGridView sellerGrid;
    }
}