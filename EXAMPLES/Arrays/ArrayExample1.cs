class ArrayExample1 
    { 
        public static void Main() 
        { 
            Console.Write("Πόσες θερμοκρασίες θα δώσετε; "); 
            
            int size = int.Parse(Console.ReadLine()); 
            double[] temperatures = new double[size]; 
            
            //Ανάγνωση των τιμών του πίνακα με ένα for 
            for (int i=0; i < temperatures.Length; i++) 
            { 
                Console.Write("Δώσε την θερμοκρασία #{0}: ",i); 
                temperatures[i] = double.Parse(Console.ReadLine()); 
            } 
            
            //Υπολογισμός του μέσου όρου θερμοκρασίας με ένα foreach 
            double sum = 0.0; 
            foreach (double t in temperatures) 
            { 
                sum += t; 
            } 
            double average = sum / temperatures.Length; 
            
            Console.WriteLine("Η μέση θερμοκρασία είναι {0}",average); 
            Console.ReadKey();  
        } 
    } 
