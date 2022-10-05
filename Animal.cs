public class Animal{
    protected string nombre;
    public virtual void hacerSonido(){
        Console.WriteLine(".....");
    }
    public Animal(string n){
        nombre = n;
    }
}