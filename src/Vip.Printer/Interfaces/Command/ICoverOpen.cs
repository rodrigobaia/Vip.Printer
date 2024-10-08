using System;
using System.Collections.Generic;
using System.Text;

namespace Vip.Printer.Interfaces.Command
{
    /// <summary>
    /// Interface para buscar o comando de verificar se tampa esta aberta
    /// </summary>
    internal interface ICoverOpen
    {
        /// <summary>
        /// Comando
        /// </summary>
        /// <returns></returns>
        byte[] GetCommand();
    }
}
