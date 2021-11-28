using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    //aop ve mikroservis  mantığını anlatıyor burada hoca.
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
