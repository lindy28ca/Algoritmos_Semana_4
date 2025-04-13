using UnityEngine;

public class CustomDoubleLinkedList<T> : DoubleLinkedList<T>
{
    public Node<T> Peak = null;

    public override void Add(T newValue)
    {
        Node<T> newNode = new Node<T>(newValue);

        if (head == null)
        {
            head = newNode;
            lastNode = newNode;
            Peak = newNode;

            head.SetNext(head);
            head.SetPrev(head);

            count++;
            return;
        }

        if (Peak == lastNode)
        {
            base.Add(newValue); 
            Peak = lastNode;
            return;
        }

        Node<T> temp = Peak.Next;
        while (temp != head)
        {
            Node<T> siguiente = temp.Next;
            temp.SetNext(null);
            temp.SetPrev(null);
            temp = siguiente;
            count--;
        }

        newNode.SetPrev(Peak);
        newNode.SetNext(head); 

        Peak.SetNext(newNode);
        head.SetPrev(newNode);

        lastNode = newNode;
        Peak = newNode;

        count++;
    }

    public void MovePeakNext()
    {
        if (Peak != null && Peak.Next != null)
        {
            Peak = Peak.Next;
        }
    }

    public void MovePeakPrev()
    {
        if (Peak != null && Peak.Prev != null)
        {
            Peak = Peak.Prev;
        }
    }

    public void PrintPeak()
    {
        if (Peak != null)
        {
            Debug.Log("Peak está en: " + Peak.Value.ToString());
        }
        else
        {
            Debug.Log("Peak está vacío.");
        }
    }
}
