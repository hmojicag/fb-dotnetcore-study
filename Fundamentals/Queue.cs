using System;

namespace Fundamentals {
  public class Queue<T> {
    Node<T> firstNode;
    Node<T> lastNode;
    int size;

    public Queue() {
      firstNode = null;
      lastNode = null;
      size = 0;
    }

    public void enqueue(T item) {
      Node<T> n = new Node<T>(item);
      if (isEmpty()){
        firstNode = n;
        lastNode = n;
      } else {
        n.Previous = lastNode;
        lastNode.Next = n;
        lastNode = n;
      }
      size++;
    }

    public T dequeue() {
      if (isEmpty()) {
        return default(T);
      }

      //Recover the Item on the last Node
      T item = lastNode.Item;

      if (size > 1) {
        lastNode = lastNode.Previous;
        lastNode.Next = null;
      } else {//This is the last element on the queue
        firstNode = null;
        lastNode = null;
      }
      size--;

      return item;
    }

    public bool isEmpty() {
      return firstNode == null;
    }

    public override string ToString() {
      if (isEmpty()) {
        return "Empty Queue";
      }

      string txt = "";
      Node<T> currentNode = firstNode;
      while (currentNode != null) {
        txt += currentNode.ToString() + "\n";
        currentNode = currentNode.Next;
      }
      return txt;
    }

  }
}
