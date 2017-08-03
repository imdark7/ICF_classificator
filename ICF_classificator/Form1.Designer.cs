namespace ICF_classificator
{
    partial class MainForm
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
            this.listBox2 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox3 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox4 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox5 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox1 = new ICF_classificator.Extensions.ListBoxExtension();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(187, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(134, 199);
            this.listBox2.TabIndex = 0;
            this.listBox2.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(327, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(134, 199);
            this.listBox3.TabIndex = 0;
            this.listBox3.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(467, 29);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(134, 199);
            this.listBox4.TabIndex = 0;
            this.listBox4.Visible = false;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(607, 29);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(134, 199);
            this.listBox5.TabIndex = 0;
            this.listBox5.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 174);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 649);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Name = "MainForm";
            this.Text = "ICF Classificator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Extensions.ListBoxExtension listBox2;
        private Extensions.ListBoxExtension listBox3;
        private Extensions.ListBoxExtension listBox4;
        private Extensions.ListBoxExtension listBox5;
        private Extensions.ListBoxExtension listBox1;
    }
}

