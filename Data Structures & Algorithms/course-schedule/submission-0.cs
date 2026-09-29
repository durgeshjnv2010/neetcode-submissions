public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] graph = new List<int>[numCourses];

        for(int i=0; i< numCourses; i++){
            graph[i] = new List<int>();
        }

        // Build graph
        // [course, prerequisite]
        // prerequisite -> course

        foreach(int[] p in prerequisites){
            int pre = p[1];
            int course = p[0];
            graph[pre].Add(course);

        }
        // 0 = unvisited
        // 1 = visiting
        // 2 = visited
        int[] state = new int[numCourses];
        for(int course=0; course<numCourses; course++){
            if(Hascycle(course)){
                return false;
            }
        }
        return true;

        bool Hascycle(int course){
            // Current DFS path mein already present
            if(state[course] == 1){
                return true;
            }

            // Already completely processed
            if(state[course] ==2){
                return false;
            }
            //start visiting
            state[course] = 1;
            foreach(int nextcourse in graph[course]){
                if(Hascycle(nextcourse)){
                    return true;
                }
            }
            // Done processing
            state[course] = 2;

            return false;


        }
    }
}
