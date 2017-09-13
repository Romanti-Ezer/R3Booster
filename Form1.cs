using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace R3Booster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //caso de problema com o PerformanceCounter , use essas linhas no cmd
        //lodctr /r
        //lodctr /q

        // Navegando entre as páginas
        // Menu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            homePage();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            homePage();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            homePage();
        }

        // Voltar a página inicial (tabPage0)
        private void homePage()
        {
            tabControl1.SelectedTab = tabPage0;
        }

        //
        // Botões das funções
        //


        private void btnArquivos_Click(object sender, EventArgs e)
        {
            if (!(cbTemp.Checked) && !(cbDesocultar.Checked) && !(cbFinalizarProcesso.Checked))
            {
                MessageBox.Show("Nenhuma ação selecionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cbTemp.Checked)
                {
                    //System.Diagnostics.Process.Start("CMD.exe", "/K del /q /f /s %temp%");
                    limparTemp();
                }
                if (cbDesocultar.Checked)
                {
                    desocultarPasta();
                }

                if (cbFinalizarProcesso.Checked)
                {
                    try
                    {
                        string processo_selecionado = listBoxProcessos.SelectedItem.ToString();
                        encerrarProcesso();
                        //listBoxProcessos.Items.RemoveAt(listBoxProcessos.SelectedIndex);
                        listBoxProcessos.Visible = false;
                        cbFinalizarProcesso.Checked = false;
                    }
                    catch (Exception ex)

                    {
                        //MessageBox.Show("Escolha um processo para encerrá-lo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show("Erro: "+ex.Message);
                    }
                }
            }
            

            
        }


        private void cbDesocultar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDesocultar.Checked)
            {
                btnSelecPasta.Visible = true;
            }
            else
            {
                btnSelecPasta.Visible = false;
            }
            
        }

        private void btnSelecPasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                // Cancel
            }
            else
            {
                txtCaminho.Visible = true;
                txtCaminho.Text = folderBrowserDialog1.SelectedPath + "\\*.*";
            }
            
        }

        /// <summary>
        /// Methods
        /// </summary>

        private void limparTemp()
        {
            progressBarTemp.Visible = true;
            int quant = 0;
            try
            {
                //Pega a pasta temporaria do sistema "C:\users\temp"
                String folder_temp = Environment.GetEnvironmentVariable("temp");
                //Pega as informações do diretorio , incluindo os arquivos
                DirectoryInfo di = new DirectoryInfo(folder_temp);
                //Salva em um vetor todos os arquivos na pasta
                FileInfo[] files = di.GetFiles("*.*");
                //Salva em um vetor as pastas do arquivo
                DirectoryInfo[] dirs = di.GetDirectories("*.*");
                int i = 0;
                //pega a quantidade de arquivos e de pastas e salva em uma variavel
                quant = dirs.Length + files.Length;
                //seta o maximo da progress bar com o total de arquivos e pastas
                progressBarTemp.Maximum = quant;
                //variavel para controlar o progresso
                int progres = 0;
                //enquanto tiver arquivos faça
                while (i < dirs.Length)
                {
                    txt_file.Text = "Arquivo atual: " + dirs[i].Name;
                    //tente apagar o arquivo
                    try
                    {
                        Directory.Delete(dirs[i].FullName);
                        //se ele conseguir ele aumenta mais 1 na progress bar
                        progres++;
                    }
                    catch (Exception ex)
                    {
                        //se não conseguir apagar aumenta mais um na progres bar
                        quant--;
                        progres++;
                    }

                    //seta o valor da progress bar
                    progressBarTemp.Value = progres;
                    i++;
                }

                i = 0;
                while (i < files.Length)
                {
                    txt_file.Text = "Arquivo atual: " + files[i].Name;
                    try
                    {
                        File.Delete(files[i].FullName);
                        progres++;
                    }
                    catch (Exception ex)
                    {
                        quant--;
                        progres++;
                    }

                    progressBarTemp.Value = progres;
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro =  " + ex);
            }
            MessageBox.Show("Pasta Temp limpa com sucesso!");
            txt_file.Text = "";
            progressBarTemp.Visible = false;

        }

        private void desocultarPasta()
        {
            if (txtCaminho.Text != "")
            {
                String comando = "/C attrib -r -s -h /s /d \"" + txtCaminho.Text + "\"";
                System.Diagnostics.Process.Start("cmd.exe", "" + comando);
                MessageBox.Show("Pasta desocultada com sucesso!");
                cbDesocultar.Checked = false;
                txtCaminho.Visible = false;
                btnSelecPasta.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecione uma pasta para desocultar");
            }
        }

        public void listProcess()
        {
            listBoxProcessos.Items.Clear();
            Process[] processlist = Process.GetProcesses();
            int i = 0;
            while (i < processlist.Length)
            {
                listBoxProcessos.Items.Add(processlist[i].ProcessName);
                i++;
            }

        }

        private void encerrarProcesso()
        {
            try {
            string processo_selecionado = listBoxProcessos.SelectedItem.ToString();
            int index_item = listBoxProcessos.SelectedIndex;
            listBoxProcessos.Items.RemoveAt(index_item);
            ExecuteCommand("/K cmd.exe /c taskkill /f /im " + processo_selecionado + ".exe && exit");
                MessageBox.Show("Processo '" + processo_selecionado + "' encerrado com sucesso!");
            listProcess();
            /*
			folderBrowserDialog1.ShowDialog();
			txt_caminho.Text = folderBrowserDialog1.SelectedPath + "\\";			
			*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinalizarProcesso.Checked)
            {
                listBoxProcessos.Visible = true;
                listProcess();
            }
            else
            {
                listBoxProcessos.Visible = false;
            }

            
        }
        private void ExecuteCommand(String comando)
        {
            System.Diagnostics.Process.Start("cmd.exe", "" + comando);
        }
        
        void Button1Click(object sender, EventArgs e)
        {
            abrirPrograma("EmptyStandbyList.exe");
        }

        public void abrirPrograma(String nome)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/K " + nome + " workingsets && exit");
        }
        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            int maximo = Convert.ToInt32(GetTotalMemoryInBytes());
            int usado = Convert.ToInt32(maximo - ramCounter.NextValue());
            progressBar1.Value = usado;
            txt_usada.Text = usado + " / " + maximo;
            /*
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro= " + ex);
                timer1.Stop();
            }
            */

        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            int maximo = Convert.ToInt32(GetTotalMemoryInBytes());
            progressBar1.Maximum = maximo;
        }

        private void btnExec2_Click(object sender, EventArgs e)
        {
            if(!(cbVerifArq.Checked) && !(cbVerifDisk.Checked) && !(cbCompact.Checked))
            {
                MessageBox.Show("Nenhuma ação selecionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cbVerifArq.Checked)
                {
                    execVerif();
                }

                if (cbVerifDisk.Checked)
                {

                    if (folderBrowserDialog1.SelectedPath.ToString().Equals(""))
                    {
                        MessageBox.Show("Nenhum disco selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        execVerifDisk(folderBrowserDialog1.SelectedPath);
                    }

                }
                if (cbCompact.Checked)
                {
                    if (folderBrowserDialog2.SelectedPath.ToString().Equals(""))
                    {
                        MessageBox.Show("Nenhum pasta selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Compact(folderBrowserDialog2.SelectedPath);
                    }

                }
            }
            
        }

        private void Compact(String pasta)
        {
            
            String comando = "compact /c /s " +pasta+ "\\ && pause && exit";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando + " && pause && exit");
            MessageBox.Show(comando);
        }
        private void execVerif()
        {
            String comando = "sfc /scannow";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando + " && pause && exit");
        }
        private void execVerifDisk(String disk)
        {
            String comando = "chkdsk "+disk+" /f";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando + " && pause && exit");
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbVerifDisk.Checked)
            {
                folderBrowserDialog1.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            String comando = "systeminfo";
            System.Diagnostics.Process.Start("cmd.exe", "/K " + comando + " && pause && exit");
        }

        private void cbCompact_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCompact.Checked)
            {
                folderBrowserDialog2.ShowDialog();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbVerifArq_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbIpMac_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void IP_MAC()
        {
            String comando = "arp -a 192.168.0.1 && pause && exit";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando);
        }
        public void ping(string host)
        {
            String comando = "ping -n 10 " + host + " && pause && exit";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!(cbIpMac.Checked) && !(cbPing.Checked))
            {
                MessageBox.Show("Nenhuma ação selecionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cbIpMac.Checked)
                {
                    IP_MAC();
                }

                if (cbPing.Checked)
                {

                    if (txtAddress.Text.Equals(""))
                    {
                        MessageBox.Show("Insira um endereço para verificar a conexão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        ping(txtAddress.Text);
                        txtAddress.Text = "";
                    }

                }
            }
        }

        private void cbPing_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPing.Checked)
            {
                txtAddress.Visible = true;
            }
            else
            {
                txtAddress.Text = "";
                txtAddress.Visible = false;
            }
        }
    }
}
