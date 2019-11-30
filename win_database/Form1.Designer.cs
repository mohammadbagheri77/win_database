namespace win_database
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_MainDataTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_sert = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MainDataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_MainDataTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_MainDataTable
            // 
            this.dgv_MainDataTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_MainDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MainDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MainDataTable.Location = new System.Drawing.Point(3, 3);
            this.dgv_MainDataTable.Name = "dgv_MainDataTable";
            this.dgv_MainDataTable.Size = new System.Drawing.Size(585, 444);
            this.dgv_MainDataTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_move);
            this.panel1.Controls.Add(this.btn_change);
            this.panel1.Controls.Add(this.btn_sert);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(594, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 444);
            this.panel1.TabIndex = 2;
            // 
            // btn_move
            // 
            this.btn_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_move.Font = new System.Drawing.Font("B Badr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_move.Image = global::win_database.Properties.Resources.video_camera;
            this.btn_move.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_move.Location = new System.Drawing.Point(0, 150);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(203, 52);
            this.btn_move.TabIndex = 3;
            this.btn_move.Text = "Move";
            this.btn_move.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_move.UseVisualStyleBackColor = false;
            this.btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            this.btn_move.MouseEnter += new System.EventHandler(this.Btn_move_MouseEnter);
            this.btn_move.MouseLeave += new System.EventHandler(this.Btn_move_MouseLeave);
            // 
            // btn_change
            // 
            this.btn_change.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_change.Font = new System.Drawing.Font("B Badr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_change.Image = global::win_database.Properties.Resources.database_1_;
            this.btn_change.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_change.Location = new System.Drawing.Point(0, 98);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(203, 52);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "ChangeTable";
            this.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.MouseEnter += new System.EventHandler(this.Btn_move_MouseEnter);
            this.btn_change.MouseLeave += new System.EventHandler(this.Btn_move_MouseLeave);
            // 
            // btn_sert
            // 
            this.btn_sert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sert.Font = new System.Drawing.Font("B Badr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_sert.Image = global::win_database.Properties.Resources.database;
            this.btn_sert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sert.Location = new System.Drawing.Point(0, 46);
            this.btn_sert.Name = "btn_sert";
            this.btn_sert.Size = new System.Drawing.Size(203, 52);
            this.btn_sert.TabIndex = 1;
            this.btn_sert.Text = "InsertToThisTable";
            this.btn_sert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sert.UseVisualStyleBackColor = false;
            this.btn_sert.MouseEnter += new System.EventHandler(this.Btn_move_MouseEnter);
            this.btn_sert.MouseLeave += new System.EventHandler(this.Btn_move_MouseLeave);
            // 
            // btn_select
            // 
            this.btn_select.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_select.Font = new System.Drawing.Font("B Badr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_select.Image = global::win_database.Properties.Resources.server;
            this.btn_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_select.Location = new System.Drawing.Point(0, 0);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(203, 46);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "select";
            this.btn_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            this.btn_select.MouseEnter += new System.EventHandler(this.Btn_move_MouseEnter);
            this.btn_select.MouseLeave += new System.EventHandler(this.Btn_move_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MainDataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dgv_MainDataTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_sert;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_move;
    }
}

