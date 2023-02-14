
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Nodes node1 = new Nodes(9);
        Nodes node2 = new Nodes(99);
        
        Nodes head = node1;
        node1.next = node2;
        
      
        node1.setNext(node2);
        
       
        
    }
    
    
    
    
    
    
    public class Nodes
    {
        
        
        private Object data;
        public Nodes next;
       
        
      public Nodes()
        {
            data = null;
            next = null;
        }
        
        
        public Nodes(Object x)
        {
            data = x;
            
        }
        
         public Nodes( Object x, Nodes y)
        {
            data = x;
            next = y;
            
        }
        
       public void setItem( Object data ){ this.data = data ; }
       
       public Object getData(){ return this.data ; }
       
       public void setNext( Nodes next ){ this.next = next ; }
       
       public Nodes getNext(){ return this.next ; }
    }
    
    
    
    
    
    
    
    
    
    
    
        
        public class LinkedList
    {
        protected Nodes head = null;
        protected int len = 0;

        // Make relevant Constructors 
        public LinkedList()
        {
            head = null;
            len = 0;
        }
        
        public bool isEmpty()
        {
            return (len == 0);
        }
        
        public void insertAtHead( Object data )
        {
            Nodes newItem = new Nodes( data, head);
            head = newItem;
            len++;
        }


        public bool insertAfter( Object newItem, Object afterItem)
        {
            // Find out what "findItem" is about? where have we previously defined this method
            Nodes afterNode = findItem( afterItem ) ;
            
            if (afterNode != null)
            {
                Nodes newItemNode = new Nodes( newItem, afterNode.getNext() ) ;
                afterNode.setNext( newItemNode ) ;
                len++;
                return true;
            }
            else 
            { 
                return false;
            }
        }
        
        //private ListNode findItem( Object item )
        
        //public void printList()
        
        
        




    }
        
}
