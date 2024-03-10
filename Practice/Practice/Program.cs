

using Practice.Helpers.Exceptions;
using System.Threading.Channels;

//void Divide()
//{
//    bool IsCorrect = true;

//    try
//    {
//        int a = int.Parse(Console.ReadLine());

//        int b = int.Parse(Console.ReadLine());

//        int c = a / b;

//        Console.WriteLine(c);

//        //int[] array = { 1, 2, 3, 4, 5, 6 };

//        //Console.WriteLine(array[10]);
//    }
//    //catch (DivideByZeroException ex)
//    //{
//    //       Console.WriteLine(ex.Message);
//    //   }
//    //   catch (IndexOutOfRangeException ex)
//    //   {
//    //       Console.WriteLine(ex.Message);
//    //   }
//    catch (Exception ex)
//    {
//        IsCorrect = false;

//        Console.WriteLine(ex.Message);
//    }
//    finally
//    {
//        //Console.WriteLine("Operation is completed...");
//        SendMessageDivide(IsCorrect);
//    }
//}

//Divide();

//void SendMessageDivide(bool IsCorrect)
//{
//    if (IsCorrect)
//    {
//        Console.WriteLine("Operation succesfully completed.");
//    }
//    else
//    {
//        Console.WriteLine("Operation failed...");
//    }
//}







//string GetById(int? id)
//{
//    try
//    {
//        //ArgumentNullException.ThrowIfNull(id);

//        if (id == null)
//        {
//            //throw new ArgumentNullException(nameof(id));

//            throw new CustomArgumentNullException("Argument can't be null");
//        }

//        return "Id exists";
//    }
//    catch (Exception ex)
//    {
//        //return "Id is null...";
//        return ex.Message;
//    }
//}

//Console.WriteLine(GetById(null));



