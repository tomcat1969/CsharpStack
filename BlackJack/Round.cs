using System;
namespace BlackJack
{
    public class Round
    {
        Deck the_deck = new Deck();
        Player p1 = new Player("Tom");
        Player host = new Player("Host");
        bool gameIsOn = true;
        string input = "";
        public Round()
        {
            this.startGame();
            
            while(input != "-1")
            {
                
                if (input == "1")
                {
                    //Console.WriteLine("11111111111111");
                    
                   
                
                    host.autoReact(the_deck);
                    
                    host.showCards();
                    
                    this.juge();





                }
                if(input == "2")
                {
                    //Console.WriteLine("22222222222222");
                    p1.draw(the_deck);
                    p1.showCards();

                   





                }

                Console.WriteLine("input 1: stand");
                Console.WriteLine("input 2: hit");
                Console.WriteLine("input -1: quit the game");
                input = Console.ReadLine();

            }



        }
        public void startGame()
        {
            Console.WriteLine("Let's play poker game!");

            Console.WriteLine(" ######                                       #                      ");
            Console.WriteLine(" #     # #        ##    ####  #    #          #   ##    ####  #    # ");
            Console.WriteLine(" #     # #       #  #  #    # #   #           #  #  #  #    # #   #  ");
            Console.WriteLine(" ######  #      #    # #      ####            # #    # #      ####   ");
            Console.WriteLine(" #     # #      ###### #      #  #      #     # ###### #      #  #   ");
            Console.WriteLine(" #     # #      #    # #    # #   #     #     # #    # #    # #   #  ");
            Console.WriteLine(" ######  ###### #    #  ####  #    #     #####  #    #  ####  #    # ");













            the_deck.showDeck();

            host.draw(the_deck);
            host.draw(the_deck);
            host.showCards();

            p1.draw(the_deck);
            p1.draw(the_deck);
            p1.showCards();

            Console.WriteLine("input 1: stand");
            Console.WriteLine("input 2: hit");
            Console.WriteLine("input -1: quit the game");
            this.input = Console.ReadLine();
        }

        public void juge()
        {
            if (host.bust) {
                Console.WriteLine($"{p1.Name} win!");
                this.gameIsOn = false;
                return;
            }
            if (p1.bust)
            {
                Console.WriteLine($"{p1.Name} win!");
                this.printYouWin();
                this.gameIsOn = false;
                return;
            }
            if(p1.score > host.score )
            {
                Console.WriteLine($"{p1.Name} win!");
                this.printYouWin();
                this.gameIsOn = false;
                return;
            }
            if (p1.score < host.score)
            {
                Console.WriteLine($"{p1.Name} lose!");
                this.gameIsOn = false;
                return;
            }
            if (p1.score == host.score)
            {
                Console.WriteLine($"the game is draw ,play again!");
                this.gameIsOn = false;
                return;
            }
            return;
        }

        public void printYouWin()
        {

              Console.WriteLine("#     #                                     ### "); 
              Console.WriteLine(" #   #   ####  #    #    #    # # #    #    ### ");
              Console.WriteLine("  # #   #    # #    #    #    # # ##   #    ### ");
              Console.WriteLine("   #    #    # #    #    #    # # # #  #     #  ");
              Console.WriteLine("   #    #    # #    #    # ## # # #  # #        ");
              Console.WriteLine("   #    #    # #    #    ##  ## # #   ##    ### ");
              Console.WriteLine("   #     ####   ####     #    # # #    #    ### ");

        }
    }
}
