using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;




namespace RS_OVER_IP_SENDER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            richTextBoxASCII.TextChanged += richTextBoxASCII_TextChanged;

        }






        private byte[] HexStringToByteArray(string hex)
        {
            return hex.Split(' ')
                .Select(s => Convert.ToByte(s, 16))
                .ToArray();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendRsOverIP_Click(object sender, EventArgs e)
        {
            string ip = textBoxIpAdress.Text.Trim();
            if (string.IsNullOrWhiteSpace(ip))
            {
                AppendStatus("Ошибка: Введите IP-адрес проектора.");
                return;
            }

            if (!int.TryParse(textBoxPortNumber.Text.Trim(), out int port) || port <= 0 || port > 65535)
            {
                AppendStatus("Ошибка: Введите корректный номер порта (1-65535).");
                return;
            }

            string hexCommand = richTextBoxHexCommand.Text.Trim();
            if (string.IsNullOrWhiteSpace(hexCommand))
            {
                AppendStatus("Ошибка: Введите команду в HEX-формате.");
                return;
            }

            try
            {
                byte[] commandBytes = HexStringToByteArray(hexCommand);
                AppendStatus($"Отправка команды на {ip}:{port} -> {hexCommand}");
                SendCommand(ip, port, commandBytes);
                AppendStatus("Команда успешно отправлена!");
            }
            catch (Exception ex)
            {
                AppendStatus($"Ошибка: {ex.Message}");
            }


        }

        private void SendCommand(string ip, int port, byte[] command)
        {
            using (TcpClient client = new TcpClient())
            {
                client.Connect(ip, port);
                using (NetworkStream stream = client.GetStream())
                {
                    // Отправляем PJLINK-запрос на авторизацию
                    byte[] authRequest = Encoding.ASCII.GetBytes("%1\r");
                    stream.Write(authRequest, 0, authRequest.Length);
                    AppendStatus("Отправлен запрос PJLINK...");

                    // Читаем ответ PJLINK
                    byte[] responseBuffer = new byte[1024];
                    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                    string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead).Trim();

                    if (response.StartsWith("PJLINK 0")) // Без пароля
                    {
                        AppendStatus("PJLINK подтверждён. Отправляем команду...");

                        // Отправляем команду
                        stream.Write(command, 0, command.Length);
                        AppendStatus("Команда отправлена, ожидаем ответ...");

                        // Читаем ответ от проектора
                        bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                        if (bytesRead > 0)
                        {
                            string responseText = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead).Trim();
                            AppendStatus($"Ответ проектора: {responseText}");
                        }
                        else
                        {
                            AppendStatus("Сервер не прислал ответа.");
                        }
                    }
                    else
                    {
                        AppendStatus($"Неизвестный ответ: {response}");
                    }
                }
            }
        }


        private void richTextBoxASCII_TextChanged(object sender, EventArgs e)
        {
            ConvertASCIIToHex();
        }


        //эта функция конвертирует текст из ASCI в HEX
        private void ConvertASCIIToHex()
        {
            string asciiText = richTextBoxASCII.Text.Trim();
            if (string.IsNullOrEmpty(asciiText))
            {
                richTextBoxHexCommand.Clear();
                return;
            }

            byte[] asciiBytes = Encoding.ASCII.GetBytes(asciiText);
            string hexString = BitConverter.ToString(asciiBytes).Replace("-", " ");

            richTextBoxHexCommand.Text = hexString;
        }



        private void AppendStatus(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            richTextBoxStatus.AppendText($"[{timestamp}] {message}" + Environment.NewLine);
            richTextBoxStatus.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxHexCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPortNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
