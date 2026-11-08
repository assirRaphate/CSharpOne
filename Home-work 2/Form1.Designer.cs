namespace Home_work2
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
            this.lbldayofweek = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblnumeric = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtnumeric = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldayofweek
            // 
            this.lbldayofweek.AutoSize = true;
            this.lbldayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayofweek.Location = new System.Drawing.Point(174, 121);
            this.lbldayofweek.Name = "lbldayofweek";
            this.lbldayofweek.Size = new System.Drawing.Size(282, 29);
            this.lbldayofweek.TabIndex = 0;
            this.lbldayofweek.Text = "Enter the day of the week";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(144, 172);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(312, 29);
            this.lblmonth.TabIndex = 1;
            this.lblmonth.Text = "Enter the name of the month";
            // 
            // lblnumeric
            // 
            this.lblnumeric.AutoSize = true;
            this.lblnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeric.Location = new System.Drawing.Point(74, 224);
            this.lblnumeric.Name = "lblnumeric";
            this.lblnumeric.Size = new System.Drawing.Size(382, 29);
            this.lblnumeric.TabIndex = 2;
            this.lblnumeric.Text = "Enter the numeric day of the month";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(295, 277);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(161, 29);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Enter the year";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(79, 397);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(842, 83);
            this.lbloutput.TabIndex = 4;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(79, 520);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(233, 53);
            this.btnshow.TabIndex = 5;
            this.btnshow.Text = "Show Data";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(385, 520);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(233, 53);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(688, 520);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(233, 53);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofweek.Location = new System.Drawing.Point(474, 121);
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(447, 27);
            this.txtdayofweek.TabIndex = 8;
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(474, 179);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(447, 27);
            this.txtmonth.TabIndex = 9;
            // 
            // txtnumeric
            // 
            this.txtnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeric.Location = new System.Drawing.Point(474, 231);
            this.txtnumeric.Name = "txtnumeric";
            this.txtnumeric.Size = new System.Drawing.Size(447, 27);
            this.txtnumeric.TabIndex = 10;
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(474, 284);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(447, 27);
            this.txtyear.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 639);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnumeric);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofweek);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumeric);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lbldayofweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayofweek;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblnumeric;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtnumeric;
        private System.Windows.Forms.TextBox txtyear;
    }
}

