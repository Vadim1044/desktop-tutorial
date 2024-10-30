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
            Sort(n, array);
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
            for (int i = 0; i<A.Length; i++){
                if ( i = 0 && (A[i+1] - A[i])>0){
                    int temp = A[i+1] - A[i];
                }
                else if (i!=0 && i!=A.Length && (A[i+1] - A[i])>0){
                    if (A[i+1]-A[i] != temp){
                        Console.WriteLine("Массив не равномерно убывающий");
                    }
                }
            }
        }
        
    }



    ,,
        using System;
    
    public class HelloWorld{
        public static void Main(string[] args){
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[n];

            input(n, array);
            ubiv(array);
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
            for (int i = 0; i<A.Length-1; i++){
                int k = Convert.ToInt32(A[i+1]-A[i]);
                if (k>0){
                    if (i!=0 && i!=A.Length-1){
                        if (A[i+1]-A[i] != k){
                            temp=1;
                            Console.WriteLine("Massive is not ravnomerno ubivaet");
                        }
                        else if (i==A.Length-1 && temp!=0){
                            Console.WriteLine("Massive ravnomeno ubivaet");
                        }
                    }
                }
            }
                
                
                
            
        }
        
    }