using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\Skillfactory\1");
            if (dirInfo.Exists)
            {
                TimeSpan interval = TimeSpan.FromMinutes(30);
                
                if(DateTime.Now - dirInfo.LastWriteTime > interval)
                {
                    dirInfo.Delete(true);
                    Console.WriteLine("Каталог удален");
                }

                else 
                { 
                    Console.WriteLine("Не прошло достаточно времени для удаления каталога"); 
                }

            }
        }

        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine("По указанному пути ничего нет");
        }

        catch (DriveNotFoundException ddnfe)
        {
            Console.WriteLine("Указанный в пути диск отсутствует");
        }
        
        catch (AccessViolationException ave)
        {
            Console.WriteLine("У вас нет доступа к указанному в пути каталогу");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}