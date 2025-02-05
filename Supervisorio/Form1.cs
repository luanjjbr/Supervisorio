using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace Supervisorio
{
    public partial class Form1 : Form
    {
        private List<Point> points;
        public Form1()
        {
            InitializeComponent();
            /***** Fast Config*****/
            Baud_ComboBox.Text = "115200";
            Ports_ComboBox.Text = "COM5";
            UpdatePortsComboBox();
            points = new List<Point> { };
            //{
            //    new Point(1, 2),
            //    new Point(3, 4),
            //    new Point(5, 6),
            //    new Point(7, 8)
            //};
            points.Clear();
            LoadPointsFromFileManual("file.json");
            updateList();
        } // end Form1

        /****************** action ******************/
        private void Scan_bt_Click(object sender, EventArgs e)
        {
            UpdatePortsComboBox();
        } // end Scan_bt
        private void Connect_bt_Click(object sender, EventArgs e)
        {
            if (ConnectPort(Ports_ComboBox.Text,Baud_ComboBox.Text))
            {
                Connect_bt.Enabled = false;
                Disconnect.Enabled = true;
                Ports_ComboBox.Enabled = false;
                Baud_ComboBox.Enabled = false;
                Scan_bt.Enabled = false;
                Conexion_Bar.Value = 100;
                Enviar_bt.Enabled = true;
                Serial_TexBox.Enabled = true;
                UP_CheckBox.Enabled = true;
                timer1.Enabled = true;
            }//end if
        }// end Connect_bt_Click
        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (DisconnectPort())
            {
                Connect_bt.Enabled = true;
                Disconnect.Enabled = false;
                Ports_ComboBox.Enabled = true;
                Baud_ComboBox.Enabled = true;
                Scan_bt.Enabled = true;
                Conexion_Bar.Value = 0;
                Enviar_bt.Enabled = false;
                Serial_TexBox.Enabled = false;
                UP_CheckBox.Enabled = false;
                timer1.Enabled= false;
            }//end if

        }//end Disconnect_Click
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SavePointsToFileManual(points, "file.json");
                DisconnectPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// END Form1_FormClosed
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                // Verifica se a porta está aberta antes de tentar ler
                if (serialPort.IsOpen)
                {
                    Thread.Sleep(100);
                    this.Invoke(new EventHandler(delegate
                    {
                        richTextBox1.AppendText(serialPort.ReadLine());
                        if (UP_CheckBox.Checked)
                        {
                            richTextBox1.ScrollToCaret();
                        }
                    }));
                }
            }
            catch (IOException ex)
            {
                // Lida com a exceção se a porta for fechada inesperadamente
                MessageBox.Show($"Erro de leitura da porta serial: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// END serialPort_DataReceived
        private void Enviar_bt_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(Serial_TexBox.Text);
                Thread.Sleep(100);
            }
        }// End Enviar_bt_Click
        private void Cear_BT_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }//END Cear_BT_Click
        private void timer1_Tick(object sender, EventArgs e)
        {
            ReconnectPort();
        }//END timer1_Tick
        private void update_BT_Click(object sender, EventArgs e)
        {
            updateList();
        }// END update_BT_Click
        private void NewPoint_BT_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(0, 0, 0,false);
            points.Add(newPoint);
            updateList();
        }// END NewPoint_BT_Click
        private void Delete_BT_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Obtém o índice do item selecionado
                int selectedIndex = listBox1.SelectedIndex;

                // Remove o item da lista
                listBox1.Items.RemoveAt(selectedIndex);

                // Também remove o ponto da lista de pontos (caso esteja associada)
                points.RemoveAt(selectedIndex);
                updateList();
            }
            else
            {
                MessageBox.Show("Selecione um ponto para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }// END Delete_BT_Click
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                X_Number.Value = points[listBox1.SelectedIndex].X;
                Y_number.Value = points[listBox1.SelectedIndex].Y;
                Z_number.Value = points[listBox1.SelectedIndex].Z;
                Claw_checkBox.Checked = points[listBox1.SelectedIndex].CLAW;
            }
        }// END listBox1_SelectedIndexChanged
        private void Edit_BT_Click(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado no ListBox
            if (listBox1.SelectedIndex != -1)
            {
                // Obtém o índice do item selecionado
                int selectedIndex = listBox1.SelectedIndex;
                // Obtém os valores dos NumericUpDowns
                int newX = (int)X_Number.Value;
                int newY = (int)Y_number.Value;
                int newZ = (int)Z_number.Value;
                bool newclaw = Claw_checkBox.Checked;

                // Atualiza os valores do ponto na lista
                points[selectedIndex] = new Point(newX, newY, newZ, newclaw);

                // Atualiza o item no ListBox para refletir a alteração
                updateList();
            }
            else
            {
                MessageBox.Show("Selecione um ponto para modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }// END Edit_BT_Click
        /*******************Function*****************/
        private void UpdatePortsComboBox()
        {
            Ports_ComboBox.Items.Clear();
            Ports_ComboBox.Items.AddRange(ScanPorts());
        }// END UpdatePortsComboBox
        private bool ConnectPort(String Ports_ComboBox, String Baud_ComboBox)
        {
            try
            {
                if (Ports_ComboBox != "" && Baud_ComboBox != "" && ScanPorts().Contains(Ports_ComboBox))
                {
                    serialPort.PortName = Ports_ComboBox;
                    serialPort.BaudRate = Int32.Parse(Baud_ComboBox);
                    serialPort.Open();
                    return true;
                }// end if
                else
                {
                    MessageBox.Show("Selecione uma porta e uma taxa de transmissão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }//end else
            }// end try
            catch (Exception ex)
            {
                MessageBox.Show($"(ConnectPort)\nErro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// end catch

            return false;
        }// end ConnectPort
        private bool ConnectPort(String Ports_ComboBox, String Baud_ComboBox,int i)
        {
            try
            {
                if (Ports_ComboBox != "" && Baud_ComboBox != "" && ScanPorts().Contains(Ports_ComboBox))
                {
                    serialPort.PortName = Ports_ComboBox;
                    serialPort.BaudRate = Int32.Parse(Baud_ComboBox);
                    serialPort.Open();
                    return true;
                }// end if
            }// end try
            catch (Exception ex)
            {
                MessageBox.Show($"(ConnectPort)\nErro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// end catch

            return false;
        }// end ConnectPort
        private String[] ScanPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            return ports;
        }//end SacanPorts
        private bool DisconnectPort()
        {
            try
            {
                serialPort.Close();
                return true;
            }// end try
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Disconnect: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// end catch

            return false;
        }// end DisconnectPort
        private void ReconnectPort()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Se a porta está aberta, nada é feito
                return;
            }
            else
            {
                try
                {
                    // Desconecta primeiro
                    DisconnectPort();

                    // Configurações para reconectar
                    Conexion_Bar.Value = 0;  // Reseta a barra de conexão

                    // Tenta conectar novamente
                    ConnectPort(Ports_ComboBox.Text, Baud_ComboBox.Text,1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"(ReconnectPort)\nErro ao tentar reconectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }// END ReconnectPort
        private void updateList()
        {
            // Verifica se a lista de pontos não está vazia
            if (points != null && points.Count > 0)
            {
                N_P.Text = "Nuamero de Pontos: " + points.Count.ToString();
                listBox1.Items.Clear();  // Limpa o ListBox
                for (int i = 0; i < points.Count; i++)
                {
                    // Adiciona a posição e o valor do ponto no ListBox
                    listBox1.Items.Add($"P{i + 1}: [ X: {points[i].X}, Y: {points[i].Y}, Z: {points[i].Z}, claw: {points[i].CLAW}]");  // Adiciona o ponto com a posição
                }
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("A lista de pontos está vazia.");
            }
        }// END updateList
        private void SavePointsToFileManual(List<Point> points, string filePath)
        {
            var sb = new StringBuilder();
            sb.AppendLine("[");

            for (int i = 0; i < points.Count; i++)
            {
                sb.AppendLine("  {");
                sb.AppendLine($"    \"X\": {points[i].X},");
                sb.AppendLine($"    \"Y\": {points[i].Y},");
                sb.AppendLine($"    \"Z\": {points[i].Z},");
                sb.AppendLine($"    \"C\": {points[i].CLAW.ToString().ToLower()}");
                sb.Append("  }");

                if (i < points.Count - 1)
                {
                    sb.AppendLine(","); // Adiciona vírgula entre os objetos JSON
                }
                else
                {
                    sb.AppendLine();
                }
            }

            sb.AppendLine("]");

            // Salva o conteúdo em um arquivo
            File.WriteAllText(filePath, sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points.Clear();
            SavePointsToFileManual(points, "file.json");
            updateList();
        }
        private void LoadPointsFromFileManual(string filePath)
        {
            if (File.Exists(filePath)) // Verifica se o arquivo existe
            {
                var lines = File.ReadAllLines(filePath);
                int x = 0, y = 0 ,z=0; // Inicializa x e y
                bool c = false;

                foreach (var line in lines)
                {
                    if (line.Trim().StartsWith("\"X\":"))
                    {
                        x = int.Parse(line.Split(':')[1].Trim().TrimEnd(','));
                    }
                    else if (line.Trim().StartsWith("\"Y\":"))
                    {
                        y = int.Parse(line.Split(':')[1].Trim().TrimEnd(','));
                    }
                    else if (line.Trim().StartsWith("\"Z\":"))
                    {
                        z = int.Parse(line.Split(':')[1].Trim().TrimEnd(','));
                    }
                    else if (line.Trim().StartsWith("\"C\":"))
                    {
                        c = bool.Parse(line.Split(':')[1].Trim().TrimEnd(',').ToLower());
                        // Cria o ponto somente depois de obter os três valores X, Y e C
                        Point newPoint = new Point(x, y, z, c);
                        points.Add(newPoint); // Adiciona o ponto à lista
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LoadPointsFromFileManual("file.json");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            N_P.Text = "Nuamero de Pontos: "+points.Count.ToString();
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            try
            {
                SavePointsToFileManual(points, "file.json");
                DisconnectPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string GetAllPointsAsJson(List<Point> points)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < points.Count; i++)
            {
                Point point = points[i];
                sb.Append($"X : {point.X},");
                sb.Append($"Y : {point.Y},");
                sb.Append($"Z : {point.Z},");
                sb.Append($"C : {point.CLAW.ToString().ToLower()}");
                // Adicionar vírgula, exceto no último elemento
                // Adicionar vírgula, exceto no último elemento
                if (i < points.Count - 1)
                {
                    sb.Append(",\n");
                }
                else
                {
                    sb.Append("");
                }
            }

            return sb.ToString();
        }
        public string GetAllPointsAsJson_Angle(List<Point> points)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < points.Count; i++)
            {
                Point point = points[i];
                double[] angles = CalculateAngles(point.X, point.Y, point.Z, point.CLAW);
                sb.Append($"X1 : {(int)angles[0]} ,");
                sb.Append($"X2 : {(int)angles[1]} ,");
                sb.Append($"X3 : {(int)angles[2]} ,");
                sb.Append($"X4 : {(int)angles[3]} ");
                // Adicionar vírgula, exceto no último elemento
                // Adicionar vírgula, exceto no último elemento
                if (i < points.Count - 1)
                {
                    sb.Append(",\n");
                }
                else
                {
                    sb.Append("");
                }
            }

            return sb.ToString();
        }

        public double[] CalculateAngles(int X, int Y, int Z, bool C)
        {
            double theta1 = 0, theta2 = 0, theta3 = 0, theta4 = 0;

            // Parâmetros DH do robô
            int a1 = 0, a2 = 92, a3 = 92;
            int d1 = 0, d2 = 0, d3 = 0;

            // Cálculo de θ1
            theta1 = Math.Atan2(Y, X);

            // Calcular a distância no plano XY
            double r1 = Math.Sqrt(X * X + Y * Y);

            // Calcular a distância no espaço 3D
            double P = Math.Sqrt(r1 * r1 + (Z - d1) * (Z - d1));

            // Cálculo de θ2 usando a lei dos cossenos
            double cos_theta2 = (P * P - a2 * a2 - a3 * a3) / (2.0 * a2 * a3);
            theta2 = Math.Acos(cos_theta2);

            // Cálculo de θ3
            double cos_theta3 = (a2 * a2 + P * P - a3 * a3) / (2.0 * a2 * P);
            theta3 = double.IsNaN(Math.Atan2(Z - d1, r1) - Math.Acos(cos_theta3)) ? 0 : Math.Atan2(Z - d1, r1) - Math.Acos(cos_theta3);

            // Cálculo de θ4
            theta4 = C ? Math.PI : 0;

            // Retornar os ângulos em graus
            theta1 *= 180 / Math.PI;
            theta2 *= 180 / Math.PI;
            theta3 *= 180 / Math.PI;
            theta4 *= 180 / Math.PI;

            return new double[] { theta1, theta3,theta2, theta4 };
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label5.Text = GetAllPointsAsJson(points);
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(GetAllPointsAsJson(points));
                Thread.Sleep(100);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = GetAllPointsAsJson_Angle(points);
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(GetAllPointsAsJson_Angle(points));
                Thread.Sleep(100);
            }
        }
    } // End namespace
} //end class Form1
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    public bool CLAW {  get; set; }

        // Construtor para inicializar os valores de X e Y
        public Point(int x, int y, int z, bool claw)
        {
            X = x;
            Y = y;
            Z = z;
            CLAW = claw;
        }

        // Método para exibir as coordenadas como uma string
        public override string ToString()
        {
            return $"({X}, {Y}, {Z}, {CLAW})";
        }
    }// END Point
