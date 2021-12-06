using System;
using System.IO;

namespace mprog_lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int [,] tablica = {{1,2}, {2,4}, {6,1}, {6,10}};
            //wrtieMatrix(tablica);
            StreamReader sr = null;

        try {
            sr = new StreamReader("/home/linuxmint/Desktop/x.doc");
            Console.WriteLine(sr.ReadToEnd());
        }
        catch(FileNotFoundException e){
            Console.WriteLine(e.Message);
        }
        catch(Exception e){
            Console.WriteLine(e.StackTrace);
        }
        finally {
            sr?.Close();
            Console.WriteLine("End program.");
        }   

        }

        static void wrtieMatrix(int [,] matrix){
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    Console.WriteLine($"Element [{i},{j}]: {matrix[i,j]}");
                }
            }
        }
    }
}
