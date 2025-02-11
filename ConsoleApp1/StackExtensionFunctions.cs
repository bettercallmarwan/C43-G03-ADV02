using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
    public static class StackExtensionFunctions
    {
        public static void PushIntegersInStack(this Stack<int> stack, List<int> numbers, int target)
        {
            if (numbers == null)
                return;

            foreach (int num in numbers)
                stack.Push(num);

            int cnt = 0, ans;
            bool found = false;

            foreach(int num in stack)
            {
                if(num == target)
                {
                    found = true;
                    break;
                }

                cnt++;
            }

            if (found == true)
                Console.WriteLine($"Your Item Is Found and the count = {cnt}");
            else
                Console.WriteLine("Your Item Is Not Found");

        }
    } 
    #endregion
}


//public static void PushIntegersInStack(this Stack<int> stack, List<int> numbers, int target)
//{
//    if (numbers == null)
//        return;

//    foreach (int num in numbers)
//        stack.Push(num);

//    int cnt = 0, ans;
//    bool found = false;

//    Stack<int> tempStack = new Stack<int>(); // To ensure that stack is unchanged

//    while (stack.Count != 0)
//    {
//        int tempNum = stack.Pop();
//        tempStack.Push(tempNum);

//        if (tempNum == target)
//        {
//            ans = tempNum;
//            found = true;
//            break;
//        }

//        cnt++;
//    }

//    while (tempStack.Count != 0)
//        stack.Push(tempStack.Pop());

//    if (found == true)
//        Console.WriteLine($"Your Item Is Found and the count = {cnt}");
//    else
//        Console.WriteLine("Your Item Is Not Found");

//}
