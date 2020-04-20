namespace SkladSUBD
{
    partial class fKlienti
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameklientaLabel;
            System.Windows.Forms.Label gorodLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label domLabel;
            System.Windows.Forms.Label innLabel;
            System.Windows.Forms.Label bikLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label primechanieLabel;
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.bsКлиенты = new System.Windows.Forms.BindingSource(this.components);
            this.bsРасход = new System.Windows.Forms.BindingSource(this.components);
            this.klientiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.KlientiTableAdapter();
            this.rashodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.RashodTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameklientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.primechanieTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.bikTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.nameklientaTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bDelCurrent = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            nameklientaLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            bikLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            primechanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsКлиенты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameklientaLabel
            // 
            nameklientaLabel.AutoSize = true;
            nameklientaLabel.Location = new System.Drawing.Point(6, 16);
            nameklientaLabel.Name = "nameklientaLabel";
            nameklientaLabel.Size = new System.Drawing.Size(130, 13);
            nameklientaLabel.TabIndex = 0;
            nameklientaLabel.Text = "Наименование клиента:";
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(6, 61);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(40, 13);
            gorodLabel.TabIndex = 2;
            gorodLabel.Text = "Город:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(6, 87);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(42, 13);
            ulicaLabel.TabIndex = 4;
            ulicaLabel.Text = "Улица:";
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(239, 87);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(33, 13);
            domLabel.TabIndex = 6;
            domLabel.Text = "Дом:";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new System.Drawing.Point(6, 115);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(34, 13);
            innLabel.TabIndex = 8;
            innLabel.Text = "ИНН:";
            // 
            // bikLabel
            // 
            bikLabel.AutoSize = true;
            bikLabel.Location = new System.Drawing.Point(196, 113);
            bikLabel.Name = "bikLabel";
            bikLabel.Size = new System.Drawing.Size(32, 13);
            bikLabel.TabIndex = 10;
            bikLabel.Text = "БИК:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(6, 142);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(55, 13);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Телефон:";
            // 
            // primechanieLabel
            // 
            primechanieLabel.AutoSize = true;
            primechanieLabel.Location = new System.Drawing.Point(6, 174);
            primechanieLabel.Name = "primechanieLabel";
            primechanieLabel.Size = new System.Drawing.Size(73, 13);
            primechanieLabel.TabIndex = 14;
            primechanieLabel.Text = "Примечание:";
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsКлиенты
            // 
            this.bsКлиенты.DataMember = "Klienti";
            this.bsКлиенты.DataSource = this.skladDataSet1;
            // 
            // bsРасход
            // 
            this.bsРасход.DataMember = "KlientiRashod";
            this.bsРасход.DataSource = this.bsКлиенты;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameklientaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsКлиенты;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameklientaDataGridViewTextBoxColumn
            // 
            this.nameklientaDataGridViewTextBoxColumn.DataPropertyName = "nameklienta";
            this.nameklientaDataGridViewTextBoxColumn.HeaderText = "Список клиентов";
            this.nameklientaDataGridViewTextBoxColumn.Name = "nameklientaDataGridViewTextBoxColumn";
            this.nameklientaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameklientaDataGridViewTextBoxColumn.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDelCurrent);
            this.groupBox1.Controls.Add(this.bAddNew);
            this.groupBox1.Controls.Add(primechanieLabel);
            this.groupBox1.Controls.Add(this.primechanieTextBox);
            this.groupBox1.Controls.Add(telefonLabel);
            this.groupBox1.Controls.Add(this.telefonTextBox);
            this.groupBox1.Controls.Add(bikLabel);
            this.groupBox1.Controls.Add(this.bikTextBox);
            this.groupBox1.Controls.Add(innLabel);
            this.groupBox1.Controls.Add(this.innTextBox);
            this.groupBox1.Controls.Add(domLabel);
            this.groupBox1.Controls.Add(this.domTextBox);
            this.groupBox1.Controls.Add(ulicaLabel);
            this.groupBox1.Controls.Add(this.ulicaTextBox);
            this.groupBox1.Controls.Add(gorodLabel);
            this.groupBox1.Controls.Add(this.gorodTextBox);
            this.groupBox1.Controls.Add(nameklientaLabel);
            this.groupBox1.Controls.Add(this.nameklientaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(262, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // primechanieTextBox
            // 
            this.primechanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "primechanie", true));
            this.primechanieTextBox.Location = new System.Drawing.Point(85, 171);
            this.primechanieTextBox.Name = "primechanieTextBox";
            this.primechanieTextBox.Size = new System.Drawing.Size(280, 20);
            this.primechanieTextBox.TabIndex = 15;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(67, 139);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(185, 20);
            this.telefonTextBox.TabIndex = 13;
            // 
            // bikTextBox
            // 
            this.bikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "bik", true));
            this.bikTextBox.Location = new System.Drawing.Point(234, 110);
            this.bikTextBox.Name = "bikTextBox";
            this.bikTextBox.Size = new System.Drawing.Size(131, 20);
            this.bikTextBox.TabIndex = 11;
            // 
            // innTextBox
            // 
            this.innTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "inn", true));
            this.innTextBox.Location = new System.Drawing.Point(46, 110);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(144, 20);
            this.innTextBox.TabIndex = 9;
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "dom", true));
            this.domTextBox.Location = new System.Drawing.Point(278, 84);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(87, 20);
            this.domTextBox.TabIndex = 7;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(49, 84);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(184, 20);
            this.ulicaTextBox.TabIndex = 5;
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(49, 58);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(316, 20);
            this.gorodTextBox.TabIndex = 3;
            // 
            // nameklientaTextBox
            // 
            this.nameklientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиенты, "nameklienta", true));
            this.nameklientaTextBox.Location = new System.Drawing.Point(6, 32);
            this.nameklientaTextBox.Name = "nameklientaTextBox";
            this.nameklientaTextBox.Size = new System.Drawing.Size(359, 20);
            this.nameklientaTextBox.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientiTableAdapter = this.klientiTableAdapter;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.PrihodTableAdapter = null;
            this.tableAdapterManager.RashodTableAdapter = this.rashodTableAdapter;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.TovariTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(6, 234);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(150, 23);
            this.bAddNew.TabIndex = 16;
            this.bAddNew.Text = "Добавить нового клиента";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bDelCurrent
            // 
            this.bDelCurrent.Location = new System.Drawing.Point(215, 234);
            this.bDelCurrent.Name = "bDelCurrent";
            this.bDelCurrent.Size = new System.Drawing.Size(150, 23);
            this.bDelCurrent.TabIndex = 17;
            this.bDelCurrent.Text = "Удалить этого клиента";
            this.bDelCurrent.UseVisualStyleBackColor = true;
            this.bDelCurrent.Click += new System.EventHandler(this.bDelCurrent_Click);
            // 
            // bSave
            // 
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Location = new System.Drawing.Point(25, 298);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(134, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Location = new System.Drawing.Point(501, 298);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(134, 23);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Отмена";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // fKlienti
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(659, 333);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fKlienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.fKlienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsКлиенты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsКлиенты;
        private System.Windows.Forms.BindingSource bsРасход;
        private SkladDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private SkladDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameklientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox primechanieTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox bikTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox domTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.TextBox nameklientaTextBox;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bDelCurrent;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClose;
    }
}