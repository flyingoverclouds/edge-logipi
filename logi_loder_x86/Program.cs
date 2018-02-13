using System;

/* this CLI simulate the logi_loader on x86 to  */

namespace logi_loder_x86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOGI_LOADER VERSION : 0.1.0");
            Console.WriteLine("Compiled for LOGI-PI SIMULx86");
            Console.WriteLine("Board variant is LOGIPI_R1.5");

            if (args.Length==1 && System.IO.File.Exists(args[0]))
            {
                var fi = new System.IO.FileInfo(args[0]);
                Console.WriteLine($"bit file size : {fi.Length}");
                System.Threading.Thread.Sleep(2000); // simulate FPGA burn time
                Console.WriteLine("bitstream loaded, check done led");
            }
            else // simulate the bug of logi_loader launch without parameters or with a wrong filename
                Console.Error.WriteLine("Segmentation fault"); 
        }

     
    }
}
