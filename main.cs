using System;
class HelloWorld {
  static void Main() {
      
      string game="King Archery";
      string goal="shoot arrows towards a target";
      string publisher="tgame";
      
     Console.WriteLine(game+" ->");
     Console.WriteLine("TAG ->");
     Console.WriteLine(ret(game));
     Console.WriteLine("DESCRIPTION ->");
     Console.WriteLine(retd(game,goal,publisher));
  }
  
  static string ret(string s){
      string rets;
      rets=s+","+s+" Gameplay,"+ "Playing "+s+",Mobile Game,"+s+" Mobile Game,";
      return rets;
  }
  
  static string retd(string g,string gl,string p){
      string ret;
      ret = g+" is a free mobile game and Hyper Casual Game that you can play on your phone."+" The Game "+
      g+" made by "+p+". In "+ g+
      " your goal is to " +gl+". I recommend playing "+g+
      " if you want to play a free mobile game or Hyper Casual Game.";
      return ret;
  }
}
