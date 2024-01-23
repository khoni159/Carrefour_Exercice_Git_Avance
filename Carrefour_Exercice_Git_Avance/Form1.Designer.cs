
namespace Carrefour_Exercice_Git_Avance
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
            button_accelerer = new Button();
            button_freiner = new Button();
            button_afficherVitesse = new Button();
            button_reculer = new Button();
            SuspendLayout();
            // 
            // button_accelerer
            // 
            button_accelerer.Location = new Point(12, 17);
            button_accelerer.Name = "button_accelerer";
            button_accelerer.Size = new Size(149, 29);
            button_accelerer.TabIndex = 0;
            button_accelerer.Text = "Accélérer";
            button_accelerer.UseVisualStyleBackColor = true;
            button_accelerer.Click += button_accelerer_Click;
            // 
            // button_freiner
            // 
            button_freiner.Location = new Point(12, 52);
            button_freiner.Name = "button_freiner";
            button_freiner.Size = new Size(149, 29);
            button_freiner.TabIndex = 1;
            button_freiner.Text = "Freiner";
            button_freiner.UseVisualStyleBackColor = true;
            button_freiner.Click += button_freiner_Click;
            // 
            // button_afficherVitesse
            // 
            button_afficherVitesse.Location = new Point(12, 87);
            button_afficherVitesse.Name = "button_afficherVitesse";
            button_afficherVitesse.Size = new Size(149, 29);
            button_afficherVitesse.TabIndex = 2;
            button_afficherVitesse.Text = "Afficher la vitesse";
            button_afficherVitesse.UseVisualStyleBackColor = true;
            button_afficherVitesse.Click += button_afficherVitesse_Click;
            // 
            // button_reculer
            // 
            button_reculer.Location = new Point(167, 17);
            button_reculer.Name = "button_reculer";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 136);
            Controls.Add(button_reculer);
            Controls.Add(button_afficherVitesse);
            Controls.Add(button_freiner);
            Controls.Add(button_accelerer);
            Name = "Form1";
            Text = "Voiture";
            ResumeLayout(false);
        }

        

        #endregion
        private Button button_accelerer;
        private Button button_freiner;
        private Button button_afficherVitesse;
        private Button button_reculer;
    }
}
