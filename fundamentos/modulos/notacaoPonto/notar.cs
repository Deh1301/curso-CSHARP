namespace fundamentosCs{
    public class NotarPonto(){
        public static void Ponto(){
            var msg = "ola".ToUpper().Insert(3," World").Replace("World","Mundo");
            Console.WriteLine(msg);
            
            Console.WriteLine(msg.Length);

        }
    }
}