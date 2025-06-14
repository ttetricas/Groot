 Console.WriteLine("--- Groot Chatbot ---\n");

 while (true)
{
    Console.Write("Pergunta:");
    string pergunta = Console.ReadLine()!.Trim();

    if (pergunta.ToUpper() == "TCHAU")
    {
        Console.WriteLine("                          Resposta: Eu sou Groot!");
        break;
    }
    else
    {
        Console.WriteLine("                          Resposta: Eu sou Groot.");
    }
}