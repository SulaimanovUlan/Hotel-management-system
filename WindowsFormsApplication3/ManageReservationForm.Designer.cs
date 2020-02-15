namespace WindowsFormsApplication3
{
    partial class ManageReservationForm
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
            this.deleteReserv = new System.Windows.Forms.Button();
            this.editReserv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addReserv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.roomNumber = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reservides = new System.Windows.Forms.TextBox();
            this.reservid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteReserv
            // 
            this.deleteReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReserv.Location = new System.Drawing.Point(219, 311);
            this.deleteReserv.Name = "deleteReserv";
            this.deleteReserv.Size = new System.Drawing.Size(81, 25);
            this.deleteReserv.TabIndex = 29;
            this.deleteReserv.Text = "DELETE";
            this.deleteReserv.UseVisualStyleBackColor = true;
            this.deleteReserv.Click += new System.EventHandler(this.deleteReserv_Click);
            // 
            // editReserv
            // 
            this.editReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editReserv.Location = new System.Drawing.Point(151, 311);
            this.editReserv.Name = "editReserv";
            this.editReserv.Size = new System.Drawing.Size(60, 25);
            this.editReserv.TabIndex = 28;
            this.editReserv.Text = "EDIT";
            this.editReserv.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 325);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addReserv
            // 
            this.addReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReserv.Location = new System.Drawing.Point(12, 311);
            this.addReserv.Name = "addReserv";
            this.addReserv.Size = new System.Drawing.Size(133, 25);
            this.addReserv.TabIndex = 26;
            this.addReserv.Text = "Add Reservation";
            this.addReserv.UseVisualStyleBackColor = true;
            this.addReserv.Click += new System.EventHandler(this.addReserv_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(137, 107);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientId.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client ID";
            // 
            // roomType
            // 
            this.roomType.FormattingEnabled = true;
            this.roomType.Location = new System.Drawing.Point(137, 143);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(121, 21);
            this.roomType.TabIndex = 30;
            this.roomType.SelectedIndexChanged += new System.EventHandler(this.roomType_SelectedIndexChanged);
            // 
            // roomNumber
            // 
            this.roomNumber.FormattingEnabled = true;
            this.roomNumber.Location = new System.Drawing.Point(137, 178);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(121, 21);
            this.roomNumber.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 216);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 6, 21, 20, 47, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date Out ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 252);
            this.dateTimePicker2.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 34;
            this.dateTimePicker2.Value = new System.DateTime(2019, 12, 6, 21, 20, 47, 0);
            // 
            // reservides
            // 
            this.reservides.Location = new System.Drawing.Point(137, 72);
            this.reservides.Name = "reservides";
            this.reservides.ReadOnly = true;
            this.reservides.Size = new System.Drawing.Size(100, 20);
            this.reservides.TabIndex = 36;
            // 
            // reservid
            // 
            this.reservid.AutoSize = true;
            this.reservid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservid.Location = new System.Drawing.Point(41, 77);
            this.reservid.Name = "reservid";
            this.reservid.Size = new System.Drawing.Size(77, 16);
            this.reservid.TabIndex = 35;
            this.reservid.Text = "Reserv ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(33, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 51);
            this.panel1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(211, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manage Reservations";
            // 
            // ManageReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(858, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reservides);
            this.Controls.Add(this.reservid);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.deleteReserv);
            this.Controls.Add(this.editReserv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addReserv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ManageReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageReservationForm";
            this.Load += new System.EventHandler(this.ManageReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteReserv;
        private System.Windows.Forms.Button editReserv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addReserv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.ComboBox roomNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox reservides;
        private System.Windows.Forms.Label reservid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}