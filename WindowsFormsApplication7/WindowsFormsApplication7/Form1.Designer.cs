namespace WindowsFormsApplication7
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
            this.submit_memory = new System.Windows.Forms.Button();
            this.Add_process = new System.Windows.Forms.Button();
            this.Hole_size = new System.Windows.Forms.TextBox();
            this.process_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.process_name = new System.Windows.Forms.TextBox();
            this.process_size = new System.Windows.Forms.TextBox();
            this.process_grid_view = new System.Windows.Forms.DataGridView();
            this.memory_grid_view = new System.Windows.Forms.DataGridView();
            this.start_add = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Deallocate = new System.Windows.Forms.Button();
            this.Bet_Fit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hole_no = new System.Windows.Forms.TextBox();
            this.Firt_Fit = new System.Windows.Forms.Button();
            this.p_allocate = new System.Windows.Forms.TextBox();
            this.allocate = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.process_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memory_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_memory
            // 
            this.submit_memory.Location = new System.Drawing.Point(128, 128);
            this.submit_memory.Name = "submit_memory";
            this.submit_memory.Size = new System.Drawing.Size(75, 37);
            this.submit_memory.TabIndex = 0;
            this.submit_memory.Text = "Submit Memory";
            this.submit_memory.UseVisualStyleBackColor = true;
            this.submit_memory.Click += new System.EventHandler(this.submit_memory_Click);
            // 
            // Add_process
            // 
            this.Add_process.Location = new System.Drawing.Point(337, 128);
            this.Add_process.Name = "Add_process";
            this.Add_process.Size = new System.Drawing.Size(75, 37);
            this.Add_process.TabIndex = 1;
            this.Add_process.Text = "Add Process";
            this.Add_process.UseVisualStyleBackColor = true;
            this.Add_process.Click += new System.EventHandler(this.Add_process_Click);
            // 
            // Hole_size
            // 
            this.Hole_size.Location = new System.Drawing.Point(119, 56);
            this.Hole_size.Name = "Hole_size";
            this.Hole_size.Size = new System.Drawing.Size(100, 20);
            this.Hole_size.TabIndex = 3;
            // 
            // process_no
            // 
            this.process_no.Location = new System.Drawing.Point(376, 21);
            this.process_no.Name = "process_no";
            this.process_no.Size = new System.Drawing.Size(100, 20);
            this.process_no.TabIndex = 4;
            this.process_no.TextChanged += new System.EventHandler(this.process_no_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hole Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of Processes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Process name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Process Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Memory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Process allocated";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 12;
            // 
            // process_name
            // 
            this.process_name.Location = new System.Drawing.Point(376, 56);
            this.process_name.Name = "process_name";
            this.process_name.Size = new System.Drawing.Size(100, 20);
            this.process_name.TabIndex = 13;
            // 
            // process_size
            // 
            this.process_size.Location = new System.Drawing.Point(376, 82);
            this.process_size.Name = "process_size";
            this.process_size.Size = new System.Drawing.Size(100, 20);
            this.process_size.TabIndex = 14;
            // 
            // process_grid_view
            // 
            this.process_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.process_grid_view.Location = new System.Drawing.Point(418, 167);
            this.process_grid_view.Name = "process_grid_view";
            this.process_grid_view.RowHeadersVisible = false;
            this.process_grid_view.Size = new System.Drawing.Size(399, 150);
            this.process_grid_view.TabIndex = 17;
            // 
            // memory_grid_view
            // 
            this.memory_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memory_grid_view.Location = new System.Drawing.Point(563, 12);
            this.memory_grid_view.Name = "memory_grid_view";
            this.memory_grid_view.RowHeadersVisible = false;
            this.memory_grid_view.Size = new System.Drawing.Size(275, 137);
            this.memory_grid_view.TabIndex = 18;
            // 
            // start_add
            // 
            this.start_add.Location = new System.Drawing.Point(119, 86);
            this.start_add.Name = "start_add";
            this.start_add.Size = new System.Drawing.Size(100, 20);
            this.start_add.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Start Address:";
            // 
            // Deallocate
            // 
            this.Deallocate.Location = new System.Drawing.Point(78, 201);
            this.Deallocate.Name = "Deallocate";
            this.Deallocate.Size = new System.Drawing.Size(75, 37);
            this.Deallocate.TabIndex = 21;
            this.Deallocate.Text = "Deallocate";
            this.Deallocate.UseVisualStyleBackColor = true;
            this.Deallocate.Click += new System.EventHandler(this.Deallocate_Click);
            // 
            // Bet_Fit
            // 
            this.Bet_Fit.Location = new System.Drawing.Point(482, 77);
            this.Bet_Fit.Name = "Bet_Fit";
            this.Bet_Fit.Size = new System.Drawing.Size(75, 37);
            this.Bet_Fit.TabIndex = 22;
            this.Bet_Fit.Text = "Best_Fit";
            this.Bet_Fit.UseVisualStyleBackColor = true;
            this.Bet_Fit.Click += new System.EventHandler(this.Bet_Fit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Process name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hole no :";
            // 
            // Hole_no
            // 
            this.Hole_no.Location = new System.Drawing.Point(119, 21);
            this.Hole_no.Name = "Hole_no";
            this.Hole_no.Size = new System.Drawing.Size(100, 20);
            this.Hole_no.TabIndex = 25;
            this.Hole_no.TextChanged += new System.EventHandler(this.Hole_no_TextChanged);
            // 
            // Firt_Fit
            // 
            this.Firt_Fit.Location = new System.Drawing.Point(482, 21);
            this.Firt_Fit.Name = "Firt_Fit";
            this.Firt_Fit.Size = new System.Drawing.Size(75, 37);
            this.Firt_Fit.TabIndex = 27;
            this.Firt_Fit.Text = "First_Fit";
            this.Firt_Fit.UseVisualStyleBackColor = true;
            this.Firt_Fit.Click += new System.EventHandler(this.Firt_Fit_Click);
            // 
            // p_allocate
            // 
            this.p_allocate.Location = new System.Drawing.Point(122, 175);
            this.p_allocate.Name = "p_allocate";
            this.p_allocate.Size = new System.Drawing.Size(100, 20);
            this.p_allocate.TabIndex = 28;
            this.p_allocate.TextChanged += new System.EventHandler(this.p_allocate_TextChanged);
            // 
            // allocate
            // 
            this.allocate.Location = new System.Drawing.Point(85, 326);
            this.allocate.Name = "allocate";
            this.allocate.Size = new System.Drawing.Size(75, 37);
            this.allocate.TabIndex = 30;
            this.allocate.Text = "Allocate";
            this.allocate.UseVisualStyleBackColor = true;
            this.allocate.Click += new System.EventHandler(this.allocate_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(122, 300);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(100, 20);
            this.size.TabIndex = 34;
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(122, 274);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(100, 20);
            this.P.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Process Size:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Process name:";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(284, 300);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(103, 72);
            this.reset.TabIndex = 36;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 386);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.size);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.allocate);
            this.Controls.Add(this.p_allocate);
            this.Controls.Add(this.Firt_Fit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hole_no);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bet_Fit);
            this.Controls.Add(this.Deallocate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.start_add);
            this.Controls.Add(this.memory_grid_view);
            this.Controls.Add(this.process_grid_view);
            this.Controls.Add(this.process_size);
            this.Controls.Add(this.process_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.process_no);
            this.Controls.Add(this.Hole_size);
            this.Controls.Add(this.Add_process);
            this.Controls.Add(this.submit_memory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.process_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memory_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_memory;
        private System.Windows.Forms.Button Add_process;
        private System.Windows.Forms.TextBox Hole_size;
        private System.Windows.Forms.TextBox process_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox process_name;
        private System.Windows.Forms.TextBox process_size;
        private System.Windows.Forms.DataGridView process_grid_view;
        private System.Windows.Forms.DataGridView memory_grid_view;
        private System.Windows.Forms.TextBox start_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Deallocate;
        private System.Windows.Forms.Button Bet_Fit;
        //private System.Windows.Forms.TextBox p_deallocate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Hole_no;
        private System.Windows.Forms.Button Firt_Fit;
        private System.Windows.Forms.TextBox p_allocate;
        private System.Windows.Forms.Button allocate;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox P;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button reset;
    }
}

