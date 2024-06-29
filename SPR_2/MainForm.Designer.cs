namespace SPR_2
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
            panel1 = new Panel();
            buttonPopTail = new Button();
            buttonAddRandomTail = new Button();
            buttonPrint = new Button();
            buttonPop = new Button();
            buttonAddRandom = new Button();
            textBoxTypeData = new TextBox();
            panel2 = new Panel();
            textBoxSortTask = new TextBox();
            buttonSort = new Button();
            buttonStepBack = new Button();
            textBoxAlghoritmSort = new TextBox();
            buttonStepForward = new Button();
            panel3 = new Panel();
            listBoxExampleOfWork = new ListBox();
            textBoxInputGraph = new TextBox();
            buttonMatrix = new Button();
            textBoxAlghoritm = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPopTail);
            panel1.Controls.Add(buttonAddRandomTail);
            panel1.Controls.Add(buttonPrint);
            panel1.Controls.Add(buttonPop);
            panel1.Controls.Add(buttonAddRandom);
            panel1.Controls.Add(textBoxTypeData);
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 230);
            panel1.TabIndex = 0;
            // 
            // buttonPopTail
            // 
            buttonPopTail.Location = new Point(106, 156);
            buttonPopTail.Name = "buttonPopTail";
            buttonPopTail.Size = new Size(94, 52);
            buttonPopTail.TabIndex = 5;
            buttonPopTail.Text = "удалить из хвоста";
            buttonPopTail.UseVisualStyleBackColor = true;
            buttonPopTail.Click += buttonPopTail_Click;
            // 
            // buttonAddRandomTail
            // 
            buttonAddRandomTail.Location = new Point(6, 156);
            buttonAddRandomTail.Name = "buttonAddRandomTail";
            buttonAddRandomTail.Size = new Size(94, 52);
            buttonAddRandomTail.TabIndex = 4;
            buttonAddRandomTail.Text = "добавить в хвост";
            buttonAddRandomTail.UseVisualStyleBackColor = true;
            buttonAddRandomTail.Click += buttonAddRandomTail_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(206, 86);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(94, 29);
            buttonPrint.TabIndex = 3;
            buttonPrint.Text = "вывод";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonPop
            // 
            buttonPop.Location = new Point(106, 86);
            buttonPop.Name = "buttonPop";
            buttonPop.Size = new Size(94, 64);
            buttonPop.TabIndex = 2;
            buttonPop.Text = "удалить из головы";
            buttonPop.UseVisualStyleBackColor = true;
            buttonPop.Click += buttonPop_Click;
            // 
            // buttonAddRandom
            // 
            buttonAddRandom.Location = new Point(6, 86);
            buttonAddRandom.Name = "buttonAddRandom";
            buttonAddRandom.Size = new Size(94, 64);
            buttonAddRandom.TabIndex = 1;
            buttonAddRandom.Text = "добавить в голову";
            buttonAddRandom.UseVisualStyleBackColor = true;
            buttonAddRandom.Click += buttonAddRandom_Click;
            // 
            // textBoxTypeData
            // 
            textBoxTypeData.Location = new Point(6, 13);
            textBoxTypeData.Multiline = true;
            textBoxTypeData.Name = "textBoxTypeData";
            textBoxTypeData.Size = new Size(294, 67);
            textBoxTypeData.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSortTask);
            panel2.Controls.Add(buttonSort);
            panel2.Controls.Add(buttonStepBack);
            panel2.Controls.Add(textBoxAlghoritmSort);
            panel2.Controls.Add(buttonStepForward);
            panel2.Location = new Point(375, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 230);
            panel2.TabIndex = 1;
            // 
            // textBoxSortTask
            // 
            textBoxSortTask.Location = new Point(21, 133);
            textBoxSortTask.Multiline = true;
            textBoxSortTask.Name = "textBoxSortTask";
            textBoxSortTask.Size = new Size(341, 85);
            textBoxSortTask.TabIndex = 8;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(21, 86);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(99, 29);
            buttonSort.TabIndex = 7;
            buttonSort.Text = "сортировка";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonStepBack
            // 
            buttonStepBack.Location = new Point(268, 86);
            buttonStepBack.Name = "buttonStepBack";
            buttonStepBack.Size = new Size(94, 29);
            buttonStepBack.TabIndex = 6;
            buttonStepBack.Text = "назад";
            buttonStepBack.UseVisualStyleBackColor = true;
            buttonStepBack.Click += buttonStepBack_Click;
            // 
            // textBoxAlghoritmSort
            // 
            textBoxAlghoritmSort.Location = new Point(21, 13);
            textBoxAlghoritmSort.Multiline = true;
            textBoxAlghoritmSort.Name = "textBoxAlghoritmSort";
            textBoxAlghoritmSort.Size = new Size(341, 67);
            textBoxAlghoritmSort.TabIndex = 5;
            // 
            // buttonStepForward
            // 
            buttonStepForward.Location = new Point(168, 86);
            buttonStepForward.Name = "buttonStepForward";
            buttonStepForward.Size = new Size(94, 29);
            buttonStepForward.TabIndex = 4;
            buttonStepForward.Text = "вперед";
            buttonStepForward.UseVisualStyleBackColor = true;
            buttonStepForward.Click += buttonStepForward_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxExampleOfWork);
            panel3.Controls.Add(textBoxInputGraph);
            panel3.Controls.Add(buttonMatrix);
            panel3.Controls.Add(textBoxAlghoritm);
            panel3.Location = new Point(48, 268);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 175);
            panel3.TabIndex = 2;
            // 
            // listBoxExampleOfWork
            // 
            listBoxExampleOfWork.FormattingEnabled = true;
            listBoxExampleOfWork.ItemHeight = 20;
            listBoxExampleOfWork.Location = new Point(372, 10);
            listBoxExampleOfWork.Name = "listBoxExampleOfWork";
            listBoxExampleOfWork.Size = new Size(263, 124);
            listBoxExampleOfWork.TabIndex = 10;
            // 
            // textBoxInputGraph
            // 
            textBoxInputGraph.Location = new Point(139, 143);
            textBoxInputGraph.Name = "textBoxInputGraph";
            textBoxInputGraph.Size = new Size(125, 27);
            textBoxInputGraph.TabIndex = 9;
            // 
            // buttonMatrix
            // 
            buttonMatrix.Location = new Point(14, 141);
            buttonMatrix.Name = "buttonMatrix";
            buttonMatrix.Size = new Size(99, 29);
            buttonMatrix.TabIndex = 8;
            buttonMatrix.Text = "матрица";
            buttonMatrix.UseVisualStyleBackColor = true;
            buttonMatrix.Click += buttonMatrix_Click;
            // 
            // textBoxAlghoritm
            // 
            textBoxAlghoritm.Location = new Point(14, 10);
            textBoxAlghoritm.Multiline = true;
            textBoxAlghoritm.Name = "textBoxAlghoritm";
            textBoxAlghoritm.Size = new Size(294, 125);
            textBoxAlghoritm.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonPrint;
        private Button buttonPop;
        private Button buttonAddRandom;
        private TextBox textBoxTypeData;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBoxAlghoritmSort;
        private Button buttonStepForward;
        private TextBox textBoxAlghoritm;
        private Button buttonPopTail;
        private Button buttonAddRandomTail;
        private Button buttonSort;
        private Button buttonStepBack;
        private Button buttonMatrix;
        private TextBox textBoxInputGraph;
        private TextBox textBoxSortTask;
        private ListBox listBoxExampleOfWork;
    }
}