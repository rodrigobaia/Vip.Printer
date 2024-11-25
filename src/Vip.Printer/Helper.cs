using PDVFlow.ManagerLog;

namespace Vip.Printer
{
    /// <summary>
    /// Helper de Log
    /// </summary>
    internal static class Helper
    {
        private static LoggerService _loggerService;

        /// <summary>
        /// Loger
        /// </summary>
        public static LoggerService Logger
        {
            get
            {

                if (_loggerService == null)
                {
                    _loggerService = new LoggerService("vip-printer");
                }

                return _loggerService;
            }
        }
    }
}
