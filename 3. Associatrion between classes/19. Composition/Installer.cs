namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
            _logger.Log("Installer:");
        }

        public void Install()
        {
            _logger.Log("we are installing the application...");
        }
    }
}
