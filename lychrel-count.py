# written by cprofitt 2/26/2010
# version .0.1

import time
total = 0

def is_lychrel(n):
    n = str(n)
    for count in xrange(0, 50):
        n = str(int(n) + int(n[::-1]))
        if n == n[::-1]: return False
    return True

starttime = time.time()
for n in xrange(0,10000):
    if is_lychrel(n):
	total = total +1

stoptime = time.time()
print 'Time to complete: %s secs' % (stoptime - starttime) 
print 'total lychrel numbers are: ' + str(total)
