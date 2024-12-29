namespace laboratornaya_rabota_17
{
    partial class WForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuestionnaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Титульный лист";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTitlePage);
            // 
            // btnQuestionnaire
            // 
            this.btnQuestionnaire.Location = new System.Drawing.Point(334, 156);
            this.btnQuestionnaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuestionnaire.Name = "btnQuestionnaire";
            this.btnQuestionnaire.Size = new System.Drawing.Size(190, 86);
            this.btnQuestionnaire.TabIndex = 1;
            this.btnQuestionnaire.Text = "Анкета";
            this.btnQuestionnaire.UseVisualStyleBackColor = true;
            this.btnQuestionnaire.Click += new System.EventHandler(this.btnQuestionnaire_Click);
            // 
            // WForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnQuestionnaire);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WForms";
            this.Text = "Задание №17 выполнила: Грачева Н.С.; Вариант №5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuestionnaire;
    }
}