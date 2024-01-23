
namespace CPT206_CH14_4_Lab_David_Hudgins
{
    partial class LookupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greaterTextBox = new System.Windows.Forms.TextBox();
            this.greaterSearchButton = new System.Windows.Forms.Button();
            this.lessTextBox = new System.Windows.Forms.TextBox();
            this.lessSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.greaterTextBox);
            this.groupBox1.Controls.Add(this.greaterSearchButton);
            this.groupBox1.Controls.Add(this.lessTextBox);
            this.groupBox1.Controls.Add(this.lessSearchButton);
            this.groupBox1.Location = new System.Drawing.Point(35, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(873, 423);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Lookup";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(180, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search Products With Units Less Than:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(180, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Products With Units Greater Than:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greaterTextBox
            // 
            this.greaterTextBox.Location = new System.Drawing.Point(272, 78);
            this.greaterTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.greaterTextBox.Name = "greaterTextBox";
            this.greaterTextBox.Size = new System.Drawing.Size(328, 35);
            this.greaterTextBox.TabIndex = 13;
            // 
            // greaterSearchButton
            // 
            this.greaterSearchButton.Location = new System.Drawing.Point(372, 134);
            this.greaterSearchButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.greaterSearchButton.Name = "greaterSearchButton";
            this.greaterSearchButton.Size = new System.Drawing.Size(129, 62);
            this.greaterSearchButton.TabIndex = 12;
            this.greaterSearchButton.Text = "Search";
            this.greaterSearchButton.UseVisualStyleBackColor = true;
            this.greaterSearchButton.Click += new System.EventHandler(this.greaterSearchButton_Click);
            // 
            // lessTextBox
            // 
            this.lessTextBox.Location = new System.Drawing.Point(272, 286);
            this.lessTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lessTextBox.Name = "lessTextBox";
            this.lessTextBox.Size = new System.Drawing.Size(328, 35);
            this.lessTextBox.TabIndex = 10;
            // 
            // lessSearchButton
            // 
            this.lessSearchButton.Location = new System.Drawing.Point(372, 342);
            this.lessSearchButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lessSearchButton.Name = "lessSearchButton";
            this.lessSearchButton.Size = new System.Drawing.Size(129, 62);
            this.lessSearchButton.TabIndex = 9;
            this.lessSearchButton.Text = "Search";
            this.lessSearchButton.UseVisualStyleBackColor = true;
            this.lessSearchButton.Click += new System.EventHandler(this.lessSearchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(779, 446);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 62);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(35, 446);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(129, 62);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(24, 530);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.Size = new System.Drawing.Size(894, 453);
            this.productDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CPT206_CH14_4_Lab_David_Hudgins.Product);
            // 
            // LookupForm
            // 
            this.AcceptButton = this.greaterSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(942, 1007);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DavidHudgins-CH14.5";
            this.Load += new System.EventHandler(this.LookupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox greaterTextBox;
        private System.Windows.Forms.Button greaterSearchButton;
        private System.Windows.Forms.TextBox lessTextBox;
        private System.Windows.Forms.Button lessSearchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
    }
}

