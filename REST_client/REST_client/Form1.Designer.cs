namespace REST_client
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetAll_btn = new System.Windows.Forms.Button();
            this.GetGameById_btn = new System.Windows.Forms.Button();
            this.get_game_by_id_numeric = new System.Windows.Forms.NumericUpDown();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.delete_id_numeric = new System.Windows.Forms.NumericUpDown();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.publisher_tb = new System.Windows.Forms.TextBox();
            this.title_update_tb = new System.Windows.Forms.TextBox();
            this.insert_price_numeric = new System.Windows.Forms.NumericUpDown();
            this.publisher_update_tb = new System.Windows.Forms.TextBox();
            this.price_update_numeric = new System.Windows.Forms.NumericUpDown();
            this.id_update_numeric = new System.Windows.Forms.NumericUpDown();
            this.authKeyBox = new System.Windows.Forms.TextBox();
            this.authKeyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.get_game_by_id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_price_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_update_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_update_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(497, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 420);
            this.listBox1.TabIndex = 0;
            // 
            // GetAll_btn
            // 
            this.GetAll_btn.Location = new System.Drawing.Point(38, 48);
            this.GetAll_btn.Name = "GetAll_btn";
            this.GetAll_btn.Size = new System.Drawing.Size(196, 53);
            this.GetAll_btn.TabIndex = 1;
            this.GetAll_btn.Text = "Get All Videogames";
            this.GetAll_btn.UseVisualStyleBackColor = true;
            this.GetAll_btn.Click += new System.EventHandler(this.GetAll_btn_Click);
            // 
            // GetGameById_btn
            // 
            this.GetGameById_btn.Location = new System.Drawing.Point(38, 123);
            this.GetGameById_btn.Name = "GetGameById_btn";
            this.GetGameById_btn.Size = new System.Drawing.Size(196, 55);
            this.GetGameById_btn.TabIndex = 2;
            this.GetGameById_btn.Text = "Get Videogame By Id";
            this.GetGameById_btn.UseVisualStyleBackColor = true;
            this.GetGameById_btn.Click += new System.EventHandler(this.GetGameById_btn_Click);
            // 
            // get_game_by_id_numeric
            // 
            this.get_game_by_id_numeric.Location = new System.Drawing.Point(265, 142);
            this.get_game_by_id_numeric.Name = "get_game_by_id_numeric";
            this.get_game_by_id_numeric.Size = new System.Drawing.Size(106, 20);
            this.get_game_by_id_numeric.TabIndex = 3;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(38, 202);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(196, 55);
            this.Delete_btn.TabIndex = 4;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(38, 293);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(196, 55);
            this.Insert_btn.TabIndex = 5;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(38, 417);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(196, 55);
            this.Update_btn.TabIndex = 6;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // delete_id_numeric
            // 
            this.delete_id_numeric.Location = new System.Drawing.Point(265, 221);
            this.delete_id_numeric.Name = "delete_id_numeric";
            this.delete_id_numeric.Size = new System.Drawing.Size(106, 20);
            this.delete_id_numeric.TabIndex = 7;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(360, 293);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(100, 20);
            this.title_tb.TabIndex = 8;
            // 
            // publisher_tb
            // 
            this.publisher_tb.Location = new System.Drawing.Point(360, 319);
            this.publisher_tb.Name = "publisher_tb";
            this.publisher_tb.Size = new System.Drawing.Size(100, 20);
            this.publisher_tb.TabIndex = 9;
            // 
            // title_update_tb
            // 
            this.title_update_tb.Location = new System.Drawing.Point(360, 435);
            this.title_update_tb.Name = "title_update_tb";
            this.title_update_tb.Size = new System.Drawing.Size(100, 20);
            this.title_update_tb.TabIndex = 10;
            // 
            // insert_price_numeric
            // 
            this.insert_price_numeric.Location = new System.Drawing.Point(360, 346);
            this.insert_price_numeric.Name = "insert_price_numeric";
            this.insert_price_numeric.Size = new System.Drawing.Size(100, 20);
            this.insert_price_numeric.TabIndex = 11;
            // 
            // publisher_update_tb
            // 
            this.publisher_update_tb.Location = new System.Drawing.Point(360, 461);
            this.publisher_update_tb.Name = "publisher_update_tb";
            this.publisher_update_tb.Size = new System.Drawing.Size(100, 20);
            this.publisher_update_tb.TabIndex = 12;
            // 
            // price_update_numeric
            // 
            this.price_update_numeric.Location = new System.Drawing.Point(360, 487);
            this.price_update_numeric.Name = "price_update_numeric";
            this.price_update_numeric.Size = new System.Drawing.Size(100, 20);
            this.price_update_numeric.TabIndex = 13;
            // 
            // id_update_numeric
            // 
            this.id_update_numeric.Location = new System.Drawing.Point(360, 409);
            this.id_update_numeric.Name = "id_update_numeric";
            this.id_update_numeric.Size = new System.Drawing.Size(100, 20);
            this.id_update_numeric.TabIndex = 14;
            // 
            // authKeyBox
            // 
            this.authKeyBox.Location = new System.Drawing.Point(265, 568);
            this.authKeyBox.Name = "authKeyBox";
            this.authKeyBox.Size = new System.Drawing.Size(195, 20);
            this.authKeyBox.TabIndex = 15;
            // 
            // authKeyLabel
            // 
            this.authKeyLabel.AutoSize = true;
            this.authKeyLabel.Location = new System.Drawing.Point(206, 571);
            this.authKeyLabel.Name = "authKeyLabel";
            this.authKeyLabel.Size = new System.Drawing.Size(53, 13);
            this.authKeyLabel.TabIndex = 16;
            this.authKeyLabel.Text = "Auth Key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.authKeyLabel);
            this.Controls.Add(this.authKeyBox);
            this.Controls.Add(this.id_update_numeric);
            this.Controls.Add(this.price_update_numeric);
            this.Controls.Add(this.publisher_update_tb);
            this.Controls.Add(this.insert_price_numeric);
            this.Controls.Add(this.title_update_tb);
            this.Controls.Add(this.publisher_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.delete_id_numeric);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.get_game_by_id_numeric);
            this.Controls.Add(this.GetGameById_btn);
            this.Controls.Add(this.GetAll_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.get_game_by_id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_price_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_update_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_update_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GetAll_btn;
        private System.Windows.Forms.Button GetGameById_btn;
        private System.Windows.Forms.NumericUpDown get_game_by_id_numeric;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.NumericUpDown delete_id_numeric;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox publisher_tb;
        private System.Windows.Forms.TextBox title_update_tb;
        private System.Windows.Forms.NumericUpDown insert_price_numeric;
        private System.Windows.Forms.TextBox publisher_update_tb;
        private System.Windows.Forms.NumericUpDown price_update_numeric;
        private System.Windows.Forms.NumericUpDown id_update_numeric;
        private System.Windows.Forms.TextBox authKeyBox;
        private System.Windows.Forms.Label authKeyLabel;
    }
}

