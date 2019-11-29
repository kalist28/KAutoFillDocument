namespace KFillDoc
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopText = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainObjectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DocName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopText
            // 
            this.TopText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopText.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopText.Enabled = false;
            this.TopText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopText.Location = new System.Drawing.Point(0, 0);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(784, 51);
            this.TopText.TabIndex = 1;
            this.TopText.Text = "K_AutoFillDoc";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 92);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(207, 357);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.mainObjectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainObjectPanel.AutoScroll = true;
            this.mainObjectPanel.ColumnCount = 2;
            this.mainObjectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainObjectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.mainObjectPanel.Location = new System.Drawing.Point(225, 112);
            this.mainObjectPanel.Name = "mainObjectPanel";
            this.mainObjectPanel.RowCount = 1;
            this.mainObjectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.mainObjectPanel.Size = new System.Drawing.Size(547, 337);
            this.mainObjectPanel.TabIndex = 3;
            // 
            // DocName
            // 
            this.DocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocName.Location = new System.Drawing.Point(225, 71);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(547, 38);
            this.DocName.TabIndex = 4;
            this.DocName.Text = "DocName";
            this.DocName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.mainObjectPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.TopText);
            this.Name = "MainMenu";
            this.Text = "K_AutoFillDoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mainObjectPanel;
        private System.Windows.Forms.Label DocName;
    }
}

