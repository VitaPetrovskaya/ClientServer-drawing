namespace Client
{
    partial class Client
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
            this.pictureBoxClient = new System.Windows.Forms.PictureBox();
            this.buttonDrawClient = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelConnection = new System.Windows.Forms.Label();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClient
            // 
            this.pictureBoxClient.BackColor = System.Drawing.Color.White;
            this.pictureBoxClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxClient.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxClient.Name = "pictureBoxClient";
            this.pictureBoxClient.Size = new System.Drawing.Size(635, 479);
            this.pictureBoxClient.TabIndex = 0;
            this.pictureBoxClient.TabStop = false;
            this.pictureBoxClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClient_MouseDown);
            this.pictureBoxClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClient_MouseMove);
            this.pictureBoxClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClient_MouseUp);
            // 
            // buttonDrawClient
            // 
            this.buttonDrawClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonDrawClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawClient.Location = new System.Drawing.Point(681, 106);
            this.buttonDrawClient.Name = "buttonDrawClient";
            this.buttonDrawClient.Size = new System.Drawing.Size(148, 53);
            this.buttonDrawClient.TabIndex = 1;
            this.buttonDrawClient.Text = "Draw";
            this.buttonDrawClient.UseVisualStyleBackColor = false;
            this.buttonDrawClient.Click += new System.EventHandler(this.buttonDrawClient_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.BackColor = System.Drawing.Color.Transparent;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.ForeColor = System.Drawing.Color.Orange;
            this.labelConnect.Location = new System.Drawing.Point(676, 54);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(154, 26);
            this.labelConnect.TabIndex = 2;
            this.labelConnect.Text = "Tap to connect";
            this.labelConnect.Click += new System.EventHandler(this.labelConnect_Click);
            this.labelConnect.MouseEnter += new System.EventHandler(this.labelConnect_MouseEnter);
            this.labelConnect.MouseLeave += new System.EventHandler(this.labelConnect_MouseLeave);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(681, 165);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(148, 53);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(714, 383);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(90, 20);
            this.labelConnection.TabIndex = 6;
            this.labelConnection.Text = "Connection";
            // 
            // textBox_Receive
            // 
            this.textBox_Receive.Location = new System.Drawing.Point(671, 241);
            this.textBox_Receive.Multiline = true;
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.Size = new System.Drawing.Size(176, 139);
            this.textBox_Receive.TabIndex = 7;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(874, 479);
            this.Controls.Add(this.textBox_Receive);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonDrawClient);
            this.Controls.Add(this.pictureBoxClient);
            this.Name = "Client";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClient;
        private System.Windows.Forms.Button buttonDrawClient;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.TextBox textBox_Receive;
    }
}

