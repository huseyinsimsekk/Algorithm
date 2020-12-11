# Algorithm Complexity Analysis

**Profiler** : A tool to measure how ast a program runs.

**Complexity Analysis** is a tool that allows us to explain how an algorithm *behaves* as the *input grows* later.

Example: The maximum element in an array. Given an input array A of size n.
```javascript
var Max= A[0];
for(var i = 0; i < n ; ++i){
  if(A[i] >= Max){
    M=A[i];
  }
}
```
**Instructions:**
- Look up A[0]
- Assign to M from A[0] ->  (M=A[0])
- Assign to i -> (var i = 0)
- Comparing i < n
- For each loop; icrease i (++i) and compare (i<n) so that 2\*n instruction each iteration.  
Just empty for statement body instructions calculate this:
```
f(n) = 4 + 2n
``` 
**For body instructions:**
- Look up A[i]
- Compare A[i] with M
- In if statement, look up A[i]
- Assign to M from A[i]
this four istructions invoke n time iteration (Worst-Case). So that instructions are `4n` from for body.

Thus, Instructions calculate this algorithm `f(n) = 4 + 2n + 4n = 4 + 6n`  

When analysing algorithm, we often consider the worst-case scenarios.

### Asymptotic Behavior
- Dropping all factors (constants). E.i. For above example drop 4. `f(n) = 4 + 6n -> f(n) = 6n -> f(n) = n`
- Keepin the largest growing term (n, n^2, n^3)
Example: `f(n) = 2n + 8 -> f(n) = n` 
In math, we can't do. But in computer science, we should do. Because, we should ignore some instructions. For example, in java program, we accept JVM runtime. 
Another examples;

`f(n) = 5n + 12 -> f(n) = n` 

`f(n) = 1234 -> f(n) = 1` 

`f(n) = n^2 + 2n + 8 -> f(n) = n^2` 

`f(n) = n^3 + 3n^2 + 4n + 8 -> f(n) = n^3` 
