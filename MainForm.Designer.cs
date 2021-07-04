namespace SkinParserForm {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnParse = new System.Windows.Forms.Button();
            this.CheckStoreItems = new System.Windows.Forms.CheckBox();
            this.CheckAddNewCharacters = new System.Windows.Forms.CheckBox();
            this.CheckPlayerTitles = new System.Windows.Forms.CheckBox();
            this.BtnDisguise = new System.Windows.Forms.Button();
            this.CheckUnreleased = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(6, 19);
            this.TxtInput.MaxLength = 2147483647;
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtInput.Size = new System.Drawing.Size(367, 347);
            this.TxtInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtOutput);
            this.groupBox2.Location = new System.Drawing.Point(398, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(6, 19);
            this.TxtOutput.MaxLength = 2147483647;
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtOutput.Size = new System.Drawing.Size(367, 347);
            this.TxtOutput.TabIndex = 1;
            this.TxtOutput.TextChanged += new System.EventHandler(this.TxtOutput_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(480, 418);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(207, 36);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save to file";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnParse
            // 
            this.BtnParse.Location = new System.Drawing.Point(91, 418);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(207, 36);
            this.BtnParse.TabIndex = 3;
            this.BtnParse.Text = "Parse";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // CheckStoreItems
            // 
            this.CheckStoreItems.AutoSize = true;
            this.CheckStoreItems.Checked = true;
            this.CheckStoreItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckStoreItems.Location = new System.Drawing.Point(19, 12);
            this.CheckStoreItems.Name = "CheckStoreItems";
            this.CheckStoreItems.Size = new System.Drawing.Size(116, 17);
            this.CheckStoreItems.TabIndex = 4;
            this.CheckStoreItems.Text = "Unlock Store Items";
            this.CheckStoreItems.UseVisualStyleBackColor = true;
            // 
            // CheckAddNewCharacters
            // 
            this.CheckAddNewCharacters.AutoSize = true;
            this.CheckAddNewCharacters.Checked = true;
            this.CheckAddNewCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAddNewCharacters.Location = new System.Drawing.Point(141, 12);
            this.CheckAddNewCharacters.Name = "CheckAddNewCharacters";
            this.CheckAddNewCharacters.Size = new System.Drawing.Size(139, 17);
            this.CheckAddNewCharacters.TabIndex = 6;
            this.CheckAddNewCharacters.Text = "Unlock New Characters";
            this.CheckAddNewCharacters.UseVisualStyleBackColor = true;
            this.CheckAddNewCharacters.CheckedChanged += new System.EventHandler(this.CheckAddNewCharacters_CheckedChanged);
            // 
            // CheckPlayerTitles
            // 
            this.CheckPlayerTitles.AutoSize = true;
            this.CheckPlayerTitles.Checked = true;
            this.CheckPlayerTitles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckPlayerTitles.Location = new System.Drawing.Point(286, 12);
            this.CheckPlayerTitles.Name = "CheckPlayerTitles";
            this.CheckPlayerTitles.Size = new System.Drawing.Size(120, 17);
            this.CheckPlayerTitles.TabIndex = 7;
            this.CheckPlayerTitles.Text = "Unlock Player Titles";
            this.CheckPlayerTitles.UseVisualStyleBackColor = true;
            this.CheckPlayerTitles.CheckedChanged += new System.EventHandler(this.CheckPlayerTitles_CheckedChanged);
            // 
            // BtnDisguise
            // 
            this.BtnDisguise.Location = new System.Drawing.Point(304, 418);
            this.BtnDisguise.Name = "BtnDisguise";
            this.BtnDisguise.Size = new System.Drawing.Size(170, 36);
            this.BtnDisguise.TabIndex = 8;
            this.BtnDisguise.Text = "Disguise Fiddler";
            this.BtnDisguise.UseVisualStyleBackColor = true;
            this.BtnDisguise.Click += new System.EventHandler(this.BtnDisguise_Click);
            // 
            // CheckUnreleased
            // 
            this.CheckUnreleased.AutoSize = true;
            this.CheckUnreleased.Checked = true;
            this.CheckUnreleased.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUnreleased.Location = new System.Drawing.Point(412, 12);
            this.CheckUnreleased.Name = "CheckUnreleased";
            this.CheckUnreleased.Size = new System.Drawing.Size(145, 17);
            this.CheckUnreleased.TabIndex = 9;
            this.CheckUnreleased.Text = "Unlock Unreleased Items";
            this.CheckUnreleased.UseVisualStyleBackColor = true;
            this.CheckUnreleased.CheckedChanged += new System.EventHandler(this.CheckUnreleased_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 462);
            this.Controls.Add(this.CheckUnreleased);
            this.Controls.Add(this.BtnDisguise);
            this.Controls.Add(this.CheckPlayerTitles);
            this.Controls.Add(this.CheckAddNewCharacters);
            this.Controls.Add(this.CheckStoreItems);
            this.Controls.Add(this.BtnParse);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Skin Parser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnParse;
        private System.Windows.Forms.CheckBox CheckStoreItems;
        private System.Windows.Forms.CheckBox CheckAddNewCharacters;
        private System.Windows.Forms.CheckBox CheckPlayerTitles;
        private System.Windows.Forms.Button BtnDisguise;
        private System.Windows.Forms.CheckBox CheckUnreleased;
    }
}

