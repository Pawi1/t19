// 13. Napisz program zliczający częstość występowania każdego słowa
// w podanym (liniach po enterze) za pomocą HashMap.
void zad13()
{
   var sc = new Scanner(System.in);
   String text = "";
   System.out.println("Wpisz tekst: (ctrl + D by zakonczyc)");
   while (sc.hasNext())
   {
    text += sc.nextLine() + "\n";
   }

   var map = new HashMap<String,Integer>();
   for(var el : text.strip().split("\\s+"))
   {
       if(map.containsKey(el)){
           map.replace(el,map.get(el),map.get(el)+1);}
       else
           map.put(el,1);
   }
   System.out.println(map);
}

void main()
{
    zad13();
}