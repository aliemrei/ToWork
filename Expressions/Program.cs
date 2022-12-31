// See https://aka.ms/new-console-template for more information

ExpressionsAndDelegates.Run();



public class ExpressionsAndDelegates
{
    delegate string getString();

    public static void Run()
    {
        //getString str = () => "Hello World";
        //or
        getString str = new getString(delegate() {
              return "Hello world";
        });

        Action<bool, string> cw = (isGrader, str1) =>
        {
            if (isGrader)
                Console.WriteLine(str1 + " is grader than 5");
            else Console.WriteLine(str1 + " is less than 5");
        };

        Func<string, int> getLength = str => str.Length;

        Predicate<int> isGraderThan5 = i => i > 5;

        var len = getLength.Invoke(str());

        var isGrader = isGraderThan5.Invoke(len);

        cw.Invoke(isGrader, str());

        Console.ReadKey();
    }
}



