class Triangle:
    def __init__(self, a:int, b:int, c:int, h:int):
        self.a = a
        self.b = b
        self.c = c
        self.h = h
    def arena(self)->float:
        return self.b * self.h / 2
    def perimeter(self)->int:
        return self.a+self.b+self.c