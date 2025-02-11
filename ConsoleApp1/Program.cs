namespace ConsoleApp1;

class Program
{
    #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

    public static void ReverseQueueUsingStack(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        while (queue.Count > 0)
            stack.Push(queue.Dequeue());

        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());
    }

    #endregion

    #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.


    public static bool IsBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if(stack.Count == 0)
                    return false;
                
                char temp = stack.Pop();

                if (!((temp == '(' && c == ')') || (temp == '{' && c == '}') || (temp == '[' && c == ']')))
                    return false;
            }
        }
        return stack.Count == 0;
    }

    #endregion

    #region 5. Given an array, implement a function to remove duplicate elements from an array.

    public static void RemoveDuplicateFromArray(ref int[] array)
    {
        HashSet<int> hashSet = new HashSet<int>();
        
        foreach (int num in array)
            hashSet.Add(num);
        
        array = hashSet.ToArray();
    }

    #endregion

    #region 6. Given an array list , implement a function to remove all odd numbers from it.

    public static void RemoveOddNumbersFromList(ref List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
            if(list[i] % 2 != 0)
                list.RemoveAt(i);
    }

    #endregion

    static void Main(string[] args)
    {
        #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X,

        // int N, Q;
        // bool flag;
        //
        // do
        // {
        //     Console.WriteLine("Enter array size:");
        //     flag = int.TryParse(Console.ReadLine(), out N);
        // }while(!flag || N < 1);
        // flag = false;
        //
        // do
        // {
        //     Console.WriteLine("Enter number of queries:");
        //     flag = int.TryParse(Console.ReadLine(), out Q);
        // }while(!flag || Q < 1);
        // flag = false;
        //
        // int[] array = new int[N];
        //
        // for (int i = 0; i < N; i++)
        // {
        //     do
        //     {
        //         Console.WriteLine($"Enter element #{i}");
        //         flag = int.TryParse(Console.ReadLine(), out array[i]);
        //     }while(!flag);
        //     flag = false;
        // }
        //
        // while (Q-- > 0)
        // {
        //     int x, ans = 0;
        //     do
        //     {
        //         Console.WriteLine("Enter x :");
        //         flag = int.TryParse(Console.ReadLine(), out x);
        //     } while (!flag);
        //     
        //     foreach (int num in array)
        //         if (num > x)
        //             ans++;
        //     Console.WriteLine(ans);
        // }

        #endregion

        #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

        // int N = int.Parse(Console.ReadLine());
        // int[] arr = new int[N];
        //
        // for(int i = 0 ; i < N; i++)
        //     arr[i] = int.Parse(Console.ReadLine());
        //
        // int l = 0, r = N - 1;
        //
        // while (l < r)
        // {
        //     if (arr[l] != arr[r])
        //     {
        //         Console.WriteLine("NO");
        //         return;
        //     }
        //
        //     l++;
        //     r--;
        // }
        //
        // Console.WriteLine("YES");

        #endregion

        #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

        // Queue<int> queue = new Queue<int>();
        // queue.Enqueue(1);
        // queue.Enqueue(2);
        // queue.Enqueue(3);
        //
        // ReverseQueueUsingStack(queue);
        //
        // foreach (int number in queue)
        // {
        //     Console.WriteLine(number);
        // }

        #endregion

        #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

        // string s = "[()]{}";
        // if(IsBalanced(s)) Console.WriteLine("Balanced");
        // else Console.WriteLine("Not Balanced");

        #endregion

        #region 5. Given an array, implement a function to remove duplicate elements from an array.

        // int[] array = { 1, 1, 2, 2, 2, 3, 3, 4 , 4, 5, 5, 0};
        // RemoveDuplicateFromArray(ref array);
        // foreach(int num in array)
        //     Console.WriteLine(num);

        #endregion

        #region 6. Given an array list , implement a function to remove all odd numbers from it.

        // List<int> list = new List<int>(){1,2,3,4,5,6,7,8,9,10};
        // RemoveOddNumbersFromList(ref list);
        // foreach(int num in list)
        //     Console.WriteLine(num);
        //
        #endregion

        #region 7. Implement a queue that can hold different data types. 
        //queue q = new queue();
        //q.EnQueue(1);
        //q.EnQueue("Apple");
        //q.EnQueue(5.28);

        //Console.WriteLine(q.DeQueue());
        //Console.WriteLine(q.DeQueue());
        //Console.WriteLine(q.DeQueue());

        //Console.WriteLine(q.size()); 
        #endregion

        #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
        //Console.WriteLine("Enter item to search for in stack: ");
        //int item = int.Parse(Console.ReadLine());

        //Stack<int> stack = new Stack<int>();
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);

        //stack.PushIntegersInStack([4, 5, 6], item);
        #endregion

        #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
        //int N1, N2;
        //Console.Write("Enter N1:");
        //N1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter N2:");
        //N2 = int.Parse(Console.ReadLine());

        //int[] arr1 = new int[N1];
        //int[] arr2 = new int[N2];

        //Dictionary<int, int> dict1 = new Dictionary<int, int>();
        //Dictionary<int, int> dict2 = new Dictionary<int, int>();


        //Console.WriteLine("First array: ");
        //for (int i = 0; i < N1; i++)
        //{
        //    Console.Write($"Enter arr1[{i}]:");

        //    arr1[i] = int.Parse(Console.ReadLine());
        //    if (dict1.ContainsKey(arr1[i]))
        //        dict1[arr1[i]]++;
        //    else
        //        dict1[arr1[i]] = 1;
        //}

        //Console.WriteLine("Second array: ");
        //for (int i = 0; i < N2; i++)
        //{
        //    Console.Write($"Enter arr[{i}]:");
        //    arr2[i] = int.Parse(Console.ReadLine());
        //    if (dict2.ContainsKey(arr2[i]))
        //        dict2[arr2[i]]++;
        //    else
        //        dict2[arr2[i]] = 1;
        //}

        //List<int> ans = new List<int>();

        //foreach(var item in dict1)
        //{
        //    int n = 0;
        //    if (dict2.ContainsKey(item.Key))
        //    {
        //        n = int.Min(item.Value, dict2[item.Key]);
        //    }

        //    for(int i = 0; i < n; i++)
        //        ans.Add(item.Key);
        //}

        //foreach(int num in ans)
        //    Console.Write($"{num} "); 
        #endregion\



        #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
        //Queue<int> queue = new Queue<int>();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Enqueue(4);
        //queue.Enqueue(5);

        //Console.Write("Enter k:");
        //int k = int.Parse(Console.ReadLine());
        //Stack<int> stack = new Stack<int>();
        //for(int i = 0; i < k; i++)
        //    stack.Push(queue.Dequeue());
        //List<int> list = new List<int>();
        //while(queue.Count != 0)
        //    list.Add(queue.Dequeue());
        //foreach (int num in stack)
        //    queue.Enqueue(num);
        //foreach (int num in list)
        //    queue.Enqueue(num);

        //foreach(int num in queue)
        //    Console.Write($"{num} "); 
        #endregion
    }
}            