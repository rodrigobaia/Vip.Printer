namespace Vip.Printer.Interfaces.Engine
{
    /// <summary>
    /// Interface do mecanismo de comunicar com a impressora
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Enviar comando para impressora
        /// </summary>
        /// <param name="printer">Impressora</param>
        /// <param name="content">Comando</param>
        /// <returns></returns>
        bool Send(string printer, byte[] content);

        /// <summary>
        /// Busca o status da Impressora
        /// </summary>
        /// <param name="printer">Nome/Endereço da Impressora</param>
        /// <param name="content">Conteudo do comando</param>
        /// <returns></returns>
        byte[] GetStatus(string printer, byte[] content);
    }
}