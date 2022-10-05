// See https://aka.ms/new-console-template for more information
public class Program{
    static void Main(string[] args){
        Animal mascota01 = new Perro("Odie");
        Animal mascota02 = new Gato("Garfield");
        Animal raro = new Animal("ET");

        mascota01.hacerSonido();
        mascota02.hacerSonido();
        raro.hacerSonido();
    }
}
