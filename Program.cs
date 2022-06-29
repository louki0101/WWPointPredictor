// See https://aka.ms/new-console-template for more information
using WWPointPredictor;

Console.WriteLine("WW Point Predictor!");

Console.Write("Please enter Calories: ");
var calories = Console.ReadLine();

Console.Write("Please enter Fat: ");
var fat = Console.ReadLine();

Console.Write("Please enter Carb: ");
var carb = Console.ReadLine();

Console.Write("Please enter Fiber: ");
var fiber = Console.ReadLine();

Console.Write("Please enter Protein: ");
var protein = Console.ReadLine();




//Load sample data
var sampleData = new WWPointMLModel.ModelInput()
{
    Calories = Convert.ToSingle(calories),
    Fat__g_ = Convert.ToSingle(fat),
    Carb__g_ = Convert.ToSingle(carb),
    Fiber__g_ = Convert.ToSingle(fiber),
    Protein__g_ = Convert.ToSingle(protein)
};

//Load model and predict output
var result = WWPointMLModel.Predict(sampleData);




Console.WriteLine("Predicted Points: " + result.Score);
Console.ReadKey();
