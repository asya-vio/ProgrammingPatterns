using Patterns.Ex05.ExternalLibs;
using Patterns.Ex05.SubEx_02;

namespace Patterns.Ex05.SubEx_02
{
    public class DatabaseSaverClient
    {
        public void Main(bool b)
        {
            var databaseSaver = new DatabaseSaverEditor();
            databaseSaver.publisher.Subscribe(new MailSenderListener());
            databaseSaver.publisher.Subscribe(new UpdateCacheListener());
           
           // var databaseSaver = new DatabaseSaver();
            DoSmth(databaseSaver);

        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}

