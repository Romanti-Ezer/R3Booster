﻿using System;
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
            CreateContextMenu();
            
        }

        //
        // Formulário como um todo
        //

        // Quando o Formulário é carregado

        // Criando um processo global, que será configurado e acionado posteriormente
        Process RAMClearprocess;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurando o recurso de visualizar a RAM usada/total do computador
            timerPegarRAM.Start();
            int maximo = Convert.ToInt32(GetTotalMemoryInBytes());
            progressBar1.Maximum = maximo;

            // Configurando o intervalo do Timer para limpeza da RAM
            timerLimparRAM.Interval = (int)(nUDMinutos.Value) * 60000;

            // Configurando o processo para limpar a RAM
            RAMClearprocess = new Process();
            RAMClearprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            RAMClearprocess.StartInfo.FileName = "cmd.exe";
            string argument = "/C EmptyStandbyList.exe workingsets && exit";
            RAMClearprocess.StartInfo.Arguments = argument;
                    }

        // Quando o Form é minimizado para a bandeja do sistema, ou aberto
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Se minimizado, cria mostra o ícone e esconde o Form
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            // Se aberto, ele esconde o ícone de notificação
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        // 
        // Página inicial
        //

        // Informações do computador
        private void lblSobre_Click(object sender, EventArgs e)
        {
            String comando = "systeminfo";
            System.Diagnostics.Process.Start("cmd.exe", "/K " + comando + " && pause && exit");
        }

        // Botões para navegar pelo programa

        // Ir para Arquivos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        // Ir para Disco Rígido e RAM
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        // Ir para Conexão
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        // Voltar para a página inicial (em cada página
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

        // Função usada para voltar à página inicial
        private void homePage()
        {
            tabControl1.SelectedTab = tabPage0;
        }




        //
        // Arquivos
        //



        // Limpar os arquivos temporários
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

        // Desocultar Pastas
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

        // Método para desocultar as pastas
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

        // Selecionar pasta para ser desocultada
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

        // Finalizar processo
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

        // Listando os processos para serem selecionados
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

        // Finalizando os processos selecionados
        private void encerrarProcesso()
        {
            try
            {
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
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        
        private void ExecuteCommand(String comando)
        {
            System.Diagnostics.Process.Start("cmd.exe", "" + comando);
        }


        // Botão para executar as funções selecionadas
        private void btnArquivos_Click(object sender, EventArgs e)
        {
            // Se nada estiver selecionado:
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
                    cbTemp.Checked = false;
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




        /// 
        /// Fim de "Arquivos"
        /// 




        ///
        /// Disco e RAM 
        ///




        // Timer para pegar a RAM usada/total
        private void timerPegarRAM_Tick(object sender, EventArgs e)
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
        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024;
        }

        // Botão limpar RAM
        void btnLimparRAM_Click(object sender, EventArgs e)
        {
            limparRAM();
        }

        public void limparRAM()
        {
            RAMClearprocess.Start();

            // Old Method
            //System.Diagnostics.Process.Start("cmd.exe", "/c EmptyStandbyList.exe workingsets && exit");
        }

        //CheckBox para limpar a RAM a cada X minutos
        private void cbLimparRAM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLimparRAM.Checked)
            {
                timerLimparRAM.Interval = (int)(nUDMinutos.Value) * 60000;
                timerLimparRAM.Start();
            }
            else
            {
                timerLimparRAM.Stop();
            }
        }

        private void timerLimparRAM_Tick(object sender, EventArgs e)
        {
            limparRAM();
        }

        //Quando o número de minutos for modificado:
        private void nUDMinutos_ValueChanged(object sender, EventArgs e)
        {
            timerLimparRAM.Interval = (int)(nUDMinutos.Value) * 60000;
        }

        // Criando e configurando o menu do ícone, para quando o programa está na bandeja do sistema
        private void CreateContextMenu()
        {
            // Criando o menu em si
            ContextMenuStrip menuStrip = new ContextMenuStrip();

            // Criando os itens do menu
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Abrir o programa");
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Limpar a RAM");
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Fechar o programa");

            // Configurando um nome aos itens
            menuItem.Name = "Abrir";
            menuItem1.Name = "Limpar";
            menuItem2.Name = "Fechar";

            // Adicionando o event "Click" aos itens
            menuItem.Click += new EventHandler(menuItem_Click);
            menuItem1.Click += new EventHandler(menuItem_Click);
            menuItem2.Click += new EventHandler(menuItem_Click);

            // Adicionando os itens ao menu
            menuStrip.Items.Add(menuItem);
            menuStrip.Items.Add(menuItem1);
            menuStrip.Items.Add(menuItem2);

            // Adicionando o menu ao ícone de notificação
            notifyIcon1.ContextMenuStrip = menuStrip;
        }

        // Método que executa uma ação conforme qual opção do menu foi selecionada
        void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            if (menuItem.Name == "Sair")
            {
                Application.Exit();
            }
            else if (menuItem.Name == "Limpar")
            {
                limparRAM();
            }
            else if(menuItem.Name == "Abrir")
            {
                this.Show();
                this.BringToFront();
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Verificação de arquivos do Disco
        private void execVerif()
        {
            String comando = "sfc /scannow";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando + " && pause && exit");
        }


        // Verificação de Disco
        private void cbVerifDisk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerifDisk.Checked)
            {
                folderBrowserDialog1.ShowDialog();
            }
        }

        // Método para verificar o disco selecionado
        private void execVerifDisk(String disk)
        {
            String comando = "chkdsk " + disk + " /f";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando + " && pause && exit");
        }

        // Compactar uma pasta
        private void cbCompact_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCompact.Checked)
            {
                folderBrowserDialog2.ShowDialog();
            }
        }

        // Método para compactar uma pasta
        private void Compact(String pasta)
        {

            String comando = "compact /c /s " + pasta + "\\ && pause && exit";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando + " && pause && exit");
            //MessageBox.Show(comando);
            cbCompact.Checked = false;
        }


        // Botão para executar as funções selecionadas
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




        //
        // Fim de "Disco rígido e RAM"
        //



        //
        // Conexão
        //




        // Função para pegar IP e MAC
        public void IP_MAC()
        {
            //String comando = "arp -a 192.168.0.1 && pause && exit";
            //String comando = "arp -a 192.168.102.44 && pause && exit";
            MessageBox.Show("Ver Adaptadores de Rede Sem Fio ou Adaptadores de Ethernet\nEndereço IPv4", "Instruçoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            String comando = "ipconfig && pause && cls && getmac && pause && exit";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando);
        }

        // Verificar a conexão com um endereço
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
        //Função para verificar o ping com algum endereço
        public void ping(string host)
        {
            String comando = "ping -n 10 " + host + " && pause && exit";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + comando);
        }

        // Botão para executar as funções selecionadas
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
                    cbIpMac.Checked = false;
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
                        cbPing.Checked = false;
                    }

                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
        }
    }
}