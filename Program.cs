

static void Main(String[] args)
{
    // Crie um novo objeto Guy em uma variável chamada joe
    // Define seu campo Name para "Joe"
    // Define seu campo Cash para 50

    // Crie um novo objeto Guy em uma variável chamada joe
    // Define seu campo Name para "Bob"
    // Define seu campo Cash para 100


    Guy joe = new Guy() { Name = "Joe", Cash = 50};
    Guy bob = new Guy() { Name = "Bob", Cash = 100};



    while (true)
    {
        //chame os métodos WriteMyIfo de cada onjeto Guy
        joe.WriteMyInfo();
        bob.WriteMyInfo();

        Console.WriteLine("Enter an amount: ");
        string howMuch = Console.ReadLine();
        if (howMuch == "") return;

        //Use int.TryParse para tentar converter a string howMuchem int
        //se teve êxito (como fez anteriormente no capitulo)

        if (int.TryParse(howMuch, out int amount))
        {
            Console.Write("Who should give the cash: ");
            string whichGuy = Console.ReadLine();
            if (whichGuy == "Joe")
            {
                //Chame o método Givecash do objeto joe e salve os resultados
                //Cahme o método ReceiveCash do objeto bo com os resultados salvos
                int cashGiven = joe.GiveCash(amount);
                bob.ReceiveCash(cashGiven);
            }
            else if (whichGuy == "Bob")
            {
                int cashGiven = bob.GiveCash(amount);
                joe.ReceiveCash(cashGiven);
            }
            else
            {
                Console.WriteLine("Please enter  'Joe' or 'Bob'");
            }
        }
        else
        {
            Console.WriteLine("Please enter an amount (or a blank line to exit). ");
        }

       
    }

}

class Guy
{
    public string Name;
    public int Cash;

    // Escreve meu no me e quanto de dinheiro tenho no console
    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " bucks.");
    }

    /// <summary>
    /// Dá parte do meu dinheiro, retirando-o da minha carteira( ou escrevendo um amensagem no console se não tenho mais dinheiro
    /// </summary>
    /// <param name="amount">Quantia de dinheiro a entregar</param>
    /// <returns>
    /// A quantia de dinheiro removida da minha carteira ou 0 se não tenho dinheiro suficiente (ou se a quantia é invalida)
    /// </returns>
    public int GiveCash(int amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine(Name + "says: " + amount + " Isn't a valid amount");
            return 0;
        }
        if(amount > Cash)
        {
            Console.WriteLine(Name + " Says: " + "I don't have enough cash to give you " + amount);
            return 0;
        }
        Cash -= amount;
        return amount;
    }

    ///Recebe algum dinheiro, adicionando-o à minha carteira (ou escrevendo uma mensagem no console se a quantia é inválida)
    ///Quantia de dinheiro a entregar
    ///
    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + "says: " + amount + "isn't an amount I'll take");
        }
        else
        {
            Cash += amount;
        }
    }
}

