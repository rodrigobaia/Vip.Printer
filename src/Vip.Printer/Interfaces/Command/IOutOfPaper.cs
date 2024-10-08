namespace Vip.Printer.Interfaces.Command
{
    /// <summary>
    /// Interface para buscar o comando que verifique a situação do papel na impressora
    /// </summary>
    internal interface IOutOfPaper
    {
        /// <summary>
        /// Buscar Comando
        /// </summary>
        /// <returns></returns>
        byte[] GetCommand();
    }
}
