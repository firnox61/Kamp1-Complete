using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
       Dictionary<string,int> MyDict = new Dictionary<string,int>();
        MyDict.Add("enes", 61);
        MyDict.Add("ismail", 641);
        MyDict.Add("selman", 5363);
        foreach (KeyValuePair<string,int> item in MyDict)
        {
            Console.WriteLine("{0} ve {1}",item.Key,item.Value);
        }

      

    }
}