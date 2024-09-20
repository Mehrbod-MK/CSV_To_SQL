namespace CSV_To_SQL
{
    partial class CSVToSQLForm
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
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxCSV = new GroupBox();
            buttonLoadCSV = new Button();
            textBoxCSVFilePath = new TextBox();
            label1 = new Label();
            groupBoxCSVTable = new GroupBox();
            listViewCSV = new ListView();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxCSV.SuspendLayout();
            groupBoxCSVTable.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanelMain.Controls.Add(groupBoxCSV, 1, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxCSVTable, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(800, 450);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxCSV
            // 
            groupBoxCSV.Controls.Add(buttonLoadCSV);
            groupBoxCSV.Controls.Add(textBoxCSVFilePath);
            groupBoxCSV.Controls.Add(label1);
            groupBoxCSV.Dock = DockStyle.Fill;
            groupBoxCSV.Location = new Point(10, 3);
            groupBoxCSV.Name = "groupBoxCSV";
            groupBoxCSV.Size = new Size(780, 94);
            groupBoxCSV.TabIndex = 0;
            groupBoxCSV.TabStop = false;
            groupBoxCSV.Text = "CSV File (Comma-Separated Value)";
            // 
            // buttonLoadCSV
            // 
            buttonLoadCSV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadCSV.Cursor = Cursors.Hand;
            buttonLoadCSV.Location = new Point(698, 28);
            buttonLoadCSV.Name = "buttonLoadCSV";
            buttonLoadCSV.Size = new Size(76, 32);
            buttonLoadCSV.TabIndex = 2;
            buttonLoadCSV.Text = "Choose...";
            buttonLoadCSV.UseVisualStyleBackColor = true;
            buttonLoadCSV.Click += buttonLoadCSV_Click;
            // 
            // textBoxCSVFilePath
            // 
            textBoxCSVFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCSVFilePath.Location = new Point(99, 31);
            textBoxCSVFilePath.Name = "textBoxCSVFilePath";
            textBoxCSVFilePath.ReadOnly = true;
            textBoxCSVFilePath.Size = new Size(593, 27);
            textBoxCSVFilePath.TabIndex = 1;
            textBoxCSVFilePath.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "File Path:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxCSVTable
            // 
            groupBoxCSVTable.Controls.Add(listViewCSV);
            groupBoxCSVTable.Dock = DockStyle.Fill;
            groupBoxCSVTable.Location = new Point(10, 103);
            groupBoxCSVTable.Name = "groupBoxCSVTable";
            groupBoxCSVTable.Size = new Size(780, 169);
            groupBoxCSVTable.TabIndex = 1;
            groupBoxCSVTable.TabStop = false;
            groupBoxCSVTable.Text = "CSV Table";
            // 
            // listViewCSV
            // 
            listViewCSV.CheckBoxes = true;
            listViewCSV.Cursor = Cursors.Hand;
            listViewCSV.Dock = DockStyle.Fill;
            listViewCSV.FullRowSelect = true;
            listViewCSV.GridLines = true;
            listViewCSV.Location = new Point(3, 23);
            listViewCSV.Name = "listViewCSV";
            listViewCSV.Size = new Size(774, 143);
            listViewCSV.TabIndex = 0;
            listViewCSV.UseCompatibleStateImageBehavior = false;
            // 
            // CSVToSQLForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelMain);
            Name = "CSVToSQLForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MMK - CSV to SQL Statements Converter";
            tableLayoutPanelMain.ResumeLayout(false);
            groupBoxCSV.ResumeLayout(false);
            groupBoxCSV.PerformLayout();
            groupBoxCSVTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private GroupBox groupBoxCSV;
        private Label label1;
        private Button buttonLoadCSV;
        private TextBox textBoxCSVFilePath;
        private GroupBox groupBoxCSVTable;
        private ListView listViewCSV;
    }
}
