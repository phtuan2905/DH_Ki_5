# class ps:
#     def __init__(self, _t = 0, _m = 0):
#         self.t, self.m = _t, _m
#     def __add__(self, other):
#         x = ps(self, t * other.m + self.m * other.t, self.m * other.m)
#         x.rg()
#         return x
#     def __str__(self):
#         return str(self.t) + "/" + str(self.m)
#     def rg(self):
#         d = abs(math.gcd(self.t, self.m))
#         if self.m < 0:
#             d = -d
#         self.t //= d
#         self.m //= d
#     def nghichdao(self):
#         return ps(self.m, self.t)

# if __name__ == '__main__':
#     n = int(input())
#     a = list(map(int, input().split()))[::1]
#     p = ps(0, 1)
#     for x in a[1:]:
#         q = p.nghichdao()
#         p = ps(x, 1) + q
#     print(p)

###13/10/2025

##Lap ghep ong nuoc
# from queue import PriorityQueue
# q = PriorityQueue()
# n, k = map(int, input().split())
# for i in map(int, input().split()):
#     q.put(i)

# sum = 0
# while q.qsize() > 1:
#     temp = 0
#     for i in range(k):
#         if (q.qsize() == 0):
#             break
#         temp += q.get()
#     q.put(temp)
#     sum += temp

# print(sum)

###20/10/2025
##Dictionary(Map)

# D = {4 : 'a', 'b' : (1, 2), (3, 4) : "abc"}
# print (D[4])
# print(D['b'])
# print(D[(3, 4)])
# D.pop

#Day con lien tuc khac biet
# n = int(input())
# d = {}
# a = list(map(int, input().split()))
# l = 0
# res = 0
# for i, x in enumerate(a, 1):

#Day con lien tuc co tong cho truoc
n, t = map(int, input().split())
D = {0 : 0}
res = 0
s = 0
a = list(map(int, input().split))
for i in range (1, n):
    s = s + a.pop(i)
    if (s - t) in D.keys():
        res = max(res, i - D[s-t])
    if s not in D.keys():
        D[s] = i
    
print(res)
