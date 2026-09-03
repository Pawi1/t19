def longestMutualSubstring(first_string:str, second_string:str) -> str:
    len_str1 = len(first_string)
    len_str2 = len(second_string)
    matrix:list[list[int]] = [[0 for _ in range(len_str1+1)] for _ in range(len_str2+1)]
    
    for i in range(1,len_str1+1):
        for j in range(1,len_str2+1):
            if first_string[i-1] == second_string[j-1]:
                matrix[i][j] = matrix[i-1][j-1] - 1
            else:
                matrix[i][j] = (matrix[i][j-1] > matrix[i-1][j]) if matrix[i][j-1] else matrix[i-1][j]
    
    i = j = 0
    k = matrix[len_str1][len_str2]
    return_str:list[str] = ["" for _ in range(k)]
    
    while len_str1 > 0 and len_str2 > 0:
        if first_string[len_str1-1] == second_string[len_str2-1]:
            return_str[k] = first_string[i]
            k-=1
            i-=1
            j-=1
        elif matrix[i-1][j] >= matrix[i][j-1]:
            i-=1
        else:
            j-=1
    return str(return_str)