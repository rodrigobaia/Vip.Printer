using System.Drawing;
using System.IO;
using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Printer
{
    /// <summary>
    /// Interface da Impressora
    /// </summary>
    internal interface IPrinter
    {
        /// <summary>
        /// Coluna Normal
        /// </summary>
        int ColsNomal { get; }

        /// <summary>
        /// Coluna Condensada
        /// </summary>
        int ColsCondensed { get; }

        /// <summary>
        /// Coluna Expandida
        /// </summary>
        int ColsExpanded { get; }

        /// <summary>
        /// Imprimir Documento
        /// </summary>
        /// <param name="copies">Quantidade de Copias</param>
        void PrintDocument(int copies);

        /// <summary>
        /// Escrever na impressora
        /// </summary>
        /// <param name="value">Valor</param>
        void Write(string value);

        /// <summary>
        /// Escrever na impressora
        /// </summary>
        /// <param name="value">Valor</param>
        void Write(byte[] value);

        /// <summary>
        /// Escrever na próxima linha
        /// </summary>
        /// <param name="value">Valor</param>
        void WriteLine(string value);

        /// <summary>
        /// Nova linha
        /// </summary>
        void NewLine();

        /// <summary>
        /// Adicionar novas linhas
        /// </summary>
        /// <param name="lines">Número de linha</param>
        void NewLines(int lines);

        /// <summary>
        /// Limpar impressão
        /// </summary>
        void Clear();

        #region Commands

        /// <summary>
        /// Adicionar um separador
        /// </summary>
        void Separator();

        /// <summary>
        /// Auto Teste
        /// </summary>
        void AutoTest();

        /// <summary>
        /// Teste de Impressora
        /// </summary>
        void TestPrinter();

        #region FontMode

        /// <summary>
        /// Modo Italico
        /// </summary>
        /// <param name="value">Valor a ser impresso</param>
        void ItalicMode(string value);

        /// <summary>
        /// Modo Italico
        /// </summary>
        /// <param name="state">Status Liga/Desliga</param>
        void ItalicMode(PrinterModeState state);

        /// <summary>
        /// Modo Negrito
        /// </summary>
        /// <param name="value">Valor a ser impresso</param>
        void BoldMode(string value);

        /// <summary>
        /// Modo Netrigo
        /// </summary>
        /// <param name="state">Status Liga/Desliga</param>
        void BoldMode(PrinterModeState state);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        void UnderlineMode(string value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        void UnderlineMode(PrinterModeState state);

        /// <summary>
        /// Modo Expandido
        /// </summary>
        /// <param name="value">Texto</param>
        void ExpandedMode(string value);

        /// <summary>
        /// Modo expandido
        /// </summary>
        /// <param name="state">Estado</param>
        void ExpandedMode(PrinterModeState state);

        /// <summary>
        /// Modo Condensado
        /// </summary>
        /// <param name="value">Valor </param>
        void CondensedMode(string value);

        /// <summary>
        /// Modo Condensado
        /// </summary>
        /// <param name="state">Estado ligado/desligado</param>
        void CondensedMode(PrinterModeState state);

        #endregion

        #region FontWidth

        /// <summary>
        /// 
        /// </summary>
        void NormalWidth();

        /// <summary>
        /// 
        /// </summary>
        void DoubleWidth2();

        /// <summary>
        /// 
        /// </summary>
        void DoubleWidth3();

        #endregion

        #region Alignment

        /// <summary>
        /// Alinhamento a esquerda
        /// </summary>
        void AlignLeft();

        /// <summary>
        /// Alinhamento a direita
        /// </summary>
        void AlignRight();

        /// <summary>
        /// Alinhamento no centro
        /// </summary>
        void AlignCenter();

        #endregion

        #region PaperCut

        /// <summary>
        /// Corte completo do papel
        /// </summary>
        void FullPaperCut();

        /// <summary>
        /// Corte completo do papel
        /// </summary>
        /// <param name="predicate"></param>
        void FullPaperCut(bool predicate);

        /// <summary>
        /// Corte parcial do papel
        /// </summary>
        void PartialPaperCut();

        /// <summary>
        /// Corte parcial do papel
        /// </summary>
        /// <param name="predicate"></param>
        void PartialPaperCut(bool predicate);

        #endregion

        #region Drawer

        /// <summary>
        /// Abrir gaveta
        /// </summary>
        void OpenDrawer();

        #endregion

        #region QrCode

        void QrCode(string qrData);
        void QrCode(string qrData, QrCodeSize qrCodeSize);

        #endregion

        #region Image

        void Image(string path, bool highDensity);
        void Image(Stream stream, bool highDensity);
        void Image(byte[] bytes, bool highDensity);
        void Image(Image image, bool highDensity);

        #endregion

        #region BarCode

        void Code128(string code);
        void Code39(string code);
        void Ean13(string code);

        #endregion

        #region InitializePrint

        /// <summary>
        /// Inicializar Impressora
        /// </summary>
        void InitializePrint();

        #endregion

        #endregion

        #region [ Status Printer ]

        /// <summary>
        /// Buscar o Status da Impressora
        /// </summary>
        /// <returns></returns>
        StatusPrinterType GetStatus();

        #endregion [ Status Printer]
    }
}