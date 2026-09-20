public class WordDictionary {
    private TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode current = root;

        foreach(char c in word){
            int index = c-'a';
            if(current.children[index] == null){
                current.children[index] = new TrieNode();
            }

            current = current.children[index];
        }
        current.isWord = true;
    }
    
    public bool Search(string word) {
        return DFS(root, 0);

        bool DFS(TrieNode node, int index){
            //word completely consumed
            if(index == word.Length){
                return node.isWord;
            }

            char c = word[index];
            // Normal Character
            if(c != '.'){
                int childindex = c-'a';
                if(node.children[childindex] == null){
                    return false;
                }
                return DFS(node.children[childindex], index+1);
            }

            // Any character
            for(int i=0; i<26; i++){
                if(node.children[i] != null){
                    if(DFS(node.children[i], index+1)){
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
public class TrieNode{
    public TrieNode[] children = new TrieNode[26];
    public bool isWord;

}
