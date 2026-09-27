/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }

        Dictionary<Node, Node> map = new();

        return Dfs(node);


        Node Dfs(Node current){
            // Map already contains Node
            if(map.ContainsKey(current)){
                return map[current];
            }

            // Create a clone
            Node clone = new Node(current.val);

            // Save to map
            map[current] = clone;

            //Clone neighbours
            foreach(Node n in current.neighbors){
                clone.neighbors.Add(Dfs(n));
            }
            return clone;

        }
    }
}
