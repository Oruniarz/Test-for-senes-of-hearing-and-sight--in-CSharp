﻿
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInstrukcja = new System.Windows.Forms.Button();
            this.buttonSzkolenie_Test1 = new System.Windows.Forms.Button();
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(212, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program sprawdzający czas reakcji na bodźce";
            // 
            // buttonInstrukcja
            // 
            this.buttonInstrukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInstrukcja.Location = new System.Drawing.Point(682, 391);
            this.buttonInstrukcja.Name = "buttonInstrukcja";
            this.buttonInstrukcja.Size = new System.Drawing.Size(106, 34);
            this.buttonInstrukcja.TabIndex = 1;
            this.buttonInstrukcja.Text = "Informacje";
            this.buttonInstrukcja.UseVisualStyleBackColor = true;
            this.buttonInstrukcja.Click += new System.EventHandler(this.buttonInstrukcja_Click);
            // 
            // buttonSzkolenie_Test1
            // 
            this.buttonSzkolenie_Test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzkolenie_Test1.Location = new System.Drawing.Point(46, 125);
            this.buttonSzkolenie_Test1.Name = "buttonSzkolenie_Test1";
            this.buttonSzkolenie_Test1.Size = new System.Drawing.Size(204, 54);
            this.buttonSzkolenie_Test1.TabIndex = 2;
            this.buttonSzkolenie_Test1.Text = "Zręcznościowo-wzrokowe szkolenie";
            this.buttonSzkolenie_Test1.UseVisualStyleBackColor = true;
            this.buttonSzkolenie_Test1.Click += new System.EventHandler(this.buttonSzkolenie_Test1_Click);
            // 
            // buttonTest1
            // 
            this.buttonTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTest1.Location = new System.Drawing.Point(46, 195);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(204, 54);
            this.buttonTest1.TabIndex = 3;
            this.buttonTest1.Text = "Zręcznościowo-wzrokowy test";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(575, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Zręcznościowo-słuchowe szkolenie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(575, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "Zręcznościowo-słuchowy test\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 464);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.buttonSzkolenie_Test1);
            this.Controls.Add(this.buttonInstrukcja);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "test";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInstrukcja;
        private System.Windows.Forms.Button buttonSzkolenie_Test1;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

