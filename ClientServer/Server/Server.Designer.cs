namespace Server
{
    partial class Server
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxServer = new System.Windows.Forms.PictureBox();
            this.buttonDrawServer = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelConnection = new System.Windows.Forms.Label();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxServer
            // 
            this.pictureBoxServer.BackColor = System.Drawing.Color.White;
            this.pictureBoxServer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxServer.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxServer.Name = "pictureBoxServer";
            this.pictureBoxServer.Size = new System.Drawing.Size(635, 479);
            this.pictureBoxServer.TabIndex = 0;
            this.pictureBoxServer.TabStop = false;
            this.pictureBoxServer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxServer_MouseDown);
            this.pictureBoxServer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxServer_MouseMove);
            this.pictureBoxServer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxServer_MouseUp);
            // 
            // buttonDrawServer
            // 
            this.buttonDrawServer.BackColor = System.Drawing.Color.Transparent;
            this.buttonDrawServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawServer.Location = new System.Drawing.Point(685, 106);
            this.buttonDrawServer.Name = "buttonDrawServer";
            this.buttonDrawServer.Size = new System.Drawing.Size(148, 53);
            this.buttonDrawServer.TabIndex = 2;
            this.buttonDrawServer.Text = "Draw";
            this.buttonDrawServer.UseVisualStyleBackColor = false;
            this.buttonDrawServer.Click += new System.EventHandler(this.buttonDrawServer_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.Color.Orange;
            this.labelStart.Location = new System.Drawing.Point(696, 53);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(120, 26);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Tap to start";
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            this.labelStart.MouseEnter += new System.EventHandler(this.labelStart_MouseEnter);
            this.labelStart.MouseLeave += new System.EventHandler(this.labelStart_MouseLeave);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(685, 165);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(148, 53);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(719, 386);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(90, 20);
            this.labelConnection.TabIndex = 5;
            this.labelConnection.Text = "Connection";
            // 
            // textBox_Receive
            // 
            this.textBox_Receive.Location = new System.Drawing.Point(673, 242);
            this.textBox_Receive.Multiline = true;
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.Size = new System.Drawing.Size(171, 141);
            this.textBox_Receive.TabIndex = 6;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(874, 479);
            this.Controls.Add(this.textBox_Receive);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.buttonDrawServer);
            this.Controls.Add(this.pictureBoxServer);
            this.Name = "Server";
            this.Text = "FormServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxServer;
        private System.Windows.Forms.Button buttonDrawServer;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.TextBox textBox_Receive;
    }
}

