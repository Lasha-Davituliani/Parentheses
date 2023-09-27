namespace Parentheses
{
    public class ParenthesesChecker
    {
        public static bool IsProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in sequence)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {                       
                        return false;
                    }
                    else
                    {                        
                        stack.Pop();
                    }
                }
                
            }
           
            return stack.Count == 0;
        }

        public static void Main(string[] args)
        {
            string sequence1 = "((?(er))!)";
            string sequence2 = "(()())";
            string sequence3 = "(()))(";

            Console.WriteLine($"Is {sequence1} properly matched? {IsProperly(sequence1)}");
            Console.WriteLine($"Is {sequence2} properly matched? {IsProperly(sequence2)}");
            Console.WriteLine($"Is {sequence3} properly matched? {IsProperly(sequence3)}");
        }
    }
}

