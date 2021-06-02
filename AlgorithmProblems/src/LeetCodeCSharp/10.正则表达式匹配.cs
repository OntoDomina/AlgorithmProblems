/*
 * @lc app=leetcode.cn id=10 lang=csharp
 *
 * [10] 正则表达式匹配
 */

// @lc code=start

/*
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public class Solution {
    struct Part {
        Char c;
        bool repeat;
    }
    public bool IsMatch(string s, string p) {
        var sc = s.ToCharArray();
        var pc = p.ToCharArray();
        var l = new List<Part>();
        (Char Last, Char Current, short ContainCount) status = (0, 0, 0);
        var ischar = (char c) => 'a' <= c && c<= 'z' || c == '.';
        
        foreach(var c in sc){
            switch (status.ContainCount){
                case 0:{
                    status.ContainCount += 1;
                    status.Last = c;
                    Continue;
                }
                case 1:{
                    status.Current = c;
                    status.ContainCount += 1;
                    Continue;
                }
                default: break;
            }
            switch((status.Last, status.Current)){
                case (char c2, '*') when ischar(c2) : {
                    l.Add(new Part(){c2, true}); 
                    status.Last = c;
                    status.ContainCount = 1;
                    continue; 
                }
                case (char c2, char c3) when ischar(c2) && ischar(c3):{
                    l.Add(new Part(){c2, false});
                    status.Last = status.Current; status.Current = c;
                    continue;
                }
                default: throw new SystemException("invalid pattern", (new String(new char[]{status.Last, status.Current, c})));
            }
            
        }

        switch((status.Last, status.Current, status.ContainCount)){
                case (char c2, '*', 2) when ischar(c2) : {
                    l.Add(new Part(){c2, true}); 
                    break;
                }
                case (char c2, char c3, 2) when ischar(c2) && ischar(c3):{
                    l.Add(new Part(){c2, false});
                    l.Add(new Part(){c3, false});
                    break;
                }
                case (char c2, _, 1) when ischar(c2):
                    l.Add(new Part(){c2, false});
                    break;
                default: throw new SystemException("invalid pattern", (new String(new char[]{status.Last, status.Current, c})));
        }
    
        l.add
    
    
    }

}
*/
// @lc code=end

