namespace Autovermietung.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Testcase bei dem man für ein auto audi pro tag 50 euro für 5 tage kunde rabbat 30 prozent Preisberechen.
        Kunde Hans = new Kunde("Hans Peter", 1234);
        Auto audi = new Auto("Audi", "rs3", "BN b 5555", true, 50);
        Hans.setRabatt(0.3);
        audi.mieten();
        Assert.Equal(expected: 50, actual: audi.PreisProTag);
        Vermietung vermietung = new Vermietung();
        vermietung.kunde = Hans;
        vermietung.auto = audi;
        vermietung.AnzahlTage = 5;
        double ergebnis = vermietung.BerechnePreis();
        Assert.Equal(expected: 75 , actual: ergebnis);
    }
}
