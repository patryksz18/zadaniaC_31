using Powtorzeniowy;

class PlikGłówny
{
    Tablice tablica = new Tablice();
    static void Main(string[] args)
        
    {
        //zmienna ktora jest odwolaniem do innego skryptu
        Tablice tablica = new Tablice();
        int[] tab= tablica.Tworzenie_tablicy();
        tablica.Wyswietl(tab);
        tablica.Sortowanie_babelkowe(tab);
        tablica.Wyswietl(tab);
    }
}
