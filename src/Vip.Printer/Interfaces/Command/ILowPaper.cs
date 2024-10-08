using System;
using System.Collections.Generic;
using System.Text;

namespace Vip.Printer.Interfaces.Command
{
    internal interface ILowPaper
    {
        /// <summary>
        /// Busca o comando
        /// </summary>
        /// <returns></returns>
        byte[] GetLowPaper();
    }
}
