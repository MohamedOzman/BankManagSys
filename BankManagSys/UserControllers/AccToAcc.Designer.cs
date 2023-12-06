namespace BankManagSys.UserControllers
{
    partial class AccToAcc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accTOaccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANKMSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANK_M_SDataSet1 = new BankManagSys.BANK_M_SDataSet1();
            this.branchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullNameTO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphoneNoTO = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxTO = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNoTO = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphoneNoFR = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullnameFR = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxFR = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountNoFR = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.accTOaccTableAdapter = new BankManagSys.BANK_M_SDataSet1TableAdapters.accTOaccTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTOaccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKMSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANK_M_SDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.guna2DataGridView1);
            this.groupBox1.Controls.Add(this.branchType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 582);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCOUNT TO ACCOUNT";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(763, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "DATE:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Crimson;
            this.lblDate.Location = new System.Drawing.Point(813, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 18);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "19/85282/2002";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.accountNoFRDataGridViewTextBoxColumn,
            this.fullNameFRDataGridViewTextBoxColumn,
            this.phoneNoFRDataGridViewTextBoxColumn,
            this.accountNoTODataGridViewTextBoxColumn,
            this.fullNameTODataGridViewTextBoxColumn,
            this.phoneNoTODataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.accTOaccBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 368);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.RowTemplate.Height = 40;
            this.guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.Size = new System.Drawing.Size(945, 211);
            this.guna2DataGridView1.TabIndex = 46;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoFRDataGridViewTextBoxColumn
            // 
            this.accountNoFRDataGridViewTextBoxColumn.DataPropertyName = "AccountNoFR";
            this.accountNoFRDataGridViewTextBoxColumn.HeaderText = "AccountNoFR";
            this.accountNoFRDataGridViewTextBoxColumn.Name = "accountNoFRDataGridViewTextBoxColumn";
            this.accountNoFRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameFRDataGridViewTextBoxColumn
            // 
            this.fullNameFRDataGridViewTextBoxColumn.DataPropertyName = "FullNameFR";
            this.fullNameFRDataGridViewTextBoxColumn.HeaderText = "FullNameFR";
            this.fullNameFRDataGridViewTextBoxColumn.Name = "fullNameFRDataGridViewTextBoxColumn";
            this.fullNameFRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNoFRDataGridViewTextBoxColumn
            // 
            this.phoneNoFRDataGridViewTextBoxColumn.DataPropertyName = "PhoneNoFR";
            this.phoneNoFRDataGridViewTextBoxColumn.HeaderText = "PhoneNoFR";
            this.phoneNoFRDataGridViewTextBoxColumn.Name = "phoneNoFRDataGridViewTextBoxColumn";
            this.phoneNoFRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoTODataGridViewTextBoxColumn
            // 
            this.accountNoTODataGridViewTextBoxColumn.DataPropertyName = "AccountNoTO";
            this.accountNoTODataGridViewTextBoxColumn.HeaderText = "AccountNoTO";
            this.accountNoTODataGridViewTextBoxColumn.Name = "accountNoTODataGridViewTextBoxColumn";
            this.accountNoTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameTODataGridViewTextBoxColumn
            // 
            this.fullNameTODataGridViewTextBoxColumn.DataPropertyName = "FullNameTO";
            this.fullNameTODataGridViewTextBoxColumn.HeaderText = "FullNameTO";
            this.fullNameTODataGridViewTextBoxColumn.Name = "fullNameTODataGridViewTextBoxColumn";
            this.fullNameTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNoTODataGridViewTextBoxColumn
            // 
            this.phoneNoTODataGridViewTextBoxColumn.DataPropertyName = "PhoneNoTO";
            this.phoneNoTODataGridViewTextBoxColumn.HeaderText = "PhoneNoTO";
            this.phoneNoTODataGridViewTextBoxColumn.Name = "phoneNoTODataGridViewTextBoxColumn";
            this.phoneNoTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accTOaccBindingSource
            // 
            this.accTOaccBindingSource.DataMember = "accTOacc";
            this.accTOaccBindingSource.DataSource = this.bANKMSDataSet1BindingSource;
            // 
            // bANKMSDataSet1BindingSource
            // 
            this.bANKMSDataSet1BindingSource.DataSource = this.bANK_M_SDataSet1;
            this.bANKMSDataSet1BindingSource.Position = 0;
            // 
            // bANK_M_SDataSet1
            // 
            this.bANK_M_SDataSet1.DataSetName = "BANK_M_SDataSet1";
            this.bANK_M_SDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchType
            // 
            this.branchType.BackColor = System.Drawing.Color.Transparent;
            this.branchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.branchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.branchType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.branchType.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.branchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.branchType.ItemHeight = 30;
            this.branchType.Items.AddRange(new object[] {
            "---CHOSE BRANCHES",
            "BAKARO",
            "SAFARI",
            "TARIBIYANO"});
            this.branchType.Location = new System.Drawing.Point(161, 277);
            this.branchType.Name = "branchType";
            this.branchType.Size = new System.Drawing.Size(303, 36);
            this.branchType.StartIndex = 0;
            this.branchType.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "BRANCH";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtFullNameTO);
            this.groupBox3.Controls.Add(this.txtphoneNoTO);
            this.groupBox3.Controls.Add(this.checkBoxTO);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAccountNoTO);
            this.groupBox3.Location = new System.Drawing.Point(481, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 222);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCOUNT TO";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "PHONE NO:";
            // 
            // txtFullNameTO
            // 
            this.txtFullNameTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFullNameTO.Animated = true;
            this.txtFullNameTO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullNameTO.DefaultText = "";
            this.txtFullNameTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullNameTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullNameTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullNameTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullNameTO.Enabled = false;
            this.txtFullNameTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullNameTO.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtFullNameTO.ForeColor = System.Drawing.Color.Black;
            this.txtFullNameTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullNameTO.Location = new System.Drawing.Point(161, 102);
            this.txtFullNameTO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFullNameTO.Name = "txtFullNameTO";
            this.txtFullNameTO.PasswordChar = '\0';
            this.txtFullNameTO.PlaceholderText = "FULLNAME";
            this.txtFullNameTO.SelectedText = "";
            this.txtFullNameTO.Size = new System.Drawing.Size(294, 36);
            this.txtFullNameTO.TabIndex = 20;
            // 
            // txtphoneNoTO
            // 
            this.txtphoneNoTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtphoneNoTO.Animated = true;
            this.txtphoneNoTO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphoneNoTO.DefaultText = "";
            this.txtphoneNoTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphoneNoTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphoneNoTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphoneNoTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphoneNoTO.Enabled = false;
            this.txtphoneNoTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphoneNoTO.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtphoneNoTO.ForeColor = System.Drawing.Color.Black;
            this.txtphoneNoTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphoneNoTO.Location = new System.Drawing.Point(160, 162);
            this.txtphoneNoTO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtphoneNoTO.Name = "txtphoneNoTO";
            this.txtphoneNoTO.PasswordChar = '\0';
            this.txtphoneNoTO.PlaceholderText = "PHONE NO";
            this.txtphoneNoTO.SelectedText = "";
            this.txtphoneNoTO.Size = new System.Drawing.Size(294, 36);
            this.txtphoneNoTO.TabIndex = 43;
            // 
            // checkBoxTO
            // 
            this.checkBoxTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTO.AutoSize = true;
            this.checkBoxTO.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxTO.CheckedState.BorderRadius = 0;
            this.checkBoxTO.CheckedState.BorderThickness = 0;
            this.checkBoxTO.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxTO.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxTO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBoxTO.Location = new System.Drawing.Point(371, 18);
            this.checkBoxTO.Name = "checkBoxTO";
            this.checkBoxTO.Size = new System.Drawing.Size(80, 22);
            this.checkBoxTO.TabIndex = 40;
            this.checkBoxTO.Text = "Check";
            this.checkBoxTO.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBoxTO.UncheckedState.BorderRadius = 0;
            this.checkBoxTO.UncheckedState.BorderThickness = 0;
            this.checkBoxTO.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxTO.CheckedChanged += new System.EventHandler(this.checkBoxTO_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "NAME:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "ACCOUNT NO:";
            // 
            // txtAccountNoTO
            // 
            this.txtAccountNoTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountNoTO.Animated = true;
            this.txtAccountNoTO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNoTO.DefaultText = "";
            this.txtAccountNoTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNoTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNoTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNoTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNoTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNoTO.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtAccountNoTO.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNoTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNoTO.Location = new System.Drawing.Point(160, 42);
            this.txtAccountNoTO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAccountNoTO.Name = "txtAccountNoTO";
            this.txtAccountNoTO.PasswordChar = '\0';
            this.txtAccountNoTO.PlaceholderText = "ACCOUNT NO";
            this.txtAccountNoTO.SelectedText = "";
            this.txtAccountNoTO.Size = new System.Drawing.Size(294, 36);
            this.txtAccountNoTO.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtphoneNoFR);
            this.groupBox2.Controls.Add(this.txtFullnameFR);
            this.groupBox2.Controls.Add(this.checkBoxFR);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAccountNoFR);
            this.groupBox2.Location = new System.Drawing.Point(6, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 222);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCOUNT FROM";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "PHONE NO:";
            // 
            // txtphoneNoFR
            // 
            this.txtphoneNoFR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtphoneNoFR.Animated = true;
            this.txtphoneNoFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphoneNoFR.DefaultText = "";
            this.txtphoneNoFR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphoneNoFR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphoneNoFR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphoneNoFR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphoneNoFR.Enabled = false;
            this.txtphoneNoFR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphoneNoFR.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtphoneNoFR.ForeColor = System.Drawing.Color.Black;
            this.txtphoneNoFR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphoneNoFR.Location = new System.Drawing.Point(156, 162);
            this.txtphoneNoFR.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtphoneNoFR.Name = "txtphoneNoFR";
            this.txtphoneNoFR.PasswordChar = '\0';
            this.txtphoneNoFR.PlaceholderText = "PHONE NO";
            this.txtphoneNoFR.SelectedText = "";
            this.txtphoneNoFR.Size = new System.Drawing.Size(294, 36);
            this.txtphoneNoFR.TabIndex = 41;
            // 
            // txtFullnameFR
            // 
            this.txtFullnameFR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullnameFR.Animated = true;
            this.txtFullnameFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullnameFR.DefaultText = "";
            this.txtFullnameFR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullnameFR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullnameFR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullnameFR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullnameFR.Enabled = false;
            this.txtFullnameFR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullnameFR.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtFullnameFR.ForeColor = System.Drawing.Color.Black;
            this.txtFullnameFR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullnameFR.Location = new System.Drawing.Point(155, 102);
            this.txtFullnameFR.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFullnameFR.Name = "txtFullnameFR";
            this.txtFullnameFR.PasswordChar = '\0';
            this.txtFullnameFR.PlaceholderText = "FULLNAME";
            this.txtFullnameFR.SelectedText = "";
            this.txtFullnameFR.Size = new System.Drawing.Size(294, 36);
            this.txtFullnameFR.TabIndex = 20;
            this.txtFullnameFR.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            // 
            // checkBoxFR
            // 
            this.checkBoxFR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFR.AutoSize = true;
            this.checkBoxFR.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxFR.CheckedState.BorderRadius = 0;
            this.checkBoxFR.CheckedState.BorderThickness = 0;
            this.checkBoxFR.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxFR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxFR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBoxFR.Location = new System.Drawing.Point(371, 17);
            this.checkBoxFR.Name = "checkBoxFR";
            this.checkBoxFR.Size = new System.Drawing.Size(80, 22);
            this.checkBoxFR.TabIndex = 40;
            this.checkBoxFR.Text = "Check";
            this.checkBoxFR.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBoxFR.UncheckedState.BorderRadius = 0;
            this.checkBoxFR.UncheckedState.BorderThickness = 0;
            this.checkBoxFR.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxFR.CheckedChanged += new System.EventHandler(this.checkBoxFR_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "NAME:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "ACCOUNT NO:";
            // 
            // txtAccountNoFR
            // 
            this.txtAccountNoFR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountNoFR.Animated = true;
            this.txtAccountNoFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNoFR.DefaultText = "";
            this.txtAccountNoFR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNoFR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNoFR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNoFR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNoFR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNoFR.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtAccountNoFR.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNoFR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNoFR.Location = new System.Drawing.Point(156, 42);
            this.txtAccountNoFR.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAccountNoFR.Name = "txtAccountNoFR";
            this.txtAccountNoFR.PasswordChar = '\0';
            this.txtAccountNoFR.PlaceholderText = "ACCOUNT NO";
            this.txtAccountNoFR.SelectedText = "";
            this.txtAccountNoFR.Size = new System.Drawing.Size(294, 36);
            this.txtAccountNoFR.TabIndex = 22;
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(162, 321);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "AMOUNT";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(302, 36);
            this.txtAmount.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "AMOUNT:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Animated = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::BankManagSys.Properties.Resources.broom_96px;
            this.btnClear.ImageSize = new System.Drawing.Size(38, 38);
            this.btnClear.Location = new System.Drawing.Point(766, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 43);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Animated = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = global::BankManagSys.Properties.Resources.add_user_male_96px;
            this.btnConfirm.ImageSize = new System.Drawing.Size(38, 38);
            this.btnConfirm.Location = new System.Drawing.Point(568, 316);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(164, 43);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(945, 42);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "ACCOUNT TO ACCOUNT";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accTOaccTableAdapter
            // 
            this.accTOaccTableAdapter.ClearBeforeFill = true;
            // 
            // AccToAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "AccToAcc";
            this.Size = new System.Drawing.Size(945, 621);
            this.Load += new System.EventHandler(this.AccToAcc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTOaccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKMSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANK_M_SDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNoFR;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFullnameFR;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtFullNameTO;
        private Guna.UI2.WinForms.Guna2TextBox txtphoneNoTO;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNoTO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtphoneNoFR;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxFR;
        public Guna.UI2.WinForms.Guna2ComboBox branchType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource bANKMSDataSet1BindingSource;
        private BANK_M_SDataSet1 bANK_M_SDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accTOaccBindingSource;
        private BANK_M_SDataSet1TableAdapters.accTOaccTableAdapter accTOaccTableAdapter;
    }
}
