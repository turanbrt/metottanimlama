using System.Security.Cryptography;
using System.Xml.XPath;

namespace metottanimlama;

class Program
{
    static int sumMethot(int d1,int d2){
    
        return d1+d2;

    }
    static void Main(string[] args)
    {
        int a=2, b=3;
        int result;
        result=sumMethot(a,b);
        //Console.WriteLine(result);
        Methots sample=new Methots();
        sample.printMetot(Convert.ToString(result));
        sample.increaseAndSum(ref a,ref b);
        
        sample.printMetot(Convert.ToString(a+b));

    }
    class Methots{

        public void printMetot(string a){
            Console.WriteLine(a);

        }
        public void increaseAndSum(ref int value1,ref int value2){
            value1++;
            value2++;
           
        }
    }
}
