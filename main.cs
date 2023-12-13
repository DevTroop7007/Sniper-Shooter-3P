using System;

class Program {
  public static void Main (string[] args) {

    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine ("▄︻デ══━一💥\t Sniper Shooooooter :|=|3PLAYERS|=|: Who is LUCKEY!!!\t ▄︻デ══━一💥");
    Console.ResetColor();
    Console.ReadKey();
    play_again:
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Enter 1st player's name:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    string p1 = Console.ReadLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Enter 2nd player's name:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    string p2 = Console.ReadLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Enter 3rd player's name:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    string p3 = Console.ReadLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;

    Console.WriteLine("Now, {0}, {1}, and {2} Let's begin the war.", p1, p2, p3);
    Console.ReadKey();
    Console.WriteLine("Round 1 :::");
    Console.ReadKey();

    int h1 = 200;
    int h2 = 200;
    int h3 = 200;

    Random NumGen = new Random();
    int D1 = NumGen.Next(1,101);
    int D2 = NumGen.Next(1,101);
    int D3 = NumGen.Next(1,101);
    int D4 = NumGen.Next(1,101);
    int D5 = NumGen.Next(1,101);
    int D6 = NumGen.Next(1,101);
    int D7 = NumGen.Next(1,101);
    int D8 = NumGen.Next(1,101);
    int D9 = NumGen.Next(1,101);
    int D10 = NumGen.Next(1,101);
    int D11 = NumGen.Next(1,101);
    int D12 = NumGen.Next(1,101);
    int D13 = NumGen.Next(1,101);
    int D14 = NumGen.Next(1,101);
    int D15 = NumGen.Next(1,101);
    int D16 = NumGen.Next(1,101);
    int D17 = NumGen.Next(1,101);
    int D18 = NumGen.Next(1,101);
    int D19 = NumGen.Next(1,101);
    int D20 = NumGen.Next(1,101);


    

    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D1);
    h2 = h2 - D1;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    
    Console.WriteLine(p2 + " sniped ---> "+ p3 +" ::: Damage =" + D2);
    h3 = h3 - D2;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    
    Console.WriteLine(p1 + " sniped ---> "+ p3 +" ::: Damage =" + D3);
    h3 = h3 - D3;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D4);
    h1 = h1 - D4;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.WriteLine(p3 + " sniped ---> "+ p2 +" ::: Damage =" + D5);
    h2 = h2 - D5;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.WriteLine(p3 + " sniped ---> "+ p1 +" ::: Damage =" + D6);
    h1 = h1 - D6;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D7);
    h2 = h2 - D7;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();

    Console.WriteLine(p2 + " sniped ---> "+ p3 +" ::: Damage =" + D8);
    h3 = h3 - D8;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();

    Console.WriteLine(p1 + " sniped ---> "+ p3 +" ::: Damage =" + D9);
    h3 = h3 - D9;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();

    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D10);
    h1 = h1 - D10;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }
    Console.ReadKey();

    Console.WriteLine(p3 + " sniped ---> "+ p2 +" ::: Damage =" + D11);
    h2 = h2 - D11;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.WriteLine(p3 + " sniped ---> "+ p1 +" ::: Damage =" + D12);
    h1 = h1 - D12;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }
    Console.ReadKey();
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D13);
    h2 = h2 - D13;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();

    Console.WriteLine(p2 + " sniped ---> "+ p3 +" ::: Damage =" + D14);
    h3 = h3 - D14;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }
    Console.ReadKey();


    Console.WriteLine(p1 + " sniped ---> "+ p3 +" ::: Damage =" + D15);
    h3 = h3 - D15;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();

    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D16);
    h1 = h1 - D16;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }
    Console.ReadKey();

    Console.WriteLine(p3 + " sniped ---> "+ p2 +" ::: Damage =" + D17);
    h2 = h2 - D17;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }
    Console.ReadKey();

    Console.WriteLine(p3 + " sniped ---> "+ p1 +" ::: Damage =" + D18);
    h1 = h1 - D18;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 + "  ~~~  " + p3 + "=" + h3);
    if(h1 <= 0){
      Console.WriteLine(p1 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h2 <= 0){
      Console.WriteLine(p2 + " IS ELIMINATED!!!");
      goto r2;
    }else if(h3 <= 0){
      Console.WriteLine(p3 + " IS ELIMINATED!!!");
      goto r2;
    }else{
      Console.WriteLine("");
    }
    Console.ResetColor();
    Console.ReadKey();
    r2:
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Round 2 ::: ");
    Console.ResetColor();
    if(h1 <= 0)
    {
      p1 = p2;
      p2 = p3;
      h1 = 500;
      h2 = 500;
      Console.WriteLine("Now, {0} and {1} will fight for the win.", p1, p2);
      
    }
    else if(h2 <= 0){
      p2 = p3;
      h1 = 500;
      h2 = 500;
      Console.WriteLine("Now, {0} and {1} will fight for the win.", p1, p2);
    }else if(h3 <= 0){
      h1 = 500;
      h2 = 500;
      Console.WriteLine("Now, {0} and {1} will fight for the win.", p1,p2);
    }else{
      Console.WriteLine("THE GAME IS A DRAW!!!");
  }


    
    int DD1 = NumGen.Next(1,101);
    int DD2 = NumGen.Next(1,101);
    int DD3 = NumGen.Next(1,101);
    int DD4 = NumGen.Next(1,101);
    int DD5 = NumGen.Next(1,101);
    int DD6 = NumGen.Next(1,101);
    int DD7 = NumGen.Next(1,101);
    int DD8 = NumGen.Next(1,101);
    int DD9 = NumGen.Next(1,101);
    int DD10 = NumGen.Next(1,101);
    int DD11 = NumGen.Next(1,101);
    int DD12 = NumGen.Next(1,101);
    int DD13 = NumGen.Next(1,101);
    int DD14 = NumGen.Next(1,101);
    int DD15 = NumGen.Next(1,101);
    int DD16 = NumGen.Next(1,101);
    int DD17 = NumGen.Next(1,101);
    int DD18 = NumGen.Next(1,101);
    int DD19 = NumGen.Next(1,101);
    int DD20 = NumGen.Next(1,101);
    int DD21 = NumGen.Next(1,101);
    int DD22 = NumGen.Next(1,101);
    int DD23 = NumGen.Next(1,101);
    int DD24 = NumGen.Next(1,101);
    int DD25 = NumGen.Next(1,101);
    int DD26 = NumGen.Next(1,101);
    Console.ReadKey();
    
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD1);
    h2 = h2 - DD1;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 );
    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD2);
    h1 = h1 - DD2;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD3);
    h2 = h2 - DD3;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD4);
    h1 = h1 - DD4;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD5);
    h2 = h2 - DD5;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD6);
    h1 = h1 - DD6;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD7);
    h2 = h2 - DD7;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD8);
    h1 = h1 - DD8;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD9);
    h2 = h2 - DD9;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD10);
    h1 = h1 - DD10;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD11);
    h2 = h2 - DD11;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD12);
    h1 = h1 - DD12;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD13);
    h2 = h2 - DD13;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD14);
    h1 = h1 - DD14;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD15);
    h2 = h2 - DD15;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD16);
    h1 = h1 - DD16;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD17);
    h2 = h2 - DD17;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD18);
    h1 = h1 - DD18;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD19);
    h2 = h2 - DD19;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD20);
    h1 = h1 - DD20;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD21);
    h2 = h2 - DD21;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD22);
    h1 = h1 - DD22;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD23);
    h2 = h2 - DD23;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD24);
    h1 = h1 - DD24;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + DD25);
    h2 = h2 - DD25;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + DD26);
    h1 = h1 - DD26;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }
    
    f:
    Console.WriteLine("Hope that it was a nice game :)");
    Console.WriteLine("Do you want to play again? (Y/N)");

    string pa = Console.ReadLine();
    if(pa == "Y" || pa == "y"){
      Console.WriteLine("Thanks, press ENTER to play again.");
      Console.ReadKey();
      goto play_again;  
    }else{
      Console.WriteLine("Thanks for playing :)");
    }
    Console.ResetColor();




    
}
  }
