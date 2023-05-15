namespace app.Forms
{
    partial class AddIngredientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addIngredientForm_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addIngredientForm_weight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.addIngredientForm_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить ингредиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вес (г)";
            // 
            // addIngredientForm_name
            // 
            this.addIngredientForm_name.Location = new System.Drawing.Point(7, 58);
            this.addIngredientForm_name.Name = "addIngredientForm_name";
            this.addIngredientForm_name.Size = new System.Drawing.Size(295, 26);
            this.addIngredientForm_name.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить новый";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addIngredientForm_weight
            // 
            this.addIngredientForm_weight.Location = new System.Drawing.Point(12, 120);
            this.addIngredientForm_weight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.addIngredientForm_weight.Name = "addIngredientForm_weight";
            this.addIngredientForm_weight.Size = new System.Drawing.Size(120, 26);
            this.addIngredientForm_weight.TabIndex = 7;
            // 
            // AddIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 206);
            this.Controls.Add(this.addIngredientForm_weight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addIngredientForm_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddIngredientForm";
            this.Text = "Форма добавления ингредиентов";
            ((System.ComponentModel.ISupportInitialize)(this.addIngredientForm_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox addIngredientForm_name;
        private Button button1;
        private Button button2;
        private NumericUpDown addIngredientForm_weight;
    }
}