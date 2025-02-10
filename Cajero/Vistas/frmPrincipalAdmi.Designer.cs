namespace Cajero.Vistas
{
    partial class frmPrincipalAdmi
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
            components = new System.ComponentModel.Container();
            sidebar = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            btnham = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel7 = new Panel();
            btnPanel = new Button();
            button3 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            menu = new Button();
            panel5 = new Panel();
            btnAgregar = new Button();
            panel4 = new Panel();
            btnEditar = new Button();
            panel1 = new Panel();
            btnEliminar = new Button();
            panel3 = new Panel();
            btnReporte = new Button();
            btnReportes = new Button();
            panel8 = new Panel();
            btnInicializar = new Button();
            button2 = new Button();
            menuTansition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelContenedor = new Panel();
            splitter1 = new Splitter();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnham).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            menuContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(5, 138, 138);
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(label1);
            sidebar.Controls.Add(flowLayoutPanel1);
            sidebar.Controls.Add(label3);
            sidebar.Controls.Add(btnham);
            sidebar.Dock = DockStyle.Top;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1024, 54);
            sidebar.TabIndex = 1;
            sidebar.MouseDown += sidebar_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(743, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 3;
            label1.Text = "LOAEC CREDOMATIC";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 9);
            label3.Name = "label3";
            label3.Size = new Size(250, 28);
            label3.TabIndex = 2;
            label3.Text = "Panel de Adminstracion";
            // 
            // btnham
            // 
            btnham.Image = Properties.Resources.Despliege;
            btnham.Location = new Point(3, -1);
            btnham.Name = "btnham";
            btnham.Size = new Size(50, 50);
            btnham.SizeMode = PictureBoxSizeMode.AutoSize;
            btnham.TabIndex = 2;
            btnham.TabStop = false;
            btnham.Click += btnham_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(5, 138, 138);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(menuContainer);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 54);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(194, 666);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 100);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnPanel);
            panel7.Controls.Add(button3);
            panel7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel7.Location = new Point(1, 20);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(193, 80);
            panel7.TabIndex = 8;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.FromArgb(5, 138, 138);
            btnPanel.BackgroundImageLayout = ImageLayout.None;
            btnPanel.FlatStyle = FlatStyle.Flat;
            btnPanel.Image = Properties.Resources.reporte_factura;
            btnPanel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanel.Location = new Point(7, 12);
            btnPanel.Margin = new Padding(0);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(178, 57);
            btnPanel.TabIndex = 4;
            btnPanel.Text = "      Inicio";
            btnPanel.UseVisualStyleBackColor = false;
            btnPanel.Click += btnPanel_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(5, 138, 138);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.reporte_factura;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 13);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(178, 57);
            button3.TabIndex = 3;
            button3.Text = "      Reportes";
            button3.UseVisualStyleBackColor = false;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel5);
            menuContainer.Controls.Add(panel4);
            menuContainer.Controls.Add(panel1);
            menuContainer.Location = new Point(0, 106);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(194, 80);
            menuContainer.TabIndex = 7;
            menuContainer.Paint += flowLayoutPanel3_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(menu);
            panel6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(194, 80);
            panel6.TabIndex = 8;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(5, 138, 138);
            menu.BackgroundImageLayout = ImageLayout.None;
            menu.FlatStyle = FlatStyle.Flat;
            menu.ForeColor = SystemColors.ActiveCaptionText;
            menu.Image = Properties.Resources.Clientes;
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(9, 11);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Size = new Size(178, 57);
            menu.TabIndex = 0;
            menu.Text = "     Usuarios";
            menu.UseVisualStyleBackColor = false;
            menu.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAgregar);
            panel5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel5.Location = new Point(0, 80);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 80);
            panel5.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(5, 138, 138);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = Properties.Resources.Usuario;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(14, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 67);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "       Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnEditar);
            panel4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel4.Location = new Point(0, 160);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 80);
            panel4.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(5, 138, 138);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = Properties.Resources.Cambio_usuario;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(14, 13);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 64);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "       Editar Usuario";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel1.Location = new Point(0, 240);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 80);
            panel1.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(5, 138, 138);
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = Properties.Resources.eliminar_usuario;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(14, 13);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 66);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "       Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnReporte);
            panel3.Controls.Add(btnReportes);
            panel3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel3.Location = new Point(0, 186);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 80);
            panel3.TabIndex = 5;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(5, 138, 138);
            btnReporte.BackgroundImageLayout = ImageLayout.None;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Image = Properties.Resources.reporte_factura;
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(7, 12);
            btnReporte.Margin = new Padding(0);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(178, 57);
            btnReporte.TabIndex = 4;
            btnReporte.Text = "      Reportes";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += button1_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(5, 138, 138);
            btnReportes.BackgroundImageLayout = ImageLayout.None;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Image = Properties.Resources.reporte_factura;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(9, 13);
            btnReportes.Margin = new Padding(0);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(178, 57);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "      Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += button2_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnInicializar);
            panel8.Controls.Add(button2);
            panel8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            panel8.Location = new Point(0, 266);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(193, 80);
            panel8.TabIndex = 6;
            // 
            // btnInicializar
            // 
            btnInicializar.BackColor = Color.FromArgb(5, 138, 138);
            btnInicializar.BackgroundImageLayout = ImageLayout.None;
            btnInicializar.FlatStyle = FlatStyle.Flat;
            btnInicializar.Image = Properties.Resources.reporte_factura;
            btnInicializar.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicializar.Location = new Point(7, 12);
            btnInicializar.Margin = new Padding(0);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(178, 57);
            btnInicializar.TabIndex = 4;
            btnInicializar.Text = "      Inicializar";
            btnInicializar.UseVisualStyleBackColor = false;
            btnInicializar.Click += btnInicializar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(5, 138, 138);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.reporte_factura;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 13);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(178, 57);
            button2.TabIndex = 3;
            button2.Text = "      Reportes";
            button2.UseVisualStyleBackColor = false;
            // 
            // menuTansition
            // 
            menuTansition.Interval = 10;
            menuTansition.Tick += menuTansition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(9, 55, 55);
            panelContenedor.Location = new Point(200, 54);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(824, 666);
            panelContenedor.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(9, 55, 55);
            splitter1.Location = new Point(194, 54);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 666);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // frmPrincipalAdmi
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 55, 55);
            ClientSize = new Size(1024, 720);
            Controls.Add(splitter1);
            Controls.Add(panelContenedor);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(sidebar);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmPrincipalAdmi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipalAdmi";
            Load += frmPrincipalAdmi_Load;
            MouseDown += frmPrincipalAdmi_MouseDown;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnham).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebar;
        private Label label3;
        private PictureBox btnham;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnEliminar;
        private Panel panel3;
        private Button btnReportes;
        private Button btnEditar;
        private Button btnAgregar;
        private FlowLayoutPanel menuContainer;
        private Button menu;
        private Panel panel5;
        private Panel panel4;
        private Panel panel1;
        private System.Windows.Forms.Timer menuTansition;
        private Panel panel6;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label label1;
        private Panel panelContenedor;
        private Splitter splitter1;
        private Panel panel2;
        private Panel panel7;
        private Button btnPanel;
        private Button button3;
        private Button btnReporte;
        private Panel panel8;
        private Button btnInicializar;
        private Button button2;
    }
}