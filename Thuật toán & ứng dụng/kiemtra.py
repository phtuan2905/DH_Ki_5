# n = int(input())
# a = list(map(int, input().split()))

# a.sort(reverse=True)

# res = max(a[0] * a[1], a[0] * a[1] * a[2])

# print(res)

# n = int(input())
# a = list(map(int, input().split()))

# s1 = 0
# for i in a:
#     s1 += i

# res = s1
# s2 = 0
# for i in a:
#     s2 += i
#     s1 -= i
#     res = min(res, abs(s1 - s2))    

# print(res)

# n = int(input())

# a = []
# b = []

# for i in range(n):
#     a.append(int(input()))
#     b.append(input())

# for i in range(n):
#     s = set()
#     c = 0
#     for j in b[i]:
#         if j in s:
#             c += 1
#         else:
#             c += 2
#             s.add(j)
#     print(c)

# from queue import PriorityQueue

# n = int(input())
# a = list(map(int, input().split()))
# b = list(map(int, input().split()))
# pq = PriorityQueue()

# for i in range(n):
#     pq.put((a[i], -b[i]))

# while not pq.empty():
#     key, value = pq.get()
#     print(key, value)

# m = max(a)
# res = 0
# for i in range(m):
#     key, value = pq.get()
#     while(key - 1 > i):
#         key, value = pq.get()
#     res += (-value)

# print(res)

# from queue import PriorityQueue
# n = int(input())
# a = list(map(int, input().split()))
# b = list(map(int, input().split()))
# A = [[] for i in range(10**6 + 1)]
# maxday = max(a) if a else 0

# for i in range(n):
#     A[a[i]].append(b[i])

# Q = PriorityQueue()
# res = 0
# sumb = sum(b)

# for day in range(maxday, 0, -1):
#     for val in A[day]:
#         Q.put(-val)
#     if not Q.empty():
#         res += -Q.get()

# print(sumb - res)

# n = int(input())
# s = list(map(int, input().split()))
# s.sort()
# res = max((s[-1] - s[1]) * (s[-2]- s[0]), (s[-1] - s[0]) * (s[-2] - s[1]))
# print(res)


n = int(input())
a = list(map(int, input().split()))
a.sort()
res = max(a[-1]*a[-2], a[-1]*a[-2]*a[-3],a[0]*a[1] , a[0]*a[1]*a[-1])
print(res)

# from collections import deque

# input = sys.stdin.readline
# chia = 10**9 + 7

# n,m = map(int,input().split())

# d = [[] for _ in range(n + 1)]
# k = [0] * (n + 1)

# for _ in range(m):
#     x,y = map(int,input().split())
#     d[x].append(y)
#     k[y] += 1

# dp = [0] * (n + 1)
# dp[1] = 1

# q = deque()

# for i in range(1, n + 1):
#     if k[i] == 0:
#         q.append(i)

# while q:
#     u = q.popleft()
#     for v in d[u]:
#         dp[v] = (dp[v] + dp[u]) % chia
#         k[v] -= 1
#         if k[v] == 0:
#             q.append(v)

# print(dp[n] % chia)