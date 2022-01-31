
using System;
class HelloWorld {
  static void Main() {
      
      int end = 0;
      int endbot = 0;
      Random rand = new Random();

      while (end < 3 && endbot < 3){
          Console.WriteLine("Выбор предмета: 1 - камень, 2 - ножницы, 3 - бумага");
          int player;
          
          player = Int32.Parse(Console.ReadLine());

          
          if (player == 1){
              Console.WriteLine("Вы атакуете камнем");
              
          }
          else if (player == 2){
              Console.WriteLine("Вы атакуете ножницами");
              
          }
          else{ 
              Console.WriteLine("Вы атакуете бумагой");
          }
          int comp = rand.Next(1,3);
          if (comp == 1){
              Console.WriteLine("Враг защищается камнем!");
              
          }
          else if (comp == 2){
              Console.WriteLine("Враг защищается ножницами");
          
          }
          else {
              Console.WriteLine("Враг защищается бумагой!");
          
          }
          int win;
          if (player == comp){
              win = 0;
              
          }
          else if (player == 1 && comp == 2) {
              win = 1;
              
          }
          else if (player == 1 && comp == 3){
              win = 2;
              
          }
          else if (player == 2 && comp == 1){
              win = 2;
              
          }
          else if (player == 2 && comp == 3){
              win = 1;
              
          }
          else if (player == 3 && comp == 1){
              win = 1;
              
          }
          else {
              win = 2;
              
          }
      if (win == 0){
          Console.WriteLine("Вы убили друг друга!");
          
      }
      else if (win == 1){
          Console.WriteLine("Вы победили врага!");
          end++;
          
      }
      else {
          Console.WriteLine("You died");
          endbot++;
      }
      }
      if (end == 3){
      Console.WriteLine("Вы победили врага 3 раза!");}
      else if (endbot == 3){
      Console.WriteLine("Вы проиграли 3 раза!");}
      else {
          Console.WriteLine("ERROR 228");
      } 
      
      }
  }

