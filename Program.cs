namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test joe , tom , mary ;
            joe=new test();
            mary=new test();    
            tom=joe;
            joe.mid=80;
            joe.Final=76;
            Console.WriteLine("joe平均成績" + joe.GetAvg());
            mary.SetGrade(78,92);
            Console.WriteLine("mary平均成績" + mary.GetAvg());
            Console.WriteLine("tom平均成績" + mary.GetAvg());












        }
    }
}
