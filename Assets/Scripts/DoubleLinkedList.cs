using UnityEngine;

public class DoubleLinkedList<T> : MonoBehaviour
{
    public Node<T> lastNode = null;

    public Node<T> head = null;

    public int count = 0;

    /* public DoubleCircularLinkedList (T value)
     {

     }*/

    public virtual void Add(T newValue)
    {
        Node<T> newNode = new Node<T>(newValue);

        count++;
        if (head == null)
        {
            lastNode = newNode;


            head = newNode;
            head.SetNext(head);
            head.SetPrev(head);
            return;
        }
        lastNode.SetNext(newNode);

        newNode.SetPrev(lastNode);

        lastNode = newNode;

        head.SetPrev(lastNode);
        lastNode.SetNext(head);
    }
    public virtual void ShowAllElements(Node<T> element = null, int _count = 0)
    {
        if (element == null)
        {
            element = head;
        }

        if (_count >= count)
        {
            Debug.Log("Se recorrió toda la lista");
            return;
        }

        Debug.Log("Node name: " + element.Value.ToString());

        ShowAllElements(element.Next, _count + 1);
    }

}
