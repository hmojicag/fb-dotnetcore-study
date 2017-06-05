using System;

namespace Fundamentals {
    public class Bag<T> {
        Node<T> firstNode;
		Node<T> lastNode;
		int size;

		public Bag() {
			size = 0;
			firstNode = null;
			lastNode = null;
		}

		public void addItem(T item) {
			if (isEmpty()) {
				firstNode = new Node<T>(item);
				lastNode = firstNode;
			} else {
				Node<T> auxNode = new Node<T>(item);
				lastNode.Next = auxNode;
				lastNode = auxNode;
			}
			size++;
		}

		public bool isEmpty() {
			if (firstNode == null) {
				return true;
			} else {
				return false;
			}
		}

		public int Size {
			get {
				return size;
			}
		}

		public override string ToString() {
			if(isEmpty()) {
				return "Empty Bag";
			}

			string txt = "";
			Node<T> currentNode = firstNode;
			while(currentNode != null) {
				txt += currentNode.ToString() + "\n";
				currentNode = currentNode.Next;
			}
			return txt;
		}
	}
}
