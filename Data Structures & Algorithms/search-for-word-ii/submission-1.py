class TrieNode: 
    def __init__(self): 
        self.children = {}
        self.endOfWord = False 
    
    def addWord(self, word): 
        root = self
        for w in word: 
            if w not in root.children: 
                root.children[w] = TrieNode()
            root = root.children[w]
        root.endOfWord = True 

class Solution:
    def findWords(self, board: List[List[str]], words: List[str]) -> List[str]:
        root = TrieNode()
        for word in words: 
            root.addWord(word)
        
        ROW, COL = len(board), len(board[0])
        res, visit = set(), set()

        def dfs(r, c, node, word):
            if (r < 0 or c < 0 or ROW <= r or 
                COL <= c or (r,c) in visit or 
                board[r][c] not in node.children): 
                return

            visit.add((r, c))

            node = node.children[board[r][c]]
            word += board[r][c]

            if node.endOfWord: 
                res.add(word)
            
            dfs(r + 1, c, node, word)
            dfs(r, c + 1, node, word)
            dfs(r - 1, c, node, word)
            dfs(r, c - 1, node, word)

            visit.remove((r, c))

        for r in range(ROW): 
            for c in range(COL): 
                dfs(r, c, root, "")
        
        return list(res)


            
