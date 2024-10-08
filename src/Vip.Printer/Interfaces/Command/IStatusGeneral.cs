namespace Vip.Printer.Interfaces.Command
{
    /// <summary>
    /// Interface do Status Geral
    /// </summary>
    internal interface IStatusGeneral
    {
        /// <summary>
        /// Busca o status geral
        /// </summary>
        /// <returns></returns>
        byte[] GetStatus();
    }
}
