namespace TelephoneBook
{
    partial class PhoneBookForm
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
            System.Windows.Forms.Label person_IDLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipcodeLabel;
            System.Windows.Forms.Label homePhoneLabel;
            System.Windows.Forms.Label workPhoneLabel;
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label notesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBookForm));
            this.contactBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.phonebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBookDataSet = new TelephoneBook.PhoneBookDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_saveContact = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.person_IDTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneTextBox = new System.Windows.Forms.TextBox();
            this.workPhoneTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.phonebookTableAdapter = new TelephoneBook.PhoneBookDataSetTableAdapters.PhonebookTableAdapter();
            this.tableAdapterManager = new TelephoneBook.PhoneBookDataSetTableAdapters.TableAdapterManager();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            person_IDLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            homePhoneLabel = new System.Windows.Forms.Label();
            workPhoneLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingNavigator)).BeginInit();
            this.contactBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // person_IDLabel
            // 
            person_IDLabel.AutoSize = true;
            person_IDLabel.Location = new System.Drawing.Point(44, 96);
            person_IDLabel.Name = "person_IDLabel";
            person_IDLabel.Size = new System.Drawing.Size(57, 13);
            person_IDLabel.TabIndex = 96;
            person_IDLabel.Text = "Person ID:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(44, 141);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 95;
            firstnameLabel.Text = "Firstname:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(450, 145);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(56, 13);
            lastnameLabel.TabIndex = 94;
            lastnameLabel.Text = "Lastname:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(44, 188);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 30;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(44, 229);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 97;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(296, 229);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 98;
            stateLabel.Text = "State:";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new System.Drawing.Point(556, 229);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(49, 13);
            zipcodeLabel.TabIndex = 99;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Location = new System.Drawing.Point(44, 278);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(72, 13);
            homePhoneLabel.TabIndex = 93;
            homePhoneLabel.Text = "Home Phone:";
            // 
            // workPhoneLabel
            // 
            workPhoneLabel.AutoSize = true;
            workPhoneLabel.Location = new System.Drawing.Point(296, 278);
            workPhoneLabel.Name = "workPhoneLabel";
            workPhoneLabel.Size = new System.Drawing.Size(70, 13);
            workPhoneLabel.TabIndex = 92;
            workPhoneLabel.Text = "Work Phone:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new System.Drawing.Point(556, 278);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(56, 13);
            extensionLabel.TabIndex = 91;
            extensionLabel.Text = "Extension:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(44, 326);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 90;
            notesLabel.Text = "Notes:";
            // 
            // contactBindingNavigator
            // 
            this.contactBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactBindingNavigator.BindingSource = this.phonebookBindingSource;
            this.contactBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tsb_saveContact});
            this.contactBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.contactBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactBindingNavigator.Name = "contactBindingNavigator";
            this.contactBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.contactBindingNavigator.TabIndex = 0;
            this.contactBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // phonebookBindingSource
            // 
            this.phonebookBindingSource.DataMember = "Phonebook";
            this.phonebookBindingSource.DataSource = this.phoneBookDataSet;
            // 
            // phoneBookDataSet
            // 
            this.phoneBookDataSet.DataSetName = "PhoneBookDataSet";
            this.phoneBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_saveContact
            // 
            this.tsb_saveContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_saveContact.Image = ((System.Drawing.Image)(resources.GetObject("tsb_saveContact.Image")));
            this.tsb_saveContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_saveContact.Name = "tsb_saveContact";
            this.tsb_saveContact.Size = new System.Drawing.Size(23, 22);
            this.tsb_saveContact.Text = "Save Contact";
            this.tsb_saveContact.Click += new System.EventHandler(this.tsb_saveContact_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.tsb_search,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Last Name";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // tsb_search
            // 
            this.tsb_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_search.Image = ((System.Drawing.Image)(resources.GetObject("tsb_search.Image")));
            this.tsb_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_search.Name = "tsb_search";
            this.tsb_search.Size = new System.Drawing.Size(121, 22);
            this.tsb_search.Text = "Search by Last Name";
            this.tsb_search.Click += new System.EventHandler(this.tsb_search_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(111, 22);
            this.toolStripButton2.Text = "Display All Records";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // person_IDTextBox
            // 
            this.person_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Person_ID", true));
            this.person_IDTextBox.Enabled = false;
            this.person_IDTextBox.Location = new System.Drawing.Point(122, 93);
            this.person_IDTextBox.Name = "person_IDTextBox";
            this.person_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.person_IDTextBox.TabIndex = 0;
            this.person_IDTextBox.Tag = "Will be added automatically";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(122, 138);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(208, 20);
            this.firstnameTextBox.TabIndex = 1;
            this.firstnameTextBox.Tag = "Enter first name";
            this.ToolTip.SetToolTip(this.firstnameTextBox, "Enter first name");
            this.firstnameTextBox.TextChanged += new System.EventHandler(this.firstnameTextBox_TextChanged);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(528, 142);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(206, 20);
            this.lastnameTextBox.TabIndex = 2;
            this.lastnameTextBox.Tag = "Enter last name";
            this.ToolTip.SetToolTip(this.lastnameTextBox, "Enter last name");
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(122, 185);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(612, 20);
            this.addressTextBox.TabIndex = 3;
            this.ToolTip.SetToolTip(this.addressTextBox, "Enter street address");
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(122, 226);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 4;
            this.ToolTip.SetToolTip(this.cityTextBox, "Enter city name");
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(374, 226);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 5;
            this.ToolTip.SetToolTip(this.stateTextBox, "Enter state name");
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(634, 226);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipcodeTextBox.TabIndex = 6;
            this.ToolTip.SetToolTip(this.zipcodeTextBox, "Enter zip code");
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "HomePhone", true));
            this.homePhoneTextBox.Location = new System.Drawing.Point(122, 275);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.homePhoneTextBox.TabIndex = 7;
            this.ToolTip.SetToolTip(this.homePhoneTextBox, "Enter home phone number");
            // 
            // workPhoneTextBox
            // 
            this.workPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "WorkPhone", true));
            this.workPhoneTextBox.Location = new System.Drawing.Point(374, 275);
            this.workPhoneTextBox.Name = "workPhoneTextBox";
            this.workPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.workPhoneTextBox.TabIndex = 8;
            this.ToolTip.SetToolTip(this.workPhoneTextBox, "Enter work phone number");
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Extension", true));
            this.extensionTextBox.Location = new System.Drawing.Point(634, 275);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.extensionTextBox.TabIndex = 9;
            this.ToolTip.SetToolTip(this.extensionTextBox, "Enter phone extension");
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phonebookBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(122, 323);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(612, 193);
            this.notesTextBox.TabIndex = 10;
            // 
            // phonebookTableAdapter
            // 
            this.phonebookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhonebookTableAdapter = this.phonebookTableAdapter;
            this.tableAdapterManager.UpdateOrder = TelephoneBook.PhoneBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ToolTip
            // 
            this.ToolTip.Tag = "";
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(person_IDLabel);
            this.Controls.Add(this.person_IDTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(homePhoneLabel);
            this.Controls.Add(this.homePhoneTextBox);
            this.Controls.Add(workPhoneLabel);
            this.Controls.Add(this.workPhoneTextBox);
            this.Controls.Add(extensionLabel);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.contactBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhoneBookForm";
            this.Text = "PhoneBookForm";
            this.Load += new System.EventHandler(this.PhoneBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingNavigator)).EndInit();
            this.contactBindingNavigator.ResumeLayout(false);
            this.contactBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator contactBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton tsb_search;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private PhoneBookDataSet phoneBookDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_saveContact;
        private PhoneBookDataSetTableAdapters.PhonebookTableAdapter phonebookTableAdapter;
        private PhoneBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource phonebookBindingSource;
        private System.Windows.Forms.TextBox person_IDTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.TextBox homePhoneTextBox;
        private System.Windows.Forms.TextBox workPhoneTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}