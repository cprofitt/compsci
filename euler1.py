# Project Euler Problem 1
# Charles Profitt 6/5/2011
# Git Change

def total_sum_in_range(n):
        # iterate through range and add multiples of 3 and 5
        sum = 0
        for i in range(1, n):
                if (i % 3 == 0) or (i % 5 == 0):
                        sum += i
        return sum

print total_sum_in_range(1000)

