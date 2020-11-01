namespace WindowsFormsApp1.GUI
{
    partial class admin
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabFOOD = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.nameFoodtxt = new System.Windows.Forms.TextBox();
            this.speciescbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sefoodbtn = new System.Windows.Forms.Button();
            this.refoodbtn = new System.Windows.Forms.Button();
            this.delfoodbtn = new System.Windows.Forms.Button();
            this.addfoodbtn = new System.Windows.Forms.Button();
            this.dataFood = new System.Windows.Forms.DataGridView();
            this.tabEMLOPER = new System.Windows.Forms.TabPage();
            this.dataEmployer = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameemployertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wagestxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.del_empbtn = new System.Windows.Forms.Button();
            this.se_empbtn = new System.Windows.Forms.Button();
            this.re_empbtn = new System.Windows.Forms.Button();
            this.add_empbtn = new System.Windows.Forms.Button();
            this.tabDESK = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.del_deskbtn = new System.Windows.Forms.Button();
            this.add_deskbtn = new System.Windows.Forms.Button();
            this.name_desktxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDesk = new System.Windows.Forms.DataGridView();
            this.tagbill = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataDetailbill = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.se_billbtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.desk_cbo = new System.Windows.Forms.ComboBox();
            this.employer_cbo = new System.Windows.Forms.ComboBox();
            this.sum_text = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.dataBill = new System.Windows.Forms.DataGridView();
            this.tabSEPECIES = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.del_spbtn = new System.Windows.Forms.Button();
            this.add_spbtn = new System.Windows.Forms.Button();
            this.name_sptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSpecies = new System.Windows.Forms.DataGridView();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.tabcontrol.SuspendLayout();
            this.tabFOOD.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFood)).BeginInit();
            this.tabEMLOPER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabDESK.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDesk)).BeginInit();
            this.tagbill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetailbill)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            this.tabSEPECIES.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabFOOD);
            this.tabcontrol.Controls.Add(this.tabEMLOPER);
            this.tabcontrol.Controls.Add(this.tabDESK);
            this.tabcontrol.Controls.Add(this.tagbill);
            this.tabcontrol.Controls.Add(this.tabSEPECIES);
            this.tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.ShowToolTips = true;
            this.tabcontrol.Size = new System.Drawing.Size(895, 600);
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabBILL_Selected);
            // 
            // tabFOOD
            // 
            this.tabFOOD.AutoScroll = true;
            this.tabFOOD.Controls.Add(this.panel1);
            this.tabFOOD.Controls.Add(this.dataFood);
            this.tabFOOD.Location = new System.Drawing.Point(4, 22);
            this.tabFOOD.Name = "tabFOOD";
            this.tabFOOD.Padding = new System.Windows.Forms.Padding(3);
            this.tabFOOD.Size = new System.Drawing.Size(887, 574);
            this.tabFOOD.TabIndex = 0;
            this.tabFOOD.Text = "FOOD";
            this.tabFOOD.UseVisualStyleBackColor = true;
            this.tabFOOD.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(481, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 491);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.nameFoodtxt);
            this.panel5.Controls.Add(this.speciescbo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pricetxt);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(11, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 245);
            this.panel5.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(111, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 40);
            this.label18.TabIndex = 6;
            this.label18.Text = "FOOD ";
            // 
            // nameFoodtxt
            // 
            this.nameFoodtxt.Location = new System.Drawing.Point(80, 66);
            this.nameFoodtxt.Name = "nameFoodtxt";
            this.nameFoodtxt.Size = new System.Drawing.Size(217, 20);
            this.nameFoodtxt.TabIndex = 3;
            // 
            // speciescbo
            // 
            this.speciescbo.FormattingEnabled = true;
            this.speciescbo.Location = new System.Drawing.Point(80, 113);
            this.speciescbo.Name = "speciescbo";
            this.speciescbo.Size = new System.Drawing.Size(217, 21);
            this.speciescbo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME FOOD";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(80, 167);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(217, 20);
            this.pricetxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SPECIES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PRICE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sefoodbtn);
            this.panel2.Controls.Add(this.refoodbtn);
            this.panel2.Controls.Add(this.delfoodbtn);
            this.panel2.Controls.Add(this.addfoodbtn);
            this.panel2.Location = new System.Drawing.Point(11, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 129);
            this.panel2.TabIndex = 2;
            // 
            // sefoodbtn
            // 
            this.sefoodbtn.Location = new System.Drawing.Point(180, 76);
            this.sefoodbtn.Name = "sefoodbtn";
            this.sefoodbtn.Size = new System.Drawing.Size(134, 38);
            this.sefoodbtn.TabIndex = 3;
            this.sefoodbtn.Text = "SEARCH";
            this.sefoodbtn.UseVisualStyleBackColor = true;
            // 
            // refoodbtn
            // 
            this.refoodbtn.Location = new System.Drawing.Point(12, 76);
            this.refoodbtn.Name = "refoodbtn";
            this.refoodbtn.Size = new System.Drawing.Size(134, 38);
            this.refoodbtn.TabIndex = 2;
            this.refoodbtn.Text = "REPAIR";
            this.refoodbtn.UseVisualStyleBackColor = true;
            // 
            // delfoodbtn
            // 
            this.delfoodbtn.Location = new System.Drawing.Point(180, 23);
            this.delfoodbtn.Name = "delfoodbtn";
            this.delfoodbtn.Size = new System.Drawing.Size(134, 38);
            this.delfoodbtn.TabIndex = 1;
            this.delfoodbtn.Text = "DETELE";
            this.delfoodbtn.UseVisualStyleBackColor = true;
            // 
            // addfoodbtn
            // 
            this.addfoodbtn.Location = new System.Drawing.Point(12, 23);
            this.addfoodbtn.Name = "addfoodbtn";
            this.addfoodbtn.Size = new System.Drawing.Size(134, 38);
            this.addfoodbtn.TabIndex = 0;
            this.addfoodbtn.Text = "ADD FOOD";
            this.addfoodbtn.UseVisualStyleBackColor = true;
            // 
            // dataFood
            // 
            this.dataFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFood.Location = new System.Drawing.Point(6, 18);
            this.dataFood.Name = "dataFood";
            this.dataFood.Size = new System.Drawing.Size(460, 491);
            this.dataFood.TabIndex = 0;
            // 
            // tabEMLOPER
            // 
            this.tabEMLOPER.Controls.Add(this.dataEmployer);
            this.tabEMLOPER.Controls.Add(this.panel3);
            this.tabEMLOPER.Location = new System.Drawing.Point(4, 22);
            this.tabEMLOPER.Name = "tabEMLOPER";
            this.tabEMLOPER.Padding = new System.Windows.Forms.Padding(3);
            this.tabEMLOPER.Size = new System.Drawing.Size(887, 574);
            this.tabEMLOPER.TabIndex = 1;
            this.tabEMLOPER.Text = "EMPLOYER";
            this.tabEMLOPER.UseVisualStyleBackColor = true;
            this.tabEMLOPER.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataEmployer
            // 
            this.dataEmployer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployer.Location = new System.Drawing.Point(7, 18);
            this.dataEmployer.Name = "dataEmployer";
            this.dataEmployer.Size = new System.Drawing.Size(433, 522);
            this.dataEmployer.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(472, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 522);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addtxt);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.phonetxt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.nameemployertxt);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.wagestxt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(23, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 264);
            this.panel4.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(74, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(204, 40);
            this.label19.TabIndex = 8;
            this.label19.Text = "EMPLOYER";
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(81, 197);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(217, 20);
            this.phonetxt.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "PHONE";
            // 
            // nameemployertxt
            // 
            this.nameemployertxt.Location = new System.Drawing.Point(81, 54);
            this.nameemployertxt.Name = "nameemployertxt";
            this.nameemployertxt.Size = new System.Drawing.Size(217, 20);
            this.nameemployertxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "NAME ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // wagestxt
            // 
            this.wagestxt.Location = new System.Drawing.Point(81, 148);
            this.wagestxt.Name = "wagestxt";
            this.wagestxt.Size = new System.Drawing.Size(217, 20);
            this.wagestxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "WAGES";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.del_empbtn);
            this.panel6.Controls.Add(this.se_empbtn);
            this.panel6.Controls.Add(this.re_empbtn);
            this.panel6.Controls.Add(this.add_empbtn);
            this.panel6.Location = new System.Drawing.Point(23, 308);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 129);
            this.panel6.TabIndex = 2;
            // 
            // del_empbtn
            // 
            this.del_empbtn.Location = new System.Drawing.Point(180, 76);
            this.del_empbtn.Name = "del_empbtn";
            this.del_empbtn.Size = new System.Drawing.Size(134, 38);
            this.del_empbtn.TabIndex = 3;
            this.del_empbtn.Text = "DELETE";
            this.del_empbtn.UseVisualStyleBackColor = true;
            // 
            // se_empbtn
            // 
            this.se_empbtn.Location = new System.Drawing.Point(12, 76);
            this.se_empbtn.Name = "se_empbtn";
            this.se_empbtn.Size = new System.Drawing.Size(134, 38);
            this.se_empbtn.TabIndex = 2;
            this.se_empbtn.Text = "SEARCH";
            this.se_empbtn.UseVisualStyleBackColor = true;
            // 
            // re_empbtn
            // 
            this.re_empbtn.Location = new System.Drawing.Point(180, 23);
            this.re_empbtn.Name = "re_empbtn";
            this.re_empbtn.Size = new System.Drawing.Size(134, 38);
            this.re_empbtn.TabIndex = 1;
            this.re_empbtn.Text = "REPAIR";
            this.re_empbtn.UseVisualStyleBackColor = true;
            // 
            // add_empbtn
            // 
            this.add_empbtn.Location = new System.Drawing.Point(12, 23);
            this.add_empbtn.Name = "add_empbtn";
            this.add_empbtn.Size = new System.Drawing.Size(134, 38);
            this.add_empbtn.TabIndex = 0;
            this.add_empbtn.Text = "ADD EMPOYER";
            this.add_empbtn.UseVisualStyleBackColor = true;
            // 
            // tabDESK
            // 
            this.tabDESK.Controls.Add(this.label17);
            this.tabDESK.Controls.Add(this.panel8);
            this.tabDESK.Controls.Add(this.dataDesk);
            this.tabDESK.Location = new System.Drawing.Point(4, 22);
            this.tabDESK.Name = "tabDESK";
            this.tabDESK.Padding = new System.Windows.Forms.Padding(3);
            this.tabDESK.Size = new System.Drawing.Size(887, 574);
            this.tabDESK.TabIndex = 2;
            this.tabDESK.Text = "DESK";
            this.tabDESK.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(342, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(222, 40);
            this.label17.TabIndex = 4;
            this.label17.Text = "DESK TABLE";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.del_deskbtn);
            this.panel8.Controls.Add(this.add_deskbtn);
            this.panel8.Controls.Add(this.name_desktxt);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(54, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 3;
            // 
            // del_deskbtn
            // 
            this.del_deskbtn.Location = new System.Drawing.Point(112, 55);
            this.del_deskbtn.Name = "del_deskbtn";
            this.del_deskbtn.Size = new System.Drawing.Size(75, 23);
            this.del_deskbtn.TabIndex = 3;
            this.del_deskbtn.Text = "DELETE";
            this.del_deskbtn.UseVisualStyleBackColor = true;
            // 
            // add_deskbtn
            // 
            this.add_deskbtn.Location = new System.Drawing.Point(19, 55);
            this.add_deskbtn.Name = "add_deskbtn";
            this.add_deskbtn.Size = new System.Drawing.Size(75, 23);
            this.add_deskbtn.TabIndex = 2;
            this.add_deskbtn.Text = "ADD";
            this.add_deskbtn.UseVisualStyleBackColor = true;
            // 
            // name_desktxt
            // 
            this.name_desktxt.Location = new System.Drawing.Point(63, 20);
            this.name_desktxt.Name = "name_desktxt";
            this.name_desktxt.Size = new System.Drawing.Size(124, 20);
            this.name_desktxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME:";
            // 
            // dataDesk
            // 
            this.dataDesk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDesk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDesk.Location = new System.Drawing.Point(54, 211);
            this.dataDesk.Name = "dataDesk";
            this.dataDesk.Size = new System.Drawing.Size(637, 220);
            this.dataDesk.TabIndex = 0;
            this.dataDesk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tagbill
            // 
            this.tagbill.Controls.Add(this.label15);
            this.tagbill.Controls.Add(this.label14);
            this.tagbill.Controls.Add(this.dataDetailbill);
            this.tagbill.Controls.Add(this.panel9);
            this.tagbill.Controls.Add(this.dataBill);
            this.tagbill.Location = new System.Drawing.Point(4, 22);
            this.tagbill.Name = "tagbill";
            this.tagbill.Padding = new System.Windows.Forms.Padding(3);
            this.tagbill.Size = new System.Drawing.Size(887, 574);
            this.tagbill.TabIndex = 3;
            this.tagbill.Text = "BILL";
            this.tagbill.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(572, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 40);
            this.label15.TabIndex = 5;
            this.label15.Text = "DETAIL BILL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(82, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 40);
            this.label14.TabIndex = 4;
            this.label14.Text = "BILL TABLE";
            // 
            // dataDetailbill
            // 
            this.dataDetailbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetailbill.Location = new System.Drawing.Point(472, 53);
            this.dataDetailbill.Name = "dataDetailbill";
            this.dataDetailbill.Size = new System.Drawing.Size(419, 499);
            this.dataDetailbill.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.se_billbtn);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.desk_cbo);
            this.panel9.Controls.Add(this.employer_cbo);
            this.panel9.Controls.Add(this.sum_text);
            this.panel9.Controls.Add(this.dateTime);
            this.panel9.Location = new System.Drawing.Point(18, 399);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(419, 169);
            this.panel9.TabIndex = 2;
            // 
            // se_billbtn
            // 
            this.se_billbtn.Location = new System.Drawing.Point(298, 56);
            this.se_billbtn.Name = "se_billbtn";
            this.se_billbtn.Size = new System.Drawing.Size(109, 67);
            this.se_billbtn.TabIndex = 8;
            this.se_billbtn.Text = "SEARCH";
            this.se_billbtn.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "EMPLOYER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "&SUM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "DESK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "DATETIME";
            // 
            // desk_cbo
            // 
            this.desk_cbo.FormattingEnabled = true;
            this.desk_cbo.Location = new System.Drawing.Point(71, 80);
            this.desk_cbo.Name = "desk_cbo";
            this.desk_cbo.Size = new System.Drawing.Size(48, 21);
            this.desk_cbo.TabIndex = 3;
            // 
            // employer_cbo
            // 
            this.employer_cbo.FormattingEnabled = true;
            this.employer_cbo.Location = new System.Drawing.Point(71, 118);
            this.employer_cbo.Name = "employer_cbo";
            this.employer_cbo.Size = new System.Drawing.Size(200, 21);
            this.employer_cbo.TabIndex = 2;
            // 
            // sum_text
            // 
            this.sum_text.Location = new System.Drawing.Point(165, 80);
            this.sum_text.Name = "sum_text";
            this.sum_text.Size = new System.Drawing.Size(106, 20);
            this.sum_text.TabIndex = 1;
            this.sum_text.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(71, 39);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 0;
            // 
            // dataBill
            // 
            this.dataBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBill.Location = new System.Drawing.Point(18, 53);
            this.dataBill.Name = "dataBill";
            this.dataBill.Size = new System.Drawing.Size(419, 340);
            this.dataBill.TabIndex = 1;
            // 
            // tabSEPECIES
            // 
            this.tabSEPECIES.Controls.Add(this.label16);
            this.tabSEPECIES.Controls.Add(this.panel7);
            this.tabSEPECIES.Controls.Add(this.dataSpecies);
            this.tabSEPECIES.Location = new System.Drawing.Point(4, 22);
            this.tabSEPECIES.Name = "tabSEPECIES";
            this.tabSEPECIES.Padding = new System.Windows.Forms.Padding(3);
            this.tabSEPECIES.Size = new System.Drawing.Size(887, 574);
            this.tabSEPECIES.TabIndex = 4;
            this.tabSEPECIES.Text = "SPECIES";
            this.tabSEPECIES.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(53, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(266, 40);
            this.label16.TabIndex = 2;
            this.label16.Text = "SPECIES TABLE";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.del_spbtn);
            this.panel7.Controls.Add(this.add_spbtn);
            this.panel7.Controls.Add(this.name_sptxt);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(421, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // del_spbtn
            // 
            this.del_spbtn.Location = new System.Drawing.Point(103, 61);
            this.del_spbtn.Name = "del_spbtn";
            this.del_spbtn.Size = new System.Drawing.Size(75, 23);
            this.del_spbtn.TabIndex = 3;
            this.del_spbtn.Text = "DELETE";
            this.del_spbtn.UseVisualStyleBackColor = true;
            // 
            // add_spbtn
            // 
            this.add_spbtn.Location = new System.Drawing.Point(16, 61);
            this.add_spbtn.Name = "add_spbtn";
            this.add_spbtn.Size = new System.Drawing.Size(75, 23);
            this.add_spbtn.TabIndex = 2;
            this.add_spbtn.Text = "ADD";
            this.add_spbtn.UseVisualStyleBackColor = true;
            // 
            // name_sptxt
            // 
            this.name_sptxt.Location = new System.Drawing.Point(63, 23);
            this.name_sptxt.Name = "name_sptxt";
            this.name_sptxt.Size = new System.Drawing.Size(115, 20);
            this.name_sptxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME :";
            // 
            // dataSpecies
            // 
            this.dataSpecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpecies.Location = new System.Drawing.Point(60, 233);
            this.dataSpecies.Name = "dataSpecies";
            this.dataSpecies.Size = new System.Drawing.Size(652, 237);
            this.dataSpecies.TabIndex = 0;
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(81, 102);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(217, 20);
            this.addtxt.TabIndex = 9;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 619);
            this.Controls.Add(this.tabcontrol);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabcontrol.ResumeLayout(false);
            this.tabFOOD.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFood)).EndInit();
            this.tabEMLOPER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tabDESK.ResumeLayout(false);
            this.tabDESK.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDesk)).EndInit();
            this.tagbill.ResumeLayout(false);
            this.tagbill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetailbill)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            this.tabSEPECIES.ResumeLayout(false);
            this.tabSEPECIES.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabFOOD;
        private System.Windows.Forms.TabPage tabEMLOPER;
        private System.Windows.Forms.TabPage tabDESK;
        private System.Windows.Forms.TabPage tagbill;
        private System.Windows.Forms.DataGridView dataFood;
        private System.Windows.Forms.TabPage tabSEPECIES;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox nameFoodtxt;
        private System.Windows.Forms.ComboBox speciescbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sefoodbtn;
        private System.Windows.Forms.Button refoodbtn;
        private System.Windows.Forms.Button delfoodbtn;
        private System.Windows.Forms.Button addfoodbtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox name_desktxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataDesk;
        private System.Windows.Forms.DataGridView dataBill;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox name_sptxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSpecies;
        private System.Windows.Forms.DataGridView dataEmployer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox nameemployertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wagestxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button del_empbtn;
        private System.Windows.Forms.Button se_empbtn;
        private System.Windows.Forms.Button re_empbtn;
        private System.Windows.Forms.Button add_empbtn;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button del_deskbtn;
        private System.Windows.Forms.Button add_deskbtn;
        private System.Windows.Forms.Button del_spbtn;
        private System.Windows.Forms.Button add_spbtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button se_billbtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox desk_cbo;
        private System.Windows.Forms.ComboBox employer_cbo;
        private System.Windows.Forms.TextBox sum_text;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataDetailbill;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox addtxt;
    }
}