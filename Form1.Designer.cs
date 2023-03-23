
namespace REPASO3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonCuotas = new System.Windows.Forms.Button();
            this.buttonPropietario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(744, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(811, 57);
            this.buttonOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(177, 97);
            this.buttonOrdenar.TabIndex = 1;
            this.buttonOrdenar.Text = "Ordenar por cuota de mantenimiento:";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonCuotas
            // 
            this.buttonCuotas.Location = new System.Drawing.Point(811, 173);
            this.buttonCuotas.Name = "buttonCuotas";
            this.buttonCuotas.Size = new System.Drawing.Size(177, 97);
            this.buttonCuotas.TabIndex = 2;
            this.buttonCuotas.Text = "Mostrar Cuotas";
            this.buttonCuotas.UseVisualStyleBackColor = true;
            this.buttonCuotas.Click += new System.EventHandler(this.buttonCuotas_Click);
            // 
            // buttonPropietario
            // 
            this.buttonPropietario.Location = new System.Drawing.Point(811, 303);
            this.buttonPropietario.Name = "buttonPropietario";
            this.buttonPropietario.Size = new System.Drawing.Size(177, 97);
            this.buttonPropietario.TabIndex = 3;
            this.buttonPropietario.Text = "Propietario con más cuotas a pagar";
            this.buttonPropietario.UseVisualStyleBackColor = true;
            this.buttonPropietario.Click += new System.EventHandler(this.buttonPropietario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPropietario);
            this.Controls.Add(this.buttonCuotas);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonCuotas;
        private System.Windows.Forms.Button buttonPropietario;
        private System.Windows.Forms.Button button1;
    }
}

