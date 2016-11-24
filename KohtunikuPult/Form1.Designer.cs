namespace KohtunikuPult {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pingButton = new System.Windows.Forms.Button();
            this.robotA = new System.Windows.Forms.Label();
            this.robotB = new System.Windows.Forms.Label();
            this.robotC = new System.Windows.Forms.Label();
            this.robotD = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Label();
            this.timerResetButton = new System.Windows.Forms.Button();
            this.timeUpdateTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(12, 12);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(229, 21);
            this.comPort.TabIndex = 0;
            this.comPort.SelectedIndexChanged += new System.EventHandler(this.comPort_SelectedIndexChanged);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dataTextBox.Location = new System.Drawing.Point(12, 39);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(448, 139);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(357, 254);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(103, 30);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 254);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 30);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(120, 254);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(102, 30);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Location = new System.Drawing.Point(47, 184);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(121, 21);
            this.fieldComboBox.TabIndex = 5;
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(216, 184);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(121, 21);
            this.teamComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Robot";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(228, 254);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 30);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(343, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(385, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(12, 225);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(448, 23);
            this.pingButton.TabIndex = 7;
            this.pingButton.Text = "PING";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // robotA
            // 
            this.robotA.AutoSize = true;
            this.robotA.BackColor = System.Drawing.SystemColors.Control;
            this.robotA.Location = new System.Drawing.Point(12, 209);
            this.robotA.Name = "robotA";
            this.robotA.Size = new System.Drawing.Size(14, 13);
            this.robotA.TabIndex = 8;
            this.robotA.Text = "A";
            // 
            // robotB
            // 
            this.robotB.AutoSize = true;
            this.robotB.Location = new System.Drawing.Point(32, 209);
            this.robotB.Name = "robotB";
            this.robotB.Size = new System.Drawing.Size(14, 13);
            this.robotB.TabIndex = 9;
            this.robotB.Text = "B";
            // 
            // robotC
            // 
            this.robotC.AutoSize = true;
            this.robotC.Location = new System.Drawing.Point(52, 209);
            this.robotC.Name = "robotC";
            this.robotC.Size = new System.Drawing.Size(14, 13);
            this.robotC.TabIndex = 9;
            this.robotC.Text = "C";
            // 
            // robotD
            // 
            this.robotD.AutoSize = true;
            this.robotD.Location = new System.Drawing.Point(72, 209);
            this.robotD.Name = "robotD";
            this.robotD.Size = new System.Drawing.Size(15, 13);
            this.robotD.TabIndex = 9;
            this.robotD.Text = "D";
            // 
            // timerTime
            // 
            this.timerTime.AutoSize = true;
            this.timerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.timerTime.Location = new System.Drawing.Point(402, 13);
            this.timerTime.Name = "timerTime";
            this.timerTime.Size = new System.Drawing.Size(40, 20);
            this.timerTime.TabIndex = 10;
            this.timerTime.Text = "00,0";
            // 
            // timerResetButton
            // 
            this.timerResetButton.Location = new System.Drawing.Point(321, 12);
            this.timerResetButton.Name = "timerResetButton";
            this.timerResetButton.Size = new System.Drawing.Size(75, 23);
            this.timerResetButton.TabIndex = 11;
            this.timerResetButton.Text = "Reset";
            this.timerResetButton.UseVisualStyleBackColor = true;
            this.timerResetButton.Click += new System.EventHandler(this.timerResetButton_Click);
            // 
            // timeUpdateTick
            // 
            this.timeUpdateTick.Tick += new System.EventHandler(this.timeUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 296);
            this.Controls.Add(this.timerResetButton);
            this.Controls.Add(this.timerTime);
            this.Controls.Add(this.robotD);
            this.Controls.Add(this.robotC);
            this.Controls.Add(this.robotB);
            this.Controls.Add(this.robotA);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.fieldComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.comPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Label robotA;
        private System.Windows.Forms.Label robotB;
        private System.Windows.Forms.Label robotC;
        private System.Windows.Forms.Label robotD;
        private System.Windows.Forms.Label timerTime;
        private System.Windows.Forms.Button timerResetButton;
        private System.Windows.Forms.Timer timeUpdateTick;
    }
}

