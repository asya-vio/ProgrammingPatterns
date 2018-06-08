using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    class DatabaseSaverEditor : IDatabaseSaver
    {
        public Publisher publisher = new Publisher();

        public void SaveData(object data)
        {
            //Сохранение данных в БД
            publisher.Notify();
        }
    }
}
