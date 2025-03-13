class RandomList(list):
    def __init__(self,n:int,min_val:int,max_val:int):
        from random import randint
        super().__init__()
        self.extend(randint(min_val, max_val) for _ in range(n))