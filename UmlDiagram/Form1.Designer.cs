namespace UmlDiagram
{
    partial class UmlParser
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.gbConnectionOptions = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbxConnCardSecond = new System.Windows.Forms.ComboBox();
            this.cbxConnCardFirst = new System.Windows.Forms.ComboBox();
            this.lblCardinalities = new System.Windows.Forms.Label();
            this.lblConnType = new System.Windows.Forms.Label();
            this.cbxConnectionType = new System.Windows.Forms.ComboBox();
            this.cbSelectConnection = new System.Windows.Forms.CheckBox();
            this.cbShowDetails = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tfClassName = new System.Windows.Forms.TextBox();
            this.gbSelectMake = new System.Windows.Forms.GroupBox();
            this.rbClass = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.lblEnterClassName = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.gbAddMethod = new System.Windows.Forms.GroupBox();
            this.cbAddMethodAccessor = new System.Windows.Forms.ComboBox();
            this.btnAddMethod = new System.Windows.Forms.Button();
            this.lblAddMethodAccessor = new System.Windows.Forms.Label();
            this.tfAddMethodName = new System.Windows.Forms.TextBox();
            this.lblAddMethodName = new System.Windows.Forms.Label();
            this.gbAddClassProp = new System.Windows.Forms.GroupBox();
            this.cbAddPropertyAccessor = new System.Windows.Forms.ComboBox();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.lblAddPropAccessor = new System.Windows.Forms.Label();
            this.tfAddPropDataType = new System.Windows.Forms.TextBox();
            this.lblAddPropDataType = new System.Windows.Forms.Label();
            this.tfAddPropName = new System.Windows.Forms.TextBox();
            this.lblAddPropName = new System.Windows.Forms.Label();
            this.gbClassMethods = new System.Windows.Forms.GroupBox();
            this.lbClassMethods = new System.Windows.Forms.ListBox();
            this.gbClassProperties = new System.Windows.Forms.GroupBox();
            this.lbClassProperties = new System.Windows.Forms.ListBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.pnlDrawingBoard = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnTitle = new System.Windows.Forms.Label();
            this.tfConnTitle = new System.Windows.Forms.TextBox();
            this.gbConnectionInfo = new System.Windows.Forms.GroupBox();
            this.lblConnInfoTitle = new System.Windows.Forms.Label();
            this.lblConnInfoTitleField = new System.Windows.Forms.Label();
            this.lblConnInfoTypeField = new System.Windows.Forms.Label();
            this.lblConnInfoType = new System.Windows.Forms.Label();
            this.lblConnInfoCardinalityField = new System.Windows.Forms.Label();
            this.lblConnInfoCardinality = new System.Windows.Forms.Label();
            this.lblConnInfoClassesField = new System.Windows.Forms.Label();
            this.lblConnInfoClasses = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.gbConnectionOptions.SuspendLayout();
            this.gbSelectMake.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.gbAddMethod.SuspendLayout();
            this.gbAddClassProp.SuspendLayout();
            this.gbClassMethods.SuspendLayout();
            this.gbClassProperties.SuspendLayout();
            this.gbConnectionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlLeft.Controls.Add(this.gbConnectionInfo);
            this.pnlLeft.Controls.Add(this.gbConnectionOptions);
            this.pnlLeft.Controls.Add(this.cbSelectConnection);
            this.pnlLeft.Controls.Add(this.cbShowDetails);
            this.pnlLeft.Controls.Add(this.btnClear);
            this.pnlLeft.Controls.Add(this.tfClassName);
            this.pnlLeft.Controls.Add(this.gbSelectMake);
            this.pnlLeft.Controls.Add(this.lblEnterClassName);
            this.pnlLeft.Location = new System.Drawing.Point(0, -1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(212, 644);
            this.pnlLeft.TabIndex = 0;
            // 
            // gbConnectionOptions
            // 
            this.gbConnectionOptions.Controls.Add(this.tfConnTitle);
            this.gbConnectionOptions.Controls.Add(this.lblConnTitle);
            this.gbConnectionOptions.Controls.Add(this.btnConnect);
            this.gbConnectionOptions.Controls.Add(this.lblTo);
            this.gbConnectionOptions.Controls.Add(this.cbxConnCardSecond);
            this.gbConnectionOptions.Controls.Add(this.cbxConnCardFirst);
            this.gbConnectionOptions.Controls.Add(this.lblCardinalities);
            this.gbConnectionOptions.Controls.Add(this.lblConnType);
            this.gbConnectionOptions.Controls.Add(this.cbxConnectionType);
            this.gbConnectionOptions.Location = new System.Drawing.Point(12, 168);
            this.gbConnectionOptions.Name = "gbConnectionOptions";
            this.gbConnectionOptions.Size = new System.Drawing.Size(184, 252);
            this.gbConnectionOptions.TabIndex = 5;
            this.gbConnectionOptions.TabStop = false;
            this.gbConnectionOptions.Text = "Connection options";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(77, 180);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(10, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "-";
            // 
            // cbxConnCardSecond
            // 
            this.cbxConnCardSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConnCardSecond.FormattingEnabled = true;
            this.cbxConnCardSecond.Items.AddRange(new object[] {
            "1",
            "0.. 1",
            "0.. *",
            "1.. *",
            "*"});
            this.cbxConnCardSecond.Location = new System.Drawing.Point(102, 176);
            this.cbxConnCardSecond.Name = "cbxConnCardSecond";
            this.cbxConnCardSecond.Size = new System.Drawing.Size(46, 21);
            this.cbxConnCardSecond.TabIndex = 4;
            // 
            // cbxConnCardFirst
            // 
            this.cbxConnCardFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConnCardFirst.FormattingEnabled = true;
            this.cbxConnCardFirst.Items.AddRange(new object[] {
            "1",
            "0.. 1",
            "0.. *",
            "1.. *",
            "*"});
            this.cbxConnCardFirst.Location = new System.Drawing.Point(18, 176);
            this.cbxConnCardFirst.Name = "cbxConnCardFirst";
            this.cbxConnCardFirst.Size = new System.Drawing.Size(46, 21);
            this.cbxConnCardFirst.TabIndex = 3;
            // 
            // lblCardinalities
            // 
            this.lblCardinalities.AutoSize = true;
            this.lblCardinalities.Location = new System.Drawing.Point(21, 160);
            this.lblCardinalities.Name = "lblCardinalities";
            this.lblCardinalities.Size = new System.Drawing.Size(66, 13);
            this.lblCardinalities.TabIndex = 2;
            this.lblCardinalities.Text = "Cardinalities:";
            // 
            // lblConnType
            // 
            this.lblConnType.AutoSize = true;
            this.lblConnType.Location = new System.Drawing.Point(15, 102);
            this.lblConnType.Name = "lblConnType";
            this.lblConnType.Size = new System.Drawing.Size(87, 13);
            this.lblConnType.TabIndex = 1;
            this.lblConnType.Text = "Connection type:";
            // 
            // cbxConnectionType
            // 
            this.cbxConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConnectionType.FormattingEnabled = true;
            this.cbxConnectionType.Items.AddRange(new object[] {
            "Association",
            "Aggregation",
            "Composition",
            "Generalisation",
            "Realisation"});
            this.cbxConnectionType.Location = new System.Drawing.Point(18, 118);
            this.cbxConnectionType.Name = "cbxConnectionType";
            this.cbxConnectionType.Size = new System.Drawing.Size(130, 21);
            this.cbxConnectionType.TabIndex = 0;
            this.cbxConnectionType.SelectedIndexChanged += new System.EventHandler(this.cbxConnectionType_SelectedIndexChanged);
            // 
            // cbSelectConnection
            // 
            this.cbSelectConnection.AutoSize = true;
            this.cbSelectConnection.Location = new System.Drawing.Point(15, 539);
            this.cbSelectConnection.Name = "cbSelectConnection";
            this.cbSelectConnection.Size = new System.Drawing.Size(112, 17);
            this.cbSelectConnection.TabIndex = 4;
            this.cbSelectConnection.Text = "Select connection";
            this.cbSelectConnection.UseVisualStyleBackColor = true;
            // 
            // cbShowDetails
            // 
            this.cbShowDetails.AutoSize = true;
            this.cbShowDetails.Location = new System.Drawing.Point(15, 562);
            this.cbShowDetails.Name = "cbShowDetails";
            this.cbShowDetails.Size = new System.Drawing.Size(113, 17);
            this.cbShowDetails.TabIndex = 3;
            this.cbShowDetails.Text = "Show class details";
            this.cbShowDetails.UseVisualStyleBackColor = true;
            this.cbShowDetails.CheckedChanged += new System.EventHandler(this.cbShowDetails_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 594);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear screen";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tfClassName
            // 
            this.tfClassName.Location = new System.Drawing.Point(12, 132);
            this.tfClassName.Name = "tfClassName";
            this.tfClassName.Size = new System.Drawing.Size(184, 20);
            this.tfClassName.TabIndex = 1;
            // 
            // gbSelectMake
            // 
            this.gbSelectMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbSelectMake.Controls.Add(this.rbClass);
            this.gbSelectMake.Controls.Add(this.rbSelect);
            this.gbSelectMake.Location = new System.Drawing.Point(12, 13);
            this.gbSelectMake.Name = "gbSelectMake";
            this.gbSelectMake.Size = new System.Drawing.Size(184, 83);
            this.gbSelectMake.TabIndex = 0;
            this.gbSelectMake.TabStop = false;
            this.gbSelectMake.Text = "Select object";
            // 
            // rbClass
            // 
            this.rbClass.AutoSize = true;
            this.rbClass.Location = new System.Drawing.Point(18, 49);
            this.rbClass.Name = "rbClass";
            this.rbClass.Size = new System.Drawing.Size(50, 17);
            this.rbClass.TabIndex = 1;
            this.rbClass.TabStop = true;
            this.rbClass.Text = "Class";
            this.rbClass.UseVisualStyleBackColor = true;
            this.rbClass.CheckedChanged += new System.EventHandler(this.rbClass_CheckedChanged);
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(18, 26);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(75, 17);
            this.rbSelect.TabIndex = 0;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select tool";
            this.rbSelect.UseVisualStyleBackColor = true;
            this.rbSelect.CheckedChanged += new System.EventHandler(this.rbSelect_CheckedChanged);
            // 
            // lblEnterClassName
            // 
            this.lblEnterClassName.AutoSize = true;
            this.lblEnterClassName.Location = new System.Drawing.Point(12, 116);
            this.lblEnterClassName.Name = "lblEnterClassName";
            this.lblEnterClassName.Size = new System.Drawing.Size(64, 13);
            this.lblEnterClassName.TabIndex = 0;
            this.lblEnterClassName.Text = "Class name:";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlRight.Controls.Add(this.gbAddMethod);
            this.pnlRight.Controls.Add(this.gbAddClassProp);
            this.pnlRight.Controls.Add(this.gbClassMethods);
            this.pnlRight.Controls.Add(this.gbClassProperties);
            this.pnlRight.Controls.Add(this.lblClassName);
            this.pnlRight.Location = new System.Drawing.Point(803, -1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(210, 644);
            this.pnlRight.TabIndex = 1;
            // 
            // gbAddMethod
            // 
            this.gbAddMethod.Controls.Add(this.cbAddMethodAccessor);
            this.gbAddMethod.Controls.Add(this.btnAddMethod);
            this.gbAddMethod.Controls.Add(this.lblAddMethodAccessor);
            this.gbAddMethod.Controls.Add(this.tfAddMethodName);
            this.gbAddMethod.Controls.Add(this.lblAddMethodName);
            this.gbAddMethod.Location = new System.Drawing.Point(15, 507);
            this.gbAddMethod.Name = "gbAddMethod";
            this.gbAddMethod.Size = new System.Drawing.Size(183, 122);
            this.gbAddMethod.TabIndex = 7;
            this.gbAddMethod.TabStop = false;
            this.gbAddMethod.Text = "Add method";
            // 
            // cbAddMethodAccessor
            // 
            this.cbAddMethodAccessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddMethodAccessor.FormattingEnabled = true;
            this.cbAddMethodAccessor.Items.AddRange(new object[] {
            "private",
            "protected",
            "public"});
            this.cbAddMethodAccessor.Location = new System.Drawing.Point(69, 46);
            this.cbAddMethodAccessor.Name = "cbAddMethodAccessor";
            this.cbAddMethodAccessor.Size = new System.Drawing.Size(108, 21);
            this.cbAddMethodAccessor.TabIndex = 8;
            // 
            // btnAddMethod
            // 
            this.btnAddMethod.Location = new System.Drawing.Point(7, 72);
            this.btnAddMethod.Name = "btnAddMethod";
            this.btnAddMethod.Size = new System.Drawing.Size(170, 36);
            this.btnAddMethod.TabIndex = 6;
            this.btnAddMethod.Text = "Add method";
            this.btnAddMethod.UseVisualStyleBackColor = true;
            this.btnAddMethod.Click += new System.EventHandler(this.btnAddMethod_Click);
            // 
            // lblAddMethodAccessor
            // 
            this.lblAddMethodAccessor.AutoSize = true;
            this.lblAddMethodAccessor.Location = new System.Drawing.Point(7, 49);
            this.lblAddMethodAccessor.Name = "lblAddMethodAccessor";
            this.lblAddMethodAccessor.Size = new System.Drawing.Size(54, 13);
            this.lblAddMethodAccessor.TabIndex = 4;
            this.lblAddMethodAccessor.Text = "Accessor:";
            // 
            // tfAddMethodName
            // 
            this.tfAddMethodName.Location = new System.Drawing.Point(51, 20);
            this.tfAddMethodName.Name = "tfAddMethodName";
            this.tfAddMethodName.Size = new System.Drawing.Size(126, 20);
            this.tfAddMethodName.TabIndex = 1;
            // 
            // lblAddMethodName
            // 
            this.lblAddMethodName.AutoSize = true;
            this.lblAddMethodName.Location = new System.Drawing.Point(7, 23);
            this.lblAddMethodName.Name = "lblAddMethodName";
            this.lblAddMethodName.Size = new System.Drawing.Size(38, 13);
            this.lblAddMethodName.TabIndex = 0;
            this.lblAddMethodName.Text = "Name:";
            // 
            // gbAddClassProp
            // 
            this.gbAddClassProp.Controls.Add(this.cbAddPropertyAccessor);
            this.gbAddClassProp.Controls.Add(this.btnAddProperty);
            this.gbAddClassProp.Controls.Add(this.lblAddPropAccessor);
            this.gbAddClassProp.Controls.Add(this.tfAddPropDataType);
            this.gbAddClassProp.Controls.Add(this.lblAddPropDataType);
            this.gbAddClassProp.Controls.Add(this.tfAddPropName);
            this.gbAddClassProp.Controls.Add(this.lblAddPropName);
            this.gbAddClassProp.Location = new System.Drawing.Point(15, 361);
            this.gbAddClassProp.Name = "gbAddClassProp";
            this.gbAddClassProp.Size = new System.Drawing.Size(183, 140);
            this.gbAddClassProp.TabIndex = 3;
            this.gbAddClassProp.TabStop = false;
            this.gbAddClassProp.Text = "Add property";
            // 
            // cbAddPropertyAccessor
            // 
            this.cbAddPropertyAccessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddPropertyAccessor.FormattingEnabled = true;
            this.cbAddPropertyAccessor.Items.AddRange(new object[] {
            "private",
            "protected",
            "public"});
            this.cbAddPropertyAccessor.Location = new System.Drawing.Point(69, 71);
            this.cbAddPropertyAccessor.Name = "cbAddPropertyAccessor";
            this.cbAddPropertyAccessor.Size = new System.Drawing.Size(108, 21);
            this.cbAddPropertyAccessor.TabIndex = 7;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(7, 98);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(170, 36);
            this.btnAddProperty.TabIndex = 6;
            this.btnAddProperty.Text = "Add property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // lblAddPropAccessor
            // 
            this.lblAddPropAccessor.AutoSize = true;
            this.lblAddPropAccessor.Location = new System.Drawing.Point(7, 75);
            this.lblAddPropAccessor.Name = "lblAddPropAccessor";
            this.lblAddPropAccessor.Size = new System.Drawing.Size(54, 13);
            this.lblAddPropAccessor.TabIndex = 4;
            this.lblAddPropAccessor.Text = "Accessor:";
            // 
            // tfAddPropDataType
            // 
            this.tfAddPropDataType.Location = new System.Drawing.Point(69, 46);
            this.tfAddPropDataType.Name = "tfAddPropDataType";
            this.tfAddPropDataType.Size = new System.Drawing.Size(108, 20);
            this.tfAddPropDataType.TabIndex = 3;
            // 
            // lblAddPropDataType
            // 
            this.lblAddPropDataType.AutoSize = true;
            this.lblAddPropDataType.Location = new System.Drawing.Point(7, 49);
            this.lblAddPropDataType.Name = "lblAddPropDataType";
            this.lblAddPropDataType.Size = new System.Drawing.Size(56, 13);
            this.lblAddPropDataType.TabIndex = 2;
            this.lblAddPropDataType.Text = "Data type:";
            // 
            // tfAddPropName
            // 
            this.tfAddPropName.Location = new System.Drawing.Point(51, 20);
            this.tfAddPropName.Name = "tfAddPropName";
            this.tfAddPropName.Size = new System.Drawing.Size(126, 20);
            this.tfAddPropName.TabIndex = 1;
            // 
            // lblAddPropName
            // 
            this.lblAddPropName.AutoSize = true;
            this.lblAddPropName.Location = new System.Drawing.Point(7, 23);
            this.lblAddPropName.Name = "lblAddPropName";
            this.lblAddPropName.Size = new System.Drawing.Size(38, 13);
            this.lblAddPropName.TabIndex = 0;
            this.lblAddPropName.Text = "Name:";
            // 
            // gbClassMethods
            // 
            this.gbClassMethods.Controls.Add(this.lbClassMethods);
            this.gbClassMethods.Location = new System.Drawing.Point(15, 175);
            this.gbClassMethods.Name = "gbClassMethods";
            this.gbClassMethods.Size = new System.Drawing.Size(183, 130);
            this.gbClassMethods.TabIndex = 2;
            this.gbClassMethods.TabStop = false;
            this.gbClassMethods.Text = "Class behaviour";
            // 
            // lbClassMethods
            // 
            this.lbClassMethods.FormattingEnabled = true;
            this.lbClassMethods.Location = new System.Drawing.Point(7, 20);
            this.lbClassMethods.Name = "lbClassMethods";
            this.lbClassMethods.Size = new System.Drawing.Size(170, 95);
            this.lbClassMethods.TabIndex = 0;
            // 
            // gbClassProperties
            // 
            this.gbClassProperties.Controls.Add(this.lbClassProperties);
            this.gbClassProperties.Location = new System.Drawing.Point(15, 39);
            this.gbClassProperties.Name = "gbClassProperties";
            this.gbClassProperties.Size = new System.Drawing.Size(183, 130);
            this.gbClassProperties.TabIndex = 1;
            this.gbClassProperties.TabStop = false;
            this.gbClassProperties.Text = "Class state";
            // 
            // lbClassProperties
            // 
            this.lbClassProperties.FormattingEnabled = true;
            this.lbClassProperties.Location = new System.Drawing.Point(7, 20);
            this.lbClassProperties.Name = "lbClassProperties";
            this.lbClassProperties.Size = new System.Drawing.Size(170, 95);
            this.lbClassProperties.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(12, 13);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(78, 13);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "<Class_Name>";
            // 
            // pnlDrawingBoard
            // 
            this.pnlDrawingBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDrawingBoard.Location = new System.Drawing.Point(218, 12);
            this.pnlDrawingBoard.Name = "pnlDrawingBoard";
            this.pnlDrawingBoard.Size = new System.Drawing.Size(579, 617);
            this.pnlDrawingBoard.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 203);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 29);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnTitle
            // 
            this.lblConnTitle.AutoSize = true;
            this.lblConnTitle.Location = new System.Drawing.Point(15, 43);
            this.lblConnTitle.Name = "lblConnTitle";
            this.lblConnTitle.Size = new System.Drawing.Size(30, 13);
            this.lblConnTitle.TabIndex = 7;
            this.lblConnTitle.Text = "Title:";
            // 
            // tfConnTitle
            // 
            this.tfConnTitle.Location = new System.Drawing.Point(18, 59);
            this.tfConnTitle.Name = "tfConnTitle";
            this.tfConnTitle.Size = new System.Drawing.Size(130, 20);
            this.tfConnTitle.TabIndex = 6;
            // 
            // gbConnectionInfo
            // 
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoClassesField);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoClasses);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoCardinalityField);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoCardinality);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoTypeField);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoType);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoTitleField);
            this.gbConnectionInfo.Controls.Add(this.lblConnInfoTitle);
            this.gbConnectionInfo.Location = new System.Drawing.Point(18, 426);
            this.gbConnectionInfo.Name = "gbConnectionInfo";
            this.gbConnectionInfo.Size = new System.Drawing.Size(178, 107);
            this.gbConnectionInfo.TabIndex = 3;
            this.gbConnectionInfo.TabStop = false;
            this.gbConnectionInfo.Text = "Connection info";
            // 
            // lblConnInfoTitle
            // 
            this.lblConnInfoTitle.AutoSize = true;
            this.lblConnInfoTitle.Location = new System.Drawing.Point(35, 22);
            this.lblConnInfoTitle.Name = "lblConnInfoTitle";
            this.lblConnInfoTitle.Size = new System.Drawing.Size(27, 13);
            this.lblConnInfoTitle.TabIndex = 8;
            this.lblConnInfoTitle.Text = "Title";
            // 
            // lblConnInfoTitleField
            // 
            this.lblConnInfoTitleField.AutoSize = true;
            this.lblConnInfoTitleField.Location = new System.Drawing.Point(80, 22);
            this.lblConnInfoTitleField.Name = "lblConnInfoTitleField";
            this.lblConnInfoTitleField.Size = new System.Drawing.Size(28, 13);
            this.lblConnInfoTitleField.TabIndex = 9;
            this.lblConnInfoTitleField.Text = "-------";
            // 
            // lblConnInfoTypeField
            // 
            this.lblConnInfoTypeField.AutoSize = true;
            this.lblConnInfoTypeField.Location = new System.Drawing.Point(80, 41);
            this.lblConnInfoTypeField.Name = "lblConnInfoTypeField";
            this.lblConnInfoTypeField.Size = new System.Drawing.Size(28, 13);
            this.lblConnInfoTypeField.TabIndex = 11;
            this.lblConnInfoTypeField.Text = "-------";
            // 
            // lblConnInfoType
            // 
            this.lblConnInfoType.AutoSize = true;
            this.lblConnInfoType.Location = new System.Drawing.Point(31, 41);
            this.lblConnInfoType.Name = "lblConnInfoType";
            this.lblConnInfoType.Size = new System.Drawing.Size(31, 13);
            this.lblConnInfoType.TabIndex = 10;
            this.lblConnInfoType.Text = "Type";
            // 
            // lblConnInfoCardinalityField
            // 
            this.lblConnInfoCardinalityField.AutoSize = true;
            this.lblConnInfoCardinalityField.Location = new System.Drawing.Point(80, 62);
            this.lblConnInfoCardinalityField.Name = "lblConnInfoCardinalityField";
            this.lblConnInfoCardinalityField.Size = new System.Drawing.Size(28, 13);
            this.lblConnInfoCardinalityField.TabIndex = 13;
            this.lblConnInfoCardinalityField.Text = "-------";
            // 
            // lblConnInfoCardinality
            // 
            this.lblConnInfoCardinality.AutoSize = true;
            this.lblConnInfoCardinality.Location = new System.Drawing.Point(9, 62);
            this.lblConnInfoCardinality.Name = "lblConnInfoCardinality";
            this.lblConnInfoCardinality.Size = new System.Drawing.Size(55, 13);
            this.lblConnInfoCardinality.TabIndex = 12;
            this.lblConnInfoCardinality.Text = "Cardinality";
            // 
            // lblConnInfoClassesField
            // 
            this.lblConnInfoClassesField.AutoSize = true;
            this.lblConnInfoClassesField.Location = new System.Drawing.Point(80, 81);
            this.lblConnInfoClassesField.Name = "lblConnInfoClassesField";
            this.lblConnInfoClassesField.Size = new System.Drawing.Size(28, 13);
            this.lblConnInfoClassesField.TabIndex = 15;
            this.lblConnInfoClassesField.Text = "-------";
            // 
            // lblConnInfoClasses
            // 
            this.lblConnInfoClasses.AutoSize = true;
            this.lblConnInfoClasses.Location = new System.Drawing.Point(18, 81);
            this.lblConnInfoClasses.Name = "lblConnInfoClasses";
            this.lblConnInfoClasses.Size = new System.Drawing.Size(43, 13);
            this.lblConnInfoClasses.TabIndex = 14;
            this.lblConnInfoClasses.Text = "Classes";
            // 
            // UmlParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 641);
            this.Controls.Add(this.pnlDrawingBoard);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "UmlParser";
            this.Text = "UML Parser";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbConnectionOptions.ResumeLayout(false);
            this.gbConnectionOptions.PerformLayout();
            this.gbSelectMake.ResumeLayout(false);
            this.gbSelectMake.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.gbAddMethod.ResumeLayout(false);
            this.gbAddMethod.PerformLayout();
            this.gbAddClassProp.ResumeLayout(false);
            this.gbAddClassProp.PerformLayout();
            this.gbClassMethods.ResumeLayout(false);
            this.gbClassProperties.ResumeLayout(false);
            this.gbConnectionInfo.ResumeLayout(false);
            this.gbConnectionInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox gbSelectMake;
        private System.Windows.Forms.TextBox tfClassName;
        private System.Windows.Forms.Label lblEnterClassName;
        private System.Windows.Forms.RadioButton rbClass;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.CheckBox cbShowDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Panel pnlDrawingBoard;
        private System.Windows.Forms.GroupBox gbAddClassProp;
        private System.Windows.Forms.Label lblAddPropAccessor;
        private System.Windows.Forms.TextBox tfAddPropDataType;
        private System.Windows.Forms.Label lblAddPropDataType;
        private System.Windows.Forms.TextBox tfAddPropName;
        private System.Windows.Forms.Label lblAddPropName;
        private System.Windows.Forms.GroupBox gbClassMethods;
        private System.Windows.Forms.ListBox lbClassMethods;
        private System.Windows.Forms.GroupBox gbClassProperties;
        private System.Windows.Forms.GroupBox gbAddMethod;
        private System.Windows.Forms.Button btnAddMethod;
        private System.Windows.Forms.Label lblAddMethodAccessor;
        private System.Windows.Forms.TextBox tfAddMethodName;
        private System.Windows.Forms.Label lblAddMethodName;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.ListBox lbClassProperties;
        private System.Windows.Forms.ComboBox cbAddPropertyAccessor;
        private System.Windows.Forms.ComboBox cbAddMethodAccessor;
        private System.Windows.Forms.GroupBox gbConnectionOptions;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cbxConnCardSecond;
        private System.Windows.Forms.ComboBox cbxConnCardFirst;
        private System.Windows.Forms.Label lblCardinalities;
        private System.Windows.Forms.Label lblConnType;
        private System.Windows.Forms.ComboBox cbxConnectionType;
        private System.Windows.Forms.CheckBox cbSelectConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tfConnTitle;
        private System.Windows.Forms.Label lblConnTitle;
        private System.Windows.Forms.GroupBox gbConnectionInfo;
        private System.Windows.Forms.Label lblConnInfoClassesField;
        private System.Windows.Forms.Label lblConnInfoClasses;
        private System.Windows.Forms.Label lblConnInfoCardinalityField;
        private System.Windows.Forms.Label lblConnInfoCardinality;
        private System.Windows.Forms.Label lblConnInfoTypeField;
        private System.Windows.Forms.Label lblConnInfoType;
        private System.Windows.Forms.Label lblConnInfoTitleField;
        private System.Windows.Forms.Label lblConnInfoTitle;
    }
}

