namespace LindenmayerSystemVisualizer
{
    partial class LSystemVisualizer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sliderGeneration = new System.Windows.Forms.TrackBar();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAxiom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLSystem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGeneration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDraw);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.sliderGeneration);
            this.splitContainer1.Panel1.Controls.Add(this.txtAngle);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtRules);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtAxiom);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picLSystem);
            this.splitContainer1.Size = new System.Drawing.Size(592, 411);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(353, 8);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(227, 131);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "N = 0";
            // 
            // sliderGeneration
            // 
            this.sliderGeneration.LargeChange = 1;
            this.sliderGeneration.Location = new System.Drawing.Point(100, 94);
            this.sliderGeneration.Name = "sliderGeneration";
            this.sliderGeneration.Size = new System.Drawing.Size(236, 45);
            this.sliderGeneration.TabIndex = 6;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(100, 68);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(236, 20);
            this.txtAngle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Angle :=";
            // 
            // txtRules
            // 
            this.txtRules.Location = new System.Drawing.Point(100, 40);
            this.txtRules.Name = "txtRules";
            this.txtRules.Size = new System.Drawing.Size(236, 20);
            this.txtRules.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rules :=";
            // 
            // txtAxiom
            // 
            this.txtAxiom.Location = new System.Drawing.Point(100, 14);
            this.txtAxiom.Name = "txtAxiom";
            this.txtAxiom.Size = new System.Drawing.Size(236, 20);
            this.txtAxiom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axiom :=";
            // 
            // picLSystem
            // 
            this.picLSystem.BackColor = System.Drawing.Color.White;
            this.picLSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLSystem.Location = new System.Drawing.Point(0, 0);
            this.picLSystem.Margin = new System.Windows.Forms.Padding(10);
            this.picLSystem.Name = "picLSystem";
            this.picLSystem.Size = new System.Drawing.Size(592, 258);
            this.picLSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLSystem.TabIndex = 0;
            this.picLSystem.TabStop = false;
            // 
            // LSystemVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 411);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LSystemVisualizer";
            this.Text = "Lindenmayer Systems Visualizer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sliderGeneration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar sliderGeneration;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAxiom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLSystem;
    }
}

