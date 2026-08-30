public class LRUCache {
    private readonly int capacity;
    private readonly Dictionary<int, Node> map;
    private readonly Node head;
    private readonly Node tail;
    public LRUCache(int capacity) {
        this.capacity =capacity;
        map = new();
        head= new Node(0,0);
        tail = new Node(0,0);
        head.next = tail;
        tail.prv = head;
    }
    
    public int Get(int key) {
        if(!map.ContainsKey(key)){
            return -1;
        }
        else{
            Node n = map[key];

            // This node is MRU now, so remove it from here and add it at tail
            n.prv.next= n.next;
            n.next.prv = n.prv;

            // add at tail; since tail dummy node h to prv wale ko point karna parega
            Node t = tail.prv;
            t.next = n;
            n.prv = t;
            n.next = tail;
            tail.prv = n;
            return n.value;

        }
    }
    
    public void Put(int key, int value) {
        // already exist case
        if(map.ContainsKey(key)){
            // node ka value update and remove then add at last MRU side or tail
            Node n = map[key];
            n.value = value;
            //remove 
            n.prv.next = n.next;
            n.next.prv = n.prv;

            // add at tail

            Node t = tail.prv;
            t.next = n;
            n.prv= t;

            n.next = tail;
            tail.prv = n;

        }
        else{
            Node n = new Node(key, value);

            // add in dict
            map[key] = n;

            // Add in LL at last or MRU or tail side
            Node t = tail.prv;
            t.next = n;
            n.prv= t;

            n.next = tail;
            tail.prv = n;

            if(map.Count > capacity){
                // evict. from head side O(1)

                Node lru = head.next;
                map.Remove(lru.key);

                head.next = lru.next;
                lru.next.prv = head;
            }


        }
    }

    
}
// Doubly Linked List Class
public class Node {
    public int key;
    public int value;
    public Node prv;
    public Node next;
    public Node(int _key, int _val){
        key = _key;
        value= _val;
    }
} 