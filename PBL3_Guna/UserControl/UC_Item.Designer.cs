namespace PBL3_Guna
{
    partial class UC_Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearchItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchItem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cxbCategoryItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.btnShowItem);
            this.panel1.Controls.Add(this.btnModifyItem);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.dtgvItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 750);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.Animated = true;
            this.btnAddCategory.BorderRadius = 10;
            this.btnAddCategory.CheckedState.Parent = this.btnAddCategory;
            this.btnAddCategory.CustomImages.Parent = this.btnAddCategory;
            this.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategory.HoverState.Parent = this.btnAddCategory;
            this.btnAddCategory.Location = new System.Drawing.Point(272, 676);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.ShadowDecoration.Parent = this.btnAddCategory;
            this.btnAddCategory.Size = new System.Drawing.Size(159, 52);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Add Category";
            // 
            // btnShowItem
            // 
            this.btnShowItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowItem.Animated = true;
            this.btnShowItem.BorderRadius = 10;
            this.btnShowItem.CheckedState.Parent = this.btnShowItem;
            this.btnShowItem.CustomImages.Parent = this.btnShowItem;
            this.btnShowItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnShowItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnShowItem.ForeColor = System.Drawing.Color.Black;
            this.btnShowItem.HoverState.Parent = this.btnShowItem;
            this.btnShowItem.Location = new System.Drawing.Point(548, 599);
            this.btnShowItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.ShadowDecoration.Parent = this.btnShowItem;
            this.btnShowItem.Size = new System.Drawing.Size(129, 52);
            this.btnShowItem.TabIndex = 4;
            this.btnShowItem.Text = "View";
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyItem.Animated = true;
            this.btnModifyItem.BorderRadius = 10;
            this.btnModifyItem.CheckedState.Parent = this.btnModifyItem;
            this.btnModifyItem.CustomImages.Parent = this.btnModifyItem;
            this.btnModifyItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnModifyItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnModifyItem.ForeColor = System.Drawing.Color.Black;
            this.btnModifyItem.HoverState.Parent = this.btnModifyItem;
            this.btnModifyItem.Location = new System.Drawing.Point(375, 599);
            this.btnModifyItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.ShadowDecoration.Parent = this.btnModifyItem;
            this.btnModifyItem.Size = new System.Drawing.Size(129, 52);
            this.btnModifyItem.TabIndex = 3;
            this.btnModifyItem.Text = "Modify";
            this.btnModifyItem.Click += new System.EventHandler(this.btnModifyItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteItem.Animated = true;
            this.btnDeleteItem.BorderRadius = 10;
            this.btnDeleteItem.CheckedState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.CustomImages.Parent = this.btnDeleteItem;
            this.btnDeleteItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItem.HoverState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Location = new System.Drawing.Point(196, 599);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.ShadowDecoration.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Size = new System.Drawing.Size(129, 52);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Animated = true;
            this.btnAddItem.BorderRadius = 10;
            this.btnAddItem.CheckedState.Parent = this.btnAddItem;
            this.btnAddItem.CustomImages.Parent = this.btnAddItem;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.HoverState.Parent = this.btnAddItem;
            this.btnAddItem.Location = new System.Drawing.Point(20, 599);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.ShadowDecoration.Parent = this.btnAddItem;
            this.btnAddItem.Size = new System.Drawing.Size(129, 52);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dtgvItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(166)))));
            this.dtgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvItem.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvItem.EnableHeadersVisualStyles = false;
            this.dtgvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvItem.Location = new System.Drawing.Point(0, 0);
            this.dtgvItem.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvItem.Name = "dtgvItem";
            this.dtgvItem.RowHeadersVisible = false;
            this.dtgvItem.RowHeadersWidth = 51;
            this.dtgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvItem.Size = new System.Drawing.Size(700, 559);
            this.dtgvItem.TabIndex = 0;
            this.dtgvItem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvItem.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(166)))));
            this.dtgvItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvItem.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvItem.ThemeStyle.ReadOnly = false;
            this.dtgvItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvItem.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvItem.SelectionChanged += new System.EventHandler(this.dtgvItem_SelectionChanged);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchItem.Animated = true;
            this.txtSearchItem.BorderRadius = 6;
            this.txtSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchItem.DefaultText = "";
            this.txtSearchItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchItem.DisabledState.Parent = this.txtSearchItem;
            this.txtSearchItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchItem.FocusedState.Parent = this.txtSearchItem;
            this.txtSearchItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchItem.HoverState.Parent = this.txtSearchItem;
            this.txtSearchItem.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchItem.IconLeft")));
            this.txtSearchItem.Location = new System.Drawing.Point(767, 92);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PasswordChar = '\0';
            this.txtSearchItem.PlaceholderText = "";
            this.txtSearchItem.SelectedText = "";
            this.txtSearchItem.ShadowDecoration.Parent = this.txtSearchItem;
            this.txtSearchItem.Size = new System.Drawing.Size(248, 47);
            this.txtSearchItem.TabIndex = 1;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchItem.Animated = true;
            this.btnSearchItem.BorderRadius = 10;
            this.btnSearchItem.CheckedState.Parent = this.btnSearchItem;
            this.btnSearchItem.CustomImages.Parent = this.btnSearchItem;
            this.btnSearchItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnSearchItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSearchItem.ForeColor = System.Drawing.Color.Black;
            this.btnSearchItem.HoverState.Parent = this.btnSearchItem;
            this.btnSearchItem.Location = new System.Drawing.Point(1051, 92);
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.ShadowDecoration.Parent = this.btnSearchItem;
            this.btnSearchItem.Size = new System.Drawing.Size(129, 47);
            this.btnSearchItem.TabIndex = 6;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(833, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // txtIDItem
            // 
            this.txtIDItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDItem.BorderRadius = 6;
            this.txtIDItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDItem.DefaultText = "";
            this.txtIDItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDItem.DisabledState.Parent = this.txtIDItem;
            this.txtIDItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDItem.FocusedState.Parent = this.txtIDItem;
            this.txtIDItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDItem.HoverState.Parent = this.txtIDItem;
            this.txtIDItem.Location = new System.Drawing.Point(899, 245);
            this.txtIDItem.Margin = new System.Windows.Forms.Padding(5);
            this.txtIDItem.Name = "txtIDItem";
            this.txtIDItem.PasswordChar = '\0';
            this.txtIDItem.PlaceholderText = "";
            this.txtIDItem.SelectedText = "";
            this.txtIDItem.ShadowDecoration.Parent = this.txtIDItem;
            this.txtIDItem.Size = new System.Drawing.Size(281, 30);
            this.txtIDItem.TabIndex = 8;
            // 
            // txtNameItem
            // 
            this.txtNameItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameItem.BorderRadius = 6;
            this.txtNameItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameItem.DefaultText = "";
            this.txtNameItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameItem.DisabledState.Parent = this.txtNameItem;
            this.txtNameItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameItem.FocusedState.Parent = this.txtNameItem;
            this.txtNameItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameItem.HoverState.Parent = this.txtNameItem;
            this.txtNameItem.Location = new System.Drawing.Point(899, 318);
            this.txtNameItem.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.PasswordChar = '\0';
            this.txtNameItem.PlaceholderText = "";
            this.txtNameItem.SelectedText = "";
            this.txtNameItem.ShadowDecoration.Parent = this.txtNameItem;
            this.txtNameItem.Size = new System.Drawing.Size(281, 30);
            this.txtNameItem.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(793, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // txtPriceItem
            // 
            this.txtPriceItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceItem.BorderRadius = 6;
            this.txtPriceItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceItem.DefaultText = "";
            this.txtPriceItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceItem.DisabledState.Parent = this.txtPriceItem;
            this.txtPriceItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceItem.FocusedState.Parent = this.txtPriceItem;
            this.txtPriceItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceItem.HoverState.Parent = this.txtPriceItem;
            this.txtPriceItem.Location = new System.Drawing.Point(899, 484);
            this.txtPriceItem.Margin = new System.Windows.Forms.Padding(5);
            this.txtPriceItem.Name = "txtPriceItem";
            this.txtPriceItem.PasswordChar = '\0';
            this.txtPriceItem.PlaceholderText = "";
            this.txtPriceItem.SelectedText = "";
            this.txtPriceItem.ShadowDecoration.Parent = this.txtPriceItem;
            this.txtPriceItem.Size = new System.Drawing.Size(281, 30);
            this.txtPriceItem.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price:";
            // 
            // cxbCategoryItem
            // 
            this.cxbCategoryItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cxbCategoryItem.Animated = true;
            this.cxbCategoryItem.BackColor = System.Drawing.Color.Transparent;
            this.cxbCategoryItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cxbCategoryItem.BorderRadius = 6;
            this.cxbCategoryItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cxbCategoryItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxbCategoryItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cxbCategoryItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cxbCategoryItem.FocusedState.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cxbCategoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cxbCategoryItem.HoverState.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.ItemHeight = 30;
            this.cxbCategoryItem.ItemsAppearance.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.Location = new System.Drawing.Point(899, 395);
            this.cxbCategoryItem.Margin = new System.Windows.Forms.Padding(4);
            this.cxbCategoryItem.Name = "cxbCategoryItem";
            this.cxbCategoryItem.ShadowDecoration.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.Size = new System.Drawing.Size(280, 36);
            this.cxbCategoryItem.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(760, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNameItem);
            this.panel2.Controls.Add(this.txtPriceItem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cxbCategoryItem);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 750);
            this.panel2.TabIndex = 15;
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIDItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(1205, 750);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvItem;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
        private Guna.UI2.WinForms.Guna2Button btnShowItem;
        private Guna.UI2.WinForms.Guna2Button btnModifyItem;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItem;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchItem;
        private Guna.UI2.WinForms.Guna2Button btnSearchItem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDItem;
        private Guna.UI2.WinForms.Guna2TextBox txtNameItem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceItem;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cxbCategoryItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}
