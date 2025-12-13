# Ngan xep
    # Khoi luong hoa chat 
# from queue import LifoQueue

# n = int(input())
# ls = []
# for i in range(0, n):
#     ls.append(input())

# k = {'(':0, 'C':12, 'H':1, 'O':16}

# for s in ls:
#     lq = LifoQueue()

#     for c in s:
#         if c in k.keys():
#             lq.put(k[c])
#         elif c == ')':
#             t = 0
#             while lq.queue[-1] != 0:
#                 t += lq.get()
#             lq.queue[-1] = t
#         else:
#             lq.queue[-1] = lq.queue[-1] * int(c)
        
#     res = sum(lq.queue)
#     print(res)

    #Chao don K59
from queue import LifoQueue

n = int(input())
l = list(map(int, input().split()))

