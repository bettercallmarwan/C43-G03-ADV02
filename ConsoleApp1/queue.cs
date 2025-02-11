using System.Collections;

namespace ConsoleApp1;

#region 7. Implement a queue that can hold different data types. 
public class queue
{
    private ArrayList arrayList;

    public queue() => arrayList = new ArrayList();

    public void EnQueue(object obj)
    {
        if (obj == null)
            throw new ArgumentNullException(nameof(obj));
        arrayList.Add(obj);
    }

    public object DeQueue()
    {
        object obj = arrayList[0];
        arrayList.RemoveAt(0);

        return obj;
    }

    public int size() => this.arrayList.Count;
} 
#endregion