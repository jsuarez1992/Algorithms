using System;
namespace Exercise001
{
    public class LinkedList
    {

        private Node Head;
        private Node Tail;

        public LinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }

        public void AddFirst(int n)
        {  //create new node
            Node node = new Node(n,null,null);

            //if the had is not empty
            if(this.Head != null)
            {
                //newNode will become new head of the list
                this.Head.previous = node;
               //Node temp(previous head) will be added after new head
                node.next = this.Head;
                //node will point to head
                this.Head = node;

            }
            else
            {
                //If list is empty, both head and tail will point to new nod
                this.Head = node;
                this.Tail= this.Head;
            }

        }

        public void AddLast(int n)
        {
            //basically the same at first, but inverted
            Node node = new Node(n,null,null);
             //if the head is not empty
            if(this.Tail != null)
            {
                //newNode will become last head of the list
                this.Tail.next = node;
               //Node temp(next head) will be added before new head
                node.previous = this.Tail;
                //node will point to tail
                this.Tail = node;

            }
            else
            {
                //If list is empty, both head and tail will point to new nod
                this.Tail = node;
                this.Head= this.Tail;
            }
        }

        public void RemoveLast()
        {//well just make the tail point to the previous node
        //Then set its value to null
        this.Tail=this.Tail.previous;
        this.Tail.next=null;
        }

        public void RemoveFirst()
        {//well just make the head point to the next node
        //Then set its value to null
        this.Head=this.Head.next;
        this.Head.previous=null;
        }

        public int GetNode(int x)
        {
            Node n = this.Head;
            for (int i = 0; i < x; i++)
            {
                n = n.next;
            }
            return n.value;
        }

        public override string ToString()
        {
            Node now = this.Head;
            string total = "";
            while (now != null)
            {
                total += now.value + " ";
                now = now.next;
            }
            return total.Trim();
        }
    }
}
