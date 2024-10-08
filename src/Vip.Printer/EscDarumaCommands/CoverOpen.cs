using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    /// <summary>
    /// Classe para buscar o comando de verificar se tampa esta aberta
    /// </summary>
    internal class CoverOpen : ICoverOpen
    {
        /// <summary>
        /// Comando
        /// </summary>
        /// <returns></returns>
        public byte[] GetCommand()
        {
            var command = new byte[] { 0x10, 0x04, 0x02 };

            return command;
        }
    }
}
