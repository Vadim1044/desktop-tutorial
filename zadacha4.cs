// на вход подается одномерный мпассив размерность задаем сами. и необходимо 1. сформировать выходной массив в октором положительные 
//потом отрицательные(--0++) сортировку использовать нельзя
// 2. определить является ли массив последовательностью равномерно убывающих элементов.
// 3. все ли элементы четные(да или нет)


//
//
//
//

    using System;
    
    public class HelloWorld{
        public static void Main(string[] args){
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[n];

            input(n, array);
            chet(array);
        }
        
        public static void input(int n, int [] A){
            
            
            for (int i = 0; i < n; i++){
                Console.Write("Array=");
                int g = Convert.ToInt32(Console.ReadLine());
                A[i] = g;
            }
        }
        
        
        public static void Sort(int n, int[] array){

            int [] arr = array;
            for (int i = 0; i < arr.Length - 1; i++){
     
                // traverse i+1 to array length
                for (int j = i + 1; j < arr.Length; j++){
                
                    // compare array element with 
                    // all next element
                    if (arr[i] < arr[j]) {
                        
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        
                    }
                }
            }
            Console.WriteLine(arr[0]);
            for (int i = 0; i<n; i++){
                Console.WriteLine(arr[i]);

            }
        }



        public static void ubiv(int[] A){
            int temp = 0;
            int k = Convert.ToInt32(A[0]-A[1]);
            for (int i = 0; i<A.Length-1; i++){
                if (k>0){
                        if (A[i]-A[i+1] != k){
                            temp=1;
                            Console.WriteLine("Massive is not ravnomerno ubivaet");
                        }
                }
                else{
                    Console.WriteLine("Massive is not ravnomerno ubivaet");
                    break;
                }
            }
            if (temp==0){
                    Console.WriteLine("Massive ravnomeno ubivaet");
            }
        }
        
        public static void chet(int[] A){
            int temp=0;
            for (int i = 0; i<A.Length; i++){
                if (A[i]%2 != 0){
                    temp++;
                }
            }
            if (temp == 0){
                Console.WriteLine("Massiv sostoit iz chet numbers");
            }
            else if(temp != 0){
                Console.WriteLine("Massiv sostoit iz NE chet numbers");
            }
        }
        
        
    }
                
            
        }
        
    }
