using System;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
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
            throw new NotImplementedException();
        }
    }
}
