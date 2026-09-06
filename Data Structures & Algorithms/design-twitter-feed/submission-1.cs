public class Twitter {
    private Dictionary<int, HashSet<int>> following;
    private Dictionary<int, List<(int tweetId, int timestamp)>> tweets;
    private int time;
    public Twitter() {
        following = new();
        tweets = new();
        time=0;
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!tweets.ContainsKey(userId)){
            tweets[userId] = new();
        }
        tweets[userId].Add((tweetId, time++));
    }
    
    public List<int> GetNewsFeed(int userId) {
        // prepare list of users including self
        List<int> users = new();
        users.Add(userId);
        if(following.ContainsKey(userId)){
            users.AddRange(following[userId]);
        }

        //Max heap me har user ka tweetid daalo
        // Heap Item: (userId, tweetIndex) max tweetindex dallo, abhi bas sab user ka latest tweet hoga
        // aage index-- karke aur tweet le ke aayenge users ka
        // Priority: -time
        PriorityQueue<(int userId, int index), int> maxheap = new();
        foreach(var user in users){
            if(tweets.ContainsKey(user)){
                var t = tweets[user];
                int index = t.Count-1;
                maxheap.Enqueue((user, index), -tweets[user][index].timestamp);
            }
        }

        // fetch top 10 tweetid
        List<int> result = new();
        while(maxheap.Count>0 && result.Count<10){
            var item = maxheap.Dequeue();

            int user = item.userId;
            int index = item.index;

            result.Add(tweets[user][index].tweetId);

            // isi user ka previous tweet heap me daal do
            if(index>0){
                var previoustweet = tweets[user][index-1];
                maxheap.Enqueue((user, index-1), -previoustweet.timestamp);

            }
        }

        return result;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!following.ContainsKey(followerId)){
            following[followerId] = new();
        }
        following[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(following.ContainsKey(followerId)){
            following[followerId].Remove(followeeId);
        }
    }
}
