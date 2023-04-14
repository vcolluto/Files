
using Files;

List <Utente> utenti=new List<Utente>();	

if (!File.Exists("dati\\utenti.txt"))
    Console.WriteLine("File non trovato!");
else
{
	try
	{
		StreamReader sr = File.OpenText("dati\\utenti.txt");  //apro il file in lettura (nella stessa cartella dell'eseguibile)

		while (!sr.EndOfStream)      //finché ci sono dati da leggere
		{
			string? line = sr.ReadLine();   //leggo una riga dal file
			if (line != null)
			{
                string[] campi = line.Split(' ');   //suddividi la stringa in più pezzi usando lo spazio come separatore
				Console.WriteLine("UTENTE:");
				Console.WriteLine($"\tNome: {campi[0]}");
                Console.WriteLine($"\tCognome: {campi[1]}");
                Console.WriteLine($"\tData di nascita: {campi[2]}");
				utenti.Add(new Utente(campi[0], campi[1], DateOnly.ParseExact(campi[2],"d")));
            }
			
		}
		sr.Close();     //chiudo il file
	}
	catch (UnauthorizedAccessException)
	{
		Console.WriteLine("Non hai i diritti di accesso al file");
	}
	catch (Exception e)
	{

		Console.WriteLine("Si è verificato un problema: " + e.Message);
	}
}

StreamWriter sw = File.CreateText("output.txt");
sw.WriteLine("prova1");
sw.WriteLine("prova2");
sw.Close();