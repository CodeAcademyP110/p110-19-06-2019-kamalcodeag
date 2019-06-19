namespace P110_Tasks
{
    partial class WebBrowser
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnParalel = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.lbSync = new System.Windows.Forms.ListBox();
            this.lbAsync = new System.Windows.Forms.ListBox();
            this.lbParalel = new System.Windows.Forms.ListBox();
            this.labelSync = new System.Windows.Forms.Label();
            this.labelAsync = new System.Windows.Forms.Label();
            this.labelParalel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSync.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSync.Location = new System.Drawing.Point(37, 42);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(344, 78);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Load websites synchronously";
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnParalel
            // 
            this.btnParalel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnParalel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParalel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnParalel.Location = new System.Drawing.Point(971, 42);
            this.btnParalel.Name = "btnParalel";
            this.btnParalel.Size = new System.Drawing.Size(344, 78);
            this.btnParalel.TabIndex = 1;
            this.btnParalel.Text = "Load websites paralel";
            this.btnParalel.UseVisualStyleBackColor = false;
            this.btnParalel.Click += new System.EventHandler(this.btnParalel_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAsync.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsync.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsync.Location = new System.Drawing.Point(504, 42);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(344, 78);
            this.btnAsync.TabIndex = 2;
            this.btnAsync.Text = "Load websites asynchronously";
            this.btnAsync.UseVisualStyleBackColor = false;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // lbSync
            // 
            this.lbSync.FormattingEnabled = true;
            this.lbSync.Location = new System.Drawing.Point(37, 179);
            this.lbSync.Name = "lbSync";
            this.lbSync.Size = new System.Drawing.Size(344, 472);
            this.lbSync.TabIndex = 3;
            // 
            // lbAsync
            // 
            this.lbAsync.FormattingEnabled = true;
            this.lbAsync.Location = new System.Drawing.Point(504, 179);
            this.lbAsync.Name = "lbAsync";
            this.lbAsync.Size = new System.Drawing.Size(344, 472);
            this.lbAsync.TabIndex = 4;
            // 
            // lbParalel
            // 
            this.lbParalel.FormattingEnabled = true;
            this.lbParalel.Location = new System.Drawing.Point(971, 179);
            this.lbParalel.Name = "lbParalel";
            this.lbParalel.Size = new System.Drawing.Size(344, 472);
            this.lbParalel.TabIndex = 5;
            // 
            // labelSync
            // 
            this.labelSync.AutoSize = true;
            this.labelSync.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSync.ForeColor = System.Drawing.Color.Maroon;
            this.labelSync.Location = new System.Drawing.Point(37, 681);
            this.labelSync.Name = "labelSync";
            this.labelSync.Size = new System.Drawing.Size(74, 24);
            this.labelSync.TabIndex = 6;
            this.labelSync.Text = "label1";
            this.labelSync.Visible = false;
            // 
            // labelAsync
            // 
            this.labelAsync.AutoSize = true;
            this.labelAsync.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsync.ForeColor = System.Drawing.Color.Maroon;
            this.labelAsync.Location = new System.Drawing.Point(500, 681);
            this.labelAsync.Name = "labelAsync";
            this.labelAsync.Size = new System.Drawing.Size(74, 24);
            this.labelAsync.TabIndex = 7;
            this.labelAsync.Text = "label1";
            this.labelAsync.Visible = false;
            // 
            // labelParalel
            // 
            this.labelParalel.AutoSize = true;
            this.labelParalel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParalel.ForeColor = System.Drawing.Color.Maroon;
            this.labelParalel.Location = new System.Drawing.Point(967, 681);
            this.labelParalel.Name = "labelParalel";
            this.labelParalel.Size = new System.Drawing.Size(74, 24);
            this.labelParalel.TabIndex = 8;
            this.labelParalel.Text = "label1";
            this.labelParalel.Visible = false;
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 842);
            this.Controls.Add(this.labelParalel);
            this.Controls.Add(this.labelAsync);
            this.Controls.Add(this.labelSync);
            this.Controls.Add(this.lbParalel);
            this.Controls.Add(this.lbAsync);
            this.Controls.Add(this.lbSync);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnParalel);
            this.Controls.Add(this.btnSync);
            this.Name = "WebBrowser";
            this.Text = "WebBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnParalel;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.ListBox lbSync;
        private System.Windows.Forms.ListBox lbAsync;
        private System.Windows.Forms.ListBox lbParalel;
        private System.Windows.Forms.Label labelSync;
        private System.Windows.Forms.Label labelAsync;
        private System.Windows.Forms.Label labelParalel;
    }
}