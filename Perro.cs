public class Perro:Animal{
    public Perro(string n):base(n){}
    public override void hacerSonido(){
            Console.WriteLine(nombre+": "+"GUAU..!");
    }
}