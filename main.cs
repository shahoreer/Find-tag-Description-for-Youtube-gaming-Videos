using System;
class HelloWorld {
  static void Main() {
      
      string g="King Archery";
      
    Console.WriteLine(g+" ->");
    Console.WriteLine(ret(g));
  }
  
  
  static string ret(string s){
      string rets;
      
      rets=s+","+s+" Gameplay,"+ "Playing "+s+",Mobile Game,"+s+" Mobile Game,";
      
      return rets;
      
  }

}