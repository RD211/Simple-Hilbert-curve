namespace Hilbert
{
    partial class Form1
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
            this.pbox_view = new System.Windows.Forms.PictureBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.num_order = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_order)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_view
            // 
            this.pbox_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_view.Location = new System.Drawing.Point(0, 0);
            this.pbox_view.Name = "pbox_view";
            this.pbox_view.Size = new System.Drawing.Size(512, 512);
            this.pbox_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_view.TabIndex = 0;
            this.pbox_view.TabStop = false;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(437, 29);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // num_order
            // 
            this.num_order.Location = new System.Drawing.Point(441, 3);
            this.num_order.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_order.Name = "num_order";
            this.num_order.Size = new System.Drawing.Size(71, 20);
            this.num_order.TabIndex = 2;
            this.num_order.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 516);
            this.Controls.Add(this.num_order);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.pbox_view);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_view;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.NumericUpDown num_order;
    }
}

