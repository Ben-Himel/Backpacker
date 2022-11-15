namespace Backpacker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxPackableItems = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpaceA = new System.Windows.Forms.Label();
            this.comboBoxBags = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelBagType = new System.Windows.Forms.Label();
            this.labelBagHeight = new System.Windows.Forms.Label();
            this.labelBagWidth = new System.Windows.Forms.Label();
            this.labelBagLength = new System.Windows.Forms.Label();
            this.labelBagMinWeight = new System.Windows.Forms.Label();
            this.labelnumbPockts = new System.Windows.Forms.Label();
            this.listBoxPackedItems = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.buttonNewBag = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxPackableItems
            // 
            this.checkedListBoxPackableItems.FormattingEnabled = true;
            this.checkedListBoxPackableItems.Location = new System.Drawing.Point(311, 48);
            this.checkedListBoxPackableItems.Name = "checkedListBoxPackableItems";
            this.checkedListBoxPackableItems.ScrollAlwaysVisible = true;
            this.checkedListBoxPackableItems.Size = new System.Drawing.Size(156, 148);
            this.checkedListBoxPackableItems.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(311, 202);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(148, 202);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packable Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Space Availlable:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelWeight.Location = new System.Drawing.Point(255, 30);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(37, 15);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "          ";
            // 
            // labelSpaceA
            // 
            this.labelSpaceA.AutoSize = true;
            this.labelSpaceA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelSpaceA.Location = new System.Drawing.Point(255, 45);
            this.labelSpaceA.Name = "labelSpaceA";
            this.labelSpaceA.Size = new System.Drawing.Size(37, 15);
            this.labelSpaceA.TabIndex = 7;
            this.labelSpaceA.Text = "          ";
            // 
            // comboBoxBags
            // 
            this.comboBoxBags.FormattingEnabled = true;
            this.comboBoxBags.Location = new System.Drawing.Point(12, 48);
            this.comboBoxBags.Name = "comboBoxBags";
            this.comboBoxBags.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBags.TabIndex = 8;
            this.comboBoxBags.SelectedIndexChanged += new System.EventHandler(this.comboBoxBags_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Height:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Width:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Length:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Weight:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Sections:";
            // 
            // labelBagType
            // 
            this.labelBagType.AutoSize = true;
            this.labelBagType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelBagType.Location = new System.Drawing.Point(72, 87);
            this.labelBagType.Name = "labelBagType";
            this.labelBagType.Size = new System.Drawing.Size(37, 15);
            this.labelBagType.TabIndex = 15;
            this.labelBagType.Text = "          ";
            // 
            // labelBagHeight
            // 
            this.labelBagHeight.AutoSize = true;
            this.labelBagHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelBagHeight.Location = new System.Drawing.Point(72, 102);
            this.labelBagHeight.Name = "labelBagHeight";
            this.labelBagHeight.Size = new System.Drawing.Size(37, 15);
            this.labelBagHeight.TabIndex = 16;
            this.labelBagHeight.Text = "          ";
            // 
            // labelBagWidth
            // 
            this.labelBagWidth.AutoSize = true;
            this.labelBagWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelBagWidth.Location = new System.Drawing.Point(72, 117);
            this.labelBagWidth.Name = "labelBagWidth";
            this.labelBagWidth.Size = new System.Drawing.Size(37, 15);
            this.labelBagWidth.TabIndex = 17;
            this.labelBagWidth.Text = "          ";
            // 
            // labelBagLength
            // 
            this.labelBagLength.AutoSize = true;
            this.labelBagLength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelBagLength.Location = new System.Drawing.Point(72, 132);
            this.labelBagLength.Name = "labelBagLength";
            this.labelBagLength.Size = new System.Drawing.Size(37, 15);
            this.labelBagLength.TabIndex = 18;
            this.labelBagLength.Text = "          ";
            // 
            // labelBagMinWeight
            // 
            this.labelBagMinWeight.AutoSize = true;
            this.labelBagMinWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelBagMinWeight.Location = new System.Drawing.Point(72, 147);
            this.labelBagMinWeight.Name = "labelBagMinWeight";
            this.labelBagMinWeight.Size = new System.Drawing.Size(37, 15);
            this.labelBagMinWeight.TabIndex = 19;
            this.labelBagMinWeight.Text = "          ";
            // 
            // labelnumbPockts
            // 
            this.labelnumbPockts.AutoSize = true;
            this.labelnumbPockts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelnumbPockts.Location = new System.Drawing.Point(72, 162);
            this.labelnumbPockts.Name = "labelnumbPockts";
            this.labelnumbPockts.Size = new System.Drawing.Size(37, 15);
            this.labelnumbPockts.TabIndex = 20;
            this.labelnumbPockts.Text = "          ";
            // 
            // listBoxPackedItems
            // 
            this.listBoxPackedItems.FormattingEnabled = true;
            this.listBoxPackedItems.ItemHeight = 15;
            this.listBoxPackedItems.Location = new System.Drawing.Point(148, 87);
            this.listBoxPackedItems.Name = "listBoxPackedItems";
            this.listBoxPackedItems.ScrollAlwaysVisible = true;
            this.listBoxPackedItems.Size = new System.Drawing.Size(145, 109);
            this.listBoxPackedItems.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 24);
            this.label18.TabIndex = 22;
            this.label18.Text = "Your Bag";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(148, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "Packed Items";
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.Location = new System.Drawing.Point(392, 4);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNewItem.TabIndex = 24;
            this.buttonNewItem.Text = "New Item";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            // 
            // buttonNewBag
            // 
            this.buttonNewBag.Location = new System.Drawing.Point(218, 4);
            this.buttonNewBag.Name = "buttonNewBag";
            this.buttonNewBag.Size = new System.Drawing.Size(75, 23);
            this.buttonNewBag.TabIndex = 25;
            this.buttonNewBag.Text = "New Bag";
            this.buttonNewBag.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 202);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 236);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNewBag);
            this.Controls.Add(this.buttonNewItem);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.listBoxPackedItems);
            this.Controls.Add(this.labelnumbPockts);
            this.Controls.Add(this.labelBagMinWeight);
            this.Controls.Add(this.labelBagLength);
            this.Controls.Add(this.labelBagWidth);
            this.Controls.Add(this.labelBagHeight);
            this.Controls.Add(this.labelBagType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBags);
            this.Controls.Add(this.labelSpaceA);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkedListBoxPackableItems);
            this.Name = "Form1";
            this.Text = "BagPacker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxPackableItems;
        private Button buttonAdd;
        private Button buttonRemove;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelWeight;
        private Label labelSpaceA;
        private ComboBox comboBoxBags;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelBagType;
        private Label labelBagHeight;
        private Label labelBagWidth;
        private Label labelBagLength;
        private Label labelBagMinWeight;
        private Label labelnumbPockts;
        private ListBox listBoxPackedItems;
        private Label label18;
        private Label label19;
        private Button buttonNewItem;
        private Button buttonNewBag;
        private Button buttonSave;
    }
}