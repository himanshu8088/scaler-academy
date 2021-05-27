const solution = { 
    //param A : array of integers
    //param B : integer
    //return an integer
       solve : function(A, B){
       
           function checkIfFits(stalls, cowAtStall, numberOfCow){
               for(let i = 0; i < stalls.length; i++)
               {
                       if (stalls[i] >= cowAtStall && (stalls.length - i) >= numberOfCow)
                       {
                           return true;
                       }
               }
       
               return false;
           }
           
           A.sort();
           let low = 0;
           let high = A[A.length-1];
           let ans = Number.MAX_VALUE;
           while (low <= high)
           {
                   let m = (low + high) / 2;
                   let mid = Math.floor(m);
                   if (checkIfFits(A, mid, B))
                   {
                       low = mid + 1;
                       if (ans > mid)
                       {
                           ans = mid;
                       }
                   }
                   else
                   {
                       high = mid - 1;
                   }
           }
           return ans;
       }
       
        
   };

  solution.solve([1,2,3,4,5],3); 
   