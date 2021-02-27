namespace WindowsFormsApp18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.report1 = new FastReport.Report();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleDataSet = new WindowsFormsApp18.PeopleDataSet();
            this.nosologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosologyTableAdapter = new WindowsFormsApp18.PeopleDataSetTableAdapters.NosologyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosologyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nosologyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // peopleDataSet
            // 
            this.peopleDataSet.DataSetName = "PeopleDataSet";
            this.peopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nosologyBindingSource
            // 
            this.nosologyBindingSource.DataMember = "Nosology";
            this.nosologyBindingSource.DataSource = this.peopleDataSet;
            // 
            // nosologyTableAdapter
            // 
            this.nosologyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosologyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Report report1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PeopleDataSet peopleDataSet;
        private System.Windows.Forms.BindingSource nosologyBindingSource;
        private PeopleDataSetTableAdapters.NosologyTableAdapter nosologyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
    }
}

