
namespace MIS_Group_Project
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.txtFirstName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btn_clear = new MaterialSkin.Controls.MaterialButton();
            this.txtCompanyEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtDepartment = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.checkTwelve = new System.Windows.Forms.CheckBox();
            this.checkTwo = new System.Windows.Forms.CheckBox();
            this.checkSix = new System.Windows.Forms.CheckBox();
            this.checkNine = new System.Windows.Forms.CheckBox();
            this.btn_submit = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_fme = new System.Windows.Forms.RadioButton();
            this.btn_male = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.AllowPromptAsInput = true;
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.AsciiOnly = false;
            this.txtFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFirstName.BeepOnError = false;
            this.txtFirstName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.HidePromptOnLeave = false;
            this.txtFirstName.HideSelection = true;
            this.txtFirstName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(232, 106);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Mask = "";
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PrefixSuffixText = null;
            this.txtFirstName.PromptChar = '_';
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.RejectInputOnFirstFailure = false;
            this.txtFirstName.ResetOnPrompt = true;
            this.txtFirstName.ResetOnSpace = true;
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(251, 48);
            this.txtFirstName.SkipLiterals = true;
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TabStop = false;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFirstName.TrailingIcon = null;
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.ValidatingType = null;
            this.txtFirstName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_clear.Depth = 0;
            this.btn_clear.HighEmphasis = true;
            this.btn_clear.Icon = null;
            this.btn_clear.Location = new System.Drawing.Point(607, 562);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_clear.Size = new System.Drawing.Size(66, 36);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clear.UseAccentColor = false;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.AllowPromptAsInput = true;
            this.txtCompanyEmail.AnimateReadOnly = false;
            this.txtCompanyEmail.AsciiOnly = false;
            this.txtCompanyEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompanyEmail.BeepOnError = false;
            this.txtCompanyEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyEmail.Depth = 0;
            this.txtCompanyEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmail.HidePromptOnLeave = false;
            this.txtCompanyEmail.HideSelection = true;
            this.txtCompanyEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCompanyEmail.LeadingIcon = null;
            this.txtCompanyEmail.Location = new System.Drawing.Point(232, 235);
            this.txtCompanyEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyEmail.Mask = "";
            this.txtCompanyEmail.MaxLength = 32767;
            this.txtCompanyEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.PasswordChar = '\0';
            this.txtCompanyEmail.PrefixSuffixText = null;
            this.txtCompanyEmail.PromptChar = '_';
            this.txtCompanyEmail.ReadOnly = false;
            this.txtCompanyEmail.RejectInputOnFirstFailure = false;
            this.txtCompanyEmail.ResetOnPrompt = true;
            this.txtCompanyEmail.ResetOnSpace = true;
            this.txtCompanyEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyEmail.SelectedText = "";
            this.txtCompanyEmail.SelectionLength = 0;
            this.txtCompanyEmail.SelectionStart = 0;
            this.txtCompanyEmail.ShortcutsEnabled = true;
            this.txtCompanyEmail.Size = new System.Drawing.Size(251, 48);
            this.txtCompanyEmail.SkipLiterals = true;
            this.txtCompanyEmail.TabIndex = 12;
            this.txtCompanyEmail.TabStop = false;
            this.txtCompanyEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyEmail.TrailingIcon = null;
            this.txtCompanyEmail.UseSystemPasswordChar = false;
            this.txtCompanyEmail.ValidatingType = null;
            // 
            // txtLastName
            // 
            this.txtLastName.AllowPromptAsInput = true;
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.AsciiOnly = false;
            this.txtLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLastName.BeepOnError = false;
            this.txtLastName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.HidePromptOnLeave = false;
            this.txtLastName.HideSelection = true;
            this.txtLastName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(232, 171);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Mask = "";
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PrefixSuffixText = null;
            this.txtLastName.PromptChar = '_';
            this.txtLastName.ReadOnly = false;
            this.txtLastName.RejectInputOnFirstFailure = false;
            this.txtLastName.ResetOnPrompt = true;
            this.txtLastName.ResetOnSpace = true;
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(251, 48);
            this.txtLastName.SkipLiterals = true;
            this.txtLastName.TabIndex = 13;
            this.txtLastName.TabStop = false;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLastName.TrailingIcon = null;
            this.txtLastName.UseSystemPasswordChar = false;
            this.txtLastName.ValidatingType = null;
            // 
            // txtDepartment
            // 
            this.txtDepartment.AllowPromptAsInput = true;
            this.txtDepartment.AnimateReadOnly = false;
            this.txtDepartment.AsciiOnly = false;
            this.txtDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDepartment.BeepOnError = false;
            this.txtDepartment.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDepartment.Depth = 0;
            this.txtDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.HidePromptOnLeave = false;
            this.txtDepartment.HideSelection = true;
            this.txtDepartment.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDepartment.LeadingIcon = null;
            this.txtDepartment.Location = new System.Drawing.Point(232, 363);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartment.Mask = "";
            this.txtDepartment.MaxLength = 32767;
            this.txtDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.PasswordChar = '\0';
            this.txtDepartment.PrefixSuffixText = null;
            this.txtDepartment.PromptChar = '_';
            this.txtDepartment.ReadOnly = false;
            this.txtDepartment.RejectInputOnFirstFailure = false;
            this.txtDepartment.ResetOnPrompt = true;
            this.txtDepartment.ResetOnSpace = true;
            this.txtDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDepartment.SelectedText = "";
            this.txtDepartment.SelectionLength = 0;
            this.txtDepartment.SelectionStart = 0;
            this.txtDepartment.ShortcutsEnabled = true;
            this.txtDepartment.Size = new System.Drawing.Size(251, 48);
            this.txtDepartment.SkipLiterals = true;
            this.txtDepartment.TabIndex = 14;
            this.txtDepartment.TabStop = false;
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDepartment.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDepartment.TrailingIcon = null;
            this.txtDepartment.UseSystemPasswordChar = false;
            this.txtDepartment.ValidatingType = null;
            this.txtDepartment.Click += new System.EventHandler(this.materialMaskedTextBox3_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.AllowPromptAsInput = true;
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.AsciiOnly = false;
            this.txtPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhone.BeepOnError = false;
            this.txtPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HidePromptOnLeave = false;
            this.txtPhone.HideSelection = true;
            this.txtPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(232, 299);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Mask = "";
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PrefixSuffixText = null;
            this.txtPhone.PromptChar = '_';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.RejectInputOnFirstFailure = false;
            this.txtPhone.ResetOnPrompt = true;
            this.txtPhone.ResetOnSpace = true;
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(251, 48);
            this.txtPhone.SkipLiterals = true;
            this.txtPhone.TabIndex = 16;
            this.txtPhone.TabStop = false;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.UseSystemPasswordChar = false;
            this.txtPhone.ValidatingType = null;
            // 
            // checkTwelve
            // 
            this.checkTwelve.AutoSize = true;
            this.checkTwelve.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTwelve.Location = new System.Drawing.Point(269, 487);
            this.checkTwelve.Margin = new System.Windows.Forms.Padding(4);
            this.checkTwelve.Name = "checkTwelve";
            this.checkTwelve.Size = new System.Drawing.Size(172, 33);
            this.checkTwelve.TabIndex = 17;
            this.checkTwelve.Text = "12:30-13:30";
            this.checkTwelve.UseVisualStyleBackColor = true;
            // 
            // checkTwo
            // 
            this.checkTwo.AutoSize = true;
            this.checkTwo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTwo.Location = new System.Drawing.Point(269, 528);
            this.checkTwo.Margin = new System.Windows.Forms.Padding(4);
            this.checkTwo.Name = "checkTwo";
            this.checkTwo.Size = new System.Drawing.Size(172, 33);
            this.checkTwo.TabIndex = 19;
            this.checkTwo.Text = "14:30-15:30";
            this.checkTwo.UseVisualStyleBackColor = true;
            // 
            // checkSix
            // 
            this.checkSix.AutoSize = true;
            this.checkSix.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSix.Location = new System.Drawing.Point(269, 569);
            this.checkSix.Margin = new System.Windows.Forms.Padding(4);
            this.checkSix.Name = "checkSix";
            this.checkSix.Size = new System.Drawing.Size(172, 33);
            this.checkSix.TabIndex = 20;
            this.checkSix.Text = "18:30-20:30";
            this.checkSix.UseVisualStyleBackColor = true;
            // 
            // checkNine
            // 
            this.checkNine.AutoSize = true;
            this.checkNine.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNine.Location = new System.Drawing.Point(269, 608);
            this.checkNine.Margin = new System.Windows.Forms.Padding(4);
            this.checkNine.Name = "checkNine";
            this.checkNine.Size = new System.Drawing.Size(172, 33);
            this.checkNine.TabIndex = 21;
            this.checkNine.Text = "21:00-23:00";
            this.checkNine.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_submit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_submit.Depth = 0;
            this.btn_submit.HighEmphasis = true;
            this.btn_submit.Icon = null;
            this.btn_submit.Location = new System.Drawing.Point(595, 619);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_submit.Size = new System.Drawing.Size(75, 36);
            this.btn_submit.TabIndex = 22;
            this.btn_submit.Text = "Submit";
            this.btn_submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_submit.UseAccentColor = false;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(575, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 708);
            this.panel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_fme);
            this.groupBox1.Controls.Add(this.btn_male);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.checkNine);
            this.groupBox1.Controls.Add(this.txtCompanyEmail);
            this.groupBox1.Controls.Add(this.checkSix);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.checkTwo);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.checkTwelve);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(715, 700);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(216, 448);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Choose a time slot for the event";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(31, 487);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Time Session";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(31, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(31, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(31, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(31, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Company Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // btn_fme
            // 
            this.btn_fme.AutoSize = true;
            this.btn_fme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fme.Location = new System.Drawing.Point(375, 59);
            this.btn_fme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fme.Name = "btn_fme";
            this.btn_fme.Size = new System.Drawing.Size(104, 27);
            this.btn_fme.TabIndex = 24;
            this.btn_fme.TabStop = true;
            this.btn_fme.Text = "Female";
            this.btn_fme.UseVisualStyleBackColor = true;
            // 
            // btn_male
            // 
            this.btn_male.AutoSize = true;
            this.btn_male.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_male.Location = new System.Drawing.Point(233, 59);
            this.btn_male.Margin = new System.Windows.Forms.Padding(4);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(80, 27);
            this.btn_male.TabIndex = 23;
            this.btn_male.TabStop = true;
            this.btn_male.Text = "Male";
            this.btn_male.UseVisualStyleBackColor = true;
            this.btn_male.CheckedChanged += new System.EventHandler(this.btn_male_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 710);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avant Bank";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 409);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 798);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrationForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialButton btn_clear;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCompanyEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtLastName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDepartment;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPhone;
        private System.Windows.Forms.CheckBox checkTwelve;
        private System.Windows.Forms.CheckBox checkTwo;
        private System.Windows.Forms.CheckBox checkSix;
        private System.Windows.Forms.CheckBox checkNine;
        private MaterialSkin.Controls.MaterialButton btn_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton btn_fme;
        private System.Windows.Forms.RadioButton btn_male;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
    }
}

