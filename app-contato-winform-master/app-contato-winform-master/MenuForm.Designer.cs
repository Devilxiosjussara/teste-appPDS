
namespace AppContatoForm
{
    partial class MenuForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastro = new Sunny.UI.UIButton();
            this.ListarContato = new Sunny.UI.UIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastro.FillColor = System.Drawing.Color.Yellow;
            this.btnCadastro.FillDisableColor = System.Drawing.Color.Bisque;
            this.btnCadastro.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Location = new System.Drawing.Point(3, 3);
            this.btnCadastro.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Radius = 1;
            this.btnCadastro.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastro.RectSelectedColor = System.Drawing.Color.Yellow;
            this.btnCadastro.Size = new System.Drawing.Size(245, 145);
            this.btnCadastro.Style = Sunny.UI.UIStyle.Custom;
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro de Contato";
            this.btnCadastro.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // ListarContato
            // 
            this.ListarContato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListarContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListarContato.FillColor = System.Drawing.Color.Yellow;
            this.ListarContato.FillDisableColor = System.Drawing.Color.Bisque;
            this.ListarContato.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarContato.ForeColor = System.Drawing.Color.Black;
            this.ListarContato.Location = new System.Drawing.Point(254, 3);
            this.ListarContato.MinimumSize = new System.Drawing.Size(1, 1);
            this.ListarContato.Name = "ListarContato";
            this.ListarContato.Radius = 1;
            this.ListarContato.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListarContato.RectSelectedColor = System.Drawing.Color.Yellow;
            this.ListarContato.Size = new System.Drawing.Size(245, 145);
            this.ListarContato.Style = Sunny.UI.UIStyle.Custom;
            this.ListarContato.TabIndex = 3;
            this.ListarContato.Text = "Listar Contato";
            this.ListarContato.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ListarContato.Click += new System.EventHandler(this.ListarContato_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCadastro);
            this.flowLayoutPanel1.Controls.Add(this.ListarContato);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(545, 291);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 441);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnCadastro;
        private Sunny.UI.UIButton ListarContato;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

