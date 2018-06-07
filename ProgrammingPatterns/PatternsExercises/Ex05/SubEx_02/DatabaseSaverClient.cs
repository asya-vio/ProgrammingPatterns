using Patterns.Ex05.ExternalLibs;
using Patterns.Ex05.SubEx_02;

namespace Patterns.Ex05.SubEx_02
{
    public class DatabaseSaverClient
    {
        public void Main(bool b)
        {
            Publisher publisher = new Publisher();

            publisher.Subscribe(new MailSenderListener());
            publisher.Subscribe(new UpdateCacheListener());
           
            var databaseSaver = new DatabaseSaver();
            DoSmth(databaseSaver);

            //Должно вызываться в Эдиторе, но его изменять нельзя
            publisher.Notify();
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}

