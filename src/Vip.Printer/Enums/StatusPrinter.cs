namespace Vip.Printer.Enums
{
    /// <summary>
    /// Tipo do Status da Impressora
    /// </summary>
    public enum StatusPrinterType
    {
        /// <summary>
        /// Nenhum
        /// </summary>
        None = -1,

        /// <summary>
        /// Ok
        /// </summary>
        OK = 0,

        /// <summary>
        /// Erro
        /// </summary>
        Error,

        /// <summary>
        /// Ocupada
        /// </summary>
        Busy,

        /// <summary>
        /// Sem Papel/ Pouco Papel
        /// </summary>
        OutPaper,

        /// <summary>
        /// Tampa Aberta
        /// </summary>
        LidOpen


    }
}
