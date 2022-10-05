public class Gato: Animal{
    public Gato(string n):base(n){}
    public override void hacerSonido()=>Console.WriteLine($"{nombre}: MIUA...!");
}