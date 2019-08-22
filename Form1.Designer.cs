namespace TicTacToe
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
            this.a = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.xScoreLabel = new System.Windows.Forms.Label();
            this.oScoreLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.ForestGreen;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(405, 124);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 100);
            this.a.TabIndex = 0;
            this.a.UseVisualStyleBackColor = false;
            this.a.Click += new System.EventHandler(this.A_Click);
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.LightGreen;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(511, 124);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 100);
            this.b.TabIndex = 1;
            this.b.UseVisualStyleBackColor = false;
            this.b.Click += new System.EventHandler(this.B_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.ForestGreen;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(617, 124);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 100);
            this.c.TabIndex = 2;
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.C_Click);
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.LightGreen;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(405, 230);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 100);
            this.d.TabIndex = 3;
            this.d.UseVisualStyleBackColor = false;
            this.d.Click += new System.EventHandler(this.D_Click);
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.ForestGreen;
            this.e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(511, 230);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(100, 100);
            this.e.TabIndex = 4;
            this.e.UseVisualStyleBackColor = false;
            this.e.Click += new System.EventHandler(this.E_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.LightGreen;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.Location = new System.Drawing.Point(617, 230);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(100, 100);
            this.f.TabIndex = 5;
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.F_Click);
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.ForestGreen;
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(405, 336);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(100, 100);
            this.g.TabIndex = 6;
            this.g.UseVisualStyleBackColor = false;
            this.g.Click += new System.EventHandler(this.G_Click);
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.LightGreen;
            this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(511, 336);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(100, 100);
            this.h.TabIndex = 7;
            this.h.UseVisualStyleBackColor = false;
            this.h.Click += new System.EventHandler(this.H_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.ForestGreen;
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(617, 336);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(100, 100);
            this.i.TabIndex = 10;
            this.i.UseVisualStyleBackColor = false;
            this.i.Click += new System.EventHandler(this.I_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Firebrick;
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(85, 358);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(130, 60);
            this.restart.TabIndex = 12;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // xScoreLabel
            // 
            this.xScoreLabel.AutoSize = true;
            this.xScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xScoreLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.xScoreLabel.Location = new System.Drawing.Point(82, 230);
            this.xScoreLabel.Name = "xScoreLabel";
            this.xScoreLabel.Size = new System.Drawing.Size(156, 32);
            this.xScoreLabel.TabIndex = 13;
            this.xScoreLabel.Text = "X\'s Score : ";
            // 
            // oScoreLabel
            // 
            this.oScoreLabel.AutoSize = true;
            this.oScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oScoreLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.oScoreLabel.Location = new System.Drawing.Point(79, 262);
            this.oScoreLabel.Name = "oScoreLabel";
            this.oScoreLabel.Size = new System.Drawing.Size(159, 32);
            this.oScoreLabel.TabIndex = 14;
            this.oScoreLabel.Text = "O\'s Score : ";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.ForeColor = System.Drawing.Color.Crimson;
            this.turnLabel.Location = new System.Drawing.Point(79, 156);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(175, 32);
            this.turnLabel.TabIndex = 15;
            this.turnLabel.Text = "Whose turn?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 611);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.oScoreLabel);
            this.Controls.Add(this.xScoreLabel);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.i);
            this.Controls.Add(this.h);
            this.Controls.Add(this.g);
            this.Controls.Add(this.f);
            this.Controls.Add(this.e);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.Button g;
        private System.Windows.Forms.Button h;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button i;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label xScoreLabel;
        private System.Windows.Forms.Label oScoreLabel;
        private System.Windows.Forms.Label turnLabel;
    }
}

