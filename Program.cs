namespace tpmodul5_1302204051;

internal class MainClass
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Doni");
        video1.IncreasePlayCount(10);
        
        video1.PrintVideoDetails();

        SayaTubeVideo video2 = new SayaTubeVideo("Tutorial Handling Exception - Doni");
        for (int i = 0; i < 215; i++)
        {
            video2.IncreasePlayCount(10000000);
        }

        video2.PrintVideoDetails();
    }
}