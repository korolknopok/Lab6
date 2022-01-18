using System.ComponentModel;

namespace Lab6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "задание 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "задание 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "задание 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "задание 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(198, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 97);
            this.label1.TabIndex = 4;
            this.label1.Text = "Написать программу, которая вводит текст, состоящий из нескольких\r\nпредложений, и" + " выводит на экран только предложения, не содержащие\r\nзапятых.\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(198, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 106);
            this.label2.TabIndex = 5;
            this.label2.Text = "Исключить из данной строки группы символов, расположенные между\r\nскобками ( , ). " + "Сами скобки тоже должны быть исключены. Предполагается,\r\nчто внутри каждой пары " + "скобок нет других скобок.\r\n";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(198, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 82);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дан текст. Переписать текст, предварительно заменяя первую букву каждого\r\nслова н" + "а заглавную. \r\n";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(204, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 86);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дан текст, имеющий структуру «Фамилия И.О. - $оклад». Вывести на экран\r\nфамилия в" + "сех лиц, чей оклад превышает $9000. \r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        #endregion
    }
}