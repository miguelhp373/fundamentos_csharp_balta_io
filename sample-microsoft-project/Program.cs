namespace sample_microsoft_project;

class Program
{
    static void Main(string[] args)
    {
        string firstNumber;
        string secondNumber;
        string isOperation;

        firstNumber =  Console.ReadLine()!;
        secondNumber =  Console.ReadLine()!;
        isOperation = "minus";

        Program program = new Program(); 

        Console.WriteLine(program.CalculateNumbers(firstNumber, secondNumber, isOperation).ToString());
    }

    public float CalculateNumbers(string NumberX, string NumberY, string CalcType)
    {
        float outPutNumberX;
        if(!float.TryParse(NumberX.ToString(), out outPutNumberX)){
            Console.WriteLine("Error! The First Number Is Not Valid!");
            return 0;
        }

        float outPutNumberY;
        if(!float.TryParse(NumberY.ToString(), out outPutNumberY)){
            Console.WriteLine("Error! The Second Number Is Not Valid!");
            return 0;
        }        

        switch (CalcType)
        {
            case "plus" :  return outPutNumberX + outPutNumberY;
            case "minus" :  return outPutNumberX - outPutNumberY;
            case "division" :  return outPutNumberX / outPutNumberY;
            case "multiplication" :  return outPutNumberX * outPutNumberY;            
            default: return 0;
        }
    }
}
