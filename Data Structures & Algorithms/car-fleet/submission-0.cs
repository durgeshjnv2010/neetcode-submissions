public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // Create tuple of position and speed
        // Sort in such a way that nearest car to target

        int n = position.Length;
        var cars = new(int position, int speed)[n];

        for(int i=0; i<n;i++){
            cars[i] = (position[i], speed[i]);
        }

        Array.Sort(cars, (a,b) => b.position.CompareTo(a.position));

        Stack<double> stack = new();

        foreach(var car in cars){
            double time = (double)(target-car.position) / car.speed;

            if(stack.Count ==0 || time > stack.Peek()){
                stack.Push(time);
            }
        }
        return stack.Count;
    }
}
