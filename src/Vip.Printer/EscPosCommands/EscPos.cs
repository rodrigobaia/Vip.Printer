using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    /// <summary>
    /// ESC/POS da Epson
    /// </summary>
    internal class EscPos : IPrintCommand
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public IFontMode FontMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IFontWidth FontWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IAlignment Alignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IPaperCut PaperCut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDrawer Drawer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IQrCode QrCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IImage Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IBarCode BarCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IInitializePrint InitializePrint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ColsNomal => 48;

        /// <summary>
        /// 
        /// </summary>
        public int ColsCondensed => 64;

        /// <summary>
        /// 
        /// </summary>
        public int ColsExpanded => 24;

        /// <summary>
        /// Status da Impressão
        /// </summary>
        /// <returns></returns>
        public IStatusGeneral StatusGeneral { get; set ; }
        
        /// <summary>
        /// 
        /// </summary>
        public ICoverOpen CoverOpen { get; set;  }

        /// <summary>
        /// Situação do Papel
        /// </summary>
        public IOutOfPaper OutOfPaper { get; set; }

        #endregion

        #region Constructor

        public EscPos()
        {
            FontMode = new FontMode();
            FontWidth = new FontWidth();
            Alignment = new Alignment();
            PaperCut = new PaperCut();
            Drawer = new Drawer();
            QrCode = new QrCode();
            Image = new Image();
            BarCode = new BarCode();
            InitializePrint = new InitializePrint();
            StatusGeneral = new StatusGeneral();
            CoverOpen = new CoverOpen();
            OutOfPaper = new OutOfPaper();
        }

        #endregion

        #region Methods

        public byte[] AutoTest()
        {
            return new byte[] {29, 40, 65, 2, 0, 0, 2};
        }

        #endregion
    }
}