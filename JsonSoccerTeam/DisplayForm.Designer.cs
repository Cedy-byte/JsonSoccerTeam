namespace JsonSoccerTeam
{
    partial class DisplayForm
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
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.rtbSelectedPlayers = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(49, 44);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(199, 132);
            this.lbPlayers.TabIndex = 0;
            // 
            // rtbSelectedPlayers
            // 
            this.rtbSelectedPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSelectedPlayers.Location = new System.Drawing.Point(287, 44);
            this.rtbSelectedPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSelectedPlayers.Name = "rtbSelectedPlayers";
            this.rtbSelectedPlayers.Size = new System.Drawing.Size(210, 147);
            this.rtbSelectedPlayers.TabIndex = 1;
            this.rtbSelectedPlayers.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(88, 199);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbSelectedPlayers);
            this.Controls.Add(this.lbPlayers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.RichTextBox rtbSelectedPlayers;
        private System.Windows.Forms.Button btnAdd;
    }
}

