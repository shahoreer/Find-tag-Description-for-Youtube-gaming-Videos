using System;
class HelloWorld {
  static void Main() {

      string game="King Archery";
      string goal="Shoot arrows towards a target, and you get point for your accuracy";
      string publisher="TGame";
      string youtube_channel= "TalhaPro";
      
     Console.WriteLine(game+" ->\n");
     Console.WriteLine("TAG ->");
     Console.WriteLine(ret(game));
     Console.WriteLine("DESCRIPTION ->");
     Console.WriteLine(retd(game,goal,publisher,youtube_channel));
  }
  
  static string ret(string s){
      string rets;
      rets=s+","+s+" Gameplay,"+ "Playing "+s+",Mobile Game,"+s+" Mobile Game,";
      return rets;
  }
  
  static string retd(string g,string gl,string p,string c){
      string ret;
      ret = g+" is a free mobile game and Hyper Casual Game that you can play on your phone."+" The Game "+
      g+" is made by "+p+". In "+ g+
      " your goal is to " +gl+". I recommend playing "+g+
      " if you want to play a free mobile game or Hyper Casual Game.\n\n"+"Subscribe to "+c+" for more "+g+
      " Gameplay.\n\n"+convinhashtag(g)+" "+convinhashtag(c)+" "+convinhashtag(c)+"videos "+convinhashtag(g)+"gameplay";
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
