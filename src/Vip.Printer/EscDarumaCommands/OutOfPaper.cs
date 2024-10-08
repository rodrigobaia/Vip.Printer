using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    /// <summary>
    /// Classe para buscar o comando que verifique a situação do papel na impressora
    /// </summary>
    internal class OutOfPaper : IOutOfPaper
    {
        /// <summary>
        /// Buscar Comando
        /// </summary>
        /// <returns></returns>
        public byte[] GetCommand()
        {
            var command = new byte[] { 0x10, 0x04, 0x04 };

            return command;
        }
    }
}
