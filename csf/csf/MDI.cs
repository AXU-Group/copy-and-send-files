using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.Win32;
using Ionic.Zip;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler;

namespace csf
{
    public partial class MDI : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                //MessageBox.Show("Hotkey pressed");
                if (this.Visible)
                {
                    this.Hide();
                }
                else
                {
                    this.Show();
                }
            }
            base.WndProc(ref m);
        }

        // Creo un task schudule para que se inicie a la hora dada.
        private void taskSchudule()
        {
            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {                
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "CSF";

                WeeklyTrigger wt = new WeeklyTrigger();
                wt.StartBoundary = DateTime.Today.AddHours(int.Parse(tiempo_3.Text)).AddMinutes(int.Parse(tiempo_4.Text)); // A que hora.minutos se ejecuta //DateTime.Today.AddDays(1);
               
                wt.DaysOfWeek = DaysOfTheWeek.AllDays; //DaysOfTheWeek.Monday | DaysOfTheWeek.Saturday
                //if (lunes.Checked) wt.DaysOfWeek = DaysOfTheWeek.Monday;
                
                //wt.WeeksInterval = 1; // Comienza la semana siguiente
                if (tiempo_1.Text!="") wt.Repetition.Interval = TimeSpan.FromMinutes(int.Parse(tiempo_1.Text)); // Se repite cada 10 minutos
                if (tiempo_2.Text != "") wt.Repetition.Duration = TimeSpan.FromHours(int.Parse(tiempo_2.Text)); // Durante 11 hs
                td.Triggers.Add(wt);

                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction(Application.ExecutablePath)); //td.Actions.Add(new ExecAction(Application.ExecutablePath, "c:\\test.log", null));
                
                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(@"CSF", td);

                // Remove the task we just created
                //ts.RootFolder.DeleteTask("CSF");
            }
        }

        // Desde aca es el codigo para que se pueda abrir una sola vez este form
        private static MDI m_FormDefInstance;
        public static MDI DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new MDI();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        //Hasta aca

        public MDI()
        {
            InitializeComponent();
            leoConfig();
            checkStartup();
            // 1 = Alt, 2 = Shift, 4 = Control, 8 = windows // Sumamos para poner el valor de la convinacion.
            RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 7, (int)'H');
        }

        private void leoConfig()
        {
            try
            {
                /*
                directorio.Text = ConfigurationManager.AppSettings["directorio"];
                tiempo_1.Text = ConfigurationManager.AppSettings["tiempo_1"];
                tiempo_2.Text = ConfigurationManager.AppSettings["tiempo_2"];
                solo_una_vez.Checked = bool.Parse(ConfigurationManager.AppSettings["solo_una_vez"].ToString());
                email.Text = ConfigurationManager.AppSettings["email"];
                usuario.Text = ConfigurationManager.AppSettings["usuario"];
                password.Text = ConfigurationManager.AppSettings["password"];
                smtp.Text = ConfigurationManager.AppSettings["smtp"];
                puerto.Text = ConfigurationManager.AppSettings["puerto"];
                seguridad.Text = ConfigurationManager.AppSettings["seguridad"];
                lunes.Checked = bool.Parse(ConfigurationManager.AppSettings["lunes"].ToString());
                martes.Checked = bool.Parse(ConfigurationManager.AppSettings["martes"].ToString());
                miercoles.Checked = bool.Parse(ConfigurationManager.AppSettings["miercoles"].ToString());
                jueves.Checked = bool.Parse(ConfigurationManager.AppSettings["jueves"].ToString());
                viernes.Checked = bool.Parse(ConfigurationManager.AppSettings["viernes"].ToString());
                sabado.Checked = bool.Parse(ConfigurationManager.AppSettings["sabado"].ToString());
                domingo.Checked = bool.Parse(ConfigurationManager.AppSettings["domingo"].ToString());
                tiempo_3.Text = ConfigurationManager.AppSettings["tiempo_3"];
                tiempo_4.Text = ConfigurationManager.AppSettings["tiempo_4"];
                */

                directorio.Text = Properties.Settings.Default.directorio;
                directorio_bkp.Text = Properties.Settings.Default.directorio_bkp;
                tiempo_1.Text = Properties.Settings.Default.tiempo_1;
                tiempo_2.Text = Properties.Settings.Default.tiempo_2;
                solo_una_vez.Checked = Properties.Settings.Default.solo_una_vez;
                email.Text = Properties.Settings.Default.email;
                usuario.Text = Properties.Settings.Default.usuario;
                password.Text = Properties.Settings.Default.password;
                smtp.Text = Properties.Settings.Default.smtp;
                puerto.Text = Properties.Settings.Default.puerto;
                seguridad.Text = Properties.Settings.Default.seguridad;
                lunes.Checked = Properties.Settings.Default.lunes;
                martes.Checked = Properties.Settings.Default.martes;
                miercoles.Checked = Properties.Settings.Default.miercoles;
                jueves.Checked = Properties.Settings.Default.jueves;
                viernes.Checked = Properties.Settings.Default.viernes;
                sabado.Checked = Properties.Settings.Default.sabado;
                domingo.Checked = Properties.Settings.Default.domingo;
                tiempo_3.Text = Properties.Settings.Default.tiempo_3;
                tiempo_4.Text = Properties.Settings.Default.tiempo_4;
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        // Directorio que quiero leer y copiar y enviar.
        private void Buscar_button_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog ruta1 = new FolderBrowserDialog();
                if (ruta1.ShowDialog() == DialogResult.OK)
                {
                    directorio.Text = ruta1.SelectedPath;
                }
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Probar_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Puerto que anda bien 587
                MailMessage msg = new MailMessage();
                msg.To.Add(new MailAddress("<" + email.Text + ">"));
                msg.From = new MailAddress("<" + email.Text + ">");
                msg.Subject = "Copy & Send Files";
                msg.Body = "Email de prueba";

                SmtpClient clienteSmtp = new SmtpClient(smtp.Text, int.Parse(puerto.Text));
                clienteSmtp.EnableSsl = true;
                clienteSmtp.Credentials = new NetworkCredential(usuario.Text, password.Text);
                clienteSmtp.Send(msg);
                MessageBox.Show("Mensaje enviado.", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Listo_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo el directorio y guardo toda la info ingresada en el form
                // creo el directorio en donde se ejecutó el archivo.
                DirectoryInfo dir_bkp = new DirectoryInfo(Environment.CurrentDirectory + @"\zip");

                if (!dir_bkp.Exists)
                {
                    dir_bkp.Create(); // creo el directorio zip
                }
                /*
                // Guardo todo en el archivo .config
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //Borro toda la configuracion vieja y guardo la nueva
                config.AppSettings.Settings.Clear();
                config.AppSettings.Settings.Add("directorio", directorio.Text);
                config.AppSettings.Settings.Add("email", email.Text);
                config.AppSettings.Settings.Add("tiempo_1", tiempo_1.Text);
                config.AppSettings.Settings.Add("tiempo_2", tiempo_1.Text);
                config.AppSettings.Settings.Add("solo_una_vez", solo_una_vez.Checked.ToString());
                config.AppSettings.Settings.Add("usuario", usuario.Text);
                config.AppSettings.Settings.Add("password", password.Text);
                config.AppSettings.Settings.Add("smtp", smtp.Text);
                config.AppSettings.Settings.Add("puerto", puerto.Text);
                config.AppSettings.Settings.Add("seguridad", seguridad.Text);

                config.AppSettings.Settings.Add("lunes", lunes.Checked.ToString());
                config.AppSettings.Settings.Add("martes", martes.Checked.ToString());
                config.AppSettings.Settings.Add("miercoles", miercoles.Checked.ToString());
                config.AppSettings.Settings.Add("jueves", jueves.Checked.ToString());
                config.AppSettings.Settings.Add("viernes", viernes.Checked.ToString());
                config.AppSettings.Settings.Add("sabado", sabado.Checked.ToString());
                config.AppSettings.Settings.Add("domingo", domingo.Checked.ToString());
                config.AppSettings.Settings.Add("tiempo_3", tiempo_3.Text);
                config.AppSettings.Settings.Add("tiempo_4", tiempo_4.Text);

                // Guardo la Configuarcion en el Archivo
                config.Save(ConfigurationSaveMode.Modified);
                // Fuerzo a releer los cambios
                ConfigurationManager.RefreshSection("appSettings");
                */
                Properties.Settings.Default.directorio = directorio.Text;
                Properties.Settings.Default.directorio_bkp = directorio_bkp.Text;
                Properties.Settings.Default.email = email.Text;
                Properties.Settings.Default.tiempo_1 = tiempo_1.Text;
                Properties.Settings.Default.tiempo_2 = tiempo_1.Text;
                Properties.Settings.Default.solo_una_vez = solo_una_vez.Checked;
                Properties.Settings.Default.usuario = usuario.Text;
                Properties.Settings.Default.password = password.Text;
                Properties.Settings.Default.smtp = smtp.Text;
                Properties.Settings.Default.puerto = puerto.Text;
                Properties.Settings.Default.seguridad = seguridad.Text;

                Properties.Settings.Default.lunes = lunes.Checked;
                Properties.Settings.Default.martes = martes.Checked;
                Properties.Settings.Default.miercoles = miercoles.Checked;
                Properties.Settings.Default.jueves = jueves.Checked;
                Properties.Settings.Default.viernes = viernes.Checked;
                Properties.Settings.Default.sabado = sabado.Checked;
                Properties.Settings.Default.domingo = domingo.Checked;
                Properties.Settings.Default.tiempo_3 = tiempo_3.Text;
                Properties.Settings.Default.tiempo_4 = tiempo_4.Text;

                // Copio el contenido del directorio origen al del backup
                string dirBackup = "";
                if (Properties.Settings.Default.directorio_bkp == "") dirBackup = Environment.CurrentDirectory + @"\backup";
                else dirBackup = @"" + Properties.Settings.Default.directorio_bkp;
                copyDirectory(@"" + Properties.Settings.Default.directorio, dirBackup, true);

                // creo el registro para que se inicie con windows para todos los usuarios
                saveStartup();

                // Creo zip del directorio seleccionado y envio por mail
                //creoZipFile();
                envioMail();

                // Cierro
                MessageBox.Show("Para volver a abrir el programa presionar\nControl + Alt + Shift + H", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MDI.ActiveForm.Hide();
                
                // Si se tildo de enviar solo una vez no creo el Schudule
                if(!solo_una_vez.Checked) taskSchudule();
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void envioMail()
        {
            // Creo el zip para adjuntarlo
            string filename = creoZipFile();

            try
            {
                //ConfigurationManager.AppSettings["seguridad"];

                /* Instrucciones genéricas de configuración:

                    Servidor de correo entrante (POP3) - requiere SSL:	 pop.gmail.com
                    Utilizar SSL: Sí
                    Puerto: 995
                    Servidor de correo saliente (SMTP) - requiere TLS o SSL:	 smtp.gmail.com
                    Utilizar autenticación: Sí
                    Puerto para TLS/STARTTLS: 587
                    Puerto para SSL: 465
                    Tiempo de espera del servidor	 Más de 1 minuto; se recomienda configurar 5 minutos
                    Nombre completo o Nombre visible:	 [tu nombre]
                    Nombre de cuenta o Nombre de usuario:	 tu dirección de correo electrónico completa (incluido @gmail.com o @tudominio.com)
                    Dirección de correo electrónico:	 tu dirección de correo electrónico (nombredeusuario@gmail.com o nombredeusuario@tudominio.com)
                    Contraseña:	 tu contraseña de Gmail
                 */
 
                if (filename != "")
                {
                    // Envia correo, adjunta archivo zip si existe.
                    MailMessage msg = new MailMessage();
                    msg.To.Add(new MailAddress("<" + Properties.Settings.Default.email + ">"));
                    msg.From = new MailAddress("<" + Properties.Settings.Default.email + ">");
                    msg.Subject = "Copy & Send Files";
                    msg.Body = "Texto";

                    // Agregar el Adjunto si deseamos hacerlo
                    Attachment fileAttach = new Attachment(filename);
                    msg.Attachments.Add(fileAttach);

                    SmtpClient clienteSmtp = new SmtpClient(Properties.Settings.Default.smtp, int.Parse(Properties.Settings.Default.puerto));
                    clienteSmtp.EnableSsl = true;
                    clienteSmtp.Credentials = new NetworkCredential(Properties.Settings.Default.usuario, Properties.Settings.Default.password);
                    clienteSmtp.Send(msg);

                    fileAttach.Dispose();
                    clienteSmtp.Dispose();

                    while (IsInUse(filename))
                    {
                        Thread.Sleep(1);
                    }
                    
                }

            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private bool IsInUse(string filename)
        {
            try
            {
                File.Delete(filename);
            }
            catch(IOException)
            {
                return true;
            }
            return false;
        }
        
        private string creoZipFile()
        {
            try
            {
                DirectoryInfo dir_bkp = new DirectoryInfo(Environment.CurrentDirectory + @"\zip");
                if(!dir_bkp.Exists)
                {
                    dir_bkp.Create(); // creo el directorio zip
                }

                if (Directory.Exists(Properties.Settings.Default.directorio))
                {
                    ZipFile zip = new ZipFile();
                    //string[] filePaths = Directory.GetFiles(@"c:\MyDir\");
                    zip.AddItem(Properties.Settings.Default.directorio);
                    //zip.AddFile("imagen.png", "");
                    //zip.AddFile("texto.txt", "");
                    //zip.AddFile("musica.mp3", "");
                    string[] DateArray = DateTime.Now.ToShortDateString().Split('/');
                    string[] LongTime = DateTime.Now.ToLongTimeString().Split(' ');
                    string[] TimeArray = LongTime[0].Split(':');
                    string Filename = dir_bkp + @"\" + DateArray[2] + "-" + DateArray[1] + "-" + DateArray[0] + "-" + TimeArray[0] + "-" + TimeArray[1] + "-" + TimeArray[2] + ".zip";
                    zip.Save(Filename);
                    zip.Dispose();

                    return Filename;
                }
                else return "";
            }
            catch (Exception ex)
            {
                if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
        }

        // Si apreto Control + Alt + Shift + H 
        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode==Keys.H)
            {

                if (this.Visible)
                {
                    MDI.ActiveForm.Hide();
                }
                else
                {
                    MDI.ActiveForm.Show();
                }
            }
        }

        // Para que se ejecute en el inicio de windows antes del login user
        private void saveStartup()
        {
            try
            {
                // Recuperar el contenido y agregarle nuestro userinit.exe,  Application.ExecutablePath.ToString()
                // HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit

                RegistryKey SOFTWARE = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
                RegistryKey Microsoft = SOFTWARE.OpenSubKey("Microsoft", true);
                RegistryKey WindowsNT = Microsoft.OpenSubKey("Windows NT", true);
                RegistryKey CurrentVersion = WindowsNT.OpenSubKey("CurrentVersion", true);
                RegistryKey Winlogon = CurrentVersion.OpenSubKey("Winlogon", true);

                string uinitOld = Winlogon.GetValue("Userinit").ToString();
                
                if (checkBox1.Checked == true)
                {
                    Winlogon.SetValue("Userinit", uinitOld + "," + Application.ExecutablePath.ToString());
                }
                else
                {
                    uinitOld.Replace("," + Application.ExecutablePath.ToString(), ""); 
                    Winlogon.SetValue("Userinit", "Userinit.exe");
                }
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void checkStartup()
        {
            // Recuperar el contenido y agregarle nuestro userinit.exe,  Application.ExecutablePath.ToString()
            // HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit
            try
            {
                RegistryKey SOFTWARE = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
                RegistryKey Microsoft = SOFTWARE.OpenSubKey("Microsoft", true);
                RegistryKey WindowsNT = Microsoft.OpenSubKey("Windows NT", true);
                RegistryKey CurrentVersion = WindowsNT.OpenSubKey("CurrentVersion", true);
                RegistryKey Winlogon = CurrentVersion.OpenSubKey("Winlogon", true);

                string uinitOld = Winlogon.GetValue("Userinit").ToString();
                string stingApp = "," + Application.ExecutablePath.ToString();

                if (uinitOld.Contains(stingApp)) checkBox1.Checked = true;
                else checkBox1.Checked = false;
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Buscar_BKP_button_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog ruta1 = new FolderBrowserDialog();
                if (ruta1.ShowDialog() == DialogResult.OK)
                {
                    directorio_bkp.Text = ruta1.SelectedPath;
                }
            }
            catch (Exception ex) { if (checkBox2.Checked == true) MessageBox.Show(ex.ToString(), "Windows Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void copyDirectory(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Obtengo los subdirectorios del directorio fuente
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                if (checkBox2.Checked == true) throw new DirectoryNotFoundException("El directorio origen no funciona: " + sourceDirName);
            }

            // Si no existe la carpeta destino la crea
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Obtiene los archivos del directorio y los copia a la carpeta destino
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // Copia el contenido de los subdirectorios
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    copyDirectory(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
