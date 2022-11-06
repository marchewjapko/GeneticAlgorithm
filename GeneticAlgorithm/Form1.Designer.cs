using OxyPlot.Series;
using OxyPlot;

namespace GeneticAlgorithm
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
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.populationSizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mutationChanceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bestIndividualFitnessTextBox = new System.Windows.Forms.TextBox();
            this.bestIndividualValueTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(11, 415);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(117, 23);
            this.iterationsTextBox.TabIndex = 0;
            this.iterationsTextBox.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of iterations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Population size";
            // 
            // populationSizeTextBox
            // 
            this.populationSizeTextBox.Location = new System.Drawing.Point(149, 415);
            this.populationSizeTextBox.Name = "populationSizeTextBox";
            this.populationSizeTextBox.Size = new System.Drawing.Size(117, 23);
            this.populationSizeTextBox.TabIndex = 2;
            this.populationSizeTextBox.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mutation chance";
            // 
            // mutationChanceTextBox
            // 
            this.mutationChanceTextBox.Location = new System.Drawing.Point(289, 415);
            this.mutationChanceTextBox.Name = "mutationChanceTextBox";
            this.mutationChanceTextBox.Size = new System.Drawing.Size(117, 23);
            this.mutationChanceTextBox.TabIndex = 4;
            this.mutationChanceTextBox.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.Control;
            this.plotView1.Location = new System.Drawing.Point(12, 12);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(530, 358);
            this.plotView1.TabIndex = 7;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(462, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Best individual";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fitness";
            // 
            // bestIndividualFitnessTextBox
            // 
            this.bestIndividualFitnessTextBox.Location = new System.Drawing.Point(567, 414);
            this.bestIndividualFitnessTextBox.Name = "bestIndividualFitnessTextBox";
            this.bestIndividualFitnessTextBox.ReadOnly = true;
            this.bestIndividualFitnessTextBox.Size = new System.Drawing.Size(100, 23);
            this.bestIndividualFitnessTextBox.TabIndex = 11;
            // 
            // bestIndividualValueTextBox
            // 
            this.bestIndividualValueTextBox.Location = new System.Drawing.Point(461, 414);
            this.bestIndividualValueTextBox.Name = "bestIndividualValueTextBox";
            this.bestIndividualValueTextBox.ReadOnly = true;
            this.bestIndividualValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.bestIndividualValueTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(406, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plotView2
            // 
            this.plotView2.BackColor = System.Drawing.SystemColors.Control;
            this.plotView2.Location = new System.Drawing.Point(548, 12);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(240, 358);
            this.plotView2.TabIndex = 16;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bestIndividualValueTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bestIndividualFitnessTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mutationChanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.populationSizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox iterationsTextBox;
        private Label label1;
        private Label label2;
        private TextBox populationSizeTextBox;
        private Label label3;
        private TextBox mutationChanceTextBox;
        private Button button1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label4;
        private Label label6;
        private TextBox bestIndividualFitnessTextBox;
        private TextBox bestIndividualValueTextBox;
        private Label label7;
        private Label label8;
        private OxyPlot.WindowsForms.PlotView plotView2;
    }
}