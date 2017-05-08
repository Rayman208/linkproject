namespace Linker
{
    partial class Form1
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
            this.dataGridViewLinks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGetAllLinks = new System.Windows.Forms.Button();
            this.buttonDeleteChoosenLink = new System.Windows.Forms.Button();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxUrl = new System.Windows.Forms.CheckBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddLink = new System.Windows.Forms.Button();
            this.buttonClearInputs = new System.Windows.Forms.Button();
            this.buttoUpdateLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLinks
            // 
            this.dataGridViewLinks.AllowUserToAddRows = false;
            this.dataGridViewLinks.AllowUserToDeleteRows = false;
            this.dataGridViewLinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewLinks.Location = new System.Drawing.Point(13, 42);
            this.dataGridViewLinks.MultiSelect = false;
            this.dataGridViewLinks.Name = "dataGridViewLinks";
            this.dataGridViewLinks.ReadOnly = true;
            this.dataGridViewLinks.Size = new System.Drawing.Size(707, 150);
            this.dataGridViewLinks.TabIndex = 0;
            this.dataGridViewLinks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLinks_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "url";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // buttonGetAllLinks
            // 
            this.buttonGetAllLinks.Location = new System.Drawing.Point(13, 13);
            this.buttonGetAllLinks.Name = "buttonGetAllLinks";
            this.buttonGetAllLinks.Size = new System.Drawing.Size(707, 23);
            this.buttonGetAllLinks.TabIndex = 1;
            this.buttonGetAllLinks.Text = "Загрузить список ссылок";
            this.buttonGetAllLinks.UseVisualStyleBackColor = true;
            this.buttonGetAllLinks.Click += new System.EventHandler(this.buttonGetAllLinks_Click);
            // 
            // buttonDeleteChoosenLink
            // 
            this.buttonDeleteChoosenLink.Location = new System.Drawing.Point(13, 199);
            this.buttonDeleteChoosenLink.Name = "buttonDeleteChoosenLink";
            this.buttonDeleteChoosenLink.Size = new System.Drawing.Size(707, 23);
            this.buttonDeleteChoosenLink.TabIndex = 2;
            this.buttonDeleteChoosenLink.Text = "Удалить выбранную ссылку";
            this.buttonDeleteChoosenLink.UseVisualStyleBackColor = true;
            this.buttonDeleteChoosenLink.Click += new System.EventHandler(this.buttonDeleteChoosenLink_Click);
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.Location = new System.Drawing.Point(159, 226);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(168, 20);
            this.textBoxSearchText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите текст для поиска";
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(333, 228);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(52, 17);
            this.checkBoxName.TabIndex = 5;
            this.checkBoxName.Text = "name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxUrl
            // 
            this.checkBoxUrl.AutoSize = true;
            this.checkBoxUrl.Location = new System.Drawing.Point(391, 229);
            this.checkBoxUrl.Name = "checkBoxUrl";
            this.checkBoxUrl.Size = new System.Drawing.Size(37, 17);
            this.checkBoxUrl.TabIndex = 5;
            this.checkBoxUrl.Text = "url";
            this.checkBoxUrl.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Location = new System.Drawing.Point(434, 229);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(77, 17);
            this.checkBoxDescription.TabIndex = 5;
            this.checkBoxDescription.Text = "description";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(567, 229);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(648, 229);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(16, 286);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(33, 20);
            this.textBoxId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(55, 286);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "url";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(208, 286);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(268, 20);
            this.textBoxUrl.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "decription";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(482, 286);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(241, 20);
            this.textBoxDescription.TabIndex = 9;
            // 
            // buttonAddLink
            // 
            this.buttonAddLink.Location = new System.Drawing.Point(16, 313);
            this.buttonAddLink.Name = "buttonAddLink";
            this.buttonAddLink.Size = new System.Drawing.Size(707, 23);
            this.buttonAddLink.TabIndex = 10;
            this.buttonAddLink.Text = "Добавить ссылку";
            this.buttonAddLink.UseVisualStyleBackColor = true;
            this.buttonAddLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // buttonClearInputs
            // 
            this.buttonClearInputs.Location = new System.Drawing.Point(16, 343);
            this.buttonClearInputs.Name = "buttonClearInputs";
            this.buttonClearInputs.Size = new System.Drawing.Size(707, 23);
            this.buttonClearInputs.TabIndex = 11;
            this.buttonClearInputs.Text = "Очистить поля ввода";
            this.buttonClearInputs.UseVisualStyleBackColor = true;
            this.buttonClearInputs.Click += new System.EventHandler(this.buttonClearInputs_Click);
            // 
            // buttoUpdateLink
            // 
            this.buttoUpdateLink.Location = new System.Drawing.Point(16, 373);
            this.buttoUpdateLink.Name = "buttoUpdateLink";
            this.buttoUpdateLink.Size = new System.Drawing.Size(707, 23);
            this.buttoUpdateLink.TabIndex = 12;
            this.buttoUpdateLink.Text = "Обновить ссылку";
            this.buttoUpdateLink.UseVisualStyleBackColor = true;
            this.buttoUpdateLink.Click += new System.EventHandler(this.buttoUpdateLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 451);
            this.Controls.Add(this.buttoUpdateLink);
            this.Controls.Add(this.buttonClearInputs);
            this.Controls.Add(this.buttonAddLink);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxDescription);
            this.Controls.Add(this.checkBoxUrl);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchText);
            this.Controls.Add(this.buttonDeleteChoosenLink);
            this.Controls.Add(this.buttonGetAllLinks);
            this.Controls.Add(this.dataGridViewLinks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonGetAllLinks;
        private System.Windows.Forms.Button buttonDeleteChoosenLink;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddLink;
        private System.Windows.Forms.Button buttonClearInputs;
        private System.Windows.Forms.Button buttoUpdateLink;
    }
}

