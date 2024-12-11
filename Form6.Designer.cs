namespace Авторизация
{
    partial class Form6
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDataSet8 = new Авторизация.DDataSet8();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dDataSet12 = new Авторизация.DDataSet12();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dDataSet11 = new Авторизация.DDataSet11();
            this.dDataSet7 = new Авторизация.DDataSet7();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material_TableAdapter = new Авторизация.DDataSet7TableAdapters.Material_TableAdapter();
            this.product_TableAdapter = new Авторизация.DDataSet8TableAdapters.Product_TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dDataSet10 = new Авторизация.DDataSet10();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.product_TableAdapter1 = new Авторизация.DDataSet10TableAdapters.Product_TableAdapter();
            this.product_TableAdapter2 = new Авторизация.DDataSet11TableAdapters.Product_TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.наименованиеПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЦехаДляПроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_TableAdapter3 = new Авторизация.DDataSet12TableAdapters.Product_TableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product$";
            this.productBindingSource.DataSource = this.dDataSet8;
            // 
            // dDataSet8
            // 
            this.dDataSet8.DataSetName = "DDataSet8";
            this.dDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Наименование продукции", true));
            this.textBox2.Location = new System.Drawing.Point(179, 419);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataMember = "Product$";
            this.productBindingSource3.DataSource = this.dDataSet12;
            // 
            // dDataSet12
            // 
            this.dDataSet12.DataSetName = "DDataSet12";
            this.dDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Минимальная стоимость для агента", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.textBox3.Location = new System.Drawing.Point(179, 482);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Тип продукции", true));
            this.textBox4.Location = new System.Drawing.Point(518, 419);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип продукции";
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product$";
            this.productBindingSource2.DataSource = this.dDataSet11;
            // 
            // dDataSet11
            // 
            this.dDataSet11.DataSetName = "DDataSet11";
            this.dDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dDataSet7
            // 
            this.dDataSet7.DataSetName = "DDataSet7";
            this.dDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material$";
            this.materialBindingSource.DataSource = this.dDataSet7;
            // 
            // material_TableAdapter
            // 
            this.material_TableAdapter.ClearBeforeFill = true;
            // 
            // product_TableAdapter
            // 
            this.product_TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dDataSet10
            // 
            this.dDataSet10.DataSetName = "DDataSet10";
            this.dDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product$";
            this.productBindingSource1.DataSource = this.dDataSet10;
            // 
            // product_TableAdapter1
            // 
            this.product_TableAdapter1.ClearBeforeFill = true;
            // 
            // product_TableAdapter2
            // 
            this.product_TableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеПродукцииDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn,
            this.idtypeDataGridViewTextBoxColumn,
            this.типПродукцииDataGridViewTextBoxColumn,
            this.количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn,
            this.номерЦехаДляПроизводстваDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1037, 367);
            this.dataGridView1.TabIndex = 10;
            // 
            // наименованиеПродукцииDataGridViewTextBoxColumn
            // 
            this.наименованиеПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Наименование продукции";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.HeaderText = "Наименование продукции";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.Name = "наименованиеПродукцииDataGridViewTextBoxColumn";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            this.артикулDataGridViewTextBoxColumn.Width = 73;
            // 
            // минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn
            // 
            this.минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn.DataPropertyName = "Минимальная стоимость для агента";
            this.минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn.HeaderText = "Минимальная стоимость для агента";
            this.минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn.Name = "минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn";
            this.минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn.Width = 149;
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            this.изображениеDataGridViewTextBoxColumn.Width = 102;
            // 
            // idtypeDataGridViewTextBoxColumn
            // 
            this.idtypeDataGridViewTextBoxColumn.DataPropertyName = "Idtype";
            this.idtypeDataGridViewTextBoxColumn.HeaderText = "Idtype";
            this.idtypeDataGridViewTextBoxColumn.Name = "idtypeDataGridViewTextBoxColumn";
            this.idtypeDataGridViewTextBoxColumn.Width = 61;
            // 
            // типПродукцииDataGridViewTextBoxColumn
            // 
            this.типПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Тип продукции";
            this.типПродукцииDataGridViewTextBoxColumn.HeaderText = "Тип продукции";
            this.типПродукцииDataGridViewTextBoxColumn.Name = "типПродукцииDataGridViewTextBoxColumn";
            this.типПродукцииDataGridViewTextBoxColumn.Width = 98;
            // 
            // количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn
            // 
            this.количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Количество человек для производства";
            this.количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn.HeaderText = "Количество человек для производства";
            this.количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn.Name = "количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn";
            this.количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn.Width = 145;
            // 
            // номерЦехаДляПроизводстваDataGridViewTextBoxColumn
            // 
            this.номерЦехаДляПроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Номер цеха для производства";
            this.номерЦехаДляПроизводстваDataGridViewTextBoxColumn.HeaderText = "Номер цеха для производства";
            this.номерЦехаДляПроизводстваDataGridViewTextBoxColumn.Name = "номерЦехаДляПроизводстваDataGridViewTextBoxColumn";
            this.номерЦехаДляПроизводстваDataGridViewTextBoxColumn.Width = 170;
            // 
            // product_TableAdapter3
            // 
            this.product_TableAdapter3.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Артикул";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Артикул", true));
            this.textBox6.Location = new System.Drawing.Point(179, 453);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Изображение";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Изображение", true));
            this.textBox7.Location = new System.Drawing.Point(179, 508);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Номер цеха для производства";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Номер цеха для производства", true));
            this.textBox9.Location = new System.Drawing.Point(518, 479);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 19;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Кол-во чел. для производства";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Количество человек для производства", true));
            this.textBox10.Location = new System.Drawing.Point(518, 450);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 21;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 666);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "Form6";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DDataSet7 dDataSet7;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DDataSet7TableAdapters.Material_TableAdapter material_TableAdapter;
        private DDataSet8 dDataSet8;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DDataSet8TableAdapters.Product_TableAdapter product_TableAdapter;
        private System.Windows.Forms.Button button1;
        private DDataSet10 dDataSet10;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DDataSet10TableAdapters.Product_TableAdapter product_TableAdapter1;
        private DDataSet11 dDataSet11;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private DDataSet11TableAdapters.Product_TableAdapter product_TableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DDataSet12 dDataSet12;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private DDataSet12TableAdapters.Product_TableAdapter product_TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальнаяСтоимостьДляАгентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЧеловекДляПроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЦехаДляПроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
    }
}