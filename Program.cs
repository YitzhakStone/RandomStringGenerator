using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStringGenerator
{
    class Program
    {

        static void Main(string[] args)
        {

              RandomStringGenarator gdc = new RandomStringGenarator(
                  RandomStringGenarator.CharType.Number |
                  RandomStringGenarator.CharType.Upper |
                  RandomStringGenarator.CharType.Lower);
            
              int i = 0;
              while (true)
              {
                  try
                  {
                      i = Convert.ToInt32(Console.ReadLine());
                      break;
                  }
                  catch
                  {
                      continue;
                  }
              }
            
              string s = gdc.gerarString(i);
              Console.WriteLine(s + "\n\n");
            
        }
        
    }
        
}
