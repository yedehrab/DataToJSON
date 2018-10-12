namespace DataToJSON
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbImportance = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbImportant = new System.Windows.Forms.RadioButton();
            this.rbExImportant = new System.Windows.Forms.RadioButton();
            this.labelData = new System.Windows.Forms.Label();
            this.labelDataName = new System.Windows.Forms.Label();
            this.labelNull = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.CheckBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbAuth = new System.Windows.Forms.CheckBox();
            this.cbUrl = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.clbOptinalGroups = new System.Windows.Forms.CheckedListBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.cbAuthMe = new System.Windows.Forms.CheckBox();
            this.cbSentence = new System.Windows.Forms.CheckBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbAuth = new System.Windows.Forms.TextBox();
            this.tbSentence = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelSentence = new System.Windows.Forms.Label();
            this.gbImportance.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbImportance
            // 
            this.gbImportance.Controls.Add(this.rbNormal);
            this.gbImportance.Controls.Add(this.rbImportant);
            this.gbImportance.Controls.Add(this.rbExImportant);
            this.gbImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbImportance.Location = new System.Drawing.Point(419, 161);
            this.gbImportance.Name = "gbImportance";
            this.gbImportance.Size = new System.Drawing.Size(155, 114);
            this.gbImportance.TabIndex = 6;
            this.gbImportance.TabStop = false;
            this.gbImportance.Text = "Önem Derecesi";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(18, 78);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(74, 21);
            this.rbNormal.TabIndex = 29;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbImportant
            // 
            this.rbImportant.AutoSize = true;
            this.rbImportant.Location = new System.Drawing.Point(18, 51);
            this.rbImportant.Name = "rbImportant";
            this.rbImportant.Size = new System.Drawing.Size(73, 21);
            this.rbImportant.TabIndex = 28;
            this.rbImportant.Text = "Önemli";
            this.rbImportant.UseVisualStyleBackColor = true;
            // 
            // rbExImportant
            // 
            this.rbExImportant.AutoSize = true;
            this.rbExImportant.Location = new System.Drawing.Point(18, 24);
            this.rbExImportant.Name = "rbExImportant";
            this.rbExImportant.Size = new System.Drawing.Size(101, 21);
            this.rbExImportant.TabIndex = 27;
            this.rbExImportant.Text = "Çok Önemli";
            this.rbExImportant.UseVisualStyleBackColor = true;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelData.Location = new System.Drawing.Point(179, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(37, 17);
            this.labelData.TabIndex = 47;
            this.labelData.Text = "Veri";
            // 
            // labelDataName
            // 
            this.labelDataName.AutoSize = true;
            this.labelDataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDataName.Location = new System.Drawing.Point(64, 9);
            this.labelDataName.Name = "labelDataName";
            this.labelDataName.Size = new System.Drawing.Size(65, 17);
            this.labelDataName.TabIndex = 46;
            this.labelDataName.Text = "Veri Adı";
            // 
            // labelNull
            // 
            this.labelNull.AutoSize = true;
            this.labelNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNull.Location = new System.Drawing.Point(19, 9);
            this.labelNull.Name = "labelNull";
            this.labelNull.Size = new System.Drawing.Size(36, 17);
            this.labelNull.TabIndex = 45;
            this.labelNull.Text = "Null";
            // 
            // cbGroup
            // 
            this.cbGroup.AutoSize = true;
            this.cbGroup.Location = new System.Drawing.Point(28, 161);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(18, 17);
            this.cbGroup.TabIndex = 44;
            this.cbGroup.TabStop = false;
            this.cbGroup.UseVisualStyleBackColor = true;
            this.cbGroup.CheckedChanged += new System.EventHandler(this.CbGroup_CheckedChanged);
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(28, 131);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(18, 17);
            this.cbDate.TabIndex = 43;
            this.cbDate.TabStop = false;
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.CbDate_CheckedChanged);
            // 
            // cbAuth
            // 
            this.cbAuth.AutoSize = true;
            this.cbAuth.Location = new System.Drawing.Point(28, 101);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(18, 17);
            this.cbAuth.TabIndex = 42;
            this.cbAuth.TabStop = false;
            this.cbAuth.UseVisualStyleBackColor = true;
            this.cbAuth.CheckedChanged += new System.EventHandler(this.CbAuth_CheckedChanged);
            // 
            // cbUrl
            // 
            this.cbUrl.AutoSize = true;
            this.cbUrl.Location = new System.Drawing.Point(28, 71);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(18, 17);
            this.cbUrl.TabIndex = 41;
            this.cbUrl.TabStop = false;
            this.cbUrl.UseVisualStyleBackColor = true;
            this.cbUrl.CheckedChanged += new System.EventHandler(this.CbUrl_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(586, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(65, 161);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(40, 17);
            this.labelGroup.TabIndex = 40;
            this.labelGroup.Text = "Grup";
            this.labelGroup.Click += new System.EventHandler(this.LabelGroup_Click);
            // 
            // clbOptinalGroups
            // 
            this.clbOptinalGroups.CheckOnClick = true;
            this.clbOptinalGroups.FormattingEnabled = true;
            this.clbOptinalGroups.Items.AddRange(new object[] {
            "Aile",
            "Bilim (Matematik / Fizik / ..)",
            "Bilgilendirici",
            "Çocuk Gelişim",
            "Devlet / Siyaset",
            "Din",
            "Güzel Ahlak",
            "İcat / Buluş",
            "İlişkiler",
            "Kariyer",
            "Kişisel Bakım",
            "Kişisel Gelişim",
            "Sağlık",
            "Diğer"});
            this.clbOptinalGroups.Location = new System.Drawing.Point(182, 161);
            this.clbOptinalGroups.Name = "clbOptinalGroups";
            this.clbOptinalGroups.Size = new System.Drawing.Size(226, 242);
            this.clbOptinalGroups.TabIndex = 5;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(182, 71);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(554, 22);
            this.tbUrl.TabIndex = 1;
            // 
            // cbAuthMe
            // 
            this.cbAuthMe.AutoSize = true;
            this.cbAuthMe.Location = new System.Drawing.Point(182, 101);
            this.cbAuthMe.Name = "cbAuthMe";
            this.cbAuthMe.Size = new System.Drawing.Size(55, 21);
            this.cbAuthMe.TabIndex = 2;
            this.cbAuthMe.Text = "Ben";
            this.cbAuthMe.UseVisualStyleBackColor = true;
            this.cbAuthMe.CheckedChanged += new System.EventHandler(this.CbAuthMe_CheckedChanged);
            // 
            // cbSentence
            // 
            this.cbSentence.AutoSize = true;
            this.cbSentence.Location = new System.Drawing.Point(28, 41);
            this.cbSentence.Name = "cbSentence";
            this.cbSentence.Size = new System.Drawing.Size(18, 17);
            this.cbSentence.TabIndex = 30;
            this.cbSentence.TabStop = false;
            this.cbSentence.UseVisualStyleBackColor = true;
            this.cbSentence.CheckedChanged += new System.EventHandler(this.CbSentence_CheckedChanged);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(65, 71);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(26, 17);
            this.labelUrl.TabIndex = 37;
            this.labelUrl.Text = "Url";
            this.labelUrl.Click += new System.EventHandler(this.LabelUrl_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(182, 131);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 4;
            // 
            // tbAuth
            // 
            this.tbAuth.Location = new System.Drawing.Point(243, 101);
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Size = new System.Drawing.Size(493, 22);
            this.tbAuth.TabIndex = 3;
            // 
            // tbSentence
            // 
            this.tbSentence.Location = new System.Drawing.Point(182, 41);
            this.tbSentence.Name = "tbSentence";
            this.tbSentence.Size = new System.Drawing.Size(554, 22);
            this.tbSentence.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(65, 131);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 17);
            this.labelDate.TabIndex = 32;
            this.labelDate.Text = "Tarih";
            this.labelDate.Click += new System.EventHandler(this.LabelDate_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Location = new System.Drawing.Point(65, 101);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(45, 17);
            this.labelAuth.TabIndex = 31;
            this.labelAuth.Text = "Yazar";
            this.labelAuth.Click += new System.EventHandler(this.LabelAuth_Click);
            // 
            // labelSentence
            // 
            this.labelSentence.AutoSize = true;
            this.labelSentence.Location = new System.Drawing.Point(65, 41);
            this.labelSentence.Name = "labelSentence";
            this.labelSentence.Size = new System.Drawing.Size(83, 17);
            this.labelSentence.TabIndex = 28;
            this.labelSentence.Text = "Söz / Cümle";
            this.labelSentence.Click += new System.EventHandler(this.LabelSentence_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 410);
            this.Controls.Add(this.gbImportance);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelDataName);
            this.Controls.Add(this.labelNull);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbAuth);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.clbOptinalGroups);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.cbAuthMe);
            this.Controls.Add(this.cbSentence);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbAuth);
            this.Controls.Add(this.tbSentence);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.labelSentence);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DataToJSON";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbImportance.ResumeLayout(false);
            this.gbImportance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbImportance;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbImportant;
        private System.Windows.Forms.RadioButton rbExImportant;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelDataName;
        private System.Windows.Forms.Label labelNull;
        private System.Windows.Forms.CheckBox cbGroup;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.CheckBox cbAuth;
        private System.Windows.Forms.CheckBox cbUrl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.CheckedListBox clbOptinalGroups;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.CheckBox cbAuthMe;
        private System.Windows.Forms.CheckBox cbSentence;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbAuth;
        private System.Windows.Forms.TextBox tbSentence;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelSentence;
    }
}

