public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // time complexity = O(n)+O(nlogn)+O(n)=O(nlogn)
        // space =O(n)+O(n)+O(1)=O(n)

        int n = position.Length;
        // Step 1: Pair each car's position with its time to reach the target
        var cars = new List<(int pos, double time)>();
        for(int i=0; i<n ; i++){
            double time = (double) (target - position[i])/speed[i];
            cars.Add((position[i],time));
        }
        // Step 2: Sort the cars by starting position in descending order
        // This way we process cars from farthest to closest to the target
        cars.Sort((a,b) => b.pos.CompareTo(a.pos));
        // Step 3: Use a monotonic stack to track fleets
        var stack = new Stack<double>();
        foreach(var car in cars){
             // If the stack is empty or the current car's time is greater than the top fleet's time
            // It means this car cannot catch up → it forms a new fleet
            if (stack.Count == 0 || car.time > stack.Peek()) {
                stack.Push(car.time); // Push new fleet’s time
            }
            // Else → this car will catch up to the fleet ahead, so it joins that fleet
            // We don't need to push it, as it doesn’t form a new fleet
        }
    return stack.Count;
    }
}