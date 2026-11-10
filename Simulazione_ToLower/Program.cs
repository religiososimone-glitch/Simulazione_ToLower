string frase, fraseMaiuscola = "";
int codAscii;
Console.WriteLine("Inserire la frase da modificare");
frase = Console.ReadLine();

for (int i = 0; i < frase.Length; i++) // Ciclo per lettura caratteri
{
    char Lettera = frase[i];
    codAscii = (int)Lettera;
    if (codAscii >= 97 && codAscii <= 122) // controllo per verificare se il carattere va modificato o no
    {
        Lettera = (char)(codAscii - 32);
    }
    fraseMaiuscola += Lettera; // Composizione della stringa di output
}
Console.WriteLine(fraseMaiuscola);