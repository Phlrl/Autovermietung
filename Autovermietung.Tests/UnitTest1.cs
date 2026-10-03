namespace Autovermietung.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Testcase bei dem man für ein auto audi pro tag 50 euro für 5 tage kunde rabbat 30 prozent Preisberechen.
        Kunde Hans = new Kunde("Hans Peter", 1234);
        Hans.setRabatt(0.3);
        Auto audi = new Auto("Audi", "rs3", "BN b 5555", true);
        audi.vermieten(true);
        
    }
}
