
namespace Projeto_Hotel
{
    partial class FormGerenciar_Clientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addCliente = new System.Windows.Forms.Button();
            this.btn_limparCamposCliente = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_editarCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.btn_editarCliente);
            this.panel1.Controls.Add(this.btn_remover);
            this.panel1.Controls.Add(this.btn_limparCamposCliente);
            this.panel1.Controls.Add(this.btn_addCliente);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_cidade);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_telefone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_sobrenome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_nomeCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciara Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(111, 84);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 26);
            this.tb_id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeCliente.Location = new System.Drawing.Point(111, 126);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(178, 26);
            this.tb_nomeCliente.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sobrenome";
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sobrenome.Location = new System.Drawing.Point(111, 168);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(178, 26);
            this.tb_sobrenome.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefone:";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefone.Location = new System.Drawing.Point(111, 210);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(178, 26);
            this.tb_telefone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cidade:";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(111, 252);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(178, 26);
            this.tb_cidade.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 342);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_addCliente
            // 
            this.btn_addCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_addCliente.ForeColor = System.Drawing.Color.White;
            this.btn_addCliente.Location = new System.Drawing.Point(22, 313);
            this.btn_addCliente.Name = "btn_addCliente";
            this.btn_addCliente.Size = new System.Drawing.Size(142, 23);
            this.btn_addCliente.TabIndex = 12;
            this.btn_addCliente.Text = "Adicionar Novo Cliente";
            this.btn_addCliente.UseVisualStyleBackColor = false;
            // 
            // btn_limparCamposCliente
            // 
            this.btn_limparCamposCliente.BackColor = System.Drawing.Color.White;
            this.btn_limparCamposCliente.Location = new System.Drawing.Point(22, 342);
            this.btn_limparCamposCliente.Name = "btn_limparCamposCliente";
            this.btn_limparCamposCliente.Size = new System.Drawing.Size(92, 23);
            this.btn_limparCamposCliente.TabIndex = 13;
            this.btn_limparCamposCliente.Text = "Limpar Campos";
            this.btn_limparCamposCliente.UseVisualStyleBackColor = false;
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(251, 313);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 14;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            // 
            // btn_editarCliente
            // 
            this.btn_editarCliente.BackColor = System.Drawing.Color.Orange;
            this.btn_editarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_editarCliente.Location = new System.Drawing.Point(170, 313);
            this.btn_editarCliente.Name = "btn_editarCliente";
            this.btn_editarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_editarCliente.TabIndex = 15;
            this.btn_editarCliente.Text = "Editar";
            this.btn_editarCliente.UseVisualStyleBackColor = false;
            // 
            // FormGerenciar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormGerenciar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGerenciar_Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_editarCliente;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_limparCamposCliente;
        private System.Windows.Forms.Button btn_addCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nomeCliente;
    }
}