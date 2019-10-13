namespace SoulCost
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.numCurrent = new System.Windows.Forms.NumericUpDown();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.lblSoulsNext = new System.Windows.Forms.Label();
            this.lblSoulsTarget = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(85, 24);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(97, 17);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Level:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(85, 109);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(92, 17);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target Level:";
            // 
            // numCurrent
            // 
            this.numCurrent.Location = new System.Drawing.Point(188, 22);
            this.numCurrent.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCurrent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrent.Name = "numCurrent";
            this.numCurrent.Size = new System.Drawing.Size(60, 22);
            this.numCurrent.TabIndex = 1;
            this.numCurrent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrent.ValueChanged += new System.EventHandler(this.numCurrent_ValueChanged);
            // 
            // numTarget
            // 
            this.numTarget.Location = new System.Drawing.Point(188, 107);
            this.numTarget.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTarget.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(60, 22);
            this.numTarget.TabIndex = 4;
            this.numTarget.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTarget.ValueChanged += new System.EventHandler(this.numCurrent_ValueChanged);
            // 
            // lblSoulsNext
            // 
            this.lblSoulsNext.Location = new System.Drawing.Point(42, 59);
            this.lblSoulsNext.Name = "lblSoulsNext";
            this.lblSoulsNext.Size = new System.Drawing.Size(250, 23);
            this.lblSoulsNext.TabIndex = 2;
            this.lblSoulsNext.Text = "Souls for next level:";
            // 
            // lblSoulsTarget
            // 
            this.lblSoulsTarget.Location = new System.Drawing.Point(41, 144);
            this.lblSoulsTarget.Name = "lblSoulsTarget";
            this.lblSoulsTarget.Size = new System.Drawing.Size(250, 23);
            this.lblSoulsTarget.TabIndex = 5;
            this.lblSoulsTarget.Text = "Souls for target level:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(210, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(129, 193);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 228);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSoulsTarget);
            this.Controls.Add(this.lblSoulsNext);
            this.Controls.Add(this.numTarget);
            this.Controls.Add(this.numCurrent);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soul Cost Calculator";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.NumericUpDown numCurrent;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.Label lblSoulsNext;
        private System.Windows.Forms.Label lblSoulsTarget;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

