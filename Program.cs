using System;

public class Program{
     public static void Main(){

     int nota;
     string resultado;
     char continuar;
    
     //1 - 39 reprovado
     //40 - 59 recuperaçã0
     //60 - 89 aprovado 
     //>=90 - aprovado com toda certeza

     inicio:


     Console.WriteLine("Digite a nota");
     nota = Convert.ToInt32 (Console.ReadLine());

    
     if(nota >= 60){
     if(nota >=90){

     resultado = "Aprovado com toda certeza";

      }else{

     resultado = "Aprovado";

     }


    }else{
    if(nota >=40){
 
         resultado = "Recuperação";

         }else{

          resultado = "Reprovado";
             
         }



       }

     Console.Clear();

       Console.WriteLine("Será {0}", resultado);

      


      Console.WriteLine("Continuar calculando notas?");
      continuar = char.Parse (Console.ReadLine());

      if(continuar == 'S'){
      goto inicio;

      }else{

          Console.Clear();
          Console.WriteLine("fim do programa");

      }


    }

}
    
 
     



    



     


        
    






    
