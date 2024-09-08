namespace scrapy2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.checkRedondeo = new System.Windows.Forms.CheckBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopiarSub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(136, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(451, 38);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicamento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(593, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 38);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 568);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(954, 36);
            this.progressBar1.TabIndex = 5;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Futura XBlk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(33, 56);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Metropolis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.Size = new System.Drawing.Size(688, 470);
            this.dgvMedicamentos.TabIndex = 6;
            this.dgvMedicamentos.SelectionChanged += new System.EventHandler(this.dgvMedicamentos_SelectionChanged);
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("AdoraPRO-75", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.Location = new System.Drawing.Point(742, 69);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(91, 33);
            this.lblPrecioCosto.TabIndex = 7;
            this.lblPrecioCosto.Text = "label2";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Font = new System.Drawing.Font("AdoraPRO-75", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtPorcentaje.Location = new System.Drawing.Point(748, 159);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(115, 29);
            this.txtPorcentaje.TabIndex = 8;
            // 
            // checkRedondeo
            // 
            this.checkRedondeo.AutoSize = true;
            this.checkRedondeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRedondeo.Location = new System.Drawing.Point(863, 461);
            this.checkRedondeo.Name = "checkRedondeo";
            this.checkRedondeo.Size = new System.Drawing.Size(127, 28);
            this.checkRedondeo.TabIndex = 9;
            this.checkRedondeo.Text = "Redondeo";
            this.checkRedondeo.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("AdoraPRO-75", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtResultado.Location = new System.Drawing.Point(738, 422);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(252, 33);
            this.txtResultado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AdoraPRO-75", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Porcentaje";
            // 
            // txtSub
            // 
            this.txtSub.Font = new System.Drawing.Font("AdoraPRO-75", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSub.Location = new System.Drawing.Point(738, 340);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(252, 33);
            this.txtSub.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AdoraPRO-75", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sub-Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AdoraPRO-75", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio Final:";
            // 
            // btnCopiarSub
            // 
            this.btnCopiarSub.Location = new System.Drawing.Point(915, 316);
            this.btnCopiarSub.Name = "btnCopiarSub";
            this.btnCopiarSub.Size = new System.Drawing.Size(75, 23);
            this.btnCopiarSub.TabIndex = 15;
            this.btnCopiarSub.Text = "Copiar";
            this.btnCopiarSub.UseVisualStyleBackColor = true;
            this.btnCopiarSub.Click += new System.EventHandler(this.btnCopiarSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 643);
            this.Controls.Add(this.btnCopiarSub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.checkRedondeo);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.CheckBox checkRedondeo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopiarSub;
    }
}

