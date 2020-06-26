namespace csf
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Listo_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.directorio = new System.Windows.Forms.TextBox();
            this.tiempo_2 = new System.Windows.Forms.ComboBox();
            this.tiempo_1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.puerto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.seguridad = new System.Windows.Forms.ComboBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Probar_button = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.solo_una_vez = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tiempo_4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tiempo_3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.domingo = new System.Windows.Forms.CheckBox();
            this.sabado = new System.Windows.Forms.CheckBox();
            this.viernes = new System.Windows.Forms.CheckBox();
            this.jueves = new System.Windows.Forms.CheckBox();
            this.miercoles = new System.Windows.Forms.CheckBox();
            this.martes = new System.Windows.Forms.CheckBox();
            this.lunes = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Buscar_BKP_button = new System.Windows.Forms.Button();
            this.directorio_bkp = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listo_button
            // 
            this.Listo_button.Location = new System.Drawing.Point(427, 481);
            this.Listo_button.Name = "Listo_button";
            this.Listo_button.Size = new System.Drawing.Size(75, 23);
            this.Listo_button.TabIndex = 11;
            this.Listo_button.Text = "Ejecutar";
            this.Listo_button.UseVisualStyleBackColor = true;
            this.Listo_button.Click += new System.EventHandler(this.Listo_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Buscar_button);
            this.groupBox2.Controls.Add(this.directorio);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 65);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directorio a copiar";
            // 
            // Buscar_button
            // 
            this.Buscar_button.Location = new System.Drawing.Point(395, 24);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(75, 23);
            this.Buscar_button.TabIndex = 4;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // directorio
            // 
            this.directorio.Location = new System.Drawing.Point(21, 26);
            this.directorio.Name = "directorio";
            this.directorio.Size = new System.Drawing.Size(368, 20);
            this.directorio.TabIndex = 2;
            // 
            // tiempo_2
            // 
            this.tiempo_2.FormattingEnabled = true;
            this.tiempo_2.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.tiempo_2.Location = new System.Drawing.Point(280, 73);
            this.tiempo_2.Name = "tiempo_2";
            this.tiempo_2.Size = new System.Drawing.Size(40, 21);
            this.tiempo_2.TabIndex = 7;
            // 
            // tiempo_1
            // 
            this.tiempo_1.FormattingEnabled = true;
            this.tiempo_1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.tiempo_1.Location = new System.Drawing.Point(180, 72);
            this.tiempo_1.Name = "tiempo_1";
            this.tiempo_1.Size = new System.Drawing.Size(43, 21);
            this.tiempo_1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.puerto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.seguridad);
            this.groupBox1.Controls.Add(this.smtp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Probar_button);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuaración de envio";
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(226, 137);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(60, 20);
            this.puerto.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Puerto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Seguridad";
            // 
            // seguridad
            // 
            this.seguridad.DisplayMember = "1";
            this.seguridad.FormattingEnabled = true;
            this.seguridad.Items.AddRange(new object[] {
            "SSL"});
            this.seguridad.Location = new System.Drawing.Point(292, 137);
            this.seguridad.Name = "seguridad";
            this.seguridad.Size = new System.Drawing.Size(138, 21);
            this.seguridad.TabIndex = 9;
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(21, 136);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(199, 20);
            this.smtp.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Servidor SMTP:";
            // 
            // Probar_button
            // 
            this.Probar_button.Location = new System.Drawing.Point(355, 44);
            this.Probar_button.Name = "Probar_button";
            this.Probar_button.Size = new System.Drawing.Size(75, 23);
            this.Probar_button.TabIndex = 6;
            this.Probar_button.Text = "Probar";
            this.Probar_button.UseVisualStyleBackColor = true;
            this.Probar_button.Click += new System.EventHandler(this.Probar_button_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(226, 90);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(204, 20);
            this.password.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(21, 90);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(199, 20);
            this.usuario.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(21, 45);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(328, 20);
            this.email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enviar A:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 487);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Ejecutar al inicio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Control + Alt + Shift + H";
            // 
            // solo_una_vez
            // 
            this.solo_una_vez.AutoSize = true;
            this.solo_una_vez.Location = new System.Drawing.Point(12, 109);
            this.solo_una_vez.Name = "solo_una_vez";
            this.solo_una_vez.Size = new System.Drawing.Size(128, 17);
            this.solo_una_vez.TabIndex = 8;
            this.solo_una_vez.Text = "Ejecutar solo una vez";
            this.solo_una_vez.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ejecutar con un intervalo de";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.solo_una_vez);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tiempo_4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tiempo_3);
            this.groupBox3.Controls.Add(this.tiempo_2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tiempo_1);
            this.groupBox3.Controls.Add(this.domingo);
            this.groupBox3.Controls.Add(this.sabado);
            this.groupBox3.Controls.Add(this.viernes);
            this.groupBox3.Controls.Add(this.jueves);
            this.groupBox3.Controls.Add(this.miercoles);
            this.groupBox3.Controls.Add(this.martes);
            this.groupBox3.Controls.Add(this.lunes);
            this.groupBox3.Location = new System.Drawing.Point(12, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 136);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task Schudule";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(134, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Minutos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "horas";
            // 
            // tiempo_4
            // 
            this.tiempo_4.FormattingEnabled = true;
            this.tiempo_4.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.tiempo_4.Location = new System.Drawing.Point(73, 72);
            this.tiempo_4.Name = "tiempo_4";
            this.tiempo_4.Size = new System.Drawing.Size(41, 21);
            this.tiempo_4.TabIndex = 12;
            this.tiempo_4.Text = "30";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "durante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Minutos";
            // 
            // tiempo_3
            // 
            this.tiempo_3.FormattingEnabled = true;
            this.tiempo_3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.tiempo_3.Location = new System.Drawing.Point(12, 72);
            this.tiempo_3.Name = "tiempo_3";
            this.tiempo_3.Size = new System.Drawing.Size(45, 21);
            this.tiempo_3.TabIndex = 9;
            this.tiempo_3.Text = "16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hora:";
            // 
            // domingo
            // 
            this.domingo.AutoSize = true;
            this.domingo.Checked = true;
            this.domingo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.domingo.Location = new System.Drawing.Point(416, 27);
            this.domingo.Name = "domingo";
            this.domingo.Size = new System.Drawing.Size(68, 17);
            this.domingo.TabIndex = 6;
            this.domingo.Text = "Domingo";
            this.domingo.UseVisualStyleBackColor = true;
            // 
            // sabado
            // 
            this.sabado.AutoSize = true;
            this.sabado.Checked = true;
            this.sabado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sabado.Location = new System.Drawing.Point(347, 27);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(63, 17);
            this.sabado.TabIndex = 5;
            this.sabado.Text = "Sabado";
            this.sabado.UseVisualStyleBackColor = true;
            // 
            // viernes
            // 
            this.viernes.AutoSize = true;
            this.viernes.Checked = true;
            this.viernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viernes.Location = new System.Drawing.Point(280, 27);
            this.viernes.Name = "viernes";
            this.viernes.Size = new System.Drawing.Size(61, 17);
            this.viernes.TabIndex = 4;
            this.viernes.Text = "Viernes";
            this.viernes.UseVisualStyleBackColor = true;
            // 
            // jueves
            // 
            this.jueves.AutoSize = true;
            this.jueves.Checked = true;
            this.jueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jueves.Location = new System.Drawing.Point(214, 27);
            this.jueves.Name = "jueves";
            this.jueves.Size = new System.Drawing.Size(60, 17);
            this.jueves.TabIndex = 3;
            this.jueves.Text = "Jueves";
            this.jueves.UseVisualStyleBackColor = true;
            // 
            // miercoles
            // 
            this.miercoles.AutoSize = true;
            this.miercoles.Checked = true;
            this.miercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miercoles.Location = new System.Drawing.Point(137, 27);
            this.miercoles.Name = "miercoles";
            this.miercoles.Size = new System.Drawing.Size(71, 17);
            this.miercoles.TabIndex = 2;
            this.miercoles.Text = "Miercoles";
            this.miercoles.UseVisualStyleBackColor = true;
            // 
            // martes
            // 
            this.martes.AutoSize = true;
            this.martes.Checked = true;
            this.martes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.martes.Location = new System.Drawing.Point(73, 27);
            this.martes.Name = "martes";
            this.martes.Size = new System.Drawing.Size(58, 17);
            this.martes.TabIndex = 1;
            this.martes.Text = "Martes";
            this.martes.UseVisualStyleBackColor = true;
            // 
            // lunes
            // 
            this.lunes.AutoSize = true;
            this.lunes.Checked = true;
            this.lunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lunes.Location = new System.Drawing.Point(12, 27);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(55, 17);
            this.lunes.TabIndex = 0;
            this.lunes.Text = "Lunes";
            this.lunes.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Buscar_BKP_button);
            this.groupBox4.Controls.Add(this.directorio_bkp);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 65);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Directorio en donde hacer backup previo a enviar (por defecto en donde se localiz" +
    "a este archivo)";
            // 
            // Buscar_BKP_button
            // 
            this.Buscar_BKP_button.Location = new System.Drawing.Point(395, 24);
            this.Buscar_BKP_button.Name = "Buscar_BKP_button";
            this.Buscar_BKP_button.Size = new System.Drawing.Size(75, 23);
            this.Buscar_BKP_button.TabIndex = 4;
            this.Buscar_BKP_button.Text = "Buscar";
            this.Buscar_BKP_button.UseVisualStyleBackColor = true;
            this.Buscar_BKP_button.Click += new System.EventHandler(this.Buscar_BKP_button_Click);
            // 
            // directorio_bkp
            // 
            this.directorio_bkp.Location = new System.Drawing.Point(21, 26);
            this.directorio_bkp.Name = "directorio_bkp";
            this.directorio_bkp.Size = new System.Drawing.Size(368, 20);
            this.directorio_bkp.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(121, 487);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Debug";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 515);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Listo_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "MDI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy & Send Files";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button Listo_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox tiempo_2;
        private System.Windows.Forms.ComboBox tiempo_1;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.TextBox directorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox seguridad;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Probar_button;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox solo_una_vez;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox domingo;
        private System.Windows.Forms.CheckBox sabado;
        private System.Windows.Forms.CheckBox viernes;
        private System.Windows.Forms.CheckBox jueves;
        private System.Windows.Forms.CheckBox miercoles;
        private System.Windows.Forms.CheckBox martes;
        private System.Windows.Forms.CheckBox lunes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tiempo_4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tiempo_3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Buscar_BKP_button;
        private System.Windows.Forms.TextBox directorio_bkp;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}



