string frase, fraseMinuscola = "";
int codAscii;
Console.WriteLine("Inserire la frase da modificare");
frase = Console.ReadLine();

for (int i = 0; i < frase.Length; i++) // Ciclo per lettura caratteri
{
    char Lettera = frase[i];
    codAscii = (int)Lettera;
    if (codAscii >= 65 && codAscii <= 90) // controllo per verificare se il carattere va modificato o no
    {
        Lettera = (char)(codAscii + 32);
    }
    fraseMinuscola += Lettera; // Composizione della stringa di output
}
Console.WriteLine(fraseMinuscola);