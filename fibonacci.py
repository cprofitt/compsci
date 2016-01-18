import time
from math import sqrt
 
def fibonacci(n):
    root5 = sqrt(5)
    phi = 0.5 + root5/2
    return int(0.5 + phi**n/root5)
 
start = time.clock()
for i in range(100):
    print ("n=%d => %d" % (i, fibonacci(i)))
end = time.clock()
print ("Time elapsed = ", end - start, "seconds")
