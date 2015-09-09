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
            this.cboxSystems = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sliderGeneration = new System.Windows.Forms.TrackBar();
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
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboxSystems);
            this.splitContainer1.Panel1.Controls.Add(this.btnDraw);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.sliderGeneration);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picLSystem);
            this.splitContainer1.Size = new System.Drawing.Size(800, 411);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // cboxSystems
            // 
            this.cboxSystems.FormattingEnabled = true;
            this.cboxSystems.Location = new System.Drawing.Point(12, 12);
            this.cboxSystems.Name = "cboxSystems";
            this.cboxSystems.Size = new System.Drawing.Size(194, 21);
            this.cboxSystems.TabIndex = 9;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(12, 39);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(194, 34);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "N = 0";
            // 
            // sliderGeneration
            // 
            this.sliderGeneration.LargeChange = 1;
            this.sliderGeneration.Location = new System.Drawing.Point(12, 101);
            this.sliderGeneration.Name = "sliderGeneration";
            this.sliderGeneration.Size = new System.Drawing.Size(194, 45);
            this.sliderGeneration.TabIndex = 6;
            // 
            // picLSystem
            // 
            this.picLSystem.BackColor = System.Drawing.Color.White;
            this.picLSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLSystem.Location = new System.Drawing.Point(0, 0);
            this.picLSystem.Margin = new System.Windows.Forms.Padding(10);
            this.picLSystem.Name = "picLSystem";
            this.picLSystem.Size = new System.Drawing.Size(584, 411);
            this.picLSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLSystem.TabIndex = 0;
            this.picLSystem.TabStop = false;
            // 
            // LSystemVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
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
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLSystem;
        private System.Windows.Forms.ComboBox cboxSystems;
    }
}

