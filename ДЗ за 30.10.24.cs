using System;
    
    public class HelloWorld{
        public static void Main(string[] args){
            Console.Write("Введите колво элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[n];

            input(n, array);
            Sort(array);
            ubiv(array);
            chet(array);
        }
        
        public static void input(int n, int [] A){
            
            
            for (int i = 0; i < n; i++){
                Console.Write("Array["+i+"]=");
                int g = Convert.ToInt32(Console.ReadLine());
                A[i] = g;
            }
        }
        
        
        public static void Sort(int[] array){
            int temp = 0;
            int [] arr = new int[array.Length];
            for (int i = 0; i < arr.Length; i++){
                if (array[i] > 0){
                    arr[temp] = array[i];
                    temp++;
                }
            }
            for (int i = 0; i < arr.Length; i++){
                if (array[i] == 0){
                    arr[temp] = array[i];
                    temp++;
                }
            }
            for (int i = 0; i < arr.Length; i++){
                if (array[i] < 0){
                    arr[temp] = array[i];
                    temp++;
                }
            }
            Console.WriteLine("1. Отсортированный массив:");
            for (int i = 0; i<arr.Length; i++){
                Console.Write(" ");
                Console.Write(arr[i]);
            }
            Console.WriteLine(".");
        }
        public static void ubiv(int[] A){
            Console.WriteLine("2.");
            int temp = 0;
            int k = Convert.ToInt32(A[0]-A[1]);
            for (int i = 0; i<A.Length-1; i++){
                if (k>0){
                        if (A[i]-A[i+1] != k){
                            temp=1;
                            Console.WriteLine("Массив НЕ равномерно убывает");
                        }
                }
                else{
                    Console.WriteLine("Массив НЕ равномерно убывает");
                    break;
                }
            }
            if (temp==0){
                    Console.WriteLine("Массив равномерно убывает");
            }
        }
        
        public static void chet(int[] A){
            Console.Write("3.");
            int temp=0;
            for (int i = 0; i<A.Length; i++){
                if (A[i]%2 != 0){
                    temp++;
                }
            }
            if (temp == 0){
                Console.Write("В массиве все числа четные");
            }
            else if(temp != 0){
                Console.Write("В массиве есть нечетные числа");
            }
        }
        
        
    }
