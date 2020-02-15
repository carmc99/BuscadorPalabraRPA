namespace Rpa.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.txt_ultimo_parrafo = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar_palabra = new System.Windows.Forms.TextBox();
            this.txt_posicion = new System.Windows.Forms.TextBox();
            this.lbl_word = new System.Windows.Forms.Label();
            this.Posición = new System.Windows.Forms.Label();
            this.groupBox_ayuda = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ultimo_parrafo
            // 
            this.txt_ultimo_parrafo.Location = new System.Drawing.Point(12, 76);
            this.txt_ultimo_parrafo.Multiline = true;
            this.txt_ultimo_parrafo.Name = "txt_ultimo_parrafo";
            this.txt_ultimo_parrafo.Size = new System.Drawing.Size(502, 159);
            this.txt_ultimo_parrafo.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(439, 241);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_buscar_palabra
            // 
            this.txt_buscar_palabra.Location = new System.Drawing.Point(99, 12);
            this.txt_buscar_palabra.Name = "txt_buscar_palabra";
            this.txt_buscar_palabra.Size = new System.Drawing.Size(194, 20);
            this.txt_buscar_palabra.TabIndex = 2;
            // 
            // txt_posicion
            // 
            this.txt_posicion.Location = new System.Drawing.Point(99, 38);
            this.txt_posicion.Name = "txt_posicion";
            this.txt_posicion.Size = new System.Drawing.Size(54, 20);
            this.txt_posicion.TabIndex = 3;
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Location = new System.Drawing.Point(12, 15);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(81, 13);
            this.lbl_word.TabIndex = 4;
            this.lbl_word.Text = "Buscar palabra:";
            // 
            // Posición
            // 
            this.Posición.AutoSize = true;
            this.Posición.Location = new System.Drawing.Point(12, 45);
            this.Posición.Name = "Posición";
            this.Posición.Size = new System.Drawing.Size(47, 13);
            this.Posición.TabIndex = 5;
            this.Posición.Text = "Posicion";
            // 
            // groupBox_ayuda
            // 
            this.groupBox_ayuda.Controls.Add(this.label3);
            this.groupBox_ayuda.Controls.Add(this.label2);
            this.groupBox_ayuda.Controls.Add(this.label1);
            this.groupBox_ayuda.Location = new System.Drawing.Point(12, 270);
            this.groupBox_ayuda.Name = "groupBox_ayuda";
            this.groupBox_ayuda.Size = new System.Drawing.Size(499, 148);
            this.groupBox_ayuda.TabIndex = 6;
            this.groupBox_ayuda.TabStop = false;
            this.groupBox_ayuda.Text = "Instrucciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Buscar palabra: ingrese la palabra a buscar, por defecto la busqueda se realiz" +
    "a por \r\nmedio del buscador google.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 78);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 420);
            this.Controls.Add(this.groupBox_ayuda);
            this.Controls.Add(this.Posición);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.txt_posicion);
            this.Controls.Add(this.txt_buscar_palabra);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_ultimo_parrafo);
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBox_ayuda.ResumeLayout(false);
            this.groupBox_ayuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ultimo_parrafo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar_palabra;
        private System.Windows.Forms.TextBox txt_posicion;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label Posición;
        private System.Windows.Forms.GroupBox groupBox_ayuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}