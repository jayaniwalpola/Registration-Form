namespace Exercise
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstuname = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtaddresss = new System.Windows.Forms.TextBox();
            this.txtconNo = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Student Details:";
            // 
            // txtstuname
            // 
            this.txtstuname.Location = new System.Drawing.Point(609, 109);
            this.txtstuname.Name = "txtstuname";
            this.txtstuname.Size = new System.Drawing.Size(183, 20);
            this.txtstuname.TabIndex = 6;
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(608, 141);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(183, 20);
            this.txtdob.TabIndex = 7;
            // 
            // txtaddresss
            // 
            this.txtaddresss.Location = new System.Drawing.Point(608, 171);
            this.txtaddresss.Name = "txtaddresss";
            this.txtaddresss.Size = new System.Drawing.Size(183, 20);
            this.txtaddresss.TabIndex = 8;
            // 
            // txtconNo
            // 
            this.txtconNo.Location = new System.Drawing.Point(608, 201);
            this.txtconNo.Name = "txtconNo";
            this.txtconNo.Size = new System.Drawing.Size(183, 20);
            this.txtconNo.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(592, 250);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(137, 43);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(609, 78);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(183, 20);
            this.txtid.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 349);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.txtconNo);
            this.Controls.Add(this.txtaddresss);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtstuname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstuname;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtaddresss;
        private System.Windows.Forms.TextBox txtconNo;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
    }
}

