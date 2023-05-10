import random as r
running = True
i = 0
j = 1
val = 10
upperVal = val**8
while(running):
    x = r.randint(0,val)
    y = r.randint(0,val)
    if(x == y):
        print("run:",j,", number:",x,", count",i, ", range:",val)
        if val != upperVal:
            val *= 10
            j += 1
        else:
            running = False
    i+=1
