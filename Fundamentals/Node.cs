using System;

namespace Fundamentals {
	public class Node<T> { 
		T item;
		Node<T> next;
		Node<T> previous;
		public Node(T item) {
			this.item = item;
			this.next = null;
		}

		public T Item {
			get {
				return item;
			}

			set {
				item = value;
			}
		}

		public Node<T> Next {
			get {
				return next;
			}

			set {
				next = value;
			}
		}
		
		public Node<T> Previous {
			get {return previous;}
			set {previous = value;}
		}
		
		public override string ToString(){
			return "Item: " + item.ToString();
		}
	}
}
