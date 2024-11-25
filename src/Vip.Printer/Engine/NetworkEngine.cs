using System;
using System.Net;
using System.Net.Sockets;
using Vip.Printer.Interfaces.Engine;

namespace Vip.Printer.Engine
{
    public class NetworkEngine : IEngine
    {
        #region Fields

        private IPEndPoint _endPoint;

        #endregion

        #region Methods

        private void ConfigureEndPoint(string printer)
        {
            var value = printer.Split(':');
            var address = value[0].Trim();
            var port = 0;

            if (value.Length > 1)
                int.TryParse(value[1], out port);
            port = port.Equals(0) ? 9100 : port;

            try
            {
                _endPoint = new IPEndPoint(IPAddress.Parse(address), port);
            }
            catch (Exception ex)
            {
                Helper.Logger.LogError(ex, $"NetworkEngine - ConfigureEndPoint IP: {printer}");
                throw new ArgumentException($"Endereço de IP ({address}) inválido ou não encontrado");
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
            ConfigureEndPoint(printer);

            try
            {
                using (var socket = new Socket(_endPoint.AddressFamily
                    , SocketType.Stream
                    , ProtocolType.Tcp))
                {
                    socket.NoDelay = true;
                    socket.Connect(_endPoint);
                    socket.Send(content);
                }

                return true;
            }
            catch(Exception ex)
            {
                Helper.Logger.LogError(ex, $"Send: Falha ao imprimir na impressora de IP: {printer}");
                return false;
            }
        }

        /// <summary>
        /// Busca o status da Impressora
        /// </summary>
        /// <param name="printer">Nome/Endereço da Impressora</param>
        /// <param name="content">Conteudo do comando</param>
        /// <returns></returns>
        public byte[] GetStatus(string printer, byte[] content)
        {
            ConfigureEndPoint(printer);

            try
            {
                using (var socket = new Socket(_endPoint.AddressFamily
                    , SocketType.Stream
                    , ProtocolType.Tcp))
                {
                    socket.NoDelay = true;
                    socket.ReceiveTimeout = 1000; // Tempo máximo de espera por uma resposta (em milissegundos)
                    socket.SendTimeout = 1000;    // Tempo máximo de espera para enviar o comando

                    socket.Connect(_endPoint);

                    // Enviar o comando para a impressora
                    socket.Send(content);

                    // Buffer para armazenar a resposta da impressora
                    var buffer = new byte[1024];  // Tamanho do buffer depende do quanto espera receber
                    int bytesRead = socket.Receive(buffer);

                    // Redimensiona o buffer para o tamanho real dos dados recebidos
                    var response = new byte[bytesRead];
                    Array.Copy(buffer, response, bytesRead);

                    return response;
                }
            }
            catch (SocketException ex)
            {
                Helper.Logger.LogError(ex, $"GetStatus - {printer}");
                throw new Exception("Erro ao obter o status da impressora: " + ex.Message);
            }
        }


        #endregion
    }
}