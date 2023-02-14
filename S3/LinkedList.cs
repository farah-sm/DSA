
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Nodes node1 = new Nodes(9);
        Nodes node2 = new Nodes(99);
        
        Nodes head = node1;
        node1.next = node2;
        
        node1.setItem(99);
        
        Console.WriteLine($"{node1.next.getNext()}");
        
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
       
        
    }
    
    
    
    
    
    
    
    
    
    
    
        
        public class LinkedList
    {
        protected Node head = null;
        protected int len = 0;

        // Make relevant Constructors 
        public string address
        {
            get;
            set;
        }

        //Make Methods 
        
        
        




    }
        
}
