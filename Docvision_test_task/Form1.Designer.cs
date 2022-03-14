namespace Docvision_test_task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAddressee = new System.Windows.Forms.Label();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddressee = new System.Windows.Forms.TextBox();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTags = new System.Windows.Forms.Label();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.labelTagInstriction = new System.Windows.Forms.Label();
            this.buttonClearGrid = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonAutoId = new System.Windows.Forms.Button();
            this.buttonEditLetter = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(85, 40);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "id";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя письма";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(66, 107);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата";
            // 
            // labelAddressee
            // 
            this.labelAddressee.AutoSize = true;
            this.labelAddressee.Location = new System.Drawing.Point(42, 150);
            this.labelAddressee.Name = "labelAddressee";
            this.labelAddressee.Size = new System.Drawing.Size(65, 20);
            this.labelAddressee.TabIndex = 3;
            this.labelAddressee.Text = "Адресат";
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(12, 196);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(99, 20);
            this.labelSender.TabIndex = 4;
            this.labelSender.Text = "Отправитель";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(14, 245);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(97, 20);
            this.labelContent.TabIndex = 5;
            this.labelContent.Text = "Содержание";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(129, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(181, 27);
            this.textBoxId.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(129, 107);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(181, 27);
            this.dateTimePicker.TabIndex = 9;
            // 
            // textBoxAddressee
            // 
            this.textBoxAddressee.Location = new System.Drawing.Point(129, 147);
            this.textBoxAddressee.Name = "textBoxAddressee";
            this.textBoxAddressee.Size = new System.Drawing.Size(181, 27);
            this.textBoxAddressee.TabIndex = 10;
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(129, 193);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(181, 27);
            this.textBoxSender.TabIndex = 11;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(129, 242);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(181, 224);
            this.textBoxContent.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(767, 370);
            this.dataGridView1.TabIndex = 13;
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(23, 481);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(39, 20);
            this.labelTags.TabIndex = 15;
            this.labelTags.Text = "Тэги";
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(129, 481);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(181, 27);
            this.textBoxTags.TabIndex = 16;
            // 
            // labelTagInstriction
            // 
            this.labelTagInstriction.AutoSize = true;
            this.labelTagInstriction.Location = new System.Drawing.Point(23, 534);
            this.labelTagInstriction.Name = "labelTagInstriction";
            this.labelTagInstriction.Size = new System.Drawing.Size(258, 20);
            this.labelTagInstriction.TabIndex = 17;
            this.labelTagInstriction.Text = "*Тэги вводить в формате \"тег1 тег2\"";
            // 
            // buttonClearGrid
            // 
            this.buttonClearGrid.Location = new System.Drawing.Point(984, 437);
            this.buttonClearGrid.Name = "buttonClearGrid";
            this.buttonClearGrid.Size = new System.Drawing.Size(144, 29);
            this.buttonClearGrid.TabIndex = 18;
            this.buttonClearGrid.Text = "Очистить таблицу";
            this.buttonClearGrid.UseVisualStyleBackColor = true;
            this.buttonClearGrid.Click += new System.EventHandler(this.buttonClearGrid_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(673, 481);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(144, 29);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(361, 437);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 29);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить письмо";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(361, 481);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 29);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить письмо";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(673, 437);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(165, 29);
            this.buttonShowAll.TabIndex = 22;
            this.buttonShowAll.Text = "Показать все письма";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonAutoId
            // 
            this.buttonAutoId.Location = new System.Drawing.Point(14, 577);
            this.buttonAutoId.Name = "buttonAutoId";
            this.buttonAutoId.Size = new System.Drawing.Size(94, 29);
            this.buttonAutoId.TabIndex = 24;
            this.buttonAutoId.Text = "Авто ID";
            this.buttonAutoId.UseVisualStyleBackColor = true;
            this.buttonAutoId.Click += new System.EventHandler(this.buttonAutoId_Click);
            // 
            // buttonEditLetter
            // 
            this.buttonEditLetter.Location = new System.Drawing.Point(361, 525);
            this.buttonEditLetter.Name = "buttonEditLetter";
            this.buttonEditLetter.Size = new System.Drawing.Size(188, 29);
            this.buttonEditLetter.TabIndex = 25;
            this.buttonEditLetter.Text = "Редактировать письмо";
            this.buttonEditLetter.UseVisualStyleBackColor = true;
            this.buttonEditLetter.Click += new System.EventHandler(this.buttonEditLetter_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(361, 577);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(188, 29);
            this.buttonClearFields.TabIndex = 26;
            this.buttonClearFields.Text = "Очистить поле ввода";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 652);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonEditLetter);
            this.Controls.Add(this.buttonAutoId);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClearGrid);
            this.Controls.Add(this.labelTagInstriction);
            this.Controls.Add(this.textBoxTags);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.textBoxAddressee);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.labelAddressee);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelID;
        private Label labelName;
        private Label labelDate;
        private Label labelAddressee;
        private Label labelSender;
        private Label labelContent;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxAddressee;
        private TextBox textBoxSender;
        private TextBox textBoxContent;
        private DataGridView dataGridView1;
        private Label labelTags;
        private TextBox textBoxTags;
        private Label labelTagInstriction;
        private Button buttonClearGrid;
        private Button buttonSearch;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonShowAll;
        private Button buttonAutoId;
        private Button buttonEditLetter;
        private Button buttonClearFields;
    }
}