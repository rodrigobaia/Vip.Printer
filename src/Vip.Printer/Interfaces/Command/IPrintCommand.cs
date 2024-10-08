using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Command
{
    /// <summary>
    /// Interface de comando da impressora
    /// </summary>
    internal interface IPrintCommand
    {
        /// <summary>
        /// 
        /// </summary>
        int ColsNomal { get; }

        /// <summary>
        /// 
        /// </summary>
        int ColsCondensed { get; }

        /// <summary>
        /// 
        /// </summary>
        int ColsExpanded { get; }

        /// <summary>
        /// 
        /// </summary>
        IFontMode FontMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IFontWidth FontWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IAlignment Alignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IPaperCut PaperCut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IDrawer Drawer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IQrCode QrCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IImage Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IBarCode BarCode { get; set; }

        /// <summary>
        /// Inicializar Impressão
        /// </summary>
        IInitializePrint InitializePrint { get; set; }

        /// <summary>
        /// Status Geral da Impressão
        /// </summary>
        /// <returns></returns>
        IStatusGeneral StatusGeneral { get; set; }

        /// <summary>
        /// Situação da tampa da impressora
        /// </summary>
        ICoverOpen CoverOpen { get; set; }

        /// <summary>
        /// Situação do Papel
        /// </summary>
        IOutOfPaper OutOfPaper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        byte[] AutoTest();

        
    }
}