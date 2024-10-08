using System;
using System.IO.Ports;
using Vip.Printer.Interfaces.Engine;

namespace Vip.Printer.Engine
{
    /// <summary>
    /// Engine de comunicação com a impressora via porta serial
    /// </summary>
    internal class USBEngine : IEngine
    {
        private SerialPort _serialPort;

        public USBEngine()
        {
            _serialPort = new SerialPort();
        }

        /// <summary>
        /// Configura a porta serial para comunicação com a impressora.
        /// </summary>
        private void ConfigureSerialPort(string portName)
        {
            // Configura os parâmetros da porta serial
            _serialPort.PortName = portName; // Nome da porta, ex: "COM1"
            _serialPort.BaudRate = 9600; // Velocidade da porta, depende do modelo da impressora
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 3000;  // Timeout de leitura
            _serialPort.WriteTimeout = 3000; // Timeout de escrita
        }

        /// <summary>
        /// Busca o status da Impressora
        /// </summary>
        /// <param name="printer">Nome/Endereço da Impressora</param>
        /// <param name="content">Conteudo do comando</param>
        /// <returns></returns>
        public byte[] GetStatus(string printer, byte[] content)
        {
            try
            {
                // Configura a porta serial com o nome da porta onde a impressora está conectada
                ConfigureSerialPort(printer);

                // Abre a conexão serial
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

                // Envia o comando para obter o status
                _serialPort.Write(content, 0, content.Length);

                // Lê a resposta da impressora
                byte[] buffer = new byte[1024]; // Buffer de leitura
                int bytesRead = _serialPort.Read(buffer, 0, buffer.Length); // Lê a resposta

                // Copia a quantidade exata de bytes lidos para um novo array
                byte[] response = new byte[bytesRead];
                Array.Copy(buffer, response, bytesRead);

                return response; // Retorna o status lido
            }
            catch (Exception ex)
            {
                // Lida com possíveis erros
                Console.WriteLine("Erro ao obter status: " + ex.Message);
                return null;
            }
            finally
            {
                // Fecha a porta serial
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
            }
        }

        /// <summary>
        /// Enviar comando para impressora
        /// </summary>
        /// <param name="printer">Impressora</param>
        /// <param name="content">Comando</param>
        /// <returns></returns>
        public bool Send(string printer, byte[] content)
        {
            try
            {
                // Configura a porta serial com o nome da porta onde a impressora está conectada (ex: COM1)
                ConfigureSerialPort(printer);

                // Abre a conexão serial
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

                // Envia o comando para a impressora
                _serialPort.Write(content, 0, content.Length);

                return true;
            }
            catch (Exception ex)
            {
                // Lida com possíveis erros
                Console.WriteLine("Erro ao enviar dados: " + ex.Message);
                return false;
            }
            finally
            {
                // Fecha a porta serial
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
            }
        }
    }
}
