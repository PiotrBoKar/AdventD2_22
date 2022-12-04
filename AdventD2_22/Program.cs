
namespace AdventD2_22
{
    public class dayTwo22
    {
        public static void Main()
        {
            int result = 0;
            string res;
            List<string[]> input = ReadFile.getList("22D2");
            for (int i = 0; i < input.Count; i++)
            {
                res = Result.getResult(String.Join("", input[i]));
                result = result + int.Parse(res);
            }
            Console.WriteLine(result);
            res = "";
            result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                res = Result.getCalculatedResult(String.Join("", input[i]));
                result = result + int.Parse(res);
            }
            Console.WriteLine(result);

        } 


    }
}
