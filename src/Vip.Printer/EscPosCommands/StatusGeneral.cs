using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    /// <summary>
    /// Status Geral
    /// </summary>
    internal class StatusGeneral : IStatusGeneral
    {
        /// <summary>
        /// Busca o status geral
        /// </summary>
        /// <returns></returns>
        public byte[] GetStatus()
        {
            // Comando para status geral (DLE EOT 1)
            byte[] commands = { 0x10, 0x04, 0x01 };

            return commands;
        }
    }
}
