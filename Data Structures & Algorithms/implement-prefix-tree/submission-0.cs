public class PrefixTree {
    private TrieNode root;
    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode current = root;
        foreach(char c in word){
            int index = c-'a';
            if(current.Children[index] == null){
                current.Children[index] = new TrieNode();
            }
            current = current.Children[index];
        }
        current.IsWord = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        foreach(char c in word){
            int index = c - 'a';
            if(current.Children[index] == null){
                return false;
            }
            current = current.Children[index];
        }
        return current.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        foreach(char c in prefix){
            int index = c-'a';
            if(current.Children[index] == null){
                return false;
            }
            current = current.Children[index];
        }
        return true;
    }
}
public class TrieNode
{
    public TrieNode[] Children = new TrieNode[26];
    public bool IsWord;
}