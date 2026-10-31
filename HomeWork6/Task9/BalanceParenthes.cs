namespace HomeWork6;

public class BalanceParenthes
{
    public static bool IsBalanced(string s)
    {
        ArgumentNullException.ThrowIfNull(s);

        var stack = new Stack<char>();
        bool hasPair = false;

        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(c);
                    break;

                case ')':
                case ']':
                case '}':
                    if (stack.Count == 0)
                        return false;

                    char open = stack.Pop();

                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                        return false;

                    hasPair = true;
                    break;

                default:
                    continue;
            }
        }

        return stack.Count == 0 && hasPair;
    }
}
