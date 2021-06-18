using System;
class HelloWorld {
  static void Main() {
      
      string g="King Archery";
      string gl="shoot arrows towards a target ";
      
     Console.WriteLine(g+" TAG ->");
     Console.WriteLine(ret(g));
     Console.WriteLine(g+" DESCRIPTION ->");
     Console.WriteLine(retd(g,gl));
  }
  
  static string ret(string s){
      string rets;
      rets=s+","+s+" Gameplay,"+ "Playing "+s+",Mobile Game,"+s+" Mobile Game,";
      return rets;
  }
  
  
  static string retd(string g,string gl){
      string ret;
      ret = g+" is a free mobile game and Hyper Casual Game that you can play on your phone. In "+g+
      " your goal is to " +gl+". I recommend playing "+g+
      " if you want to play a free mobile game or Hyper Casual Game.";
      return ret;
  }
}
