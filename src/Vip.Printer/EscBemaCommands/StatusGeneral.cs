using System;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
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
