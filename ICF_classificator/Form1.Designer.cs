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
            this.listBox6 = new ICF_classificator.Extensions.ListBoxExtension();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(187, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(271, 173);
            this.listBox2.TabIndex = 0;
            this.listBox2.Visible = false;
            this.listBox2.SelectedValueChanged += new System.EventHandler(this.listBox2_SelectedValueChanged);
            // 
            // listBox3
            // 
            this.listBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(464, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(241, 173);
            this.listBox3.TabIndex = 0;
            this.listBox3.Visible = false;
            this.listBox3.SelectedValueChanged += new System.EventHandler(this.listBox3_SelectedValueChanged);
            // 
            // listBox4
            // 
            this.listBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(711, 29);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(234, 173);
            this.listBox4.TabIndex = 0;
            this.listBox4.Visible = false;
            this.listBox4.SelectedValueChanged += new System.EventHandler(this.listBox4_SelectedValueChanged);
            // 
            // listBox5
            // 
            this.listBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(951, 29);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(229, 173);
            this.listBox5.TabIndex = 0;
            this.listBox5.Visible = false;
            this.listBox5.SelectedValueChanged += new System.EventHandler(this.listBox5_SelectedValueChanged);
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
            // listBox6
            // 
            this.listBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(1186, 29);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(229, 173);
            this.listBox6.TabIndex = 3;
            this.listBox6.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1491, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентаToolStripMenuItem,
            this.врачаToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить...";
            // 
            // пациентаToolStripMenuItem
            // 
            this.пациентаToolStripMenuItem.Name = "пациентаToolStripMenuItem";
            this.пациентаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пациентаToolStripMenuItem.Text = "Пациента";
            this.пациентаToolStripMenuItem.Click += new System.EventHandler(this.пациентаToolStripMenuItem_Click);
            // 
            // врачаToolStripMenuItem
            // 
            this.врачаToolStripMenuItem.Name = "врачаToolStripMenuItem";
            this.врачаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.врачаToolStripMenuItem.Text = "Врача";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 649);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ICF Classificator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Extensions.ListBoxExtension listBox2;
        private Extensions.ListBoxExtension listBox3;
        private Extensions.ListBoxExtension listBox4;
        private Extensions.ListBoxExtension listBox5;
        private Extensions.ListBoxExtension listBox1;
        private Extensions.ListBoxExtension listBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem врачаToolStripMenuItem;
    }
}

