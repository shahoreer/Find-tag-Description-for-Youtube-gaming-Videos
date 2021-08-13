using System;
class HelloWorld {
  static void Main() {

     string game="King Archery";
     string goal="shoot arrows towards the target";
     string publisher="tgame";
     string youtube_channel= "TheBro";
     string email= "thebroytm@gmail.com";
     string gametype="2D Shooting";
     
     Console.WriteLine(game+" ->\n");
     Console.WriteLine("TAG ->\n");
     Console.WriteLine(ret(game,gametype));
     Console.WriteLine("\nDESCRIPTION ->\n");
     Console.WriteLine(retd(game,goal,publisher,youtube_channel,email,gametype));
  }
  
  static string ret(string s,string t){
      string rets;
      rets=s+","+s+" Gameplay,"+ "Playing "+s+","+s+
      " Mobile Game,"+t+" Games,Offline Games,Best Mobile Games,Best Offline Games,"+t+" offline Games,"+t+" Mobile Games,";
      return rets;
  }
  
  static string retd(string g,string gl,string p,string c,string e,string t){
      string ret;
      ret = g+" is a free mobile game and "+t+ " Game that you can play on your phone." + " The Game "+
      g+" is made by "+p+". In "+ g+
      " your goal is to " +gl+". I recommend playing "+g+
      " if you want to play a free mobile game or "+t+" Game.\n\n"+
      "Offline Games and Free Mobile Games are always fun, since "+g+" is a Offline Games and Free Mobile Games it's really a fun game to play. And I think "+
      g+" is the best "+ t+" and best Free Mobile Games that you can play without internet connection. And "+
      g+" is also the best offline mobile game and best "+t+"Game.\n\n"+
      "Subscribe to "+c+" for more "+g+
      " Gameplay and mobile "+t+" Games.\n\n"+convinhashtag(g)+" "+convinhashtag(c)+" "+convinhashtag(c)+"videos "+convinhashtag(g)+"gameplay\n\n"+"Email: "+e;
      return ret;
  }
  
  static string convinhashtag(string s){
      int l=s.Length;
      string r="#";
      for(int i=0;i<l;i++){
          string ck=s.Substring(i,1);
          if(ck!= " ")
            r+=ck;
      }
      return r;
  }
}
